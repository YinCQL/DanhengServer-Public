// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetGroupCustomSaveDataCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetGroupCustomSaveDataCsReq.proto</summary>
  public static partial class SetGroupCustomSaveDataCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SetGroupCustomSaveDataCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetGroupCustomSaveDataCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFTZXRHcm91cEN1c3RvbVNhdmVEYXRhQ3NSZXEucHJvdG8iVAobU2V0R3Jv",
            "dXBDdXN0b21TYXZlRGF0YUNzUmVxEhEKCXNhdmVfZGF0YRgLIAEoCRIQCghn",
            "cm91cF9pZBgMIAEoDRIQCghlbnRyeV9pZBgFIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetGroupCustomSaveDataCsReq), global::EggLink.DanhengServer.Proto.SetGroupCustomSaveDataCsReq.Parser, new[]{ "SaveData", "GroupId", "EntryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetGroupCustomSaveDataCsReq : pb::IMessage<SetGroupCustomSaveDataCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetGroupCustomSaveDataCsReq> _parser = new pb::MessageParser<SetGroupCustomSaveDataCsReq>(() => new SetGroupCustomSaveDataCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetGroupCustomSaveDataCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetGroupCustomSaveDataCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetGroupCustomSaveDataCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetGroupCustomSaveDataCsReq(SetGroupCustomSaveDataCsReq other) : this() {
      saveData_ = other.saveData_;
      groupId_ = other.groupId_;
      entryId_ = other.entryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetGroupCustomSaveDataCsReq Clone() {
      return new SetGroupCustomSaveDataCsReq(this);
    }

    /// <summary>Field number for the "save_data" field.</summary>
    public const int SaveDataFieldNumber = 11;
    private string saveData_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SaveData {
      get { return saveData_; }
      set {
        saveData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 12;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 5;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetGroupCustomSaveDataCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetGroupCustomSaveDataCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SaveData != other.SaveData) return false;
      if (GroupId != other.GroupId) return false;
      if (EntryId != other.EntryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SaveData.Length != 0) hash ^= SaveData.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
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
      if (EntryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EntryId);
      }
      if (SaveData.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(SaveData);
      }
      if (GroupId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GroupId);
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
      if (EntryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EntryId);
      }
      if (SaveData.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(SaveData);
      }
      if (GroupId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GroupId);
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
      if (SaveData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SaveData);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetGroupCustomSaveDataCsReq other) {
      if (other == null) {
        return;
      }
      if (other.SaveData.Length != 0) {
        SaveData = other.SaveData;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
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
          case 40: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 90: {
            SaveData = input.ReadString();
            break;
          }
          case 96: {
            GroupId = input.ReadUInt32();
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
          case 40: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 90: {
            SaveData = input.ReadString();
            break;
          }
          case 96: {
            GroupId = input.ReadUInt32();
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
