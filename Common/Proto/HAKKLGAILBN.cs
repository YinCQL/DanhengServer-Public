// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HAKKLGAILBN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HAKKLGAILBN.proto</summary>
  public static partial class HAKKLGAILBNReflection {

    #region Descriptor
    /// <summary>File descriptor for HAKKLGAILBN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HAKKLGAILBNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQUtLTEdBSUxCTi5wcm90byI3CgtIQUtLTEdBSUxCThITCgtLQUFMS0VN",
            "TUZKQRgKIAEoDRITCgtLUERBSUhISE9ETBgJIAMoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HAKKLGAILBN), global::EggLink.DanhengServer.Proto.HAKKLGAILBN.Parser, new[]{ "KAALKEMMFJA", "KPDAIHHHODL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HAKKLGAILBN : pb::IMessage<HAKKLGAILBN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HAKKLGAILBN> _parser = new pb::MessageParser<HAKKLGAILBN>(() => new HAKKLGAILBN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HAKKLGAILBN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HAKKLGAILBNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAKKLGAILBN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAKKLGAILBN(HAKKLGAILBN other) : this() {
      kAALKEMMFJA_ = other.kAALKEMMFJA_;
      kPDAIHHHODL_ = other.kPDAIHHHODL_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAKKLGAILBN Clone() {
      return new HAKKLGAILBN(this);
    }

    /// <summary>Field number for the "KAALKEMMFJA" field.</summary>
    public const int KAALKEMMFJAFieldNumber = 10;
    private uint kAALKEMMFJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAALKEMMFJA {
      get { return kAALKEMMFJA_; }
      set {
        kAALKEMMFJA_ = value;
      }
    }

    /// <summary>Field number for the "KPDAIHHHODL" field.</summary>
    public const int KPDAIHHHODLFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_kPDAIHHHODL_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> kPDAIHHHODL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KPDAIHHHODL {
      get { return kPDAIHHHODL_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HAKKLGAILBN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HAKKLGAILBN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KAALKEMMFJA != other.KAALKEMMFJA) return false;
      if(!kPDAIHHHODL_.Equals(other.kPDAIHHHODL_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KAALKEMMFJA != 0) hash ^= KAALKEMMFJA.GetHashCode();
      hash ^= kPDAIHHHODL_.GetHashCode();
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
      kPDAIHHHODL_.WriteTo(output, _repeated_kPDAIHHHODL_codec);
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(80);
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
      kPDAIHHHODL_.WriteTo(ref output, _repeated_kPDAIHHHODL_codec);
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(80);
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
      size += kPDAIHHHODL_.CalculateSize(_repeated_kPDAIHHHODL_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HAKKLGAILBN other) {
      if (other == null) {
        return;
      }
      if (other.KAALKEMMFJA != 0) {
        KAALKEMMFJA = other.KAALKEMMFJA;
      }
      kPDAIHHHODL_.Add(other.kPDAIHHHODL_);
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
          case 74:
          case 72: {
            kPDAIHHHODL_.AddEntriesFrom(input, _repeated_kPDAIHHHODL_codec);
            break;
          }
          case 80: {
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
          case 74:
          case 72: {
            kPDAIHHHODL_.AddEntriesFrom(ref input, _repeated_kPDAIHHHODL_codec);
            break;
          }
          case 80: {
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
