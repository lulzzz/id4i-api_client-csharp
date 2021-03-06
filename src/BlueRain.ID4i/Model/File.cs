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
    /// File
    /// </summary>
    [DataContract]
    public partial class File :  IEquatable<File>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="Absolute">Absolute.</param>
        /// <param name="AbsoluteFile">AbsoluteFile.</param>
        /// <param name="AbsolutePath">AbsolutePath.</param>
        /// <param name="CanonicalFile">CanonicalFile.</param>
        /// <param name="CanonicalPath">CanonicalPath.</param>
        /// <param name="Directory">Directory.</param>
        /// <param name="_File">_File.</param>
        /// <param name="FreeSpace">FreeSpace.</param>
        /// <param name="Hidden">Hidden.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="ParentFile">ParentFile.</param>
        /// <param name="Path">Path.</param>
        /// <param name="TotalSpace">TotalSpace.</param>
        /// <param name="UsableSpace">UsableSpace.</param>
        public File(bool? Absolute = default(bool?), System.IO.Stream AbsoluteFile = default(System.IO.Stream), string AbsolutePath = default(string), System.IO.Stream CanonicalFile = default(System.IO.Stream), string CanonicalPath = default(string), bool? Directory = default(bool?), bool? _File = default(bool?), long? FreeSpace = default(long?), bool? Hidden = default(bool?), string Name = default(string), string Parent = default(string), System.IO.Stream ParentFile = default(System.IO.Stream), string Path = default(string), long? TotalSpace = default(long?), long? UsableSpace = default(long?))
        {
            this.Absolute = Absolute;
            this.AbsoluteFile = AbsoluteFile;
            this.AbsolutePath = AbsolutePath;
            this.CanonicalFile = CanonicalFile;
            this.CanonicalPath = CanonicalPath;
            this.Directory = Directory;
            this._File = _File;
            this.FreeSpace = FreeSpace;
            this.Hidden = Hidden;
            this.Name = Name;
            this.Parent = Parent;
            this.ParentFile = ParentFile;
            this.Path = Path;
            this.TotalSpace = TotalSpace;
            this.UsableSpace = UsableSpace;
        }
        
        /// <summary>
        /// Gets or Sets Absolute
        /// </summary>
        [DataMember(Name="absolute", EmitDefaultValue=false)]
        public bool? Absolute { get; set; }

        /// <summary>
        /// Gets or Sets AbsoluteFile
        /// </summary>
        [DataMember(Name="absoluteFile", EmitDefaultValue=false)]
        public System.IO.Stream AbsoluteFile { get; set; }

        /// <summary>
        /// Gets or Sets AbsolutePath
        /// </summary>
        [DataMember(Name="absolutePath", EmitDefaultValue=false)]
        public string AbsolutePath { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalFile
        /// </summary>
        [DataMember(Name="canonicalFile", EmitDefaultValue=false)]
        public System.IO.Stream CanonicalFile { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalPath
        /// </summary>
        [DataMember(Name="canonicalPath", EmitDefaultValue=false)]
        public string CanonicalPath { get; set; }

        /// <summary>
        /// Gets or Sets Directory
        /// </summary>
        [DataMember(Name="directory", EmitDefaultValue=false)]
        public bool? Directory { get; set; }

        /// <summary>
        /// Gets or Sets _File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public bool? _File { get; set; }

        /// <summary>
        /// Gets or Sets FreeSpace
        /// </summary>
        [DataMember(Name="freeSpace", EmitDefaultValue=false)]
        public long? FreeSpace { get; set; }

        /// <summary>
        /// Gets or Sets Hidden
        /// </summary>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }

        /// <summary>
        /// Gets or Sets ParentFile
        /// </summary>
        [DataMember(Name="parentFile", EmitDefaultValue=false)]
        public System.IO.Stream ParentFile { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets TotalSpace
        /// </summary>
        [DataMember(Name="totalSpace", EmitDefaultValue=false)]
        public long? TotalSpace { get; set; }

        /// <summary>
        /// Gets or Sets UsableSpace
        /// </summary>
        [DataMember(Name="usableSpace", EmitDefaultValue=false)]
        public long? UsableSpace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class File {\n");
            sb.Append("  Absolute: ").Append(Absolute).Append("\n");
            sb.Append("  AbsoluteFile: ").Append(AbsoluteFile).Append("\n");
            sb.Append("  AbsolutePath: ").Append(AbsolutePath).Append("\n");
            sb.Append("  CanonicalFile: ").Append(CanonicalFile).Append("\n");
            sb.Append("  CanonicalPath: ").Append(CanonicalPath).Append("\n");
            sb.Append("  Directory: ").Append(Directory).Append("\n");
            sb.Append("  _File: ").Append(_File).Append("\n");
            sb.Append("  FreeSpace: ").Append(FreeSpace).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  ParentFile: ").Append(ParentFile).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  TotalSpace: ").Append(TotalSpace).Append("\n");
            sb.Append("  UsableSpace: ").Append(UsableSpace).Append("\n");
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
            return this.Equals(input as File);
        }

        /// <summary>
        /// Returns true if File instances are equal
        /// </summary>
        /// <param name="input">Instance of File to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(File input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Absolute == input.Absolute ||
                    (this.Absolute != null &&
                    this.Absolute.Equals(input.Absolute))
                ) && 
                (
                    this.AbsoluteFile == input.AbsoluteFile ||
                    (this.AbsoluteFile != null &&
                    this.AbsoluteFile.Equals(input.AbsoluteFile))
                ) && 
                (
                    this.AbsolutePath == input.AbsolutePath ||
                    (this.AbsolutePath != null &&
                    this.AbsolutePath.Equals(input.AbsolutePath))
                ) && 
                (
                    this.CanonicalFile == input.CanonicalFile ||
                    (this.CanonicalFile != null &&
                    this.CanonicalFile.Equals(input.CanonicalFile))
                ) && 
                (
                    this.CanonicalPath == input.CanonicalPath ||
                    (this.CanonicalPath != null &&
                    this.CanonicalPath.Equals(input.CanonicalPath))
                ) && 
                (
                    this.Directory == input.Directory ||
                    (this.Directory != null &&
                    this.Directory.Equals(input.Directory))
                ) && 
                (
                    this._File == input._File ||
                    (this._File != null &&
                    this._File.Equals(input._File))
                ) && 
                (
                    this.FreeSpace == input.FreeSpace ||
                    (this.FreeSpace != null &&
                    this.FreeSpace.Equals(input.FreeSpace))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.ParentFile == input.ParentFile ||
                    (this.ParentFile != null &&
                    this.ParentFile.Equals(input.ParentFile))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.TotalSpace == input.TotalSpace ||
                    (this.TotalSpace != null &&
                    this.TotalSpace.Equals(input.TotalSpace))
                ) && 
                (
                    this.UsableSpace == input.UsableSpace ||
                    (this.UsableSpace != null &&
                    this.UsableSpace.Equals(input.UsableSpace))
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
                if (this.Absolute != null)
                    hashCode = hashCode * 59 + this.Absolute.GetHashCode();
                if (this.AbsoluteFile != null)
                    hashCode = hashCode * 59 + this.AbsoluteFile.GetHashCode();
                if (this.AbsolutePath != null)
                    hashCode = hashCode * 59 + this.AbsolutePath.GetHashCode();
                if (this.CanonicalFile != null)
                    hashCode = hashCode * 59 + this.CanonicalFile.GetHashCode();
                if (this.CanonicalPath != null)
                    hashCode = hashCode * 59 + this.CanonicalPath.GetHashCode();
                if (this.Directory != null)
                    hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this._File != null)
                    hashCode = hashCode * 59 + this._File.GetHashCode();
                if (this.FreeSpace != null)
                    hashCode = hashCode * 59 + this.FreeSpace.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.ParentFile != null)
                    hashCode = hashCode * 59 + this.ParentFile.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.TotalSpace != null)
                    hashCode = hashCode * 59 + this.TotalSpace.GetHashCode();
                if (this.UsableSpace != null)
                    hashCode = hashCode * 59 + this.UsableSpace.GetHashCode();
                return hashCode;
            }
        }
    }

}
