// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueCell.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueCell.proto</summary>
  public static partial class ChessRogueCellReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueCell.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueCellReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDaGVzc1JvZ3VlQ2VsbC5wcm90bxofQ2hlc3NSb2d1ZUJvYXJkQ2VsbFN0",
            "YXR1cy5wcm90bxoVQ2VsbEFkdmFuY2VJbmZvLnByb3RvGh9DaGVzc1JvZ3Vl",
            "Q2VsbFNwZWNpYWxUeXBlLnByb3RvIroCCg5DaGVzc1JvZ3VlQ2VsbBIlCgtw",
            "bGF5ZXJfaW5mbxgGIAEoCzIQLkNlbGxBZHZhbmNlSW5mbxIvCgtjZWxsX3N0",
            "YXR1cxgDIAEoDjIaLkNoZXNzUm9ndWVCb2FyZENlbGxTdGF0dXMSMAoMc3Bl",
            "Y2lhbF90eXBlGAwgASgOMhouQ2hlc3NSb2d1ZUNlbGxTcGVjaWFsVHlwZRIN",
            "CgVwb3NfeBgPIAEoDRIRCgljZWxsX3R5cGUYASABKA0SDwoHcm9vbV9pZBgF",
            "IAEoDRITCgtPS0JFS1BKQUdNRhgKIAEoDRIKCgJpZBgNIAEoDRINCgVwb3Nf",
            "eRgLIAEoDRITCgtQRk9FTEhKTk5HTxgEIAMoDRIRCglpc191bmxvY2sYAiAB",
            "KAgSEwoLTUdFSElIQ0NISE8YByABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.CellAdvanceInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueCell), global::EggLink.DanhengServer.Proto.ChessRogueCell.Parser, new[]{ "PlayerInfo", "CellStatus", "SpecialType", "PosX", "CellType", "RoomId", "OKBEKPJAGMF", "Id", "PosY", "PFOELHJNNGO", "IsUnlock", "MGEHIHCCHHO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueCell : pb::IMessage<ChessRogueCell>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueCell> _parser = new pb::MessageParser<ChessRogueCell>(() => new ChessRogueCell());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueCell> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueCellReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCell() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCell(ChessRogueCell other) : this() {
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      cellStatus_ = other.cellStatus_;
      specialType_ = other.specialType_;
      posX_ = other.posX_;
      cellType_ = other.cellType_;
      roomId_ = other.roomId_;
      oKBEKPJAGMF_ = other.oKBEKPJAGMF_;
      id_ = other.id_;
      posY_ = other.posY_;
      pFOELHJNNGO_ = other.pFOELHJNNGO_.Clone();
      isUnlock_ = other.isUnlock_;
      mGEHIHCCHHO_ = other.mGEHIHCCHHO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueCell Clone() {
      return new ChessRogueCell(this);
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.CellAdvanceInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellAdvanceInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "cell_status" field.</summary>
    public const int CellStatusFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus cellStatus_ = global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus CellStatus {
      get { return cellStatus_; }
      set {
        cellStatus_ = value;
      }
    }

    /// <summary>Field number for the "special_type" field.</summary>
    public const int SpecialTypeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType specialType_ = global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType SpecialType {
      get { return specialType_; }
      set {
        specialType_ = value;
      }
    }

    /// <summary>Field number for the "pos_x" field.</summary>
    public const int PosXFieldNumber = 15;
    private uint posX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PosX {
      get { return posX_; }
      set {
        posX_ = value;
      }
    }

    /// <summary>Field number for the "cell_type" field.</summary>
    public const int CellTypeFieldNumber = 1;
    private uint cellType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellType {
      get { return cellType_; }
      set {
        cellType_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 5;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "OKBEKPJAGMF" field.</summary>
    public const int OKBEKPJAGMFFieldNumber = 10;
    private uint oKBEKPJAGMF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OKBEKPJAGMF {
      get { return oKBEKPJAGMF_; }
      set {
        oKBEKPJAGMF_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 13;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "pos_y" field.</summary>
    public const int PosYFieldNumber = 11;
    private uint posY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PosY {
      get { return posY_; }
      set {
        posY_ = value;
      }
    }

    /// <summary>Field number for the "PFOELHJNNGO" field.</summary>
    public const int PFOELHJNNGOFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_pFOELHJNNGO_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> pFOELHJNNGO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PFOELHJNNGO {
      get { return pFOELHJNNGO_; }
    }

    /// <summary>Field number for the "is_unlock" field.</summary>
    public const int IsUnlockFieldNumber = 2;
    private bool isUnlock_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlock {
      get { return isUnlock_; }
      set {
        isUnlock_ = value;
      }
    }

    /// <summary>Field number for the "MGEHIHCCHHO" field.</summary>
    public const int MGEHIHCCHHOFieldNumber = 7;
    private bool mGEHIHCCHHO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MGEHIHCCHHO {
      get { return mGEHIHCCHHO_; }
      set {
        mGEHIHCCHHO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueCell);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueCell other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (CellStatus != other.CellStatus) return false;
      if (SpecialType != other.SpecialType) return false;
      if (PosX != other.PosX) return false;
      if (CellType != other.CellType) return false;
      if (RoomId != other.RoomId) return false;
      if (OKBEKPJAGMF != other.OKBEKPJAGMF) return false;
      if (Id != other.Id) return false;
      if (PosY != other.PosY) return false;
      if(!pFOELHJNNGO_.Equals(other.pFOELHJNNGO_)) return false;
      if (IsUnlock != other.IsUnlock) return false;
      if (MGEHIHCCHHO != other.MGEHIHCCHHO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) hash ^= CellStatus.GetHashCode();
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) hash ^= SpecialType.GetHashCode();
      if (PosX != 0) hash ^= PosX.GetHashCode();
      if (CellType != 0) hash ^= CellType.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (OKBEKPJAGMF != 0) hash ^= OKBEKPJAGMF.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (PosY != 0) hash ^= PosY.GetHashCode();
      hash ^= pFOELHJNNGO_.GetHashCode();
      if (IsUnlock != false) hash ^= IsUnlock.GetHashCode();
      if (MGEHIHCCHHO != false) hash ^= MGEHIHCCHHO.GetHashCode();
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
      if (CellType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CellType);
      }
      if (IsUnlock != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsUnlock);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CellStatus);
      }
      pFOELHJNNGO_.WriteTo(output, _repeated_pFOELHJNNGO_codec);
      if (RoomId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RoomId);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PlayerInfo);
      }
      if (MGEHIHCCHHO != false) {
        output.WriteRawTag(56);
        output.WriteBool(MGEHIHCCHHO);
      }
      if (OKBEKPJAGMF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OKBEKPJAGMF);
      }
      if (PosY != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PosY);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) SpecialType);
      }
      if (Id != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Id);
      }
      if (PosX != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PosX);
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
      if (CellType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CellType);
      }
      if (IsUnlock != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsUnlock);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CellStatus);
      }
      pFOELHJNNGO_.WriteTo(ref output, _repeated_pFOELHJNNGO_codec);
      if (RoomId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RoomId);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PlayerInfo);
      }
      if (MGEHIHCCHHO != false) {
        output.WriteRawTag(56);
        output.WriteBool(MGEHIHCCHHO);
      }
      if (OKBEKPJAGMF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OKBEKPJAGMF);
      }
      if (PosY != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PosY);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) SpecialType);
      }
      if (Id != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Id);
      }
      if (PosX != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PosX);
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
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CellStatus);
      }
      if (SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SpecialType);
      }
      if (PosX != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PosX);
      }
      if (CellType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellType);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (OKBEKPJAGMF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OKBEKPJAGMF);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (PosY != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PosY);
      }
      size += pFOELHJNNGO_.CalculateSize(_repeated_pFOELHJNNGO_codec);
      if (IsUnlock != false) {
        size += 1 + 1;
      }
      if (MGEHIHCCHHO != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueCell other) {
      if (other == null) {
        return;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.CellStatus != global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus.Idle) {
        CellStatus = other.CellStatus;
      }
      if (other.SpecialType != global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType.None) {
        SpecialType = other.SpecialType;
      }
      if (other.PosX != 0) {
        PosX = other.PosX;
      }
      if (other.CellType != 0) {
        CellType = other.CellType;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.OKBEKPJAGMF != 0) {
        OKBEKPJAGMF = other.OKBEKPJAGMF;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.PosY != 0) {
        PosY = other.PosY;
      }
      pFOELHJNNGO_.Add(other.pFOELHJNNGO_);
      if (other.IsUnlock != false) {
        IsUnlock = other.IsUnlock;
      }
      if (other.MGEHIHCCHHO != false) {
        MGEHIHCCHHO = other.MGEHIHCCHHO;
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
          case 8: {
            CellType = input.ReadUInt32();
            break;
          }
          case 16: {
            IsUnlock = input.ReadBool();
            break;
          }
          case 24: {
            CellStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 34:
          case 32: {
            pFOELHJNNGO_.AddEntriesFrom(input, _repeated_pFOELHJNNGO_codec);
            break;
          }
          case 40: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 56: {
            MGEHIHCCHHO = input.ReadBool();
            break;
          }
          case 80: {
            OKBEKPJAGMF = input.ReadUInt32();
            break;
          }
          case 88: {
            PosY = input.ReadUInt32();
            break;
          }
          case 96: {
            SpecialType = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 104: {
            Id = input.ReadUInt32();
            break;
          }
          case 120: {
            PosX = input.ReadUInt32();
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
            CellType = input.ReadUInt32();
            break;
          }
          case 16: {
            IsUnlock = input.ReadBool();
            break;
          }
          case 24: {
            CellStatus = (global::EggLink.DanhengServer.Proto.ChessRogueBoardCellStatus) input.ReadEnum();
            break;
          }
          case 34:
          case 32: {
            pFOELHJNNGO_.AddEntriesFrom(ref input, _repeated_pFOELHJNNGO_codec);
            break;
          }
          case 40: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.CellAdvanceInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 56: {
            MGEHIHCCHHO = input.ReadBool();
            break;
          }
          case 80: {
            OKBEKPJAGMF = input.ReadUInt32();
            break;
          }
          case 88: {
            PosY = input.ReadUInt32();
            break;
          }
          case 96: {
            SpecialType = (global::EggLink.DanhengServer.Proto.ChessRogueCellSpecialType) input.ReadEnum();
            break;
          }
          case 104: {
            Id = input.ReadUInt32();
            break;
          }
          case 120: {
            PosX = input.ReadUInt32();
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
