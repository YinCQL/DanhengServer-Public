// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMapRotationDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMapRotationDataScRsp.proto</summary>
  public static partial class GetMapRotationDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMapRotationDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMapRotationDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRNYXBSb3RhdGlvbkRhdGFTY1JzcC5wcm90bxoRUm90YXRlckRhdGEu",
            "cHJvdG8aEUNoYXJnZXJJbmZvLnByb3RvGhdSb3RhdG9yRW5lcmd5SW5mby5w",
            "cm90bxoRSUpKSEtETkZLTUQucHJvdG8i+gEKF0dldE1hcFJvdGF0aW9uRGF0",
            "YVNjUnNwEhMKC0lJQ0ZPT05PTEFJGA4gASgFEhMKC0hNQ0FGRUpBUEpLGAog",
            "ASgNEiIKDHJvdGF0ZXJfZGF0YRgPIAMoCzIMLlJvdGF0ZXJEYXRhEhMKC0NM",
            "SE1BRkNISkFGGAcgASgIEg8KB3JldGNvZGUYAiABKA0SJwoLZW5lcmd5X2lu",
            "Zm8YASABKAsyEi5Sb3RhdG9yRW5lcmd5SW5mbxIiCgxjaGFyZ2VyX2luZm8Y",
            "CyADKAsyDC5DaGFyZ2VySW5mbxIeCghtYXBfaW5mbxgEIAEoCzIMLklKSkhL",
            "RE5GS01EQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RotaterDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChargerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotatorEnergyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.IJJHKDNFKMDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMapRotationDataScRsp), global::EggLink.DanhengServer.Proto.GetMapRotationDataScRsp.Parser, new[]{ "IICFOONOLAI", "HMCAFEJAPJK", "RotaterData", "CLHMAFCHJAF", "Retcode", "EnergyInfo", "ChargerInfo", "MapInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMapRotationDataScRsp : pb::IMessage<GetMapRotationDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMapRotationDataScRsp> _parser = new pb::MessageParser<GetMapRotationDataScRsp>(() => new GetMapRotationDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMapRotationDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMapRotationDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp(GetMapRotationDataScRsp other) : this() {
      iICFOONOLAI_ = other.iICFOONOLAI_;
      hMCAFEJAPJK_ = other.hMCAFEJAPJK_;
      rotaterData_ = other.rotaterData_.Clone();
      cLHMAFCHJAF_ = other.cLHMAFCHJAF_;
      retcode_ = other.retcode_;
      energyInfo_ = other.energyInfo_ != null ? other.energyInfo_.Clone() : null;
      chargerInfo_ = other.chargerInfo_.Clone();
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp Clone() {
      return new GetMapRotationDataScRsp(this);
    }

    /// <summary>Field number for the "IICFOONOLAI" field.</summary>
    public const int IICFOONOLAIFieldNumber = 14;
    private int iICFOONOLAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IICFOONOLAI {
      get { return iICFOONOLAI_; }
      set {
        iICFOONOLAI_ = value;
      }
    }

    /// <summary>Field number for the "HMCAFEJAPJK" field.</summary>
    public const int HMCAFEJAPJKFieldNumber = 10;
    private uint hMCAFEJAPJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HMCAFEJAPJK {
      get { return hMCAFEJAPJK_; }
      set {
        hMCAFEJAPJK_ = value;
      }
    }

    /// <summary>Field number for the "rotater_data" field.</summary>
    public const int RotaterDataFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RotaterData> _repeated_rotaterData_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.RotaterData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> rotaterData_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> RotaterData {
      get { return rotaterData_; }
    }

    /// <summary>Field number for the "CLHMAFCHJAF" field.</summary>
    public const int CLHMAFCHJAFFieldNumber = 7;
    private bool cLHMAFCHJAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CLHMAFCHJAF {
      get { return cLHMAFCHJAF_; }
      set {
        cLHMAFCHJAF_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "energy_info" field.</summary>
    public const int EnergyInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RotatorEnergyInfo energyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotatorEnergyInfo EnergyInfo {
      get { return energyInfo_; }
      set {
        energyInfo_ = value;
      }
    }

    /// <summary>Field number for the "charger_info" field.</summary>
    public const int ChargerInfoFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChargerInfo> _repeated_chargerInfo_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.ChargerInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> chargerInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> ChargerInfo {
      get { return chargerInfo_; }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.IJJHKDNFKMD mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IJJHKDNFKMD MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMapRotationDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMapRotationDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IICFOONOLAI != other.IICFOONOLAI) return false;
      if (HMCAFEJAPJK != other.HMCAFEJAPJK) return false;
      if(!rotaterData_.Equals(other.rotaterData_)) return false;
      if (CLHMAFCHJAF != other.CLHMAFCHJAF) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(EnergyInfo, other.EnergyInfo)) return false;
      if(!chargerInfo_.Equals(other.chargerInfo_)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IICFOONOLAI != 0) hash ^= IICFOONOLAI.GetHashCode();
      if (HMCAFEJAPJK != 0) hash ^= HMCAFEJAPJK.GetHashCode();
      hash ^= rotaterData_.GetHashCode();
      if (CLHMAFCHJAF != false) hash ^= CLHMAFCHJAF.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (energyInfo_ != null) hash ^= EnergyInfo.GetHashCode();
      hash ^= chargerInfo_.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
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
      if (energyInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EnergyInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MapInfo);
      }
      if (CLHMAFCHJAF != false) {
        output.WriteRawTag(56);
        output.WriteBool(CLHMAFCHJAF);
      }
      if (HMCAFEJAPJK != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HMCAFEJAPJK);
      }
      chargerInfo_.WriteTo(output, _repeated_chargerInfo_codec);
      if (IICFOONOLAI != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(IICFOONOLAI);
      }
      rotaterData_.WriteTo(output, _repeated_rotaterData_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (energyInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EnergyInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MapInfo);
      }
      if (CLHMAFCHJAF != false) {
        output.WriteRawTag(56);
        output.WriteBool(CLHMAFCHJAF);
      }
      if (HMCAFEJAPJK != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HMCAFEJAPJK);
      }
      chargerInfo_.WriteTo(ref output, _repeated_chargerInfo_codec);
      if (IICFOONOLAI != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(IICFOONOLAI);
      }
      rotaterData_.WriteTo(ref output, _repeated_rotaterData_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IICFOONOLAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IICFOONOLAI);
      }
      if (HMCAFEJAPJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HMCAFEJAPJK);
      }
      size += rotaterData_.CalculateSize(_repeated_rotaterData_codec);
      if (CLHMAFCHJAF != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (energyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnergyInfo);
      }
      size += chargerInfo_.CalculateSize(_repeated_chargerInfo_codec);
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMapRotationDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IICFOONOLAI != 0) {
        IICFOONOLAI = other.IICFOONOLAI;
      }
      if (other.HMCAFEJAPJK != 0) {
        HMCAFEJAPJK = other.HMCAFEJAPJK;
      }
      rotaterData_.Add(other.rotaterData_);
      if (other.CLHMAFCHJAF != false) {
        CLHMAFCHJAF = other.CLHMAFCHJAF;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.energyInfo_ != null) {
        if (energyInfo_ == null) {
          EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
        }
        EnergyInfo.MergeFrom(other.EnergyInfo);
      }
      chargerInfo_.Add(other.chargerInfo_);
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.IJJHKDNFKMD();
        }
        MapInfo.MergeFrom(other.MapInfo);
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
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.IJJHKDNFKMD();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 56: {
            CLHMAFCHJAF = input.ReadBool();
            break;
          }
          case 80: {
            HMCAFEJAPJK = input.ReadUInt32();
            break;
          }
          case 90: {
            chargerInfo_.AddEntriesFrom(input, _repeated_chargerInfo_codec);
            break;
          }
          case 112: {
            IICFOONOLAI = input.ReadInt32();
            break;
          }
          case 122: {
            rotaterData_.AddEntriesFrom(input, _repeated_rotaterData_codec);
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
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.IJJHKDNFKMD();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 56: {
            CLHMAFCHJAF = input.ReadBool();
            break;
          }
          case 80: {
            HMCAFEJAPJK = input.ReadUInt32();
            break;
          }
          case 90: {
            chargerInfo_.AddEntriesFrom(ref input, _repeated_chargerInfo_codec);
            break;
          }
          case 112: {
            IICFOONOLAI = input.ReadInt32();
            break;
          }
          case 122: {
            rotaterData_.AddEntriesFrom(ref input, _repeated_rotaterData_codec);
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
