// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChallengeGroupStatisticsScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChallengeGroupStatisticsScRsp.proto</summary>
  public static partial class GetChallengeGroupStatisticsScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChallengeGroupStatisticsScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChallengeGroupStatisticsScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZHZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NTY1JzcC5wcm90bxoRQ0VJ",
            "SUtJSUZCQkIucHJvdG8aEUlIQ01QSUVLTkZCLnByb3RvGhFKT0NHUE5FTE9C",
            "Sy5wcm90byKuAQogR2V0Q2hhbGxlbmdlR3JvdXBTdGF0aXN0aWNzU2NSc3AS",
            "DwoHcmV0Y29kZRgBIAEoDRIQCghncm91cF9pZBgOIAEoDRIhCgtHTkNMSkFI",
            "SEJLTxgEIAEoCzIMLklIQ01QSUVLTkZCEiEKC0NES0NOS0xQSUdKGAIgASgL",
            "MgwuSk9DR1BORUxPQksSIQoLTEpCRU9HT0VKSUoYBSABKAsyDC5DRUlJS0lJ",
            "RkJCQkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CEIIKIIFBBBReflection.Descriptor, global::EggLink.DanhengServer.Proto.IHCMPIEKNFBReflection.Descriptor, global::EggLink.DanhengServer.Proto.JOCGPNELOBKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChallengeGroupStatisticsScRsp), global::EggLink.DanhengServer.Proto.GetChallengeGroupStatisticsScRsp.Parser, new[]{ "Retcode", "GroupId", "GNCLJAHHBKO", "CDKCNKLPIGJ", "LJBEOGOEJIJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChallengeGroupStatisticsScRsp : pb::IMessage<GetChallengeGroupStatisticsScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChallengeGroupStatisticsScRsp> _parser = new pb::MessageParser<GetChallengeGroupStatisticsScRsp>(() => new GetChallengeGroupStatisticsScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChallengeGroupStatisticsScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChallengeGroupStatisticsScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeGroupStatisticsScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeGroupStatisticsScRsp(GetChallengeGroupStatisticsScRsp other) : this() {
      retcode_ = other.retcode_;
      groupId_ = other.groupId_;
      gNCLJAHHBKO_ = other.gNCLJAHHBKO_ != null ? other.gNCLJAHHBKO_.Clone() : null;
      cDKCNKLPIGJ_ = other.cDKCNKLPIGJ_ != null ? other.cDKCNKLPIGJ_.Clone() : null;
      lJBEOGOEJIJ_ = other.lJBEOGOEJIJ_ != null ? other.lJBEOGOEJIJ_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeGroupStatisticsScRsp Clone() {
      return new GetChallengeGroupStatisticsScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 14;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "GNCLJAHHBKO" field.</summary>
    public const int GNCLJAHHBKOFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.IHCMPIEKNFB gNCLJAHHBKO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IHCMPIEKNFB GNCLJAHHBKO {
      get { return gNCLJAHHBKO_; }
      set {
        gNCLJAHHBKO_ = value;
      }
    }

    /// <summary>Field number for the "CDKCNKLPIGJ" field.</summary>
    public const int CDKCNKLPIGJFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.JOCGPNELOBK cDKCNKLPIGJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JOCGPNELOBK CDKCNKLPIGJ {
      get { return cDKCNKLPIGJ_; }
      set {
        cDKCNKLPIGJ_ = value;
      }
    }

    /// <summary>Field number for the "LJBEOGOEJIJ" field.</summary>
    public const int LJBEOGOEJIJFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.CEIIKIIFBBB lJBEOGOEJIJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CEIIKIIFBBB LJBEOGOEJIJ {
      get { return lJBEOGOEJIJ_; }
      set {
        lJBEOGOEJIJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetChallengeGroupStatisticsScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChallengeGroupStatisticsScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(GNCLJAHHBKO, other.GNCLJAHHBKO)) return false;
      if (!object.Equals(CDKCNKLPIGJ, other.CDKCNKLPIGJ)) return false;
      if (!object.Equals(LJBEOGOEJIJ, other.LJBEOGOEJIJ)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (gNCLJAHHBKO_ != null) hash ^= GNCLJAHHBKO.GetHashCode();
      if (cDKCNKLPIGJ_ != null) hash ^= CDKCNKLPIGJ.GetHashCode();
      if (lJBEOGOEJIJ_ != null) hash ^= LJBEOGOEJIJ.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (cDKCNKLPIGJ_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CDKCNKLPIGJ);
      }
      if (gNCLJAHHBKO_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GNCLJAHHBKO);
      }
      if (lJBEOGOEJIJ_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LJBEOGOEJIJ);
      }
      if (GroupId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GroupId);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      if (cDKCNKLPIGJ_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CDKCNKLPIGJ);
      }
      if (gNCLJAHHBKO_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(GNCLJAHHBKO);
      }
      if (lJBEOGOEJIJ_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LJBEOGOEJIJ);
      }
      if (GroupId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GroupId);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (gNCLJAHHBKO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GNCLJAHHBKO);
      }
      if (cDKCNKLPIGJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CDKCNKLPIGJ);
      }
      if (lJBEOGOEJIJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LJBEOGOEJIJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetChallengeGroupStatisticsScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.gNCLJAHHBKO_ != null) {
        if (gNCLJAHHBKO_ == null) {
          GNCLJAHHBKO = new global::EggLink.DanhengServer.Proto.IHCMPIEKNFB();
        }
        GNCLJAHHBKO.MergeFrom(other.GNCLJAHHBKO);
      }
      if (other.cDKCNKLPIGJ_ != null) {
        if (cDKCNKLPIGJ_ == null) {
          CDKCNKLPIGJ = new global::EggLink.DanhengServer.Proto.JOCGPNELOBK();
        }
        CDKCNKLPIGJ.MergeFrom(other.CDKCNKLPIGJ);
      }
      if (other.lJBEOGOEJIJ_ != null) {
        if (lJBEOGOEJIJ_ == null) {
          LJBEOGOEJIJ = new global::EggLink.DanhengServer.Proto.CEIIKIIFBBB();
        }
        LJBEOGOEJIJ.MergeFrom(other.LJBEOGOEJIJ);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            if (cDKCNKLPIGJ_ == null) {
              CDKCNKLPIGJ = new global::EggLink.DanhengServer.Proto.JOCGPNELOBK();
            }
            input.ReadMessage(CDKCNKLPIGJ);
            break;
          }
          case 34: {
            if (gNCLJAHHBKO_ == null) {
              GNCLJAHHBKO = new global::EggLink.DanhengServer.Proto.IHCMPIEKNFB();
            }
            input.ReadMessage(GNCLJAHHBKO);
            break;
          }
          case 42: {
            if (lJBEOGOEJIJ_ == null) {
              LJBEOGOEJIJ = new global::EggLink.DanhengServer.Proto.CEIIKIIFBBB();
            }
            input.ReadMessage(LJBEOGOEJIJ);
            break;
          }
          case 112: {
            GroupId = input.ReadUInt32();
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            if (cDKCNKLPIGJ_ == null) {
              CDKCNKLPIGJ = new global::EggLink.DanhengServer.Proto.JOCGPNELOBK();
            }
            input.ReadMessage(CDKCNKLPIGJ);
            break;
          }
          case 34: {
            if (gNCLJAHHBKO_ == null) {
              GNCLJAHHBKO = new global::EggLink.DanhengServer.Proto.IHCMPIEKNFB();
            }
            input.ReadMessage(GNCLJAHHBKO);
            break;
          }
          case 42: {
            if (lJBEOGOEJIJ_ == null) {
              LJBEOGOEJIJ = new global::EggLink.DanhengServer.Proto.CEIIKIIFBBB();
            }
            input.ReadMessage(LJBEOGOEJIJ);
            break;
          }
          case 112: {
            GroupId = input.ReadUInt32();
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
