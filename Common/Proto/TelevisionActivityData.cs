// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TelevisionActivityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TelevisionActivityData.proto</summary>
  public static partial class TelevisionActivityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for TelevisionActivityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TelevisionActivityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxUZWxldmlzaW9uQWN0aXZpdHlEYXRhLnByb3RvIlcKFlRlbGV2aXNpb25B",
            "Y3Rpdml0eURhdGESEwoLUE5PTFBJQ0VMS0kYCSABKA0SEwoLSUdLSUdGQk9L",
            "Q0oYCyABKA0SEwoLS05OSlBDR0VDTUUYASABKA1CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TelevisionActivityData), global::EggLink.DanhengServer.Proto.TelevisionActivityData.Parser, new[]{ "PNOLPICELKI", "IGKIGFBOKCJ", "KNNJPCGECME" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TelevisionActivityData : pb::IMessage<TelevisionActivityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TelevisionActivityData> _parser = new pb::MessageParser<TelevisionActivityData>(() => new TelevisionActivityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TelevisionActivityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TelevisionActivityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityData(TelevisionActivityData other) : this() {
      pNOLPICELKI_ = other.pNOLPICELKI_;
      iGKIGFBOKCJ_ = other.iGKIGFBOKCJ_;
      kNNJPCGECME_ = other.kNNJPCGECME_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityData Clone() {
      return new TelevisionActivityData(this);
    }

    /// <summary>Field number for the "PNOLPICELKI" field.</summary>
    public const int PNOLPICELKIFieldNumber = 9;
    private uint pNOLPICELKI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PNOLPICELKI {
      get { return pNOLPICELKI_; }
      set {
        pNOLPICELKI_ = value;
      }
    }

    /// <summary>Field number for the "IGKIGFBOKCJ" field.</summary>
    public const int IGKIGFBOKCJFieldNumber = 11;
    private uint iGKIGFBOKCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IGKIGFBOKCJ {
      get { return iGKIGFBOKCJ_; }
      set {
        iGKIGFBOKCJ_ = value;
      }
    }

    /// <summary>Field number for the "KNNJPCGECME" field.</summary>
    public const int KNNJPCGECMEFieldNumber = 1;
    private uint kNNJPCGECME_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KNNJPCGECME {
      get { return kNNJPCGECME_; }
      set {
        kNNJPCGECME_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TelevisionActivityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TelevisionActivityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PNOLPICELKI != other.PNOLPICELKI) return false;
      if (IGKIGFBOKCJ != other.IGKIGFBOKCJ) return false;
      if (KNNJPCGECME != other.KNNJPCGECME) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PNOLPICELKI != 0) hash ^= PNOLPICELKI.GetHashCode();
      if (IGKIGFBOKCJ != 0) hash ^= IGKIGFBOKCJ.GetHashCode();
      if (KNNJPCGECME != 0) hash ^= KNNJPCGECME.GetHashCode();
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
      if (KNNJPCGECME != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KNNJPCGECME);
      }
      if (PNOLPICELKI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PNOLPICELKI);
      }
      if (IGKIGFBOKCJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IGKIGFBOKCJ);
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
      if (KNNJPCGECME != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KNNJPCGECME);
      }
      if (PNOLPICELKI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PNOLPICELKI);
      }
      if (IGKIGFBOKCJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IGKIGFBOKCJ);
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
      if (PNOLPICELKI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PNOLPICELKI);
      }
      if (IGKIGFBOKCJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IGKIGFBOKCJ);
      }
      if (KNNJPCGECME != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KNNJPCGECME);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TelevisionActivityData other) {
      if (other == null) {
        return;
      }
      if (other.PNOLPICELKI != 0) {
        PNOLPICELKI = other.PNOLPICELKI;
      }
      if (other.IGKIGFBOKCJ != 0) {
        IGKIGFBOKCJ = other.IGKIGFBOKCJ;
      }
      if (other.KNNJPCGECME != 0) {
        KNNJPCGECME = other.KNNJPCGECME;
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
          case 8: {
            KNNJPCGECME = input.ReadUInt32();
            break;
          }
          case 72: {
            PNOLPICELKI = input.ReadUInt32();
            break;
          }
          case 88: {
            IGKIGFBOKCJ = input.ReadUInt32();
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
          case 8: {
            KNNJPCGECME = input.ReadUInt32();
            break;
          }
          case 72: {
            PNOLPICELKI = input.ReadUInt32();
            break;
          }
          case 88: {
            IGKIGFBOKCJ = input.ReadUInt32();
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
