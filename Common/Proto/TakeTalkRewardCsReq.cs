// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeTalkRewardCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeTalkRewardCsReq.proto</summary>
  public static partial class TakeTalkRewardCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeTalkRewardCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeTalkRewardCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlUYWtlVGFsa1Jld2FyZENzUmVxLnByb3RvGgxWZWN0b3IucHJvdG8iSAoT",
            "VGFrZVRhbGtSZXdhcmRDc1JlcRIcCgtES0VPUEtDSUdGShgKIAEoCzIHLlZl",
            "Y3RvchITCgtBTktPSkNNT0dGShgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeTalkRewardCsReq), global::EggLink.DanhengServer.Proto.TakeTalkRewardCsReq.Parser, new[]{ "DKEOPKCIGFJ", "ANKOJCMOGFJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeTalkRewardCsReq : pb::IMessage<TakeTalkRewardCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeTalkRewardCsReq> _parser = new pb::MessageParser<TakeTalkRewardCsReq>(() => new TakeTalkRewardCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeTalkRewardCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeTalkRewardCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeTalkRewardCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeTalkRewardCsReq(TakeTalkRewardCsReq other) : this() {
      dKEOPKCIGFJ_ = other.dKEOPKCIGFJ_ != null ? other.dKEOPKCIGFJ_.Clone() : null;
      aNKOJCMOGFJ_ = other.aNKOJCMOGFJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeTalkRewardCsReq Clone() {
      return new TakeTalkRewardCsReq(this);
    }

    /// <summary>Field number for the "DKEOPKCIGFJ" field.</summary>
    public const int DKEOPKCIGFJFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.Vector dKEOPKCIGFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.Vector DKEOPKCIGFJ {
      get { return dKEOPKCIGFJ_; }
      set {
        dKEOPKCIGFJ_ = value;
      }
    }

    /// <summary>Field number for the "ANKOJCMOGFJ" field.</summary>
    public const int ANKOJCMOGFJFieldNumber = 13;
    private uint aNKOJCMOGFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ANKOJCMOGFJ {
      get { return aNKOJCMOGFJ_; }
      set {
        aNKOJCMOGFJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeTalkRewardCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeTalkRewardCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DKEOPKCIGFJ, other.DKEOPKCIGFJ)) return false;
      if (ANKOJCMOGFJ != other.ANKOJCMOGFJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dKEOPKCIGFJ_ != null) hash ^= DKEOPKCIGFJ.GetHashCode();
      if (ANKOJCMOGFJ != 0) hash ^= ANKOJCMOGFJ.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (dKEOPKCIGFJ_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(DKEOPKCIGFJ);
      }
      if (ANKOJCMOGFJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ANKOJCMOGFJ);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (dKEOPKCIGFJ_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(DKEOPKCIGFJ);
      }
      if (ANKOJCMOGFJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ANKOJCMOGFJ);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (dKEOPKCIGFJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DKEOPKCIGFJ);
      }
      if (ANKOJCMOGFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ANKOJCMOGFJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeTalkRewardCsReq other) {
      if (other == null) {
        return;
      }
      if (other.dKEOPKCIGFJ_ != null) {
        if (dKEOPKCIGFJ_ == null) {
          DKEOPKCIGFJ = new global::EggLink.DanhengServer.Proto.Vector();
        }
        DKEOPKCIGFJ.MergeFrom(other.DKEOPKCIGFJ);
      }
      if (other.ANKOJCMOGFJ != 0) {
        ANKOJCMOGFJ = other.ANKOJCMOGFJ;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 82: {
            if (dKEOPKCIGFJ_ == null) {
              DKEOPKCIGFJ = new global::EggLink.DanhengServer.Proto.Vector();
            }
            input.ReadMessage(DKEOPKCIGFJ);
            break;
          }
          case 104: {
            ANKOJCMOGFJ = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 82: {
            if (dKEOPKCIGFJ_ == null) {
              DKEOPKCIGFJ = new global::EggLink.DanhengServer.Proto.Vector();
            }
            input.ReadMessage(DKEOPKCIGFJ);
            break;
          }
          case 104: {
            ANKOJCMOGFJ = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
