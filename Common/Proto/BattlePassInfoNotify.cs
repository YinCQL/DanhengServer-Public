// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattlePassInfoNotify.proto</summary>
  public static partial class BattlePassInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpCYXR0bGVQYXNzSW5mb05vdGlmeS5wcm90bxoQQnBUaWVyVHlwZS5wcm90",
            "byL7AgoUQmF0dGxlUGFzc0luZm9Ob3RpZnkSEwoLREdHUEpBSE1HS00YDiAB",
            "KAQSJQoddGFrZW5fcHJlbWl1bV9vcHRpb25hbF9yZXdhcmQYAiABKAQSJQod",
            "dGFrZW5fcHJlbWl1bV9leHRlbmRlZF9yZXdhcmQYBCABKAQSHQoVdGFrZW5f",
            "cHJlbWl1bV9yZXdhcmQyGAMgASgEEgsKA2V4cBgBIAEoDRIdChV0YWtlbl9w",
            "cmVtaXVtX3Jld2FyZDEYCSABKAQSHAoUY3VyX3dlZWtfYWRkX2V4cF9zdW0Y",
            "DCABKA0SEwoLT0JKUEhLRkNET0MYDyABKAQSIgoadGFrZW5fZnJlZV9leHRl",
            "bmRlZF9yZXdhcmQYCCABKAQSEQoJY3VyX2JwX2lkGAUgASgNEhkKEXRha2Vu",
            "X2ZyZWVfcmV3YXJkGAogASgEEiEKDGJwX3RpZXJfdHlwZRgLIAEoDjILLkJw",
            "VGllclR5cGUSDQoFbGV2ZWwYDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BpTierTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BattlePassInfoNotify), global::EggLink.DanhengServer.Proto.BattlePassInfoNotify.Parser, new[]{ "DGGPJAHMGKM", "TakenPremiumOptionalReward", "TakenPremiumExtendedReward", "TakenPremiumReward2", "Exp", "TakenPremiumReward1", "CurWeekAddExpSum", "OBJPHKFCDOC", "TakenFreeExtendedReward", "CurBpId", "TakenFreeReward", "BpTierType", "Level" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattlePassInfoNotify : pb::IMessage<BattlePassInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassInfoNotify> _parser = new pb::MessageParser<BattlePassInfoNotify>(() => new BattlePassInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BattlePassInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify(BattlePassInfoNotify other) : this() {
      dGGPJAHMGKM_ = other.dGGPJAHMGKM_;
      takenPremiumOptionalReward_ = other.takenPremiumOptionalReward_;
      takenPremiumExtendedReward_ = other.takenPremiumExtendedReward_;
      takenPremiumReward2_ = other.takenPremiumReward2_;
      exp_ = other.exp_;
      takenPremiumReward1_ = other.takenPremiumReward1_;
      curWeekAddExpSum_ = other.curWeekAddExpSum_;
      oBJPHKFCDOC_ = other.oBJPHKFCDOC_;
      takenFreeExtendedReward_ = other.takenFreeExtendedReward_;
      curBpId_ = other.curBpId_;
      takenFreeReward_ = other.takenFreeReward_;
      bpTierType_ = other.bpTierType_;
      level_ = other.level_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify Clone() {
      return new BattlePassInfoNotify(this);
    }

    /// <summary>Field number for the "DGGPJAHMGKM" field.</summary>
    public const int DGGPJAHMGKMFieldNumber = 14;
    private ulong dGGPJAHMGKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DGGPJAHMGKM {
      get { return dGGPJAHMGKM_; }
      set {
        dGGPJAHMGKM_ = value;
      }
    }

    /// <summary>Field number for the "taken_premium_optional_reward" field.</summary>
    public const int TakenPremiumOptionalRewardFieldNumber = 2;
    private ulong takenPremiumOptionalReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenPremiumOptionalReward {
      get { return takenPremiumOptionalReward_; }
      set {
        takenPremiumOptionalReward_ = value;
      }
    }

    /// <summary>Field number for the "taken_premium_extended_reward" field.</summary>
    public const int TakenPremiumExtendedRewardFieldNumber = 4;
    private ulong takenPremiumExtendedReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenPremiumExtendedReward {
      get { return takenPremiumExtendedReward_; }
      set {
        takenPremiumExtendedReward_ = value;
      }
    }

    /// <summary>Field number for the "taken_premium_reward2" field.</summary>
    public const int TakenPremiumReward2FieldNumber = 3;
    private ulong takenPremiumReward2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenPremiumReward2 {
      get { return takenPremiumReward2_; }
      set {
        takenPremiumReward2_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 1;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "taken_premium_reward1" field.</summary>
    public const int TakenPremiumReward1FieldNumber = 9;
    private ulong takenPremiumReward1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenPremiumReward1 {
      get { return takenPremiumReward1_; }
      set {
        takenPremiumReward1_ = value;
      }
    }

    /// <summary>Field number for the "cur_week_add_exp_sum" field.</summary>
    public const int CurWeekAddExpSumFieldNumber = 12;
    private uint curWeekAddExpSum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurWeekAddExpSum {
      get { return curWeekAddExpSum_; }
      set {
        curWeekAddExpSum_ = value;
      }
    }

    /// <summary>Field number for the "OBJPHKFCDOC" field.</summary>
    public const int OBJPHKFCDOCFieldNumber = 15;
    private ulong oBJPHKFCDOC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong OBJPHKFCDOC {
      get { return oBJPHKFCDOC_; }
      set {
        oBJPHKFCDOC_ = value;
      }
    }

    /// <summary>Field number for the "taken_free_extended_reward" field.</summary>
    public const int TakenFreeExtendedRewardFieldNumber = 8;
    private ulong takenFreeExtendedReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenFreeExtendedReward {
      get { return takenFreeExtendedReward_; }
      set {
        takenFreeExtendedReward_ = value;
      }
    }

    /// <summary>Field number for the "cur_bp_id" field.</summary>
    public const int CurBpIdFieldNumber = 5;
    private uint curBpId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurBpId {
      get { return curBpId_; }
      set {
        curBpId_ = value;
      }
    }

    /// <summary>Field number for the "taken_free_reward" field.</summary>
    public const int TakenFreeRewardFieldNumber = 10;
    private ulong takenFreeReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TakenFreeReward {
      get { return takenFreeReward_; }
      set {
        takenFreeReward_ = value;
      }
    }

    /// <summary>Field number for the "bp_tier_type" field.</summary>
    public const int BpTierTypeFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.BpTierType bpTierType_ = global::EggLink.DanhengServer.Proto.BpTierType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BpTierType BpTierType {
      get { return bpTierType_; }
      set {
        bpTierType_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 13;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DGGPJAHMGKM != other.DGGPJAHMGKM) return false;
      if (TakenPremiumOptionalReward != other.TakenPremiumOptionalReward) return false;
      if (TakenPremiumExtendedReward != other.TakenPremiumExtendedReward) return false;
      if (TakenPremiumReward2 != other.TakenPremiumReward2) return false;
      if (Exp != other.Exp) return false;
      if (TakenPremiumReward1 != other.TakenPremiumReward1) return false;
      if (CurWeekAddExpSum != other.CurWeekAddExpSum) return false;
      if (OBJPHKFCDOC != other.OBJPHKFCDOC) return false;
      if (TakenFreeExtendedReward != other.TakenFreeExtendedReward) return false;
      if (CurBpId != other.CurBpId) return false;
      if (TakenFreeReward != other.TakenFreeReward) return false;
      if (BpTierType != other.BpTierType) return false;
      if (Level != other.Level) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DGGPJAHMGKM != 0UL) hash ^= DGGPJAHMGKM.GetHashCode();
      if (TakenPremiumOptionalReward != 0UL) hash ^= TakenPremiumOptionalReward.GetHashCode();
      if (TakenPremiumExtendedReward != 0UL) hash ^= TakenPremiumExtendedReward.GetHashCode();
      if (TakenPremiumReward2 != 0UL) hash ^= TakenPremiumReward2.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (TakenPremiumReward1 != 0UL) hash ^= TakenPremiumReward1.GetHashCode();
      if (CurWeekAddExpSum != 0) hash ^= CurWeekAddExpSum.GetHashCode();
      if (OBJPHKFCDOC != 0UL) hash ^= OBJPHKFCDOC.GetHashCode();
      if (TakenFreeExtendedReward != 0UL) hash ^= TakenFreeExtendedReward.GetHashCode();
      if (CurBpId != 0) hash ^= CurBpId.GetHashCode();
      if (TakenFreeReward != 0UL) hash ^= TakenFreeReward.GetHashCode();
      if (BpTierType != global::EggLink.DanhengServer.Proto.BpTierType.None) hash ^= BpTierType.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (TakenPremiumOptionalReward != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TakenPremiumOptionalReward);
      }
      if (TakenPremiumReward2 != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TakenPremiumReward2);
      }
      if (TakenPremiumExtendedReward != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TakenPremiumExtendedReward);
      }
      if (CurBpId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurBpId);
      }
      if (TakenFreeExtendedReward != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(TakenFreeExtendedReward);
      }
      if (TakenPremiumReward1 != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(TakenPremiumReward1);
      }
      if (TakenFreeReward != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(TakenFreeReward);
      }
      if (BpTierType != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) BpTierType);
      }
      if (CurWeekAddExpSum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurWeekAddExpSum);
      }
      if (Level != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Level);
      }
      if (DGGPJAHMGKM != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(DGGPJAHMGKM);
      }
      if (OBJPHKFCDOC != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(OBJPHKFCDOC);
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (TakenPremiumOptionalReward != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TakenPremiumOptionalReward);
      }
      if (TakenPremiumReward2 != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TakenPremiumReward2);
      }
      if (TakenPremiumExtendedReward != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TakenPremiumExtendedReward);
      }
      if (CurBpId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurBpId);
      }
      if (TakenFreeExtendedReward != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(TakenFreeExtendedReward);
      }
      if (TakenPremiumReward1 != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(TakenPremiumReward1);
      }
      if (TakenFreeReward != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(TakenFreeReward);
      }
      if (BpTierType != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) BpTierType);
      }
      if (CurWeekAddExpSum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurWeekAddExpSum);
      }
      if (Level != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Level);
      }
      if (DGGPJAHMGKM != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(DGGPJAHMGKM);
      }
      if (OBJPHKFCDOC != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(OBJPHKFCDOC);
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
      if (DGGPJAHMGKM != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DGGPJAHMGKM);
      }
      if (TakenPremiumOptionalReward != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenPremiumOptionalReward);
      }
      if (TakenPremiumExtendedReward != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenPremiumExtendedReward);
      }
      if (TakenPremiumReward2 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenPremiumReward2);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (TakenPremiumReward1 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenPremiumReward1);
      }
      if (CurWeekAddExpSum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurWeekAddExpSum);
      }
      if (OBJPHKFCDOC != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(OBJPHKFCDOC);
      }
      if (TakenFreeExtendedReward != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenFreeExtendedReward);
      }
      if (CurBpId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurBpId);
      }
      if (TakenFreeReward != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TakenFreeReward);
      }
      if (BpTierType != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BpTierType);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.DGGPJAHMGKM != 0UL) {
        DGGPJAHMGKM = other.DGGPJAHMGKM;
      }
      if (other.TakenPremiumOptionalReward != 0UL) {
        TakenPremiumOptionalReward = other.TakenPremiumOptionalReward;
      }
      if (other.TakenPremiumExtendedReward != 0UL) {
        TakenPremiumExtendedReward = other.TakenPremiumExtendedReward;
      }
      if (other.TakenPremiumReward2 != 0UL) {
        TakenPremiumReward2 = other.TakenPremiumReward2;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.TakenPremiumReward1 != 0UL) {
        TakenPremiumReward1 = other.TakenPremiumReward1;
      }
      if (other.CurWeekAddExpSum != 0) {
        CurWeekAddExpSum = other.CurWeekAddExpSum;
      }
      if (other.OBJPHKFCDOC != 0UL) {
        OBJPHKFCDOC = other.OBJPHKFCDOC;
      }
      if (other.TakenFreeExtendedReward != 0UL) {
        TakenFreeExtendedReward = other.TakenFreeExtendedReward;
      }
      if (other.CurBpId != 0) {
        CurBpId = other.CurBpId;
      }
      if (other.TakenFreeReward != 0UL) {
        TakenFreeReward = other.TakenFreeReward;
      }
      if (other.BpTierType != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        BpTierType = other.BpTierType;
      }
      if (other.Level != 0) {
        Level = other.Level;
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            TakenPremiumOptionalReward = input.ReadUInt64();
            break;
          }
          case 24: {
            TakenPremiumReward2 = input.ReadUInt64();
            break;
          }
          case 32: {
            TakenPremiumExtendedReward = input.ReadUInt64();
            break;
          }
          case 40: {
            CurBpId = input.ReadUInt32();
            break;
          }
          case 64: {
            TakenFreeExtendedReward = input.ReadUInt64();
            break;
          }
          case 72: {
            TakenPremiumReward1 = input.ReadUInt64();
            break;
          }
          case 80: {
            TakenFreeReward = input.ReadUInt64();
            break;
          }
          case 88: {
            BpTierType = (global::EggLink.DanhengServer.Proto.BpTierType) input.ReadEnum();
            break;
          }
          case 96: {
            CurWeekAddExpSum = input.ReadUInt32();
            break;
          }
          case 104: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            DGGPJAHMGKM = input.ReadUInt64();
            break;
          }
          case 120: {
            OBJPHKFCDOC = input.ReadUInt64();
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            TakenPremiumOptionalReward = input.ReadUInt64();
            break;
          }
          case 24: {
            TakenPremiumReward2 = input.ReadUInt64();
            break;
          }
          case 32: {
            TakenPremiumExtendedReward = input.ReadUInt64();
            break;
          }
          case 40: {
            CurBpId = input.ReadUInt32();
            break;
          }
          case 64: {
            TakenFreeExtendedReward = input.ReadUInt64();
            break;
          }
          case 72: {
            TakenPremiumReward1 = input.ReadUInt64();
            break;
          }
          case 80: {
            TakenFreeReward = input.ReadUInt64();
            break;
          }
          case 88: {
            BpTierType = (global::EggLink.DanhengServer.Proto.BpTierType) input.ReadEnum();
            break;
          }
          case 96: {
            CurWeekAddExpSum = input.ReadUInt32();
            break;
          }
          case 104: {
            Level = input.ReadUInt32();
            break;
          }
          case 112: {
            DGGPJAHMGKM = input.ReadUInt64();
            break;
          }
          case 120: {
            OBJPHKFCDOC = input.ReadUInt64();
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
