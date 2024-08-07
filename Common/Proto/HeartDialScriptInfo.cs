// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeartDialScriptInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeartDialScriptInfo.proto</summary>
  public static partial class HeartDialScriptInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HeartDialScriptInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeartDialScriptInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlIZWFydERpYWxTY3JpcHRJbmZvLnByb3RvGhdIZWFydERpYWxTdGVwVHlw",
            "ZS5wcm90bxoaSGVhcnREaWFsRW1vdGlvblR5cGUucHJvdG8ipQEKE0hlYXJ0",
            "RGlhbFNjcmlwdEluZm8SEwoLRUtPQkZCRFBQTEcYASABKAgSEwoLR0xLRU1O",
            "REFIRUcYBiABKAgSIAoEc3RlcBgMIAEoDjISLkhlYXJ0RGlhbFN0ZXBUeXBl",
            "EhEKCXNjcmlwdF9pZBgEIAEoDRIvChBjdXJfZW1vdGlvbl90eXBlGA4gASgO",
            "MhUuSGVhcnREaWFsRW1vdGlvblR5cGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeartDialStepTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeartDialEmotionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeartDialScriptInfo), global::EggLink.DanhengServer.Proto.HeartDialScriptInfo.Parser, new[]{ "EKOBFBDPPLG", "GLKEMNDAHEG", "Step", "ScriptId", "CurEmotionType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeartDialScriptInfo : pb::IMessage<HeartDialScriptInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeartDialScriptInfo> _parser = new pb::MessageParser<HeartDialScriptInfo>(() => new HeartDialScriptInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeartDialScriptInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeartDialScriptInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptInfo(HeartDialScriptInfo other) : this() {
      eKOBFBDPPLG_ = other.eKOBFBDPPLG_;
      gLKEMNDAHEG_ = other.gLKEMNDAHEG_;
      step_ = other.step_;
      scriptId_ = other.scriptId_;
      curEmotionType_ = other.curEmotionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeartDialScriptInfo Clone() {
      return new HeartDialScriptInfo(this);
    }

    /// <summary>Field number for the "EKOBFBDPPLG" field.</summary>
    public const int EKOBFBDPPLGFieldNumber = 1;
    private bool eKOBFBDPPLG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EKOBFBDPPLG {
      get { return eKOBFBDPPLG_; }
      set {
        eKOBFBDPPLG_ = value;
      }
    }

    /// <summary>Field number for the "GLKEMNDAHEG" field.</summary>
    public const int GLKEMNDAHEGFieldNumber = 6;
    private bool gLKEMNDAHEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool GLKEMNDAHEG {
      get { return gLKEMNDAHEG_; }
      set {
        gLKEMNDAHEG_ = value;
      }
    }

    /// <summary>Field number for the "step" field.</summary>
    public const int StepFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.HeartDialStepType step_ = global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialStepType Step {
      get { return step_; }
      set {
        step_ = value;
      }
    }

    /// <summary>Field number for the "script_id" field.</summary>
    public const int ScriptIdFieldNumber = 4;
    private uint scriptId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScriptId {
      get { return scriptId_; }
      set {
        scriptId_ = value;
      }
    }

    /// <summary>Field number for the "cur_emotion_type" field.</summary>
    public const int CurEmotionTypeFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.HeartDialEmotionType curEmotionType_ = global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialEmotionType CurEmotionType {
      get { return curEmotionType_; }
      set {
        curEmotionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeartDialScriptInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeartDialScriptInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EKOBFBDPPLG != other.EKOBFBDPPLG) return false;
      if (GLKEMNDAHEG != other.GLKEMNDAHEG) return false;
      if (Step != other.Step) return false;
      if (ScriptId != other.ScriptId) return false;
      if (CurEmotionType != other.CurEmotionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EKOBFBDPPLG != false) hash ^= EKOBFBDPPLG.GetHashCode();
      if (GLKEMNDAHEG != false) hash ^= GLKEMNDAHEG.GetHashCode();
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) hash ^= Step.GetHashCode();
      if (ScriptId != 0) hash ^= ScriptId.GetHashCode();
      if (CurEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) hash ^= CurEmotionType.GetHashCode();
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
      if (EKOBFBDPPLG != false) {
        output.WriteRawTag(8);
        output.WriteBool(EKOBFBDPPLG);
      }
      if (ScriptId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ScriptId);
      }
      if (GLKEMNDAHEG != false) {
        output.WriteRawTag(48);
        output.WriteBool(GLKEMNDAHEG);
      }
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Step);
      }
      if (CurEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        output.WriteRawTag(112);
        output.WriteEnum((int) CurEmotionType);
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
      if (EKOBFBDPPLG != false) {
        output.WriteRawTag(8);
        output.WriteBool(EKOBFBDPPLG);
      }
      if (ScriptId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ScriptId);
      }
      if (GLKEMNDAHEG != false) {
        output.WriteRawTag(48);
        output.WriteBool(GLKEMNDAHEG);
      }
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Step);
      }
      if (CurEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        output.WriteRawTag(112);
        output.WriteEnum((int) CurEmotionType);
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
      if (EKOBFBDPPLG != false) {
        size += 1 + 1;
      }
      if (GLKEMNDAHEG != false) {
        size += 1 + 1;
      }
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Step);
      }
      if (ScriptId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScriptId);
      }
      if (CurEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CurEmotionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeartDialScriptInfo other) {
      if (other == null) {
        return;
      }
      if (other.EKOBFBDPPLG != false) {
        EKOBFBDPPLG = other.EKOBFBDPPLG;
      }
      if (other.GLKEMNDAHEG != false) {
        GLKEMNDAHEG = other.GLKEMNDAHEG;
      }
      if (other.Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        Step = other.Step;
      }
      if (other.ScriptId != 0) {
        ScriptId = other.ScriptId;
      }
      if (other.CurEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        CurEmotionType = other.CurEmotionType;
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
            EKOBFBDPPLG = input.ReadBool();
            break;
          }
          case 32: {
            ScriptId = input.ReadUInt32();
            break;
          }
          case 48: {
            GLKEMNDAHEG = input.ReadBool();
            break;
          }
          case 96: {
            Step = (global::EggLink.DanhengServer.Proto.HeartDialStepType) input.ReadEnum();
            break;
          }
          case 112: {
            CurEmotionType = (global::EggLink.DanhengServer.Proto.HeartDialEmotionType) input.ReadEnum();
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
            EKOBFBDPPLG = input.ReadBool();
            break;
          }
          case 32: {
            ScriptId = input.ReadUInt32();
            break;
          }
          case 48: {
            GLKEMNDAHEG = input.ReadBool();
            break;
          }
          case 96: {
            Step = (global::EggLink.DanhengServer.Proto.HeartDialStepType) input.ReadEnum();
            break;
          }
          case 112: {
            CurEmotionType = (global::EggLink.DanhengServer.Proto.HeartDialEmotionType) input.ReadEnum();
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
