// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/grpc_http1_reverse_bridge/v3alpha/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.GrpcHttp1ReverseBridge.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/grpc_http1_reverse_bridge/v3alpha/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/grpc_http1_reverse_bridge/v3alpha/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkdlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvZ3JwY19odHRwMV9yZXZlcnNl",
            "X2JyaWRnZS92M2FscGhhL2NvbmZpZy5wcm90bxI6ZW52b3kuY29uZmlnLmZp",
            "bHRlci5odHRwLmdycGNfaHR0cDFfcmV2ZXJzZV9icmlkZ2UudjNhbHBoYRoX",
            "dmFsaWRhdGUvdmFsaWRhdGUucHJvdG8iTQoMRmlsdGVyQ29uZmlnEh8KDGNv",
            "bnRlbnRfdHlwZRgBIAEoCUIJuunAAwRyAiABEhwKFHdpdGhob2xkX2dycGNf",
            "ZnJhbWVzGAIgASgIQlkKSGlvLmVudm95cHJveHkuZW52b3kuY29uZmlnLmZp",
            "bHRlci5odHRwLmdycGNfaHR0cDFfcmV2ZXJzZV9icmlkZ2UudjNhbHBoYUIL",
            "Q29uZmlnUHJvdG9QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.GrpcHttp1ReverseBridge.V3Alpha.FilterConfig), global::Envoy.Config.Filter.Http.GrpcHttp1ReverseBridge.V3Alpha.FilterConfig.Parser, new[]{ "ContentType", "WithholdGrpcFrames" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// gRPC reverse bridge filter configuration
  /// </summary>
  public sealed partial class FilterConfig : pb::IMessage<FilterConfig> {
    private static readonly pb::MessageParser<FilterConfig> _parser = new pb::MessageParser<FilterConfig>(() => new FilterConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FilterConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.GrpcHttp1ReverseBridge.V3Alpha.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FilterConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FilterConfig(FilterConfig other) : this() {
      contentType_ = other.contentType_;
      withholdGrpcFrames_ = other.withholdGrpcFrames_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FilterConfig Clone() {
      return new FilterConfig(this);
    }

    /// <summary>Field number for the "content_type" field.</summary>
    public const int ContentTypeFieldNumber = 1;
    private string contentType_ = "";
    /// <summary>
    /// The content-type to pass to the upstream when the gRPC bridge filter is applied.
    /// The filter will also validate that the upstream responds with the same content type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContentType {
      get { return contentType_; }
      set {
        contentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "withhold_grpc_frames" field.</summary>
    public const int WithholdGrpcFramesFieldNumber = 2;
    private bool withholdGrpcFrames_;
    /// <summary>
    /// If true, Envoy will assume that the upstream doesn't understand gRPC frames and
    /// strip the gRPC frame from the request, and add it back in to the response. This will
    /// hide the gRPC semantics from the upstream, allowing it to receive and respond with a
    /// simple binary encoded protobuf.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool WithholdGrpcFrames {
      get { return withholdGrpcFrames_; }
      set {
        withholdGrpcFrames_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FilterConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FilterConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContentType != other.ContentType) return false;
      if (WithholdGrpcFrames != other.WithholdGrpcFrames) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ContentType.Length != 0) hash ^= ContentType.GetHashCode();
      if (WithholdGrpcFrames != false) hash ^= WithholdGrpcFrames.GetHashCode();
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
      if (ContentType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ContentType);
      }
      if (WithholdGrpcFrames != false) {
        output.WriteRawTag(16);
        output.WriteBool(WithholdGrpcFrames);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ContentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContentType);
      }
      if (WithholdGrpcFrames != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FilterConfig other) {
      if (other == null) {
        return;
      }
      if (other.ContentType.Length != 0) {
        ContentType = other.ContentType;
      }
      if (other.WithholdGrpcFrames != false) {
        WithholdGrpcFrames = other.WithholdGrpcFrames;
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
            ContentType = input.ReadString();
            break;
          }
          case 16: {
            WithholdGrpcFrames = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code