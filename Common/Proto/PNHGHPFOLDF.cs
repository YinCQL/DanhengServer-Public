// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PNHGHPFOLDF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PNHGHPFOLDF.proto</summary>
  public static partial class PNHGHPFOLDFReflection {

    #region Descriptor
    /// <summary>File descriptor for PNHGHPFOLDF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PNHGHPFOLDFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQTkhHSFBGT0xERi5wcm90bxoVQ2VsbE1vbnN0ZXJJbmZvLnByb3RvGhtD",
            "ZWxsTW9uc3RlclNlbGVjdEluZm8ucHJvdG8iZAoLUE5IR0hQRk9MREYSMAoQ",
            "c2VsZWN0X2Jvc3NfaW5mbxgIIAEoCzIWLkNlbGxNb25zdGVyU2VsZWN0SW5m",
            "bxIjCglib3NzX2luZm8YCyABKAsyEC5DZWxsTW9uc3RlckluZm9CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CellMonsterInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.CellMonsterSelectInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PNHGHPFOLDF), global::EggLink.DanhengServer.Proto.PNHGHPFOLDF.Parser, new[]{ "SelectBossInfo", "BossInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PNHGHPFOLDF : pb::IMessage<PNHGHPFOLDF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PNHGHPFOLDF> _parser = new pb::MessageParser<PNHGHPFOLDF>(() => new PNHGHPFOLDF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PNHGHPFOLDF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PNHGHPFOLDFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PNHGHPFOLDF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PNHGHPFOLDF(PNHGHPFOLDF other) : this() {
      selectBossInfo_ = other.selectBossInfo_ != null ? other.selectBossInfo_.Clone() : null;
      bossInfo_ = other.bossInfo_ != null ? other.bossInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PNHGHPFOLDF Clone() {
      return new PNHGHPFOLDF(this);
    }

    /// <summary>Field number for the "select_boss_info" field.</summary>
    public const int SelectBossInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo selectBossInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo SelectBossInfo {
      get { return selectBossInfo_; }
      set {
        selectBossInfo_ = value;
      }
    }

    /// <summary>Field number for the "boss_info" field.</summary>
    public const int BossInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.CellMonsterInfo bossInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellMonsterInfo BossInfo {
      get { return bossInfo_; }
      set {
        bossInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PNHGHPFOLDF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PNHGHPFOLDF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SelectBossInfo, other.SelectBossInfo)) return false;
      if (!object.Equals(BossInfo, other.BossInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (selectBossInfo_ != null) hash ^= SelectBossInfo.GetHashCode();
      if (bossInfo_ != null) hash ^= BossInfo.GetHashCode();
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
      if (selectBossInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SelectBossInfo);
      }
      if (bossInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BossInfo);
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
      if (selectBossInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SelectBossInfo);
      }
      if (bossInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BossInfo);
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
      if (selectBossInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SelectBossInfo);
      }
      if (bossInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BossInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PNHGHPFOLDF other) {
      if (other == null) {
        return;
      }
      if (other.selectBossInfo_ != null) {
        if (selectBossInfo_ == null) {
          SelectBossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo();
        }
        SelectBossInfo.MergeFrom(other.SelectBossInfo);
      }
      if (other.bossInfo_ != null) {
        if (bossInfo_ == null) {
          BossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterInfo();
        }
        BossInfo.MergeFrom(other.BossInfo);
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
          case 66: {
            if (selectBossInfo_ == null) {
              SelectBossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo();
            }
            input.ReadMessage(SelectBossInfo);
            break;
          }
          case 90: {
            if (bossInfo_ == null) {
              BossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterInfo();
            }
            input.ReadMessage(BossInfo);
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
            if (selectBossInfo_ == null) {
              SelectBossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterSelectInfo();
            }
            input.ReadMessage(SelectBossInfo);
            break;
          }
          case 90: {
            if (bossInfo_ == null) {
              BossInfo = new global::EggLink.DanhengServer.Proto.CellMonsterInfo();
            }
            input.ReadMessage(BossInfo);
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