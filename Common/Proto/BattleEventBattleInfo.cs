// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleEventBattleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattleEventBattleInfo.proto</summary>
  public static partial class BattleEventBattleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleEventBattleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleEventBattleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtCYXR0bGVFdmVudEJhdHRsZUluZm8ucHJvdG8aEUVMQkROSUdHSE9FLnBy",
            "b3RvGhlCYXR0bGVFdmVudFByb3BlcnR5LnByb3RvIngKFUJhdHRsZUV2ZW50",
            "QmF0dGxlSW5mbxIXCg9iYXR0bGVfZXZlbnRfaWQYASABKA0SJAoGc3RhdHVz",
            "GAIgASgLMhQuQmF0dGxlRXZlbnRQcm9wZXJ0eRIgCgpza2lsbF9pbmZvGAMg",
            "AygLMgwuRUxCRE5JR0dIT0VCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ELBDNIGGHOEReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleEventPropertyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BattleEventBattleInfo), global::EggLink.DanhengServer.Proto.BattleEventBattleInfo.Parser, new[]{ "BattleEventId", "Status", "SkillInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleEventBattleInfo : pb::IMessage<BattleEventBattleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleEventBattleInfo> _parser = new pb::MessageParser<BattleEventBattleInfo>(() => new BattleEventBattleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleEventBattleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BattleEventBattleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleEventBattleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleEventBattleInfo(BattleEventBattleInfo other) : this() {
      battleEventId_ = other.battleEventId_;
      status_ = other.status_ != null ? other.status_.Clone() : null;
      skillInfo_ = other.skillInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleEventBattleInfo Clone() {
      return new BattleEventBattleInfo(this);
    }

    /// <summary>Field number for the "battle_event_id" field.</summary>
    public const int BattleEventIdFieldNumber = 1;
    private uint battleEventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleEventId {
      get { return battleEventId_; }
      set {
        battleEventId_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.BattleEventProperty status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleEventProperty Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "skill_info" field.</summary>
    public const int SkillInfoFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ELBDNIGGHOE> _repeated_skillInfo_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.ELBDNIGGHOE.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ELBDNIGGHOE> skillInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ELBDNIGGHOE>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ELBDNIGGHOE> SkillInfo {
      get { return skillInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleEventBattleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleEventBattleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleEventId != other.BattleEventId) return false;
      if (!object.Equals(Status, other.Status)) return false;
      if(!skillInfo_.Equals(other.skillInfo_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleEventId != 0) hash ^= BattleEventId.GetHashCode();
      if (status_ != null) hash ^= Status.GetHashCode();
      hash ^= skillInfo_.GetHashCode();
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
      if (BattleEventId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BattleEventId);
      }
      if (status_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Status);
      }
      skillInfo_.WriteTo(output, _repeated_skillInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BattleEventId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BattleEventId);
      }
      if (status_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Status);
      }
      skillInfo_.WriteTo(ref output, _repeated_skillInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BattleEventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleEventId);
      }
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      size += skillInfo_.CalculateSize(_repeated_skillInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleEventBattleInfo other) {
      if (other == null) {
        return;
      }
      if (other.BattleEventId != 0) {
        BattleEventId = other.BattleEventId;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          Status = new global::EggLink.DanhengServer.Proto.BattleEventProperty();
        }
        Status.MergeFrom(other.Status);
      }
      skillInfo_.Add(other.skillInfo_);
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
          case 8: {
            BattleEventId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (status_ == null) {
              Status = new global::EggLink.DanhengServer.Proto.BattleEventProperty();
            }
            input.ReadMessage(Status);
            break;
          }
          case 26: {
            skillInfo_.AddEntriesFrom(input, _repeated_skillInfo_codec);
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
          case 8: {
            BattleEventId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (status_ == null) {
              Status = new global::EggLink.DanhengServer.Proto.BattleEventProperty();
            }
            input.ReadMessage(Status);
            break;
          }
          case 26: {
            skillInfo_.AddEntriesFrom(ref input, _repeated_skillInfo_codec);
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
