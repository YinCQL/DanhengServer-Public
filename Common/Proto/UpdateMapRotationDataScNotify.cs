// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdateMapRotationDataScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdateMapRotationDataScNotify.proto</summary>
  public static partial class UpdateMapRotationDataScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateMapRotationDataScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateMapRotationDataScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVcGRhdGVNYXBSb3RhdGlvbkRhdGFTY05vdGlmeS5wcm90bxoRUm90YXRl",
            "ckRhdGEucHJvdG8aEUNoYXJnZXJJbmZvLnByb3RvGhdSb3RhdG9yRW5lcmd5",
            "SW5mby5wcm90bxoRSUpKSEtETkZLTUQucHJvdG8i7wEKHVVwZGF0ZU1hcFJv",
            "dGF0aW9uRGF0YVNjTm90aWZ5EiIKDHJvdGF0ZXJfZGF0YRgBIAMoCzIMLlJv",
            "dGF0ZXJEYXRhEhMKC0lJQ0ZPT05PTEFJGAogASgFEiIKDGNoYXJnZXJfaW5m",
            "bxgHIAMoCzIMLkNoYXJnZXJJbmZvEhMKC0NMSE1BRkNISkFGGAQgASgIEicK",
            "C2VuZXJneV9pbmZvGAYgASgLMhIuUm90YXRvckVuZXJneUluZm8SHgoIbWFw",
            "X2luZm8YAyABKAsyDC5JSkpIS0RORktNRBITCgtITUNBRkVKQVBKSxgPIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RotaterDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChargerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotatorEnergyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.IJJHKDNFKMDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdateMapRotationDataScNotify), global::EggLink.DanhengServer.Proto.UpdateMapRotationDataScNotify.Parser, new[]{ "RotaterData", "IICFOONOLAI", "ChargerInfo", "CLHMAFCHJAF", "EnergyInfo", "MapInfo", "HMCAFEJAPJK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdateMapRotationDataScNotify : pb::IMessage<UpdateMapRotationDataScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateMapRotationDataScNotify> _parser = new pb::MessageParser<UpdateMapRotationDataScNotify>(() => new UpdateMapRotationDataScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateMapRotationDataScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdateMapRotationDataScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMapRotationDataScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMapRotationDataScNotify(UpdateMapRotationDataScNotify other) : this() {
      rotaterData_ = other.rotaterData_.Clone();
      iICFOONOLAI_ = other.iICFOONOLAI_;
      chargerInfo_ = other.chargerInfo_.Clone();
      cLHMAFCHJAF_ = other.cLHMAFCHJAF_;
      energyInfo_ = other.energyInfo_ != null ? other.energyInfo_.Clone() : null;
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      hMCAFEJAPJK_ = other.hMCAFEJAPJK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMapRotationDataScNotify Clone() {
      return new UpdateMapRotationDataScNotify(this);
    }

    /// <summary>Field number for the "rotater_data" field.</summary>
    public const int RotaterDataFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RotaterData> _repeated_rotaterData_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.RotaterData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> rotaterData_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> RotaterData {
      get { return rotaterData_; }
    }

    /// <summary>Field number for the "IICFOONOLAI" field.</summary>
    public const int IICFOONOLAIFieldNumber = 10;
    private int iICFOONOLAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IICFOONOLAI {
      get { return iICFOONOLAI_; }
      set {
        iICFOONOLAI_ = value;
      }
    }

    /// <summary>Field number for the "charger_info" field.</summary>
    public const int ChargerInfoFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChargerInfo> _repeated_chargerInfo_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.ChargerInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> chargerInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> ChargerInfo {
      get { return chargerInfo_; }
    }

    /// <summary>Field number for the "CLHMAFCHJAF" field.</summary>
    public const int CLHMAFCHJAFFieldNumber = 4;
    private bool cLHMAFCHJAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CLHMAFCHJAF {
      get { return cLHMAFCHJAF_; }
      set {
        cLHMAFCHJAF_ = value;
      }
    }

    /// <summary>Field number for the "energy_info" field.</summary>
    public const int EnergyInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RotatorEnergyInfo energyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotatorEnergyInfo EnergyInfo {
      get { return energyInfo_; }
      set {
        energyInfo_ = value;
      }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.IJJHKDNFKMD mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IJJHKDNFKMD MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "HMCAFEJAPJK" field.</summary>
    public const int HMCAFEJAPJKFieldNumber = 15;
    private uint hMCAFEJAPJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HMCAFEJAPJK {
      get { return hMCAFEJAPJK_; }
      set {
        hMCAFEJAPJK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateMapRotationDataScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateMapRotationDataScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rotaterData_.Equals(other.rotaterData_)) return false;
      if (IICFOONOLAI != other.IICFOONOLAI) return false;
      if(!chargerInfo_.Equals(other.chargerInfo_)) return false;
      if (CLHMAFCHJAF != other.CLHMAFCHJAF) return false;
      if (!object.Equals(EnergyInfo, other.EnergyInfo)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (HMCAFEJAPJK != other.HMCAFEJAPJK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rotaterData_.GetHashCode();
      if (IICFOONOLAI != 0) hash ^= IICFOONOLAI.GetHashCode();
      hash ^= chargerInfo_.GetHashCode();
      if (CLHMAFCHJAF != false) hash ^= CLHMAFCHJAF.GetHashCode();
      if (energyInfo_ != null) hash ^= EnergyInfo.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (HMCAFEJAPJK != 0) hash ^= HMCAFEJAPJK.GetHashCode();
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
      rotaterData_.WriteTo(output, _repeated_rotaterData_codec);
      if (mapInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MapInfo);
      }
      if (CLHMAFCHJAF != false) {
        output.WriteRawTag(32);
        output.WriteBool(CLHMAFCHJAF);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EnergyInfo);
      }
      chargerInfo_.WriteTo(output, _repeated_chargerInfo_codec);
      if (IICFOONOLAI != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(IICFOONOLAI);
      }
      if (HMCAFEJAPJK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HMCAFEJAPJK);
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
      rotaterData_.WriteTo(ref output, _repeated_rotaterData_codec);
      if (mapInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MapInfo);
      }
      if (CLHMAFCHJAF != false) {
        output.WriteRawTag(32);
        output.WriteBool(CLHMAFCHJAF);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EnergyInfo);
      }
      chargerInfo_.WriteTo(ref output, _repeated_chargerInfo_codec);
      if (IICFOONOLAI != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(IICFOONOLAI);
      }
      if (HMCAFEJAPJK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HMCAFEJAPJK);
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
      size += rotaterData_.CalculateSize(_repeated_rotaterData_codec);
      if (IICFOONOLAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IICFOONOLAI);
      }
      size += chargerInfo_.CalculateSize(_repeated_chargerInfo_codec);
      if (CLHMAFCHJAF != false) {
        size += 1 + 1;
      }
      if (energyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnergyInfo);
      }
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (HMCAFEJAPJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HMCAFEJAPJK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateMapRotationDataScNotify other) {
      if (other == null) {
        return;
      }
      rotaterData_.Add(other.rotaterData_);
      if (other.IICFOONOLAI != 0) {
        IICFOONOLAI = other.IICFOONOLAI;
      }
      chargerInfo_.Add(other.chargerInfo_);
      if (other.CLHMAFCHJAF != false) {
        CLHMAFCHJAF = other.CLHMAFCHJAF;
      }
      if (other.energyInfo_ != null) {
        if (energyInfo_ == null) {
          EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
        }
        EnergyInfo.MergeFrom(other.EnergyInfo);
      }
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.IJJHKDNFKMD();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.HMCAFEJAPJK != 0) {
        HMCAFEJAPJK = other.HMCAFEJAPJK;
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
            rotaterData_.AddEntriesFrom(input, _repeated_rotaterData_codec);
            break;
          }
          case 26: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.IJJHKDNFKMD();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 32: {
            CLHMAFCHJAF = input.ReadBool();
            break;
          }
          case 50: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 58: {
            chargerInfo_.AddEntriesFrom(input, _repeated_chargerInfo_codec);
            break;
          }
          case 80: {
            IICFOONOLAI = input.ReadInt32();
            break;
          }
          case 120: {
            HMCAFEJAPJK = input.ReadUInt32();
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
            rotaterData_.AddEntriesFrom(ref input, _repeated_rotaterData_codec);
            break;
          }
          case 26: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.IJJHKDNFKMD();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 32: {
            CLHMAFCHJAF = input.ReadBool();
            break;
          }
          case 50: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 58: {
            chargerInfo_.AddEntriesFrom(ref input, _repeated_chargerInfo_codec);
            break;
          }
          case 80: {
            IICFOONOLAI = input.ReadInt32();
            break;
          }
          case 120: {
            HMCAFEJAPJK = input.ReadUInt32();
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
