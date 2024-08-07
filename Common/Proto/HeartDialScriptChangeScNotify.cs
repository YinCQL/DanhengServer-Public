// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeartDialScriptChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeartDialScriptChangeScNotify.proto</summary>
  public static partial class HeartDialScriptChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HeartDialScriptChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeartDialScriptChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeS5wcm90bxoRQ0NPT0VP",
            "RURDRk4ucHJvdG8aG0hlYXJ0RGlhbERpYWxvZ3VlSW5mby5wcm90bxobSGVh",
            "cnREaWFsVW5sb2NrU3RhdHVzLnByb3RvGhlIZWFydERpYWxTY3JpcHRJbmZv",
            "LnByb3RvIuUBCh1IZWFydERpYWxTY3JpcHRDaGFuZ2VTY05vdGlmeRI2Chhj",
            "aGFuZ2VkX3NjcmlwdF9pbmZvX2xpc3QYByADKAsyFC5IZWFydERpYWxTY3Jp",
            "cHRJbmZvEiEKC0ZOTFBKTkxCSE5BGAggAygLMgwuQ0NPT0VPRURDRk4SLQoN",
            "dW5sb2NrX3N0YXR1cxgMIAEoDjIWLkhlYXJ0RGlhbFVubG9ja1N0YXR1cxI6",
            "ChpjaGFuZ2VkX2RpYWxvZ3VlX2luZm9fbGlzdBgGIAMoCzIWLkhlYXJ0RGlh",
            "bERpYWxvZ3VlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CCOOEOEDCFNReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeartDialDialogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeartDialUnlockStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeartDialScriptInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotify), global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotify.Parser, new[]{ "ChangedScriptInfoList", "FNLPJNLBHNA", "UnlockStatus", "ChangedDialogueInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeartDialScriptChangeScNotify : pb::IMessage<HeartDialScriptChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeartDialScriptChangeScNotify> _parser = new pb::MessageParser<HeartDialScriptChangeScNotify>(() => new HeartDialScriptChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeartDialScriptChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeartDialScriptChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify(HeartDialScriptChangeScNotify other) : this() {
      changedScriptInfoList_ = other.changedScriptInfoList_.Clone();
      fNLPJNLBHNA_ = other.fNLPJNLBHNA_.Clone();
      unlockStatus_ = other.unlockStatus_;
      changedDialogueInfoList_ = other.changedDialogueInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptChangeScNotify Clone() {
      return new HeartDialScriptChangeScNotify(this);
    }

    /// <summary>Field number for the "changed_script_info_list" field.</summary>
    public const int ChangedScriptInfoListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HeartDialScriptInfo> _repeated_changedScriptInfoList_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.HeartDialScriptInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeartDialScriptInfo> changedScriptInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeartDialScriptInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeartDialScriptInfo> ChangedScriptInfoList {
      get { return changedScriptInfoList_; }
    }

    /// <summary>Field number for the "FNLPJNLBHNA" field.</summary>
    public const int FNLPJNLBHNAFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN> _repeated_fNLPJNLBHNA_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.CCOOEOEDCFN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN> fNLPJNLBHNA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCOOEOEDCFN> FNLPJNLBHNA {
      get { return fNLPJNLBHNA_; }
    }

    /// <summary>Field number for the "unlock_status" field.</summary>
    public const int UnlockStatusFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus unlockStatus_ = global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus UnlockStatus {
      get { return unlockStatus_; }
      set {
        unlockStatus_ = value;
      }
    }

    /// <summary>Field number for the "changed_dialogue_info_list" field.</summary>
    public const int ChangedDialogueInfoListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HeartDialDialogueInfo> _repeated_changedDialogueInfoList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.HeartDialDialogueInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeartDialDialogueInfo> changedDialogueInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeartDialDialogueInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HeartDialDialogueInfo> ChangedDialogueInfoList {
      get { return changedDialogueInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeartDialScriptChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeartDialScriptChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!changedScriptInfoList_.Equals(other.changedScriptInfoList_)) return false;
      if(!fNLPJNLBHNA_.Equals(other.fNLPJNLBHNA_)) return false;
      if (UnlockStatus != other.UnlockStatus) return false;
      if(!changedDialogueInfoList_.Equals(other.changedDialogueInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= changedScriptInfoList_.GetHashCode();
      hash ^= fNLPJNLBHNA_.GetHashCode();
      if (UnlockStatus != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) hash ^= UnlockStatus.GetHashCode();
      hash ^= changedDialogueInfoList_.GetHashCode();
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
      changedDialogueInfoList_.WriteTo(output, _repeated_changedDialogueInfoList_codec);
      changedScriptInfoList_.WriteTo(output, _repeated_changedScriptInfoList_codec);
      fNLPJNLBHNA_.WriteTo(output, _repeated_fNLPJNLBHNA_codec);
      if (UnlockStatus != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        output.WriteRawTag(96);
        output.WriteEnum((int) UnlockStatus);
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
      changedDialogueInfoList_.WriteTo(ref output, _repeated_changedDialogueInfoList_codec);
      changedScriptInfoList_.WriteTo(ref output, _repeated_changedScriptInfoList_codec);
      fNLPJNLBHNA_.WriteTo(ref output, _repeated_fNLPJNLBHNA_codec);
      if (UnlockStatus != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        output.WriteRawTag(96);
        output.WriteEnum((int) UnlockStatus);
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
      size += changedScriptInfoList_.CalculateSize(_repeated_changedScriptInfoList_codec);
      size += fNLPJNLBHNA_.CalculateSize(_repeated_fNLPJNLBHNA_codec);
      if (UnlockStatus != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnlockStatus);
      }
      size += changedDialogueInfoList_.CalculateSize(_repeated_changedDialogueInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeartDialScriptChangeScNotify other) {
      if (other == null) {
        return;
      }
      changedScriptInfoList_.Add(other.changedScriptInfoList_);
      fNLPJNLBHNA_.Add(other.fNLPJNLBHNA_);
      if (other.UnlockStatus != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        UnlockStatus = other.UnlockStatus;
      }
      changedDialogueInfoList_.Add(other.changedDialogueInfoList_);
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
          case 50: {
            changedDialogueInfoList_.AddEntriesFrom(input, _repeated_changedDialogueInfoList_codec);
            break;
          }
          case 58: {
            changedScriptInfoList_.AddEntriesFrom(input, _repeated_changedScriptInfoList_codec);
            break;
          }
          case 66: {
            fNLPJNLBHNA_.AddEntriesFrom(input, _repeated_fNLPJNLBHNA_codec);
            break;
          }
          case 96: {
            UnlockStatus = (global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus) input.ReadEnum();
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
          case 50: {
            changedDialogueInfoList_.AddEntriesFrom(ref input, _repeated_changedDialogueInfoList_codec);
            break;
          }
          case 58: {
            changedScriptInfoList_.AddEntriesFrom(ref input, _repeated_changedScriptInfoList_codec);
            break;
          }
          case 66: {
            fNLPJNLBHNA_.AddEntriesFrom(ref input, _repeated_fNLPJNLBHNA_codec);
            break;
          }
          case 96: {
            UnlockStatus = (global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus) input.ReadEnum();
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
