// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GroupStatus.proto</summary>
  public static partial class GroupStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHcm91cFN0YXR1cy5wcm90bxoYTWVzc2FnZUdyb3VwU3RhdHVzLnByb3Rv",
            "ImAKC0dyb3VwU3RhdHVzEikKDGdyb3VwX3N0YXR1cxgNIAEoDjITLk1lc3Nh",
            "Z2VHcm91cFN0YXR1cxIUCgxyZWZyZXNoX3RpbWUYDiABKAMSEAoIZ3JvdXBf",
            "aWQYCCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MessageGroupStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GroupStatus), global::EggLink.DanhengServer.Proto.GroupStatus.Parser, new[]{ "GroupStatus_", "RefreshTime", "GroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GroupStatus : pb::IMessage<GroupStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupStatus> _parser = new pb::MessageParser<GroupStatus>(() => new GroupStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GroupStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupStatus(GroupStatus other) : this() {
      groupStatus_ = other.groupStatus_;
      refreshTime_ = other.refreshTime_;
      groupId_ = other.groupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupStatus Clone() {
      return new GroupStatus(this);
    }

    /// <summary>Field number for the "group_status" field.</summary>
    public const int GroupStatus_FieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.MessageGroupStatus groupStatus_ = global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MessageGroupStatus GroupStatus_ {
      get { return groupStatus_; }
      set {
        groupStatus_ = value;
      }
    }

    /// <summary>Field number for the "refresh_time" field.</summary>
    public const int RefreshTimeFieldNumber = 14;
    private long refreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RefreshTime {
      get { return refreshTime_; }
      set {
        refreshTime_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 8;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupStatus_ != other.GroupStatus_) return false;
      if (RefreshTime != other.RefreshTime) return false;
      if (GroupId != other.GroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupStatus_ != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) hash ^= GroupStatus_.GetHashCode();
      if (RefreshTime != 0L) hash ^= RefreshTime.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GroupId);
      }
      if (GroupStatus_ != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) GroupStatus_);
      }
      if (RefreshTime != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(RefreshTime);
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
      if (GroupId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GroupId);
      }
      if (GroupStatus_ != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) GroupStatus_);
      }
      if (RefreshTime != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(RefreshTime);
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
      if (GroupStatus_ != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GroupStatus_);
      }
      if (RefreshTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RefreshTime);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupStatus other) {
      if (other == null) {
        return;
      }
      if (other.GroupStatus_ != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        GroupStatus_ = other.GroupStatus_;
      }
      if (other.RefreshTime != 0L) {
        RefreshTime = other.RefreshTime;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
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
          case 64: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 104: {
            GroupStatus_ = (global::EggLink.DanhengServer.Proto.MessageGroupStatus) input.ReadEnum();
            break;
          }
          case 112: {
            RefreshTime = input.ReadInt64();
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
          case 64: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 104: {
            GroupStatus_ = (global::EggLink.DanhengServer.Proto.MessageGroupStatus) input.ReadEnum();
            break;
          }
          case 112: {
            RefreshTime = input.ReadInt64();
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
