//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ForwardDocumentEvent.proto
// Note: requires additional types generated from: Timestamp.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ForwardDocumentEvent")]
  public partial class ForwardDocumentEvent : global::ProtoBuf.IExtensible
  {
    public ForwardDocumentEvent() {}
    

    private Diadoc.Api.Proto.Timestamp _Timestamp = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Timestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp Timestamp
    {
      get { return _Timestamp; }
      set { _Timestamp = value; }
    }

    private string _ToBoxId = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ToBoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ToBoxId
    {
      get { return _ToBoxId; }
      set { _ToBoxId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}