// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueUpdateDiceInfoScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueUpdateDiceInfoScNotify.proto</summary>
  public static partial class ChessRogueUpdateDiceInfoScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueUpdateDiceInfoScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueUpdateDiceInfoScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDaGVzc1JvZ3VlVXBkYXRlRGljZUluZm9TY05vdGlmeS5wcm90bxoYQ2hl",
            "c3NSb2d1ZURpY2VJbmZvLnByb3RvIlAKIENoZXNzUm9ndWVVcGRhdGVEaWNl",
            "SW5mb1NjTm90aWZ5EiwKD3JvZ3VlX2RpY2VfaW5mbxgIIAEoCzITLkNoZXNz",
            "Um9ndWVEaWNlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueUpdateDiceInfoScNotify), global::EggLink.DanhengServer.Proto.ChessRogueUpdateDiceInfoScNotify.Parser, new[]{ "RogueDiceInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueUpdateDiceInfoScNotify : pb::IMessage<ChessRogueUpdateDiceInfoScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueUpdateDiceInfoScNotify> _parser = new pb::MessageParser<ChessRogueUpdateDiceInfoScNotify>(() => new ChessRogueUpdateDiceInfoScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueUpdateDiceInfoScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueUpdateDiceInfoScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateDiceInfoScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateDiceInfoScNotify(ChessRogueUpdateDiceInfoScNotify other) : this() {
      rogueDiceInfo_ = other.rogueDiceInfo_ != null ? other.rogueDiceInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueUpdateDiceInfoScNotify Clone() {
      return new ChessRogueUpdateDiceInfoScNotify(this);
    }

    /// <summary>Field number for the "rogue_dice_info" field.</summary>
    public const int RogueDiceInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo rogueDiceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo RogueDiceInfo {
      get { return rogueDiceInfo_; }
      set {
        rogueDiceInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueUpdateDiceInfoScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueUpdateDiceInfoScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueDiceInfo, other.RogueDiceInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueDiceInfo_ != null) hash ^= RogueDiceInfo.GetHashCode();
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
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueDiceInfo);
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
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RogueDiceInfo);
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
      if (rogueDiceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDiceInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueUpdateDiceInfoScNotify other) {
      if (other == null) {
        return;
      }
      if (other.rogueDiceInfo_ != null) {
        if (rogueDiceInfo_ == null) {
          RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
        }
        RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
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
          case 66: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
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
          case 66: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
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
