// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SyncHandleFriendScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SyncHandleFriendScNotify.proto</summary>
  public static partial class SyncHandleFriendScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SyncHandleFriendScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SyncHandleFriendScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TeW5jSGFuZGxlRnJpZW5kU2NOb3RpZnkucHJvdG8aFkZyaWVuZFNpbXBs",
            "ZUluZm8ucHJvdG8iYgoYU3luY0hhbmRsZUZyaWVuZFNjTm90aWZ5EgsKA3Vp",
            "ZBgKIAEoDRIRCglpc19hY2NlcHQYBiABKAgSJgoLZnJpZW5kX2luZm8YASAB",
            "KAsyES5GcmllbmRTaW1wbGVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FriendSimpleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SyncHandleFriendScNotify), global::EggLink.DanhengServer.Proto.SyncHandleFriendScNotify.Parser, new[]{ "Uid", "IsAccept", "FriendInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SyncHandleFriendScNotify : pb::IMessage<SyncHandleFriendScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SyncHandleFriendScNotify> _parser = new pb::MessageParser<SyncHandleFriendScNotify>(() => new SyncHandleFriendScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SyncHandleFriendScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SyncHandleFriendScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncHandleFriendScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncHandleFriendScNotify(SyncHandleFriendScNotify other) : this() {
      uid_ = other.uid_;
      isAccept_ = other.isAccept_;
      friendInfo_ = other.friendInfo_ != null ? other.friendInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SyncHandleFriendScNotify Clone() {
      return new SyncHandleFriendScNotify(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 10;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "is_accept" field.</summary>
    public const int IsAcceptFieldNumber = 6;
    private bool isAccept_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAccept {
      get { return isAccept_; }
      set {
        isAccept_ = value;
      }
    }

    /// <summary>Field number for the "friend_info" field.</summary>
    public const int FriendInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.FriendSimpleInfo friendInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FriendSimpleInfo FriendInfo {
      get { return friendInfo_; }
      set {
        friendInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SyncHandleFriendScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SyncHandleFriendScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (IsAccept != other.IsAccept) return false;
      if (!object.Equals(FriendInfo, other.FriendInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (IsAccept != false) hash ^= IsAccept.GetHashCode();
      if (friendInfo_ != null) hash ^= FriendInfo.GetHashCode();
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
      if (friendInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FriendInfo);
      }
      if (IsAccept != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsAccept);
      }
      if (Uid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Uid);
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
      if (friendInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FriendInfo);
      }
      if (IsAccept != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsAccept);
      }
      if (Uid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Uid);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (IsAccept != false) {
        size += 1 + 1;
      }
      if (friendInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FriendInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SyncHandleFriendScNotify other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.IsAccept != false) {
        IsAccept = other.IsAccept;
      }
      if (other.friendInfo_ != null) {
        if (friendInfo_ == null) {
          FriendInfo = new global::EggLink.DanhengServer.Proto.FriendSimpleInfo();
        }
        FriendInfo.MergeFrom(other.FriendInfo);
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
          case 10: {
            if (friendInfo_ == null) {
              FriendInfo = new global::EggLink.DanhengServer.Proto.FriendSimpleInfo();
            }
            input.ReadMessage(FriendInfo);
            break;
          }
          case 48: {
            IsAccept = input.ReadBool();
            break;
          }
          case 80: {
            Uid = input.ReadUInt32();
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
            if (friendInfo_ == null) {
              FriendInfo = new global::EggLink.DanhengServer.Proto.FriendSimpleInfo();
            }
            input.ReadMessage(FriendInfo);
            break;
          }
          case 48: {
            IsAccept = input.ReadBool();
            break;
          }
          case 80: {
            Uid = input.ReadUInt32();
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
