// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NGFPPDBIOKJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NGFPPDBIOKJ.proto</summary>
  public static partial class NGFPPDBIOKJReflection {

    #region Descriptor
    /// <summary>File descriptor for NGFPPDBIOKJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NGFPPDBIOKJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOR0ZQUERCSU9LSi5wcm90byI3CgtOR0ZQUERCSU9LShITCgtNT0xDREVL",
            "RUhBRhgNIAMoDRITCgtLQUFMS0VNTUZKQRgGIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NGFPPDBIOKJ), global::EggLink.DanhengServer.Proto.NGFPPDBIOKJ.Parser, new[]{ "MOLCDEKEHAF", "KAALKEMMFJA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NGFPPDBIOKJ : pb::IMessage<NGFPPDBIOKJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NGFPPDBIOKJ> _parser = new pb::MessageParser<NGFPPDBIOKJ>(() => new NGFPPDBIOKJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NGFPPDBIOKJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NGFPPDBIOKJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGFPPDBIOKJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGFPPDBIOKJ(NGFPPDBIOKJ other) : this() {
      mOLCDEKEHAF_ = other.mOLCDEKEHAF_.Clone();
      kAALKEMMFJA_ = other.kAALKEMMFJA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NGFPPDBIOKJ Clone() {
      return new NGFPPDBIOKJ(this);
    }

    /// <summary>Field number for the "MOLCDEKEHAF" field.</summary>
    public const int MOLCDEKEHAFFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_mOLCDEKEHAF_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> mOLCDEKEHAF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MOLCDEKEHAF {
      get { return mOLCDEKEHAF_; }
    }

    /// <summary>Field number for the "KAALKEMMFJA" field.</summary>
    public const int KAALKEMMFJAFieldNumber = 6;
    private uint kAALKEMMFJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAALKEMMFJA {
      get { return kAALKEMMFJA_; }
      set {
        kAALKEMMFJA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NGFPPDBIOKJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NGFPPDBIOKJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mOLCDEKEHAF_.Equals(other.mOLCDEKEHAF_)) return false;
      if (KAALKEMMFJA != other.KAALKEMMFJA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mOLCDEKEHAF_.GetHashCode();
      if (KAALKEMMFJA != 0) hash ^= KAALKEMMFJA.GetHashCode();
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
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KAALKEMMFJA);
      }
      mOLCDEKEHAF_.WriteTo(output, _repeated_mOLCDEKEHAF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (KAALKEMMFJA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(KAALKEMMFJA);
      }
      mOLCDEKEHAF_.WriteTo(ref output, _repeated_mOLCDEKEHAF_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += mOLCDEKEHAF_.CalculateSize(_repeated_mOLCDEKEHAF_codec);
      if (KAALKEMMFJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAALKEMMFJA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NGFPPDBIOKJ other) {
      if (other == null) {
        return;
      }
      mOLCDEKEHAF_.Add(other.mOLCDEKEHAF_);
      if (other.KAALKEMMFJA != 0) {
        KAALKEMMFJA = other.KAALKEMMFJA;
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
          case 48: {
            KAALKEMMFJA = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            mOLCDEKEHAF_.AddEntriesFrom(input, _repeated_mOLCDEKEHAF_codec);
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
          case 48: {
            KAALKEMMFJA = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            mOLCDEKEHAF_.AddEntriesFrom(ref input, _repeated_mOLCDEKEHAF_codec);
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
