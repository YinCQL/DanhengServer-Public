// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PJFEGMHPDPO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PJFEGMHPDPO.proto</summary>
  public static partial class PJFEGMHPDPOReflection {

    #region Descriptor
    /// <summary>File descriptor for PJFEGMHPDPO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PJFEGMHPDPOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQSkZFR01IUERQTy5wcm90bxoVUm9ndWVDb21tb25CdWZmLnByb3RvIkkK",
            "C1BKRkVHTUhQRFBPEhMKC0tBQUxLRU1NRkpBGAwgASgNEiUKC0xITEpPQkpK",
            "S0ZHGAogAygLMhAuUm9ndWVDb21tb25CdWZmQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PJFEGMHPDPO), global::EggLink.DanhengServer.Proto.PJFEGMHPDPO.Parser, new[]{ "KAALKEMMFJA", "LHLJOBJJKFG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PJFEGMHPDPO : pb::IMessage<PJFEGMHPDPO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PJFEGMHPDPO> _parser = new pb::MessageParser<PJFEGMHPDPO>(() => new PJFEGMHPDPO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PJFEGMHPDPO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PJFEGMHPDPOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PJFEGMHPDPO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PJFEGMHPDPO(PJFEGMHPDPO other) : this() {
      kAALKEMMFJA_ = other.kAALKEMMFJA_;
      lHLJOBJJKFG_ = other.lHLJOBJJKFG_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PJFEGMHPDPO Clone() {
      return new PJFEGMHPDPO(this);
    }

    /// <summary>Field number for the "KAALKEMMFJA" field.</summary>
    public const int KAALKEMMFJAFieldNumber = 12;
    private uint kAALKEMMFJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAALKEMMFJA {
      get { return kAALKEMMFJA_; }
      set {
        kAALKEMMFJA_ = value;
      }
    }

    /// <summary>Field number for the "LHLJOBJJKFG" field.</summary>
    public const int LHLJOBJJKFGFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonBuff> _repeated_lHLJOBJJKFG_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.RogueCommonBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> lHLJOBJJKFG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> LHLJOBJJKFG {
      get { return lHLJOBJJKFG_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PJFEGMHPDPO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PJFEGMHPDPO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KAALKEMMFJA != other.KAALKEMMFJA) return false;
      if(!lHLJOBJJKFG_.Equals(other.lHLJOBJJKFG_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KAALKEMMFJA != 0) hash ^= KAALKEMMFJA.GetHashCode();
      hash ^= lHLJOBJJKFG_.GetHashCode();
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
      lHLJOBJJKFG_.WriteTo(output, _repeated_lHLJOBJJKFG_codec);
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KAALKEMMFJA);
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
      lHLJOBJJKFG_.WriteTo(ref output, _repeated_lHLJOBJJKFG_codec);
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KAALKEMMFJA);
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
      if (KAALKEMMFJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAALKEMMFJA);
      }
      size += lHLJOBJJKFG_.CalculateSize(_repeated_lHLJOBJJKFG_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PJFEGMHPDPO other) {
      if (other == null) {
        return;
      }
      if (other.KAALKEMMFJA != 0) {
        KAALKEMMFJA = other.KAALKEMMFJA;
      }
      lHLJOBJJKFG_.Add(other.lHLJOBJJKFG_);
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
          case 82: {
            lHLJOBJJKFG_.AddEntriesFrom(input, _repeated_lHLJOBJJKFG_codec);
            break;
          }
          case 96: {
            KAALKEMMFJA = input.ReadUInt32();
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
          case 82: {
            lHLJOBJJKFG_.AddEntriesFrom(ref input, _repeated_lHLJOBJJKFG_codec);
            break;
          }
          case 96: {
            KAALKEMMFJA = input.ReadUInt32();
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