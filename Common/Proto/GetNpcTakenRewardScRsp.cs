// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetNpcTakenRewardScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetNpcTakenRewardScRsp.proto</summary>
  public static partial class GetNpcTakenRewardScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetNpcTakenRewardScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetNpcTakenRewardScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXROcGNUYWtlblJld2FyZFNjUnNwLnByb3RvIk4KFkdldE5wY1Rha2Vu",
            "UmV3YXJkU2NSc3ASEwoLTlBCQU9DQUxQQUsYByADKA0SDgoGbnBjX2lkGAUg",
            "ASgNEg8KB3JldGNvZGUYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetNpcTakenRewardScRsp), global::EggLink.DanhengServer.Proto.GetNpcTakenRewardScRsp.Parser, new[]{ "NPBAOCALPAK", "NpcId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetNpcTakenRewardScRsp : pb::IMessage<GetNpcTakenRewardScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetNpcTakenRewardScRsp> _parser = new pb::MessageParser<GetNpcTakenRewardScRsp>(() => new GetNpcTakenRewardScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetNpcTakenRewardScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetNpcTakenRewardScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNpcTakenRewardScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNpcTakenRewardScRsp(GetNpcTakenRewardScRsp other) : this() {
      nPBAOCALPAK_ = other.nPBAOCALPAK_.Clone();
      npcId_ = other.npcId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNpcTakenRewardScRsp Clone() {
      return new GetNpcTakenRewardScRsp(this);
    }

    /// <summary>Field number for the "NPBAOCALPAK" field.</summary>
    public const int NPBAOCALPAKFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_nPBAOCALPAK_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> nPBAOCALPAK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NPBAOCALPAK {
      get { return nPBAOCALPAK_; }
    }

    /// <summary>Field number for the "npc_id" field.</summary>
    public const int NpcIdFieldNumber = 5;
    private uint npcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NpcId {
      get { return npcId_; }
      set {
        npcId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetNpcTakenRewardScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetNpcTakenRewardScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!nPBAOCALPAK_.Equals(other.nPBAOCALPAK_)) return false;
      if (NpcId != other.NpcId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= nPBAOCALPAK_.GetHashCode();
      if (NpcId != 0) hash ^= NpcId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (NpcId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NpcId);
      }
      nPBAOCALPAK_.WriteTo(output, _repeated_nPBAOCALPAK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (NpcId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NpcId);
      }
      nPBAOCALPAK_.WriteTo(ref output, _repeated_nPBAOCALPAK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      size += nPBAOCALPAK_.CalculateSize(_repeated_nPBAOCALPAK_codec);
      if (NpcId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NpcId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetNpcTakenRewardScRsp other) {
      if (other == null) {
        return;
      }
      nPBAOCALPAK_.Add(other.nPBAOCALPAK_);
      if (other.NpcId != 0) {
        NpcId = other.NpcId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            NpcId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            nPBAOCALPAK_.AddEntriesFrom(input, _repeated_nPBAOCALPAK_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
            NpcId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            nPBAOCALPAK_.AddEntriesFrom(ref input, _repeated_nPBAOCALPAK_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
