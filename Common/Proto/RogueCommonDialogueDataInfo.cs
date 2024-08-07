// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonDialogueDataInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonDialogueDataInfo.proto</summary>
  public static partial class RogueCommonDialogueDataInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonDialogueDataInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonDialogueDataInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSb2d1ZUNvbW1vbkRpYWxvZ3VlRGF0YUluZm8ucHJvdG8aHVJvZ3VlQ29t",
            "bW9uRGlhbG9ndWVJbmZvLnByb3RvGiNSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0",
            "aW9uSW5mby5wcm90byKcAQobUm9ndWVDb21tb25EaWFsb2d1ZURhdGFJbmZv",
            "EhcKD2V2ZW50X3VuaXF1ZV9pZBgDIAEoDRIvCg1kaWFsb2d1ZV9pbmZvGAEg",
            "ASgLMhguUm9ndWVDb21tb25EaWFsb2d1ZUluZm8SMwoLb3B0aW9uX2xpc3QY",
            "CSADKAsyHi5Sb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uSW5mb0IeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonDialogueInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonDialogueOptionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo), global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfo.Parser, new[]{ "EventUniqueId", "DialogueInfo", "OptionList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonDialogueDataInfo : pb::IMessage<RogueCommonDialogueDataInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonDialogueDataInfo> _parser = new pb::MessageParser<RogueCommonDialogueDataInfo>(() => new RogueCommonDialogueDataInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonDialogueDataInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonDialogueDataInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonDialogueDataInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonDialogueDataInfo(RogueCommonDialogueDataInfo other) : this() {
      eventUniqueId_ = other.eventUniqueId_;
      dialogueInfo_ = other.dialogueInfo_ != null ? other.dialogueInfo_.Clone() : null;
      optionList_ = other.optionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonDialogueDataInfo Clone() {
      return new RogueCommonDialogueDataInfo(this);
    }

    /// <summary>Field number for the "event_unique_id" field.</summary>
    public const int EventUniqueIdFieldNumber = 3;
    private uint eventUniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventUniqueId {
      get { return eventUniqueId_; }
      set {
        eventUniqueId_ = value;
      }
    }

    /// <summary>Field number for the "dialogue_info" field.</summary>
    public const int DialogueInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RogueCommonDialogueInfo dialogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonDialogueInfo DialogueInfo {
      get { return dialogueInfo_; }
      set {
        dialogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "option_list" field.</summary>
    public const int OptionListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonDialogueOptionInfo> _repeated_optionList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.RogueCommonDialogueOptionInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonDialogueOptionInfo> optionList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonDialogueOptionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonDialogueOptionInfo> OptionList {
      get { return optionList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonDialogueDataInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonDialogueDataInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventUniqueId != other.EventUniqueId) return false;
      if (!object.Equals(DialogueInfo, other.DialogueInfo)) return false;
      if(!optionList_.Equals(other.optionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EventUniqueId != 0) hash ^= EventUniqueId.GetHashCode();
      if (dialogueInfo_ != null) hash ^= DialogueInfo.GetHashCode();
      hash ^= optionList_.GetHashCode();
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
      if (dialogueInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DialogueInfo);
      }
      if (EventUniqueId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EventUniqueId);
      }
      optionList_.WriteTo(output, _repeated_optionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (dialogueInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DialogueInfo);
      }
      if (EventUniqueId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EventUniqueId);
      }
      optionList_.WriteTo(ref output, _repeated_optionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EventUniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventUniqueId);
      }
      if (dialogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DialogueInfo);
      }
      size += optionList_.CalculateSize(_repeated_optionList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonDialogueDataInfo other) {
      if (other == null) {
        return;
      }
      if (other.EventUniqueId != 0) {
        EventUniqueId = other.EventUniqueId;
      }
      if (other.dialogueInfo_ != null) {
        if (dialogueInfo_ == null) {
          DialogueInfo = new global::EggLink.DanhengServer.Proto.RogueCommonDialogueInfo();
        }
        DialogueInfo.MergeFrom(other.DialogueInfo);
      }
      optionList_.Add(other.optionList_);
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
          case 10: {
            if (dialogueInfo_ == null) {
              DialogueInfo = new global::EggLink.DanhengServer.Proto.RogueCommonDialogueInfo();
            }
            input.ReadMessage(DialogueInfo);
            break;
          }
          case 24: {
            EventUniqueId = input.ReadUInt32();
            break;
          }
          case 74: {
            optionList_.AddEntriesFrom(input, _repeated_optionList_codec);
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
          case 10: {
            if (dialogueInfo_ == null) {
              DialogueInfo = new global::EggLink.DanhengServer.Proto.RogueCommonDialogueInfo();
            }
            input.ReadMessage(DialogueInfo);
            break;
          }
          case 24: {
            EventUniqueId = input.ReadUInt32();
            break;
          }
          case 74: {
            optionList_.AddEntriesFrom(ref input, _repeated_optionList_codec);
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
