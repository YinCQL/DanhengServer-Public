// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournDoorInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournDoorInfo.proto</summary>
  public static partial class RogueTournDoorInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournDoorInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournDoorInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZVRvdXJuRG9vckluZm8ucHJvdG8iXQoSUm9ndWVUb3VybkRvb3JJ",
            "bmZvEhMKC0JOTEtNQ0xKRkJQGAogASgNEhMKC0tET0xOTkFLTEtMGAYgASgI",
            "Eh0KFXJvZ3VlX3RvdXJuX3Jvb21fdHlwZRgFIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournDoorInfo), global::EggLink.DanhengServer.Proto.RogueTournDoorInfo.Parser, new[]{ "BNLKMCLJFBP", "KDOLNNAKLKL", "RogueTournRoomType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournDoorInfo : pb::IMessage<RogueTournDoorInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournDoorInfo> _parser = new pb::MessageParser<RogueTournDoorInfo>(() => new RogueTournDoorInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournDoorInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournDoorInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournDoorInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournDoorInfo(RogueTournDoorInfo other) : this() {
      bNLKMCLJFBP_ = other.bNLKMCLJFBP_;
      kDOLNNAKLKL_ = other.kDOLNNAKLKL_;
      rogueTournRoomType_ = other.rogueTournRoomType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournDoorInfo Clone() {
      return new RogueTournDoorInfo(this);
    }

    /// <summary>Field number for the "BNLKMCLJFBP" field.</summary>
    public const int BNLKMCLJFBPFieldNumber = 10;
    private uint bNLKMCLJFBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BNLKMCLJFBP {
      get { return bNLKMCLJFBP_; }
      set {
        bNLKMCLJFBP_ = value;
      }
    }

    /// <summary>Field number for the "KDOLNNAKLKL" field.</summary>
    public const int KDOLNNAKLKLFieldNumber = 6;
    private bool kDOLNNAKLKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KDOLNNAKLKL {
      get { return kDOLNNAKLKL_; }
      set {
        kDOLNNAKLKL_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_room_type" field.</summary>
    public const int RogueTournRoomTypeFieldNumber = 5;
    private uint rogueTournRoomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueTournRoomType {
      get { return rogueTournRoomType_; }
      set {
        rogueTournRoomType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournDoorInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournDoorInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BNLKMCLJFBP != other.BNLKMCLJFBP) return false;
      if (KDOLNNAKLKL != other.KDOLNNAKLKL) return false;
      if (RogueTournRoomType != other.RogueTournRoomType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BNLKMCLJFBP != 0) hash ^= BNLKMCLJFBP.GetHashCode();
      if (KDOLNNAKLKL != false) hash ^= KDOLNNAKLKL.GetHashCode();
      if (RogueTournRoomType != 0) hash ^= RogueTournRoomType.GetHashCode();
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
      if (RogueTournRoomType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RogueTournRoomType);
      }
      if (KDOLNNAKLKL != false) {
        output.WriteRawTag(48);
        output.WriteBool(KDOLNNAKLKL);
      }
      if (BNLKMCLJFBP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BNLKMCLJFBP);
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
      if (RogueTournRoomType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RogueTournRoomType);
      }
      if (KDOLNNAKLKL != false) {
        output.WriteRawTag(48);
        output.WriteBool(KDOLNNAKLKL);
      }
      if (BNLKMCLJFBP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BNLKMCLJFBP);
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
      if (BNLKMCLJFBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BNLKMCLJFBP);
      }
      if (KDOLNNAKLKL != false) {
        size += 1 + 1;
      }
      if (RogueTournRoomType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueTournRoomType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournDoorInfo other) {
      if (other == null) {
        return;
      }
      if (other.BNLKMCLJFBP != 0) {
        BNLKMCLJFBP = other.BNLKMCLJFBP;
      }
      if (other.KDOLNNAKLKL != false) {
        KDOLNNAKLKL = other.KDOLNNAKLKL;
      }
      if (other.RogueTournRoomType != 0) {
        RogueTournRoomType = other.RogueTournRoomType;
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
            RogueTournRoomType = input.ReadUInt32();
            break;
          }
          case 48: {
            KDOLNNAKLKL = input.ReadBool();
            break;
          }
          case 80: {
            BNLKMCLJFBP = input.ReadUInt32();
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
            RogueTournRoomType = input.ReadUInt32();
            break;
          }
          case 48: {
            KDOLNNAKLKL = input.ReadBool();
            break;
          }
          case 80: {
            BNLKMCLJFBP = input.ReadUInt32();
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