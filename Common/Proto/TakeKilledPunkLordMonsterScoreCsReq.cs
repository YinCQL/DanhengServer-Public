// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeKilledPunkLordMonsterScoreCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeKilledPunkLordMonsterScoreCsReq.proto</summary>
  public static partial class TakeKilledPunkLordMonsterScoreCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeKilledPunkLordMonsterScoreCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeKilledPunkLordMonsterScoreCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilUYWtlS2lsbGVkUHVua0xvcmRNb25zdGVyU2NvcmVDc1JlcS5wcm90bxoY",
            "UHVua0xvcmRNb25zdGVyS2V5LnByb3RvImQKI1Rha2VLaWxsZWRQdW5rTG9y",
            "ZE1vbnN0ZXJTY29yZUNzUmVxEhMKC0hKSkdDQ0xIQUhLGAwgASgIEigKC01E",
            "Rk1DRkZLQkZQGA8gASgLMhMuUHVua0xvcmRNb25zdGVyS2V5Qh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PunkLordMonsterKeyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeKilledPunkLordMonsterScoreCsReq), global::EggLink.DanhengServer.Proto.TakeKilledPunkLordMonsterScoreCsReq.Parser, new[]{ "HJJGCCLHAHK", "MDFMCFFKBFP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeKilledPunkLordMonsterScoreCsReq : pb::IMessage<TakeKilledPunkLordMonsterScoreCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeKilledPunkLordMonsterScoreCsReq> _parser = new pb::MessageParser<TakeKilledPunkLordMonsterScoreCsReq>(() => new TakeKilledPunkLordMonsterScoreCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeKilledPunkLordMonsterScoreCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeKilledPunkLordMonsterScoreCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeKilledPunkLordMonsterScoreCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeKilledPunkLordMonsterScoreCsReq(TakeKilledPunkLordMonsterScoreCsReq other) : this() {
      hJJGCCLHAHK_ = other.hJJGCCLHAHK_;
      mDFMCFFKBFP_ = other.mDFMCFFKBFP_ != null ? other.mDFMCFFKBFP_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeKilledPunkLordMonsterScoreCsReq Clone() {
      return new TakeKilledPunkLordMonsterScoreCsReq(this);
    }

    /// <summary>Field number for the "HJJGCCLHAHK" field.</summary>
    public const int HJJGCCLHAHKFieldNumber = 12;
    private bool hJJGCCLHAHK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HJJGCCLHAHK {
      get { return hJJGCCLHAHK_; }
      set {
        hJJGCCLHAHK_ = value;
      }
    }

    /// <summary>Field number for the "MDFMCFFKBFP" field.</summary>
    public const int MDFMCFFKBFPFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.PunkLordMonsterKey mDFMCFFKBFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordMonsterKey MDFMCFFKBFP {
      get { return mDFMCFFKBFP_; }
      set {
        mDFMCFFKBFP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeKilledPunkLordMonsterScoreCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeKilledPunkLordMonsterScoreCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HJJGCCLHAHK != other.HJJGCCLHAHK) return false;
      if (!object.Equals(MDFMCFFKBFP, other.MDFMCFFKBFP)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HJJGCCLHAHK != false) hash ^= HJJGCCLHAHK.GetHashCode();
      if (mDFMCFFKBFP_ != null) hash ^= MDFMCFFKBFP.GetHashCode();
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
      if (HJJGCCLHAHK != false) {
        output.WriteRawTag(96);
        output.WriteBool(HJJGCCLHAHK);
      }
      if (mDFMCFFKBFP_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MDFMCFFKBFP);
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
      if (HJJGCCLHAHK != false) {
        output.WriteRawTag(96);
        output.WriteBool(HJJGCCLHAHK);
      }
      if (mDFMCFFKBFP_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MDFMCFFKBFP);
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
      if (HJJGCCLHAHK != false) {
        size += 1 + 1;
      }
      if (mDFMCFFKBFP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MDFMCFFKBFP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeKilledPunkLordMonsterScoreCsReq other) {
      if (other == null) {
        return;
      }
      if (other.HJJGCCLHAHK != false) {
        HJJGCCLHAHK = other.HJJGCCLHAHK;
      }
      if (other.mDFMCFFKBFP_ != null) {
        if (mDFMCFFKBFP_ == null) {
          MDFMCFFKBFP = new global::EggLink.DanhengServer.Proto.PunkLordMonsterKey();
        }
        MDFMCFFKBFP.MergeFrom(other.MDFMCFFKBFP);
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
          case 96: {
            HJJGCCLHAHK = input.ReadBool();
            break;
          }
          case 122: {
            if (mDFMCFFKBFP_ == null) {
              MDFMCFFKBFP = new global::EggLink.DanhengServer.Proto.PunkLordMonsterKey();
            }
            input.ReadMessage(MDFMCFFKBFP);
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
          case 96: {
            HJJGCCLHAHK = input.ReadBool();
            break;
          }
          case 122: {
            if (mDFMCFFKBFP_ == null) {
              MDFMCFFKBFP = new global::EggLink.DanhengServer.Proto.PunkLordMonsterKey();
            }
            input.ReadMessage(MDFMCFFKBFP);
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