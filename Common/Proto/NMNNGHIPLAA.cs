// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NMNNGHIPLAA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NMNNGHIPLAA.proto</summary>
  public static partial class NMNNGHIPLAAReflection {

    #region Descriptor
    /// <summary>File descriptor for NMNNGHIPLAA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NMNNGHIPLAAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOTU5OR0hJUExBQS5wcm90byJICgtOTU5OR0hJUExBQRITCgtEUEFNTElP",
            "RVBPSxgLIAEoDRITCgtJQUlESk1GTE9EQhgGIAMoDRIPCgdjb25maXJtGAUg",
            "ASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NMNNGHIPLAA), global::EggLink.DanhengServer.Proto.NMNNGHIPLAA.Parser, new[]{ "DPAMLIOEPOK", "IAIDJMFLODB", "Confirm" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NMNNGHIPLAA : pb::IMessage<NMNNGHIPLAA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NMNNGHIPLAA> _parser = new pb::MessageParser<NMNNGHIPLAA>(() => new NMNNGHIPLAA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NMNNGHIPLAA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NMNNGHIPLAAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NMNNGHIPLAA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NMNNGHIPLAA(NMNNGHIPLAA other) : this() {
      dPAMLIOEPOK_ = other.dPAMLIOEPOK_;
      iAIDJMFLODB_ = other.iAIDJMFLODB_.Clone();
      confirm_ = other.confirm_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NMNNGHIPLAA Clone() {
      return new NMNNGHIPLAA(this);
    }

    /// <summary>Field number for the "DPAMLIOEPOK" field.</summary>
    public const int DPAMLIOEPOKFieldNumber = 11;
    private uint dPAMLIOEPOK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DPAMLIOEPOK {
      get { return dPAMLIOEPOK_; }
      set {
        dPAMLIOEPOK_ = value;
      }
    }

    /// <summary>Field number for the "IAIDJMFLODB" field.</summary>
    public const int IAIDJMFLODBFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_iAIDJMFLODB_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> iAIDJMFLODB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IAIDJMFLODB {
      get { return iAIDJMFLODB_; }
    }

    /// <summary>Field number for the "confirm" field.</summary>
    public const int ConfirmFieldNumber = 5;
    private bool confirm_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Confirm {
      get { return confirm_; }
      set {
        confirm_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NMNNGHIPLAA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NMNNGHIPLAA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DPAMLIOEPOK != other.DPAMLIOEPOK) return false;
      if(!iAIDJMFLODB_.Equals(other.iAIDJMFLODB_)) return false;
      if (Confirm != other.Confirm) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DPAMLIOEPOK != 0) hash ^= DPAMLIOEPOK.GetHashCode();
      hash ^= iAIDJMFLODB_.GetHashCode();
      if (Confirm != false) hash ^= Confirm.GetHashCode();
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
      if (Confirm != false) {
        output.WriteRawTag(40);
        output.WriteBool(Confirm);
      }
      iAIDJMFLODB_.WriteTo(output, _repeated_iAIDJMFLODB_codec);
      if (DPAMLIOEPOK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DPAMLIOEPOK);
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
      if (Confirm != false) {
        output.WriteRawTag(40);
        output.WriteBool(Confirm);
      }
      iAIDJMFLODB_.WriteTo(ref output, _repeated_iAIDJMFLODB_codec);
      if (DPAMLIOEPOK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DPAMLIOEPOK);
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
      if (DPAMLIOEPOK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DPAMLIOEPOK);
      }
      size += iAIDJMFLODB_.CalculateSize(_repeated_iAIDJMFLODB_codec);
      if (Confirm != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NMNNGHIPLAA other) {
      if (other == null) {
        return;
      }
      if (other.DPAMLIOEPOK != 0) {
        DPAMLIOEPOK = other.DPAMLIOEPOK;
      }
      iAIDJMFLODB_.Add(other.iAIDJMFLODB_);
      if (other.Confirm != false) {
        Confirm = other.Confirm;
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
            Confirm = input.ReadBool();
            break;
          }
          case 50:
          case 48: {
            iAIDJMFLODB_.AddEntriesFrom(input, _repeated_iAIDJMFLODB_codec);
            break;
          }
          case 88: {
            DPAMLIOEPOK = input.ReadUInt32();
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
            Confirm = input.ReadBool();
            break;
          }
          case 50:
          case 48: {
            iAIDJMFLODB_.AddEntriesFrom(ref input, _repeated_iAIDJMFLODB_codec);
            break;
          }
          case 88: {
            DPAMLIOEPOK = input.ReadUInt32();
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
