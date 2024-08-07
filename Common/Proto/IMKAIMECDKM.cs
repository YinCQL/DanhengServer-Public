// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IMKAIMECDKM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IMKAIMECDKM.proto</summary>
  public static partial class IMKAIMECDKMReflection {

    #region Descriptor
    /// <summary>File descriptor for IMKAIMECDKM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IMKAIMECDKMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJTUtBSU1FQ0RLTS5wcm90bxoVQWxsZXlFdmVudFN0YXRlLnByb3RvIlUK",
            "C0lNS0FJTUVDREtNEhMKC0ZPSEtKSE9JUExIGAggASgNEhAKCGV2ZW50X2lk",
            "GAcgASgNEh8KBXN0YXRlGAMgASgOMhAuQWxsZXlFdmVudFN0YXRlQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AlleyEventStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IMKAIMECDKM), global::EggLink.DanhengServer.Proto.IMKAIMECDKM.Parser, new[]{ "FOHKJHOIPLH", "EventId", "State" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IMKAIMECDKM : pb::IMessage<IMKAIMECDKM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IMKAIMECDKM> _parser = new pb::MessageParser<IMKAIMECDKM>(() => new IMKAIMECDKM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IMKAIMECDKM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IMKAIMECDKMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IMKAIMECDKM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IMKAIMECDKM(IMKAIMECDKM other) : this() {
      fOHKJHOIPLH_ = other.fOHKJHOIPLH_;
      eventId_ = other.eventId_;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IMKAIMECDKM Clone() {
      return new IMKAIMECDKM(this);
    }

    /// <summary>Field number for the "FOHKJHOIPLH" field.</summary>
    public const int FOHKJHOIPLHFieldNumber = 8;
    private uint fOHKJHOIPLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FOHKJHOIPLH {
      get { return fOHKJHOIPLH_; }
      set {
        fOHKJHOIPLH_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 7;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.AlleyEventState state_ = global::EggLink.DanhengServer.Proto.AlleyEventState.AlleyStateNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AlleyEventState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IMKAIMECDKM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IMKAIMECDKM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FOHKJHOIPLH != other.FOHKJHOIPLH) return false;
      if (EventId != other.EventId) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FOHKJHOIPLH != 0) hash ^= FOHKJHOIPLH.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (State != global::EggLink.DanhengServer.Proto.AlleyEventState.AlleyStateNone) hash ^= State.GetHashCode();
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
      if (State != global::EggLink.DanhengServer.Proto.AlleyEventState.AlleyStateNone) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (EventId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EventId);
      }
      if (FOHKJHOIPLH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FOHKJHOIPLH);
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
      if (State != global::EggLink.DanhengServer.Proto.AlleyEventState.AlleyStateNone) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (EventId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EventId);
      }
      if (FOHKJHOIPLH != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FOHKJHOIPLH);
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
      if (FOHKJHOIPLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FOHKJHOIPLH);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (State != global::EggLink.DanhengServer.Proto.AlleyEventState.AlleyStateNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IMKAIMECDKM other) {
      if (other == null) {
        return;
      }
      if (other.FOHKJHOIPLH != 0) {
        FOHKJHOIPLH = other.FOHKJHOIPLH;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.State != global::EggLink.DanhengServer.Proto.AlleyEventState.AlleyStateNone) {
        State = other.State;
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
          case 24: {
            State = (global::EggLink.DanhengServer.Proto.AlleyEventState) input.ReadEnum();
            break;
          }
          case 56: {
            EventId = input.ReadUInt32();
            break;
          }
          case 64: {
            FOHKJHOIPLH = input.ReadUInt32();
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
          case 24: {
            State = (global::EggLink.DanhengServer.Proto.AlleyEventState) input.ReadEnum();
            break;
          }
          case 56: {
            EventId = input.ReadUInt32();
            break;
          }
          case 64: {
            FOHKJHOIPLH = input.ReadUInt32();
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
