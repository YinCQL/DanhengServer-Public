// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BGFMMOEHJCE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BGFMMOEHJCE.proto</summary>
  public static partial class BGFMMOEHJCEReflection {

    #region Descriptor
    /// <summary>File descriptor for BGFMMOEHJCE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BGFMMOEHJCEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCR0ZNTU9FSEpDRS5wcm90byJFCgtCR0ZNTU9FSEpDRRITCgtBTUxJQ0tN",
            "QUhCUBgCIAEoDRIMCgR0eXBlGAogASgNEhMKC0lBSEhOS0JJT0pBGAsgASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BGFMMOEHJCE), global::EggLink.DanhengServer.Proto.BGFMMOEHJCE.Parser, new[]{ "AMLICKMAHBP", "Type", "IAHHNKBIOJA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BGFMMOEHJCE : pb::IMessage<BGFMMOEHJCE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BGFMMOEHJCE> _parser = new pb::MessageParser<BGFMMOEHJCE>(() => new BGFMMOEHJCE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BGFMMOEHJCE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BGFMMOEHJCEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BGFMMOEHJCE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BGFMMOEHJCE(BGFMMOEHJCE other) : this() {
      aMLICKMAHBP_ = other.aMLICKMAHBP_;
      type_ = other.type_;
      iAHHNKBIOJA_ = other.iAHHNKBIOJA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BGFMMOEHJCE Clone() {
      return new BGFMMOEHJCE(this);
    }

    /// <summary>Field number for the "AMLICKMAHBP" field.</summary>
    public const int AMLICKMAHBPFieldNumber = 2;
    private uint aMLICKMAHBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AMLICKMAHBP {
      get { return aMLICKMAHBP_; }
      set {
        aMLICKMAHBP_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 10;
    private uint type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "IAHHNKBIOJA" field.</summary>
    public const int IAHHNKBIOJAFieldNumber = 11;
    private uint iAHHNKBIOJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IAHHNKBIOJA {
      get { return iAHHNKBIOJA_; }
      set {
        iAHHNKBIOJA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BGFMMOEHJCE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BGFMMOEHJCE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AMLICKMAHBP != other.AMLICKMAHBP) return false;
      if (Type != other.Type) return false;
      if (IAHHNKBIOJA != other.IAHHNKBIOJA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AMLICKMAHBP != 0) hash ^= AMLICKMAHBP.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (IAHHNKBIOJA != 0) hash ^= IAHHNKBIOJA.GetHashCode();
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
      if (AMLICKMAHBP != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AMLICKMAHBP);
      }
      if (Type != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Type);
      }
      if (IAHHNKBIOJA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IAHHNKBIOJA);
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
      if (AMLICKMAHBP != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AMLICKMAHBP);
      }
      if (Type != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Type);
      }
      if (IAHHNKBIOJA != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IAHHNKBIOJA);
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
      if (AMLICKMAHBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AMLICKMAHBP);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      if (IAHHNKBIOJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IAHHNKBIOJA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BGFMMOEHJCE other) {
      if (other == null) {
        return;
      }
      if (other.AMLICKMAHBP != 0) {
        AMLICKMAHBP = other.AMLICKMAHBP;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.IAHHNKBIOJA != 0) {
        IAHHNKBIOJA = other.IAHHNKBIOJA;
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
          case 16: {
            AMLICKMAHBP = input.ReadUInt32();
            break;
          }
          case 80: {
            Type = input.ReadUInt32();
            break;
          }
          case 88: {
            IAHHNKBIOJA = input.ReadUInt32();
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
          case 16: {
            AMLICKMAHBP = input.ReadUInt32();
            break;
          }
          case 80: {
            Type = input.ReadUInt32();
            break;
          }
          case 88: {
            IAHHNKBIOJA = input.ReadUInt32();
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
