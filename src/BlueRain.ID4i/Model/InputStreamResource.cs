/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.4.0
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = BlueRain.ID4i.Client.SwaggerDateConverter;

namespace BlueRain.ID4i.Model
{
    /// <summary>
    /// InputStreamResource
    /// </summary>
    [DataContract]
    public partial class InputStreamResource :  IEquatable<InputStreamResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputStreamResource" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="File">File.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="InputStream">InputStream.</param>
        /// <param name="Open">Open.</param>
        /// <param name="Readable">Readable.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="Url">Url.</param>
        public InputStreamResource(string Description = default(string), System.IO.Stream File = default(System.IO.Stream), string Filename = default(string), InputStream InputStream = default(InputStream), bool? Open = default(bool?), bool? Readable = default(bool?), URI Uri = default(URI), URL Url = default(URL))
        {
            this.Description = Description;
            this.File = File;
            this.Filename = Filename;
            this.InputStream = InputStream;
            this.Open = Open;
            this.Readable = Readable;
            this.Uri = Uri;
            this.Url = Url;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets InputStream
        /// </summary>
        [DataMember(Name="inputStream", EmitDefaultValue=false)]
        public InputStream InputStream { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public bool? Open { get; set; }

        /// <summary>
        /// Gets or Sets Readable
        /// </summary>
        [DataMember(Name="readable", EmitDefaultValue=false)]
        public bool? Readable { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public URI Uri { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public URL Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputStreamResource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  InputStream: ").Append(InputStream).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Readable: ").Append(Readable).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputStreamResource);
        }

        /// <summary>
        /// Returns true if InputStreamResource instances are equal
        /// </summary>
        /// <param name="input">Instance of InputStreamResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputStreamResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.InputStream == input.InputStream ||
                    (this.InputStream != null &&
                    this.InputStream.Equals(input.InputStream))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Readable == input.Readable ||
                    (this.Readable != null &&
                    this.Readable.Equals(input.Readable))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.InputStream != null)
                    hashCode = hashCode * 59 + this.InputStream.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Readable != null)
                    hashCode = hashCode * 59 + this.Readable.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
