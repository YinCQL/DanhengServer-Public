// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCurrentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCurrentInfo.proto</summary>
  public static partial class RogueCurrentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCurrentInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCurrentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSb2d1ZUN1cnJlbnRJbmZvLnByb3RvGhFSb2d1ZVN0YXR1cy5wcm90bxoW",
            "Um9ndWVWaXJ0dWFsSXRlbS5wcm90bxoSUm9ndWVNYXBJbmZvLnByb3RvGhVS",
            "b2d1ZUxpbmV1cEluZm8ucHJvdG8aFUdhbWVNaXJhY2xlSW5mby5wcm90bxoe",
            "Um9ndWVDb21tb25QZW5kaW5nQWN0aW9uLnByb3RvGhVSb2d1ZU1vZHVsZUlu",
            "Zm8ucHJvdG8aE1JvZ3VlQnVmZkluZm8ucHJvdG8aEkdhbWVBZW9uSW5mby5w",
            "cm90byKVAwoQUm9ndWVDdXJyZW50SW5mbxIOCgZpc193aW4YCSABKAgSJwoP",
            "cm9ndWVfYnVmZl9pbmZvGAUgASgLMg4uUm9ndWVCdWZmSW5mbxIlCgttb2R1",
            "bGVfaW5mbxgGIAEoCzIQLlJvZ3VlTW9kdWxlSW5mbxIcCgZzdGF0dXMYDSAB",
            "KA4yDC5Sb2d1ZVN0YXR1cxIrChFyb2d1ZV9saW5ldXBfaW5mbxgLIAEoCzIQ",
            "LlJvZ3VlTGluZXVwSW5mbxIfCghtYXBfaW5mbxgEIAEoCzINLlJvZ3VlTWFw",
            "SW5mbxImCg9yb2d1ZV9hZW9uX2luZm8YDyABKAsyDS5HYW1lQWVvbkluZm8S",
            "LQoScm9ndWVfdmlydHVhbF9pdGVtGAogASgLMhEuUm9ndWVWaXJ0dWFsSXRl",
            "bRIxCg5wZW5kaW5nX2FjdGlvbhgCIAEoCzIZLlJvZ3VlQ29tbW9uUGVuZGlu",
            "Z0FjdGlvbhIrChFnYW1lX21pcmFjbGVfaW5mbxgIIAEoCzIQLkdhbWVNaXJh",
            "Y2xlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueVirtualItemReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMapInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueLineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GameMiracleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonPendingActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueModuleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.GameAeonInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCurrentInfo), global::EggLink.DanhengServer.Proto.RogueCurrentInfo.Parser, new[]{ "IsWin", "RogueBuffInfo", "ModuleInfo", "Status", "RogueLineupInfo", "MapInfo", "RogueAeonInfo", "RogueVirtualItem", "PendingAction", "GameMiracleInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCurrentInfo : pb::IMessage<RogueCurrentInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCurrentInfo> _parser = new pb::MessageParser<RogueCurrentInfo>(() => new RogueCurrentInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCurrentInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCurrentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCurrentInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCurrentInfo(RogueCurrentInfo other) : this() {
      isWin_ = other.isWin_;
      rogueBuffInfo_ = other.rogueBuffInfo_ != null ? other.rogueBuffInfo_.Clone() : null;
      moduleInfo_ = other.moduleInfo_ != null ? other.moduleInfo_.Clone() : null;
      status_ = other.status_;
      rogueLineupInfo_ = other.rogueLineupInfo_ != null ? other.rogueLineupInfo_.Clone() : null;
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      rogueVirtualItem_ = other.rogueVirtualItem_ != null ? other.rogueVirtualItem_.Clone() : null;
      pendingAction_ = other.pendingAction_ != null ? other.pendingAction_.Clone() : null;
      gameMiracleInfo_ = other.gameMiracleInfo_ != null ? other.gameMiracleInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCurrentInfo Clone() {
      return new RogueCurrentInfo(this);
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 9;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueBuffInfo rogueBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffInfo RogueBuffInfo {
      get { return rogueBuffInfo_; }
      set {
        rogueBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "module_info" field.</summary>
    public const int ModuleInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueModuleInfo moduleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModuleInfo ModuleInfo {
      get { return moduleInfo_; }
      set {
        moduleInfo_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueStatus status_ = global::EggLink.DanhengServer.Proto.RogueStatus.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "rogue_lineup_info" field.</summary>
    public const int RogueLineupInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueLineupInfo rogueLineupInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueLineupInfo RogueLineupInfo {
      get { return rogueLineupInfo_; }
      set {
        rogueLineupInfo_ = value;
      }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueMapInfo mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMapInfo MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.GameAeonInfo rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GameAeonInfo RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_virtual_item" field.</summary>
    public const int RogueVirtualItemFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.RogueVirtualItem rogueVirtualItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueVirtualItem RogueVirtualItem {
      get { return rogueVirtualItem_; }
      set {
        rogueVirtualItem_ = value;
      }
    }

    /// <summary>Field number for the "pending_action" field.</summary>
    public const int PendingActionFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueCommonPendingAction pendingAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonPendingAction PendingAction {
      get { return pendingAction_; }
      set {
        pendingAction_ = value;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.GameMiracleInfo gameMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GameMiracleInfo GameMiracleInfo {
      get { return gameMiracleInfo_; }
      set {
        gameMiracleInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCurrentInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCurrentInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsWin != other.IsWin) return false;
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (!object.Equals(ModuleInfo, other.ModuleInfo)) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(RogueLineupInfo, other.RogueLineupInfo)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(RogueVirtualItem, other.RogueVirtualItem)) return false;
      if (!object.Equals(PendingAction, other.PendingAction)) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      if (rogueBuffInfo_ != null) hash ^= RogueBuffInfo.GetHashCode();
      if (moduleInfo_ != null) hash ^= ModuleInfo.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) hash ^= Status.GetHashCode();
      if (rogueLineupInfo_ != null) hash ^= RogueLineupInfo.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (rogueVirtualItem_ != null) hash ^= RogueVirtualItem.GetHashCode();
      if (pendingAction_ != null) hash ^= PendingAction.GetHashCode();
      if (gameMiracleInfo_ != null) hash ^= GameMiracleInfo.GetHashCode();
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
      if (pendingAction_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PendingAction);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MapInfo);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueBuffInfo);
      }
      if (moduleInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ModuleInfo);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(GameMiracleInfo);
      }
      if (IsWin != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsWin);
      }
      if (rogueVirtualItem_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueVirtualItem);
      }
      if (rogueLineupInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueLineupInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Status);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueAeonInfo);
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
      if (pendingAction_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PendingAction);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MapInfo);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RogueBuffInfo);
      }
      if (moduleInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ModuleInfo);
      }
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(GameMiracleInfo);
      }
      if (IsWin != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsWin);
      }
      if (rogueVirtualItem_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueVirtualItem);
      }
      if (rogueLineupInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueLineupInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Status);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueAeonInfo);
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
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (rogueBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (moduleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModuleInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (rogueLineupInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueLineupInfo);
      }
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (rogueVirtualItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueVirtualItem);
      }
      if (pendingAction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PendingAction);
      }
      if (gameMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCurrentInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      if (other.rogueBuffInfo_ != null) {
        if (rogueBuffInfo_ == null) {
          RogueBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
        }
        RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
      }
      if (other.moduleInfo_ != null) {
        if (moduleInfo_ == null) {
          ModuleInfo = new global::EggLink.DanhengServer.Proto.RogueModuleInfo();
        }
        ModuleInfo.MergeFrom(other.ModuleInfo);
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.RogueStatus.None) {
        Status = other.Status;
      }
      if (other.rogueLineupInfo_ != null) {
        if (rogueLineupInfo_ == null) {
          RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueLineupInfo();
        }
        RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
      }
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.RogueMapInfo();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.GameAeonInfo();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.rogueVirtualItem_ != null) {
        if (rogueVirtualItem_ == null) {
          RogueVirtualItem = new global::EggLink.DanhengServer.Proto.RogueVirtualItem();
        }
        RogueVirtualItem.MergeFrom(other.RogueVirtualItem);
      }
      if (other.pendingAction_ != null) {
        if (pendingAction_ == null) {
          PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
        }
        PendingAction.MergeFrom(other.PendingAction);
      }
      if (other.gameMiracleInfo_ != null) {
        if (gameMiracleInfo_ == null) {
          GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GameMiracleInfo();
        }
        GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
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
          case 18: {
            if (pendingAction_ == null) {
              PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(PendingAction);
            break;
          }
          case 34: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RogueMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 42: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 50: {
            if (moduleInfo_ == null) {
              ModuleInfo = new global::EggLink.DanhengServer.Proto.RogueModuleInfo();
            }
            input.ReadMessage(ModuleInfo);
            break;
          }
          case 66: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GameMiracleInfo();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 72: {
            IsWin = input.ReadBool();
            break;
          }
          case 82: {
            if (rogueVirtualItem_ == null) {
              RogueVirtualItem = new global::EggLink.DanhengServer.Proto.RogueVirtualItem();
            }
            input.ReadMessage(RogueVirtualItem);
            break;
          }
          case 90: {
            if (rogueLineupInfo_ == null) {
              RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueLineupInfo();
            }
            input.ReadMessage(RogueLineupInfo);
            break;
          }
          case 104: {
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
            break;
          }
          case 122: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.GameAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
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
          case 18: {
            if (pendingAction_ == null) {
              PendingAction = new global::EggLink.DanhengServer.Proto.RogueCommonPendingAction();
            }
            input.ReadMessage(PendingAction);
            break;
          }
          case 34: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RogueMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 42: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.RogueBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 50: {
            if (moduleInfo_ == null) {
              ModuleInfo = new global::EggLink.DanhengServer.Proto.RogueModuleInfo();
            }
            input.ReadMessage(ModuleInfo);
            break;
          }
          case 66: {
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.GameMiracleInfo();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 72: {
            IsWin = input.ReadBool();
            break;
          }
          case 82: {
            if (rogueVirtualItem_ == null) {
              RogueVirtualItem = new global::EggLink.DanhengServer.Proto.RogueVirtualItem();
            }
            input.ReadMessage(RogueVirtualItem);
            break;
          }
          case 90: {
            if (rogueLineupInfo_ == null) {
              RogueLineupInfo = new global::EggLink.DanhengServer.Proto.RogueLineupInfo();
            }
            input.ReadMessage(RogueLineupInfo);
            break;
          }
          case 104: {
            Status = (global::EggLink.DanhengServer.Proto.RogueStatus) input.ReadEnum();
            break;
          }
          case 122: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.GameAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
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
