// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MsgType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MsgType.proto</summary>
  public static partial class MsgTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MsgType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1Nc2dUeXBlLnByb3RvKl8KB01zZ1R5cGUSEQoNTVNHX1RZUEVfTk9ORRAA",
            "EhgKFE1TR19UWVBFX0NVU1RPTV9URVhUEAESEgoOTVNHX1RZUEVfRU1PSkkQ",
            "AhITCg9NU0dfVFlQRV9JTlZJVEUQA0IeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.MsgType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MsgType {
    [pbr::OriginalName("MSG_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MSG_TYPE_CUSTOM_TEXT")] CustomText = 1,
    [pbr::OriginalName("MSG_TYPE_EMOJI")] Emoji = 2,
    [pbr::OriginalName("MSG_TYPE_INVITE")] Invite = 3,
  }

  #endregion

}

#endregion Designer generated code
