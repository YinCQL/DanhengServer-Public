// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncChessRogueNousValueScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncChessRogueNousValueScNotify.proto</summary>
  public static partial class SyncChessRogueNousValueScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncChessRogueNousValueScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncChessRogueNousValueScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTeW5jQ2hlc3NSb2d1ZU5vdXNWYWx1ZVNjTm90aWZ5LnByb3RvGhFJQkpE",
            "QU9MQklHTy5wcm90byJECh9TeW5jQ2hlc3NSb2d1ZU5vdXNWYWx1ZVNjTm90",
            "aWZ5EiEKC05HTUlMSEZDRkhJGA4gASgLMgwuSUJKREFPTEJJR09CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.IBJDAOLBIGOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncChessRogueNousValueScNotify), global::EggLink.DanhengServer.Proto.SyncChessRogueNousValueScNotify.Parser, new[]{ "NGMILHFCFHI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncChessRogueNousValueScNotify : pb::IMessage<SyncChessRogueNousValueScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncChessRogueNousValueScNotify> _parser = new pb::MessageParser<SyncChessRogueNousValueScNotify>(() => new SyncChessRogueNousValueScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncChessRogueNousValueScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncChessRogueNousValueScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncChessRogueNousValueScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncChessRogueNousValueScNotify(SyncChessRogueNousValueScNotify other) : this() {
      nGMILHFCFHI_ = other.nGMILHFCFHI_ != null ? other.nGMILHFCFHI_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncChessRogueNousValueScNotify Clone() {
      return new SyncChessRogueNousValueScNotify(this);
    }

    /// <summary>Field number for the "NGMILHFCFHI" field.</summary>
    public const int NGMILHFCFHIFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.IBJDAOLBIGO nGMILHFCFHI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IBJDAOLBIGO NGMILHFCFHI {
      get { return nGMILHFCFHI_; }
      set {
        nGMILHFCFHI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncChessRogueNousValueScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncChessRogueNousValueScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(NGMILHFCFHI, other.NGMILHFCFHI)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (nGMILHFCFHI_ != null) hash ^= NGMILHFCFHI.GetHashCode();
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
      if (nGMILHFCFHI_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(NGMILHFCFHI);
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
      if (nGMILHFCFHI_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(NGMILHFCFHI);
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
      if (nGMILHFCFHI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NGMILHFCFHI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncChessRogueNousValueScNotify other) {
      if (other == null) {
        return;
      }
      if (other.nGMILHFCFHI_ != null) {
        if (nGMILHFCFHI_ == null) {
          NGMILHFCFHI = new global::EggLink.DanhengServer.Proto.IBJDAOLBIGO();
        }
        NGMILHFCFHI.MergeFrom(other.NGMILHFCFHI);
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
          case 114: {
            if (nGMILHFCFHI_ == null) {
              NGMILHFCFHI = new global::EggLink.DanhengServer.Proto.IBJDAOLBIGO();
            }
            input.ReadMessage(NGMILHFCFHI);
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
          case 114: {
            if (nGMILHFCFHI_ == null) {
              NGMILHFCFHI = new global::EggLink.DanhengServer.Proto.IBJDAOLBIGO();
            }
            input.ReadMessage(NGMILHFCFHI);
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
