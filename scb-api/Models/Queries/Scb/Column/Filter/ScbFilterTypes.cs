using System.Runtime.Serialization;

namespace scb_api.Models.Queries.Scb.Column.Filter
{
  public enum ScbFilterTypes
  {
    [EnumMember(Value = "item")]
    Item,
    [EnumMember(Value = "all")]
    All,
    [EnumMember(Value = "top")]
    Top,
    [EnumMember(Value = "agg")]
    Agg,
    [EnumMember(Value = "vs")]
    Vs
  }
}