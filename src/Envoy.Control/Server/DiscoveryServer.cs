using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Envoy.Control.Cache;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Envoy.Control.Server
{
    public class DiscoveryServer : IDisposable
    {
        readonly IConfigWatcher _configWatcher;
        private IHost? _host = null;
        private readonly object _lock = new object();
        private readonly IDictionary<string, Action<IEndpointRouteBuilder>> _enabledServices
            = new Dictionary<string, Action<IEndpointRouteBuilder>>();

        public DiscoveryServer(IConfigWatcher configWatcher)
        {
            if (configWatcher == null)
            {
                throw new ArgumentNullException($"{nameof(configWatcher)} cannot be null");
            }

            this._configWatcher = configWatcher;
        }

        public DiscoveryServer UseAggregatedDiscoveryService(Action<IEndpointRouteBuilder>? action = null)
        {
            action = action ?? (e => e.MapGrpcService<AggregatedDiscoveryService>());
            this._enabledServices[nameof(AggregatedDiscoveryService)] = action;
            return this;
        }

        public DiscoveryServer UseClusterDiscoveryService(Action<IEndpointRouteBuilder>? action = null)
        {
            action = action ?? (e => e.MapGrpcService<ClusterDiscoveryService>());
            this._enabledServices[nameof(ClusterDiscoveryService)] = action;
            return this;
        }

        public DiscoveryServer UseEndpointDiscoveryService(Action<IEndpointRouteBuilder>? action = null)
        {
            action = action ?? (e => e.MapGrpcService<EndpointDiscoveryService>());
            this._enabledServices[nameof(EndpointDiscoveryService)] = action;
            return this;
        }

        public DiscoveryServer UseListenerDiscoveryService(Action<IEndpointRouteBuilder>? action = null)
        {
            action = action ?? (e => e.MapGrpcService<ListenerDiscoveryService>());
            this._enabledServices[nameof(ListenerDiscoveryService)] = action;
            return this;
        }

        public DiscoveryServer UseRouteDiscoveryService(Action<IEndpointRouteBuilder>? action = null)
        {
            action = action ?? (e => e.MapGrpcService<RouteDiscoveryService>());
            this._enabledServices[nameof(RouteDiscoveryService)] = action;
            return this;
        }

        public DiscoveryServer UseSecretDiscoveryService(Action<IEndpointRouteBuilder>? action = null)
        {
            action = action ?? (e => e.MapGrpcService<SecretDiscoveryService>());
            this._enabledServices[nameof(SecretDiscoveryService)] = action;
            return this;
        }

        private IHost CreateHost()
        {
            return Host.CreateDefaultBuilder()
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.SetMinimumLevel(LogLevel.Debug);
            })
            .ConfigureServices(services =>
            {
                services.AddSingleton<IConfigWatcher>(this._configWatcher);
                services.AddSingleton<IDiscoveryStreamHandler, DiscoveryStreamHandler>();
                services.AddGrpc();
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                    .UseUrls("https://+:6000", "http://+:6001")
                    .Configure((app) =>
                    {
                        var env = app.ApplicationServices.GetRequiredService<IWebHostEnvironment>();
                        if (env.IsDevelopment())
                        {
                            app.UseDeveloperExceptionPage();
                        }

                        app.UseRouting();
                        app.UseEndpoints(endpoints =>
                        {
                            foreach (var action in this._enabledServices.Values)
                            {
                                action(endpoints);
                            }

                            endpoints.MapGet("/", async context =>
                            {
                                await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                            });
                        });
                    });
            })
            .Build();
        }

        public Task RunAsync(CancellationToken token = default)
        {
            if (_host == null)
            {
                lock (_lock)
                {
                    if (_host == null)
                    {
                        _host = CreateHost();
                        return _host.RunAsync(token);
                    }
                }
            }
            throw new InvalidOperationException("Host is already running");
        }
        public Task StartAsync(CancellationToken token = default)
        {
            if (_host == null)
            {
                lock (_lock)
                {
                    if (_host == null)
                    {
                        _host = CreateHost();
                        return _host.StartAsync(token);
                    }
                }
            }
            throw new InvalidOperationException("Host is already running");
        }

        public Task StopAsync(CancellationToken token = default)
        {
            if (_host != null)
            {
                return _host.StopAsync(token);
            }
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _host != null)
            {
                _host.Dispose();
            }
        }
    }
}