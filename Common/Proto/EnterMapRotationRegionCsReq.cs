// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterMapRotationRegionCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterMapRotationRegionCsReq.proto</summary>
  public static partial class EnterMapRotationRegionCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterMapRotationRegionCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterMapRotationRegionCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbnRlck1hcFJvdGF0aW9uUmVnaW9uQ3NSZXEucHJvdG8aEE1vdGlvbklu",
            "Zm8ucHJvdG8iZAobRW50ZXJNYXBSb3RhdGlvblJlZ2lvbkNzUmVxEhMKC0hN",
            "Q0FGRUpBUEpLGAcgASgNEhsKBm1vdGlvbhgFIAEoCzILLk1vdGlvbkluZm8S",
            "EwoLSUlDRk9PTk9MQUkYDiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterMapRotationRegionCsReq), global::EggLink.DanhengServer.Proto.EnterMapRotationRegionCsReq.Parser, new[]{ "HMCAFEJAPJK", "Motion", "IICFOONOLAI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterMapRotationRegionCsReq : pb::IMessage<EnterMapRotationRegionCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterMapRotationRegionCsReq> _parser = new pb::MessageParser<EnterMapRotationRegionCsReq>(() => new EnterMapRotationRegionCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterMapRotationRegionCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterMapRotationRegionCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionCsReq(EnterMapRotationRegionCsReq other) : this() {
      hMCAFEJAPJK_ = other.hMCAFEJAPJK_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      iICFOONOLAI_ = other.iICFOONOLAI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterMapRotationRegionCsReq Clone() {
      return new EnterMapRotationRegionCsReq(this);
    }

    /// <summary>Field number for the "HMCAFEJAPJK" field.</summary>
    public const int HMCAFEJAPJKFieldNumber = 7;
    private uint hMCAFEJAPJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HMCAFEJAPJK {
      get { return hMCAFEJAPJK_; }
      set {
        hMCAFEJAPJK_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "IICFOONOLAI" field.</summary>
    public const int IICFOONOLAIFieldNumber = 14;
    private uint iICFOONOLAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IICFOONOLAI {
      get { return iICFOONOLAI_; }
      set {
        iICFOONOLAI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterMapRotationRegionCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterMapRotationRegionCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HMCAFEJAPJK != other.HMCAFEJAPJK) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      if (IICFOONOLAI != other.IICFOONOLAI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HMCAFEJAPJK != 0) hash ^= HMCAFEJAPJK.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (IICFOONOLAI != 0) hash ^= IICFOONOLAI.GetHashCode();
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
      if (motion_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Motion);
      }
      if (HMCAFEJAPJK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HMCAFEJAPJK);
      }
      if (IICFOONOLAI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IICFOONOLAI);
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
      if (motion_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Motion);
      }
      if (HMCAFEJAPJK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HMCAFEJAPJK);
      }
      if (IICFOONOLAI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IICFOONOLAI);
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
      if (HMCAFEJAPJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HMCAFEJAPJK);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (IICFOONOLAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IICFOONOLAI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterMapRotationRegionCsReq other) {
      if (other == null) {
        return;
      }
      if (other.HMCAFEJAPJK != 0) {
        HMCAFEJAPJK = other.HMCAFEJAPJK;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.IICFOONOLAI != 0) {
        IICFOONOLAI = other.IICFOONOLAI;
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
          case 42: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 56: {
            HMCAFEJAPJK = input.ReadUInt32();
            break;
          }
          case 112: {
            IICFOONOLAI = input.ReadUInt32();
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
          case 42: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 56: {
            HMCAFEJAPJK = input.ReadUInt32();
            break;
          }
          case 112: {
            IICFOONOLAI = input.ReadUInt32();
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
