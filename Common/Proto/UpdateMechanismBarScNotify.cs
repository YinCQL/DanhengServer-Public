// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdateMechanismBarScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdateMechanismBarScNotify.proto</summary>
  public static partial class UpdateMechanismBarScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateMechanismBarScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateMechanismBarScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBVcGRhdGVNZWNoYW5pc21CYXJTY05vdGlmeS5wcm90bxoWTWVjaGFuaXNt",
            "QmFySW5mby5wcm90byJoChpVcGRhdGVNZWNoYW5pc21CYXJTY05vdGlmeRIQ",
            "CghwbGFuZV9pZBgFIAEoDRImCgtDRktQRERGSE5HQRgPIAEoCzIRLk1lY2hh",
            "bmlzbUJhckluZm8SEAoIZmxvb3JfaWQYDiABKA1CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MechanismBarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdateMechanismBarScNotify), global::EggLink.DanhengServer.Proto.UpdateMechanismBarScNotify.Parser, new[]{ "PlaneId", "CFKPDDFHNGA", "FloorId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdateMechanismBarScNotify : pb::IMessage<UpdateMechanismBarScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateMechanismBarScNotify> _parser = new pb::MessageParser<UpdateMechanismBarScNotify>(() => new UpdateMechanismBarScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateMechanismBarScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdateMechanismBarScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMechanismBarScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMechanismBarScNotify(UpdateMechanismBarScNotify other) : this() {
      planeId_ = other.planeId_;
      cFKPDDFHNGA_ = other.cFKPDDFHNGA_ != null ? other.cFKPDDFHNGA_.Clone() : null;
      floorId_ = other.floorId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMechanismBarScNotify Clone() {
      return new UpdateMechanismBarScNotify(this);
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 5;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "CFKPDDFHNGA" field.</summary>
    public const int CFKPDDFHNGAFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.MechanismBarInfo cFKPDDFHNGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MechanismBarInfo CFKPDDFHNGA {
      get { return cFKPDDFHNGA_; }
      set {
        cFKPDDFHNGA_ = value;
      }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 14;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateMechanismBarScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateMechanismBarScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlaneId != other.PlaneId) return false;
      if (!object.Equals(CFKPDDFHNGA, other.CFKPDDFHNGA)) return false;
      if (FloorId != other.FloorId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (cFKPDDFHNGA_ != null) hash ^= CFKPDDFHNGA.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
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
      if (PlaneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PlaneId);
      }
      if (FloorId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FloorId);
      }
      if (cFKPDDFHNGA_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(CFKPDDFHNGA);
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
      if (PlaneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PlaneId);
      }
      if (FloorId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FloorId);
      }
      if (cFKPDDFHNGA_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(CFKPDDFHNGA);
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
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (cFKPDDFHNGA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CFKPDDFHNGA);
      }
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateMechanismBarScNotify other) {
      if (other == null) {
        return;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.cFKPDDFHNGA_ != null) {
        if (cFKPDDFHNGA_ == null) {
          CFKPDDFHNGA = new global::EggLink.DanhengServer.Proto.MechanismBarInfo();
        }
        CFKPDDFHNGA.MergeFrom(other.CFKPDDFHNGA);
      }
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
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
          case 40: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 112: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (cFKPDDFHNGA_ == null) {
              CFKPDDFHNGA = new global::EggLink.DanhengServer.Proto.MechanismBarInfo();
            }
            input.ReadMessage(CFKPDDFHNGA);
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
          case 40: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 112: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (cFKPDDFHNGA_ == null) {
              CFKPDDFHNGA = new global::EggLink.DanhengServer.Proto.MechanismBarInfo();
            }
            input.ReadMessage(CFKPDDFHNGA);
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
