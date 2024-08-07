// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeScriptEmotionCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChangeScriptEmotionCsReq.proto</summary>
  public static partial class ChangeScriptEmotionCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeScriptEmotionCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeScriptEmotionCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5DaGFuZ2VTY3JpcHRFbW90aW9uQ3NSZXEucHJvdG8aGkhlYXJ0RGlhbEVt",
            "b3Rpb25UeXBlLnByb3RvInYKGENoYW5nZVNjcmlwdEVtb3Rpb25Dc1JlcRIR",
            "CglzY3JpcHRfaWQYASABKA0SMgoTdGFyZ2V0X2Vtb3Rpb25fdHlwZRgFIAEo",
            "DjIVLkhlYXJ0RGlhbEVtb3Rpb25UeXBlEhMKC0pKUE5EQUFDTUVKGAIgASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeartDialEmotionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChangeScriptEmotionCsReq), global::EggLink.DanhengServer.Proto.ChangeScriptEmotionCsReq.Parser, new[]{ "ScriptId", "TargetEmotionType", "JJPNDAACMEJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChangeScriptEmotionCsReq : pb::IMessage<ChangeScriptEmotionCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeScriptEmotionCsReq> _parser = new pb::MessageParser<ChangeScriptEmotionCsReq>(() => new ChangeScriptEmotionCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeScriptEmotionCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChangeScriptEmotionCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeScriptEmotionCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeScriptEmotionCsReq(ChangeScriptEmotionCsReq other) : this() {
      scriptId_ = other.scriptId_;
      targetEmotionType_ = other.targetEmotionType_;
      jJPNDAACMEJ_ = other.jJPNDAACMEJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeScriptEmotionCsReq Clone() {
      return new ChangeScriptEmotionCsReq(this);
    }

    /// <summary>Field number for the "script_id" field.</summary>
    public const int ScriptIdFieldNumber = 1;
    private uint scriptId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScriptId {
      get { return scriptId_; }
      set {
        scriptId_ = value;
      }
    }

    /// <summary>Field number for the "target_emotion_type" field.</summary>
    public const int TargetEmotionTypeFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.HeartDialEmotionType targetEmotionType_ = global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialEmotionType TargetEmotionType {
      get { return targetEmotionType_; }
      set {
        targetEmotionType_ = value;
      }
    }

    /// <summary>Field number for the "JJPNDAACMEJ" field.</summary>
    public const int JJPNDAACMEJFieldNumber = 2;
    private uint jJPNDAACMEJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JJPNDAACMEJ {
      get { return jJPNDAACMEJ_; }
      set {
        jJPNDAACMEJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeScriptEmotionCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeScriptEmotionCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScriptId != other.ScriptId) return false;
      if (TargetEmotionType != other.TargetEmotionType) return false;
      if (JJPNDAACMEJ != other.JJPNDAACMEJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScriptId != 0) hash ^= ScriptId.GetHashCode();
      if (TargetEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) hash ^= TargetEmotionType.GetHashCode();
      if (JJPNDAACMEJ != 0) hash ^= JJPNDAACMEJ.GetHashCode();
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
      if (ScriptId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ScriptId);
      }
      if (JJPNDAACMEJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JJPNDAACMEJ);
      }
      if (TargetEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        output.WriteRawTag(40);
        output.WriteEnum((int) TargetEmotionType);
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
      if (ScriptId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ScriptId);
      }
      if (JJPNDAACMEJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(JJPNDAACMEJ);
      }
      if (TargetEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        output.WriteRawTag(40);
        output.WriteEnum((int) TargetEmotionType);
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
      if (ScriptId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScriptId);
      }
      if (TargetEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TargetEmotionType);
      }
      if (JJPNDAACMEJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JJPNDAACMEJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeScriptEmotionCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ScriptId != 0) {
        ScriptId = other.ScriptId;
      }
      if (other.TargetEmotionType != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        TargetEmotionType = other.TargetEmotionType;
      }
      if (other.JJPNDAACMEJ != 0) {
        JJPNDAACMEJ = other.JJPNDAACMEJ;
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
            ScriptId = input.ReadUInt32();
            break;
          }
          case 16: {
            JJPNDAACMEJ = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetEmotionType = (global::EggLink.DanhengServer.Proto.HeartDialEmotionType) input.ReadEnum();
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
            ScriptId = input.ReadUInt32();
            break;
          }
          case 16: {
            JJPNDAACMEJ = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetEmotionType = (global::EggLink.DanhengServer.Proto.HeartDialEmotionType) input.ReadEnum();
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
