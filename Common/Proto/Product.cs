// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Product.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Product.proto</summary>
  public static partial class ProductReflection {

    #region Descriptor
    /// <summary>File descriptor for Product.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1Qcm9kdWN0LnByb3RvGhVQcm9kdWN0R2lmdFR5cGUucHJvdG8imQEKB1By",
            "b2R1Y3QSJQoLQ09QQUROQ0VHR08YDyABKA4yEC5Qcm9kdWN0R2lmdFR5cGUS",
            "EwoLUEpKSURIUE9MTEgYDCABKAgSEwoLUFBQTEJKR0ZEQ0gYDSABKA0SEwoL",
            "REdKSEJHR0pJQ0cYCCABKAkSEwoLTURPQkRIRUhNS00YAiABKAkSEwoLQ1BC",
            "UExMTFBFQUQYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ProductGiftTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Product), global::EggLink.DanhengServer.Proto.Product.Parser, new[]{ "COPADNCEGGO", "PJJIDHPOLLH", "PPPLBJGFDCH", "DGJHBGGJICG", "MDOBDHEHMKM", "CPBPLLLPEAD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Product : pb::IMessage<Product>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Product> _parser = new pb::MessageParser<Product>(() => new Product());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Product> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ProductReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product(Product other) : this() {
      cOPADNCEGGO_ = other.cOPADNCEGGO_;
      pJJIDHPOLLH_ = other.pJJIDHPOLLH_;
      pPPLBJGFDCH_ = other.pPPLBJGFDCH_;
      dGJHBGGJICG_ = other.dGJHBGGJICG_;
      mDOBDHEHMKM_ = other.mDOBDHEHMKM_;
      cPBPLLLPEAD_ = other.cPBPLLLPEAD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product Clone() {
      return new Product(this);
    }

    /// <summary>Field number for the "COPADNCEGGO" field.</summary>
    public const int COPADNCEGGOFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ProductGiftType cOPADNCEGGO_ = global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ProductGiftType COPADNCEGGO {
      get { return cOPADNCEGGO_; }
      set {
        cOPADNCEGGO_ = value;
      }
    }

    /// <summary>Field number for the "PJJIDHPOLLH" field.</summary>
    public const int PJJIDHPOLLHFieldNumber = 12;
    private bool pJJIDHPOLLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PJJIDHPOLLH {
      get { return pJJIDHPOLLH_; }
      set {
        pJJIDHPOLLH_ = value;
      }
    }

    /// <summary>Field number for the "PPPLBJGFDCH" field.</summary>
    public const int PPPLBJGFDCHFieldNumber = 13;
    private uint pPPLBJGFDCH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PPPLBJGFDCH {
      get { return pPPLBJGFDCH_; }
      set {
        pPPLBJGFDCH_ = value;
      }
    }

    /// <summary>Field number for the "DGJHBGGJICG" field.</summary>
    public const int DGJHBGGJICGFieldNumber = 8;
    private string dGJHBGGJICG_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DGJHBGGJICG {
      get { return dGJHBGGJICG_; }
      set {
        dGJHBGGJICG_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MDOBDHEHMKM" field.</summary>
    public const int MDOBDHEHMKMFieldNumber = 2;
    private string mDOBDHEHMKM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MDOBDHEHMKM {
      get { return mDOBDHEHMKM_; }
      set {
        mDOBDHEHMKM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CPBPLLLPEAD" field.</summary>
    public const int CPBPLLLPEADFieldNumber = 1;
    private uint cPBPLLLPEAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CPBPLLLPEAD {
      get { return cPBPLLLPEAD_; }
      set {
        cPBPLLLPEAD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Product);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Product other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (COPADNCEGGO != other.COPADNCEGGO) return false;
      if (PJJIDHPOLLH != other.PJJIDHPOLLH) return false;
      if (PPPLBJGFDCH != other.PPPLBJGFDCH) return false;
      if (DGJHBGGJICG != other.DGJHBGGJICG) return false;
      if (MDOBDHEHMKM != other.MDOBDHEHMKM) return false;
      if (CPBPLLLPEAD != other.CPBPLLLPEAD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (COPADNCEGGO != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) hash ^= COPADNCEGGO.GetHashCode();
      if (PJJIDHPOLLH != false) hash ^= PJJIDHPOLLH.GetHashCode();
      if (PPPLBJGFDCH != 0) hash ^= PPPLBJGFDCH.GetHashCode();
      if (DGJHBGGJICG.Length != 0) hash ^= DGJHBGGJICG.GetHashCode();
      if (MDOBDHEHMKM.Length != 0) hash ^= MDOBDHEHMKM.GetHashCode();
      if (CPBPLLLPEAD != 0) hash ^= CPBPLLLPEAD.GetHashCode();
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
      if (CPBPLLLPEAD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CPBPLLLPEAD);
      }
      if (MDOBDHEHMKM.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MDOBDHEHMKM);
      }
      if (DGJHBGGJICG.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DGJHBGGJICG);
      }
      if (PJJIDHPOLLH != false) {
        output.WriteRawTag(96);
        output.WriteBool(PJJIDHPOLLH);
      }
      if (PPPLBJGFDCH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PPPLBJGFDCH);
      }
      if (COPADNCEGGO != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        output.WriteRawTag(120);
        output.WriteEnum((int) COPADNCEGGO);
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
      if (CPBPLLLPEAD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CPBPLLLPEAD);
      }
      if (MDOBDHEHMKM.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MDOBDHEHMKM);
      }
      if (DGJHBGGJICG.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DGJHBGGJICG);
      }
      if (PJJIDHPOLLH != false) {
        output.WriteRawTag(96);
        output.WriteBool(PJJIDHPOLLH);
      }
      if (PPPLBJGFDCH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PPPLBJGFDCH);
      }
      if (COPADNCEGGO != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        output.WriteRawTag(120);
        output.WriteEnum((int) COPADNCEGGO);
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
      if (COPADNCEGGO != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) COPADNCEGGO);
      }
      if (PJJIDHPOLLH != false) {
        size += 1 + 1;
      }
      if (PPPLBJGFDCH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PPPLBJGFDCH);
      }
      if (DGJHBGGJICG.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DGJHBGGJICG);
      }
      if (MDOBDHEHMKM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MDOBDHEHMKM);
      }
      if (CPBPLLLPEAD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CPBPLLLPEAD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Product other) {
      if (other == null) {
        return;
      }
      if (other.COPADNCEGGO != global::EggLink.DanhengServer.Proto.ProductGiftType.ProductGiftNone) {
        COPADNCEGGO = other.COPADNCEGGO;
      }
      if (other.PJJIDHPOLLH != false) {
        PJJIDHPOLLH = other.PJJIDHPOLLH;
      }
      if (other.PPPLBJGFDCH != 0) {
        PPPLBJGFDCH = other.PPPLBJGFDCH;
      }
      if (other.DGJHBGGJICG.Length != 0) {
        DGJHBGGJICG = other.DGJHBGGJICG;
      }
      if (other.MDOBDHEHMKM.Length != 0) {
        MDOBDHEHMKM = other.MDOBDHEHMKM;
      }
      if (other.CPBPLLLPEAD != 0) {
        CPBPLLLPEAD = other.CPBPLLLPEAD;
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
            CPBPLLLPEAD = input.ReadUInt32();
            break;
          }
          case 18: {
            MDOBDHEHMKM = input.ReadString();
            break;
          }
          case 66: {
            DGJHBGGJICG = input.ReadString();
            break;
          }
          case 96: {
            PJJIDHPOLLH = input.ReadBool();
            break;
          }
          case 104: {
            PPPLBJGFDCH = input.ReadUInt32();
            break;
          }
          case 120: {
            COPADNCEGGO = (global::EggLink.DanhengServer.Proto.ProductGiftType) input.ReadEnum();
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
            CPBPLLLPEAD = input.ReadUInt32();
            break;
          }
          case 18: {
            MDOBDHEHMKM = input.ReadString();
            break;
          }
          case 66: {
            DGJHBGGJICG = input.ReadString();
            break;
          }
          case 96: {
            PJJIDHPOLLH = input.ReadBool();
            break;
          }
          case 104: {
            PPPLBJGFDCH = input.ReadUInt32();
            break;
          }
          case 120: {
            COPADNCEGGO = (global::EggLink.DanhengServer.Proto.ProductGiftType) input.ReadEnum();
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
