// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournRoomStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournRoomStatus.proto</summary>
  public static partial class RogueTournRoomStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournRoomStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournRoomStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZVRvdXJuUm9vbVN0YXR1cy5wcm90byqoAQoUUm9ndWVUb3VyblJv",
            "b21TdGF0dXMSIAocUk9HVUVfVE9VUk5fUk9PTV9TVEFUVVNfTk9ORRAAEiIK",
            "HlJPR1VFX1RPVVJOX1JPT01fU1RBVFVTX0lOSVRFRBABEiYKIlJPR1VFX1RP",
            "VVJOX1JPT01fU1RBVFVTX1BST0NFU1NJTkcQAhIiCh5ST0dVRV9UT1VSTl9S",
            "T09NX1NUQVRVU19GSU5JU0gQA0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RogueTournRoomStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueTournRoomStatus {
    [pbr::OriginalName("ROGUE_TOURN_ROOM_STATUS_NONE")] None = 0,
    [pbr::OriginalName("ROGUE_TOURN_ROOM_STATUS_INITED")] Inited = 1,
    [pbr::OriginalName("ROGUE_TOURN_ROOM_STATUS_PROCESSING")] Processing = 2,
    [pbr::OriginalName("ROGUE_TOURN_ROOM_STATUS_FINISH")] Finish = 3,
  }

  #endregion

}

#endregion Designer generated code
