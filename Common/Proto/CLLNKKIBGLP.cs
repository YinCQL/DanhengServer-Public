// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CLLNKKIBGLP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CLLNKKIBGLP.proto</summary>
  public static partial class CLLNKKIBGLPReflection {

    #region Descriptor
    /// <summary>File descriptor for CLLNKKIBGLP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CLLNKKIBGLPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDTExOS0tJQkdMUC5wcm90byI3CgtDTExOS0tJQkdMUBITCgtERUJITUJQ",
            "Q0FMRBgEIAEoDRITCgtLQkZMRkRQRktDQhgBIAMoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CLLNKKIBGLP), global::EggLink.DanhengServer.Proto.CLLNKKIBGLP.Parser, new[]{ "DEBHMBPCALD", "KBFLFDPFKCB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CLLNKKIBGLP : pb::IMessage<CLLNKKIBGLP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CLLNKKIBGLP> _parser = new pb::MessageParser<CLLNKKIBGLP>(() => new CLLNKKIBGLP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CLLNKKIBGLP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CLLNKKIBGLPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLLNKKIBGLP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLLNKKIBGLP(CLLNKKIBGLP other) : this() {
      dEBHMBPCALD_ = other.dEBHMBPCALD_;
      kBFLFDPFKCB_ = other.kBFLFDPFKCB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLLNKKIBGLP Clone() {
      return new CLLNKKIBGLP(this);
    }

    /// <summary>Field number for the "DEBHMBPCALD" field.</summary>
    public const int DEBHMBPCALDFieldNumber = 4;
    private uint dEBHMBPCALD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DEBHMBPCALD {
      get { return dEBHMBPCALD_; }
      set {
        dEBHMBPCALD_ = value;
      }
    }

    /// <summary>Field number for the "KBFLFDPFKCB" field.</summary>
    public const int KBFLFDPFKCBFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_kBFLFDPFKCB_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> kBFLFDPFKCB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KBFLFDPFKCB {
      get { return kBFLFDPFKCB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CLLNKKIBGLP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CLLNKKIBGLP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DEBHMBPCALD != other.DEBHMBPCALD) return false;
      if(!kBFLFDPFKCB_.Equals(other.kBFLFDPFKCB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DEBHMBPCALD != 0) hash ^= DEBHMBPCALD.GetHashCode();
      hash ^= kBFLFDPFKCB_.GetHashCode();
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
      kBFLFDPFKCB_.WriteTo(output, _repeated_kBFLFDPFKCB_codec);
      if (DEBHMBPCALD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DEBHMBPCALD);
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
      kBFLFDPFKCB_.WriteTo(ref output, _repeated_kBFLFDPFKCB_codec);
      if (DEBHMBPCALD != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DEBHMBPCALD);
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
      if (DEBHMBPCALD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DEBHMBPCALD);
      }
      size += kBFLFDPFKCB_.CalculateSize(_repeated_kBFLFDPFKCB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CLLNKKIBGLP other) {
      if (other == null) {
        return;
      }
      if (other.DEBHMBPCALD != 0) {
        DEBHMBPCALD = other.DEBHMBPCALD;
      }
      kBFLFDPFKCB_.Add(other.kBFLFDPFKCB_);
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
          case 10:
          case 8: {
            kBFLFDPFKCB_.AddEntriesFrom(input, _repeated_kBFLFDPFKCB_codec);
            break;
          }
          case 32: {
            DEBHMBPCALD = input.ReadUInt32();
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
          case 10:
          case 8: {
            kBFLFDPFKCB_.AddEntriesFrom(ref input, _repeated_kBFLFDPFKCB_codec);
            break;
          }
          case 32: {
            DEBHMBPCALD = input.ReadUInt32();
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
