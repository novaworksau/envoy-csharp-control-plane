// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/discovery/v2/sds.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Discovery.V2 {
  public static partial class SecretDiscoveryService
  {
    static readonly string __ServiceName = "envoy.service.discovery.v2.SecretDiscoveryService";

    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryRequest> __Marshaller_envoy_api_v2_DeltaDiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryResponse> __Marshaller_envoy_api_v2_DeltaDiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryRequest> __Marshaller_envoy_api_v2_DiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryResponse> __Marshaller_envoy_api_v2_DiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> __Method_DeltaSecrets = new grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaSecrets",
        __Marshaller_envoy_api_v2_DeltaDiscoveryRequest,
        __Marshaller_envoy_api_v2_DeltaDiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_StreamSecrets = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamSecrets",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_FetchSecrets = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchSecrets",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Discovery.V2.SdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SecretDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(SecretDiscoveryService), "BindService")]
    public abstract partial class SecretDiscoveryServiceBase
    {
      public virtual global::System.Threading.Tasks.Task DeltaSecrets(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task StreamSecrets(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Envoy.Api.V2.DiscoveryResponse> FetchSecrets(global::Envoy.Api.V2.DiscoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SecretDiscoveryService</summary>
    public partial class SecretDiscoveryServiceClient : grpc::ClientBase<SecretDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for SecretDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SecretDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SecretDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SecretDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SecretDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SecretDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaSecrets(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaSecrets(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaSecrets(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaSecrets, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamSecrets(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamSecrets(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamSecrets(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamSecrets, null, options);
      }
      public virtual global::Envoy.Api.V2.DiscoveryResponse FetchSecrets(global::Envoy.Api.V2.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchSecrets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Envoy.Api.V2.DiscoveryResponse FetchSecrets(global::Envoy.Api.V2.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchSecrets, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V2.DiscoveryResponse> FetchSecretsAsync(global::Envoy.Api.V2.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchSecretsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V2.DiscoveryResponse> FetchSecretsAsync(global::Envoy.Api.V2.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchSecrets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SecretDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SecretDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SecretDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeltaSecrets, serviceImpl.DeltaSecrets)
          .AddMethod(__Method_StreamSecrets, serviceImpl.StreamSecrets)
          .AddMethod(__Method_FetchSecrets, serviceImpl.FetchSecrets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SecretDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeltaSecrets, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(serviceImpl.DeltaSecrets));
      serviceBinder.AddMethod(__Method_StreamSecrets, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.StreamSecrets));
      serviceBinder.AddMethod(__Method_FetchSecrets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.FetchSecrets));
    }

  }
}
#endregion
