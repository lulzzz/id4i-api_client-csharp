using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace  {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DocumentUpdate {
    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// Document is publicly readable
    /// </summary>
    /// <value>Document is publicly readable</value>
    [DataMember(Name="publicVisibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicVisibility")]
    public bool? PublicVisibility { get; set; }

    /// <summary>
    /// Document is readable by these organizations
    /// </summary>
    /// <value>Document is readable by these organizations</value>
    [DataMember(Name="visibleByOrganizationIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibleByOrganizationIds")]
    public List<long?> VisibleByOrganizationIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentUpdate {\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  PublicVisibility: ").Append(PublicVisibility).Append("\n");
      sb.Append("  VisibleByOrganizationIds: ").Append(VisibleByOrganizationIds).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
