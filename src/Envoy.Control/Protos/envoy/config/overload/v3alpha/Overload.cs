// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/overload/v3alpha/overload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Overload.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/overload/v3alpha/overload.proto</summary>
  public static partial class OverloadReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/overload/v3alpha/overload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OverloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixlbnZveS9jb25maWcvb3ZlcmxvYWQvdjNhbHBoYS9vdmVybG9hZC5wcm90",
            "bxIdZW52b3kuY29uZmlnLm92ZXJsb2FkLnYzYWxwaGEaGWdvb2dsZS9wcm90",
            "b2J1Zi9hbnkucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90",
            "bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxoXdmFsaWRhdGUvdmFs",
            "aWRhdGUucHJvdG8ikgEKD1Jlc291cmNlTW9uaXRvchIXCgRuYW1lGAEgASgJ",
            "Qgm66cADBHICIAESKQoGY29uZmlnGAIgASgLMhcuZ29vZ2xlLnByb3RvYnVm",
            "LlN0cnVjdEgAEiwKDHR5cGVkX2NvbmZpZxgDIAEoCzIULmdvb2dsZS5wcm90",
            "b2J1Zi5BbnlIAEINCgtjb25maWdfdHlwZSI8ChBUaHJlc2hvbGRUcmlnZ2Vy",
            "EigKBXZhbHVlGAEgASgBQhm66cADFBISGQAAAAAAAPA/KQAAAAAAAAAAIoAB",
            "CgdUcmlnZ2VyEhcKBG5hbWUYASABKAlCCbrpwAMEcgIgARJECgl0aHJlc2hv",
            "bGQYAiABKAsyLy5lbnZveS5jb25maWcub3ZlcmxvYWQudjNhbHBoYS5UaHJl",
            "c2hvbGRUcmlnZ2VySABCFgoNdHJpZ2dlcl9vbmVvZhIFuOnAAwEibwoOT3Zl",
            "cmxvYWRBY3Rpb24SFwoEbmFtZRgBIAEoCUIJuunAAwRyAiABEkQKCHRyaWdn",
            "ZXJzGAIgAygLMiYuZW52b3kuY29uZmlnLm92ZXJsb2FkLnYzYWxwaGEuVHJp",
            "Z2dlckIKuunAAwWSAQIIASLdAQoPT3ZlcmxvYWRNYW5hZ2VyEjMKEHJlZnJl",
            "c2hfaW50ZXJ2YWwYASABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb24S",
            "VQoRcmVzb3VyY2VfbW9uaXRvcnMYAiADKAsyLi5lbnZveS5jb25maWcub3Zl",
            "cmxvYWQudjNhbHBoYS5SZXNvdXJjZU1vbml0b3JCCrrpwAMFkgECCAESPgoH",
            "YWN0aW9ucxgDIAMoCzItLmVudm95LmNvbmZpZy5vdmVybG9hZC52M2FscGhh",
            "Lk92ZXJsb2FkQWN0aW9uQj4KK2lvLmVudm95cHJveHkuZW52b3kuY29uZmln",
            "Lm92ZXJsb2FkLnYzYWxwaGFCDU92ZXJsb2FkUHJvdG9QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Overload.V3Alpha.ResourceMonitor), global::Envoy.Config.Overload.V3Alpha.ResourceMonitor.Parser, new[]{ "Name", "Config", "TypedConfig" }, new[]{ "ConfigType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger), global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger.Parser, new[]{ "Value" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Overload.V3Alpha.Trigger), global::Envoy.Config.Overload.V3Alpha.Trigger.Parser, new[]{ "Name", "Threshold" }, new[]{ "TriggerOneof" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Overload.V3Alpha.OverloadAction), global::Envoy.Config.Overload.V3Alpha.OverloadAction.Parser, new[]{ "Name", "Triggers" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Overload.V3Alpha.OverloadManager), global::Envoy.Config.Overload.V3Alpha.OverloadManager.Parser, new[]{ "RefreshInterval", "ResourceMonitors", "Actions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResourceMonitor : pb::IMessage<ResourceMonitor> {
    private static readonly pb::MessageParser<ResourceMonitor> _parser = new pb::MessageParser<ResourceMonitor>(() => new ResourceMonitor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResourceMonitor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Overload.V3Alpha.OverloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceMonitor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceMonitor(ResourceMonitor other) : this() {
      name_ = other.name_;
      switch (other.ConfigTypeCase) {
        case ConfigTypeOneofCase.Config:
          Config = other.Config.Clone();
          break;
        case ConfigTypeOneofCase.TypedConfig:
          TypedConfig = other.TypedConfig.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceMonitor Clone() {
      return new ResourceMonitor(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the resource monitor to instantiate. Must match a registered
    /// resource monitor type. The built-in resource monitors are:
    ///
    /// * :ref:`envoy.resource_monitors.fixed_heap
    ///   &lt;envoy_api_msg_config.resource_monitor.fixed_heap.v3alpha.FixedHeapConfig>`
    /// * :ref:`envoy.resource_monitors.injected_resource
    ///   &lt;envoy_api_msg_config.resource_monitor.injected_resource.v3alpha.InjectedResourceConfig>`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Config {
      get { return configTypeCase_ == ConfigTypeOneofCase.Config ? (global::Google.Protobuf.WellKnownTypes.Struct) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.Config;
      }
    }

    /// <summary>Field number for the "typed_config" field.</summary>
    public const int TypedConfigFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any TypedConfig {
      get { return configTypeCase_ == ConfigTypeOneofCase.TypedConfig ? (global::Google.Protobuf.WellKnownTypes.Any) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.TypedConfig;
      }
    }

    private object configType_;
    /// <summary>Enum of possible cases for the "config_type" oneof.</summary>
    public enum ConfigTypeOneofCase {
      None = 0,
      Config = 2,
      TypedConfig = 3,
    }
    private ConfigTypeOneofCase configTypeCase_ = ConfigTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigTypeOneofCase ConfigTypeCase {
      get { return configTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConfigType() {
      configTypeCase_ = ConfigTypeOneofCase.None;
      configType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResourceMonitor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResourceMonitor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Config, other.Config)) return false;
      if (!object.Equals(TypedConfig, other.TypedConfig)) return false;
      if (ConfigTypeCase != other.ConfigTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (configTypeCase_ == ConfigTypeOneofCase.Config) hash ^= Config.GetHashCode();
      if (configTypeCase_ == ConfigTypeOneofCase.TypedConfig) hash ^= TypedConfig.GetHashCode();
      hash ^= (int) configTypeCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.Config) {
        output.WriteRawTag(18);
        output.WriteMessage(Config);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.TypedConfig) {
        output.WriteRawTag(26);
        output.WriteMessage(TypedConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.Config) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.TypedConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypedConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResourceMonitor other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.ConfigTypeCase) {
        case ConfigTypeOneofCase.Config:
          if (Config == null) {
            Config = new global::Google.Protobuf.WellKnownTypes.Struct();
          }
          Config.MergeFrom(other.Config);
          break;
        case ConfigTypeOneofCase.TypedConfig:
          if (TypedConfig == null) {
            TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
          }
          TypedConfig.MergeFrom(other.TypedConfig);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (configTypeCase_ == ConfigTypeOneofCase.Config) {
              subBuilder.MergeFrom(Config);
            }
            input.ReadMessage(subBuilder);
            Config = subBuilder;
            break;
          }
          case 26: {
            global::Google.Protobuf.WellKnownTypes.Any subBuilder = new global::Google.Protobuf.WellKnownTypes.Any();
            if (configTypeCase_ == ConfigTypeOneofCase.TypedConfig) {
              subBuilder.MergeFrom(TypedConfig);
            }
            input.ReadMessage(subBuilder);
            TypedConfig = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class ThresholdTrigger : pb::IMessage<ThresholdTrigger> {
    private static readonly pb::MessageParser<ThresholdTrigger> _parser = new pb::MessageParser<ThresholdTrigger>(() => new ThresholdTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ThresholdTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Overload.V3Alpha.OverloadReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ThresholdTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ThresholdTrigger(ThresholdTrigger other) : this() {
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ThresholdTrigger Clone() {
      return new ThresholdTrigger(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private double value_;
    /// <summary>
    /// If the resource pressure is greater than or equal to this value, the trigger
    /// will fire.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ThresholdTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ThresholdTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Value);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ThresholdTrigger other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0D) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Value = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Trigger : pb::IMessage<Trigger> {
    private static readonly pb::MessageParser<Trigger> _parser = new pb::MessageParser<Trigger>(() => new Trigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Trigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Overload.V3Alpha.OverloadReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trigger(Trigger other) : this() {
      name_ = other.name_;
      switch (other.TriggerOneofCase) {
        case TriggerOneofOneofCase.Threshold:
          Threshold = other.Threshold.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trigger Clone() {
      return new Trigger(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the resource this is a trigger for.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "threshold" field.</summary>
    public const int ThresholdFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger Threshold {
      get { return triggerOneofCase_ == TriggerOneofOneofCase.Threshold ? (global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger) triggerOneof_ : null; }
      set {
        triggerOneof_ = value;
        triggerOneofCase_ = value == null ? TriggerOneofOneofCase.None : TriggerOneofOneofCase.Threshold;
      }
    }

    private object triggerOneof_;
    /// <summary>Enum of possible cases for the "trigger_oneof" oneof.</summary>
    public enum TriggerOneofOneofCase {
      None = 0,
      Threshold = 2,
    }
    private TriggerOneofOneofCase triggerOneofCase_ = TriggerOneofOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TriggerOneofOneofCase TriggerOneofCase {
      get { return triggerOneofCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTriggerOneof() {
      triggerOneofCase_ = TriggerOneofOneofCase.None;
      triggerOneof_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Trigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Trigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Threshold, other.Threshold)) return false;
      if (TriggerOneofCase != other.TriggerOneofCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (triggerOneofCase_ == TriggerOneofOneofCase.Threshold) hash ^= Threshold.GetHashCode();
      hash ^= (int) triggerOneofCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (triggerOneofCase_ == TriggerOneofOneofCase.Threshold) {
        output.WriteRawTag(18);
        output.WriteMessage(Threshold);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (triggerOneofCase_ == TriggerOneofOneofCase.Threshold) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Threshold);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Trigger other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.TriggerOneofCase) {
        case TriggerOneofOneofCase.Threshold:
          if (Threshold == null) {
            Threshold = new global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger();
          }
          Threshold.MergeFrom(other.Threshold);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger subBuilder = new global::Envoy.Config.Overload.V3Alpha.ThresholdTrigger();
            if (triggerOneofCase_ == TriggerOneofOneofCase.Threshold) {
              subBuilder.MergeFrom(Threshold);
            }
            input.ReadMessage(subBuilder);
            Threshold = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class OverloadAction : pb::IMessage<OverloadAction> {
    private static readonly pb::MessageParser<OverloadAction> _parser = new pb::MessageParser<OverloadAction>(() => new OverloadAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OverloadAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Overload.V3Alpha.OverloadReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverloadAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverloadAction(OverloadAction other) : this() {
      name_ = other.name_;
      triggers_ = other.triggers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverloadAction Clone() {
      return new OverloadAction(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the overload action. This is just a well-known string that listeners can
    /// use for registering callbacks. Custom overload actions should be named using reverse
    /// DNS to ensure uniqueness.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "triggers" field.</summary>
    public const int TriggersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Config.Overload.V3Alpha.Trigger> _repeated_triggers_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Config.Overload.V3Alpha.Trigger.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.Trigger> triggers_ = new pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.Trigger>();
    /// <summary>
    /// A set of triggers for this action. If any of these triggers fire the overload action
    /// is activated. Listeners are notified when the overload action transitions from
    /// inactivated to activated, or vice versa.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.Trigger> Triggers {
      get { return triggers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OverloadAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OverloadAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!triggers_.Equals(other.triggers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= triggers_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      triggers_.WriteTo(output, _repeated_triggers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += triggers_.CalculateSize(_repeated_triggers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OverloadAction other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      triggers_.Add(other.triggers_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            triggers_.AddEntriesFrom(input, _repeated_triggers_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class OverloadManager : pb::IMessage<OverloadManager> {
    private static readonly pb::MessageParser<OverloadManager> _parser = new pb::MessageParser<OverloadManager>(() => new OverloadManager());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OverloadManager> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Overload.V3Alpha.OverloadReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverloadManager() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverloadManager(OverloadManager other) : this() {
      refreshInterval_ = other.refreshInterval_ != null ? other.refreshInterval_.Clone() : null;
      resourceMonitors_ = other.resourceMonitors_.Clone();
      actions_ = other.actions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverloadManager Clone() {
      return new OverloadManager(this);
    }

    /// <summary>Field number for the "refresh_interval" field.</summary>
    public const int RefreshIntervalFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration refreshInterval_;
    /// <summary>
    /// The interval for refreshing resource usage.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration RefreshInterval {
      get { return refreshInterval_; }
      set {
        refreshInterval_ = value;
      }
    }

    /// <summary>Field number for the "resource_monitors" field.</summary>
    public const int ResourceMonitorsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Config.Overload.V3Alpha.ResourceMonitor> _repeated_resourceMonitors_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Config.Overload.V3Alpha.ResourceMonitor.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.ResourceMonitor> resourceMonitors_ = new pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.ResourceMonitor>();
    /// <summary>
    /// The set of resources to monitor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.ResourceMonitor> ResourceMonitors {
      get { return resourceMonitors_; }
    }

    /// <summary>Field number for the "actions" field.</summary>
    public const int ActionsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Envoy.Config.Overload.V3Alpha.OverloadAction> _repeated_actions_codec
        = pb::FieldCodec.ForMessage(26, global::Envoy.Config.Overload.V3Alpha.OverloadAction.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.OverloadAction> actions_ = new pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.OverloadAction>();
    /// <summary>
    /// The set of overload actions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Config.Overload.V3Alpha.OverloadAction> Actions {
      get { return actions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OverloadManager);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OverloadManager other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RefreshInterval, other.RefreshInterval)) return false;
      if(!resourceMonitors_.Equals(other.resourceMonitors_)) return false;
      if(!actions_.Equals(other.actions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (refreshInterval_ != null) hash ^= RefreshInterval.GetHashCode();
      hash ^= resourceMonitors_.GetHashCode();
      hash ^= actions_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (refreshInterval_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RefreshInterval);
      }
      resourceMonitors_.WriteTo(output, _repeated_resourceMonitors_codec);
      actions_.WriteTo(output, _repeated_actions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (refreshInterval_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RefreshInterval);
      }
      size += resourceMonitors_.CalculateSize(_repeated_resourceMonitors_codec);
      size += actions_.CalculateSize(_repeated_actions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OverloadManager other) {
      if (other == null) {
        return;
      }
      if (other.refreshInterval_ != null) {
        if (refreshInterval_ == null) {
          RefreshInterval = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        RefreshInterval.MergeFrom(other.RefreshInterval);
      }
      resourceMonitors_.Add(other.resourceMonitors_);
      actions_.Add(other.actions_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (refreshInterval_ == null) {
              RefreshInterval = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(RefreshInterval);
            break;
          }
          case 18: {
            resourceMonitors_.AddEntriesFrom(input, _repeated_resourceMonitors_codec);
            break;
          }
          case 26: {
            actions_.AddEntriesFrom(input, _repeated_actions_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code