// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueHandbook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueHandbook.proto</summary>
  public static partial class RogueHandbookReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueHandbook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueHandbookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNSb2d1ZUhhbmRib29rLnByb3RvGhFKQU9QQktBRE5OTC5wcm90bxoRSUZK",
            "UExMTURIUEwucHJvdG8aEUVEUEhMSU5BQ05KLnByb3RvGhFFR05DSkpKT0xK",
            "QS5wcm90byKaAQoNUm9ndWVIYW5kYm9vaxIhCgtCQkhJUFBGTUtJTBgMIAMo",
            "CzIMLkpBT1BCS0FETk5MEh8KCWJ1ZmZfbGlzdBgKIAMoCzIMLklGSlBMTE1E",
            "SFBMEiEKC0lGSU9KSERGSUhJGA8gAygLMgwuRURQSExJTkFDTkoSIgoMbWly",
            "YWNsZV9saXN0GAggAygLMgwuRUdOQ0pKSk9MSkFCHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.JAOPBKADNNLReflection.Descriptor, global::EggLink.DanhengServer.Proto.IFJPLLMDHPLReflection.Descriptor, global::EggLink.DanhengServer.Proto.EDPHLINACNJReflection.Descriptor, global::EggLink.DanhengServer.Proto.EGNCJJJOLJAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueHandbook), global::EggLink.DanhengServer.Proto.RogueHandbook.Parser, new[]{ "BBHIPPFMKIL", "BuffList", "IFIOJHDFIHI", "MiracleList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueHandbook : pb::IMessage<RogueHandbook>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueHandbook> _parser = new pb::MessageParser<RogueHandbook>(() => new RogueHandbook());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueHandbook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueHandbookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueHandbook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueHandbook(RogueHandbook other) : this() {
      bBHIPPFMKIL_ = other.bBHIPPFMKIL_.Clone();
      buffList_ = other.buffList_.Clone();
      iFIOJHDFIHI_ = other.iFIOJHDFIHI_.Clone();
      miracleList_ = other.miracleList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueHandbook Clone() {
      return new RogueHandbook(this);
    }

    /// <summary>Field number for the "BBHIPPFMKIL" field.</summary>
    public const int BBHIPPFMKILFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.JAOPBKADNNL> _repeated_bBHIPPFMKIL_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.JAOPBKADNNL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JAOPBKADNNL> bBHIPPFMKIL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JAOPBKADNNL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.JAOPBKADNNL> BBHIPPFMKIL {
      get { return bBHIPPFMKIL_; }
    }

    /// <summary>Field number for the "buff_list" field.</summary>
    public const int BuffListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL> _repeated_buffList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.IFJPLLMDHPL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL> buffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IFJPLLMDHPL> BuffList {
      get { return buffList_; }
    }

    /// <summary>Field number for the "IFIOJHDFIHI" field.</summary>
    public const int IFIOJHDFIHIFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EDPHLINACNJ> _repeated_iFIOJHDFIHI_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.EDPHLINACNJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EDPHLINACNJ> iFIOJHDFIHI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EDPHLINACNJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EDPHLINACNJ> IFIOJHDFIHI {
      get { return iFIOJHDFIHI_; }
    }

    /// <summary>Field number for the "miracle_list" field.</summary>
    public const int MiracleListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA> _repeated_miracleList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.EGNCJJJOLJA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA> miracleList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EGNCJJJOLJA> MiracleList {
      get { return miracleList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueHandbook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueHandbook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bBHIPPFMKIL_.Equals(other.bBHIPPFMKIL_)) return false;
      if(!buffList_.Equals(other.buffList_)) return false;
      if(!iFIOJHDFIHI_.Equals(other.iFIOJHDFIHI_)) return false;
      if(!miracleList_.Equals(other.miracleList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bBHIPPFMKIL_.GetHashCode();
      hash ^= buffList_.GetHashCode();
      hash ^= iFIOJHDFIHI_.GetHashCode();
      hash ^= miracleList_.GetHashCode();
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
      miracleList_.WriteTo(output, _repeated_miracleList_codec);
      buffList_.WriteTo(output, _repeated_buffList_codec);
      bBHIPPFMKIL_.WriteTo(output, _repeated_bBHIPPFMKIL_codec);
      iFIOJHDFIHI_.WriteTo(output, _repeated_iFIOJHDFIHI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      miracleList_.WriteTo(ref output, _repeated_miracleList_codec);
      buffList_.WriteTo(ref output, _repeated_buffList_codec);
      bBHIPPFMKIL_.WriteTo(ref output, _repeated_bBHIPPFMKIL_codec);
      iFIOJHDFIHI_.WriteTo(ref output, _repeated_iFIOJHDFIHI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += bBHIPPFMKIL_.CalculateSize(_repeated_bBHIPPFMKIL_codec);
      size += buffList_.CalculateSize(_repeated_buffList_codec);
      size += iFIOJHDFIHI_.CalculateSize(_repeated_iFIOJHDFIHI_codec);
      size += miracleList_.CalculateSize(_repeated_miracleList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueHandbook other) {
      if (other == null) {
        return;
      }
      bBHIPPFMKIL_.Add(other.bBHIPPFMKIL_);
      buffList_.Add(other.buffList_);
      iFIOJHDFIHI_.Add(other.iFIOJHDFIHI_);
      miracleList_.Add(other.miracleList_);
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
            miracleList_.AddEntriesFrom(input, _repeated_miracleList_codec);
            break;
          }
          case 82: {
            buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
            break;
          }
          case 98: {
            bBHIPPFMKIL_.AddEntriesFrom(input, _repeated_bBHIPPFMKIL_codec);
            break;
          }
          case 122: {
            iFIOJHDFIHI_.AddEntriesFrom(input, _repeated_iFIOJHDFIHI_codec);
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
            miracleList_.AddEntriesFrom(ref input, _repeated_miracleList_codec);
            break;
          }
          case 82: {
            buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
            break;
          }
          case 98: {
            bBHIPPFMKIL_.AddEntriesFrom(ref input, _repeated_bBHIPPFMKIL_codec);
            break;
          }
          case 122: {
            iFIOJHDFIHI_.AddEntriesFrom(ref input, _repeated_iFIOJHDFIHI_codec);
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
