/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CatAllOf
    /// </summary>
    [DataContract]
    public partial class CatAllOf :  IEquatable<CatAllOf>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatAllOf" /> class.
        /// </summary>
        /// <param name="declawed">declawed.</param>
        public CatAllOf(bool declawed = default(bool))
        {
            this.Declawed = declawed;
        }
        
        /// <summary>
        /// Gets or Sets Declawed
        /// </summary>
        [DataMember(Name="declawed", EmitDefaultValue=false)]
        public bool Declawed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatAllOf {\n");
            sb.Append("  Declawed: ").Append(Declawed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as CatAllOf);
        }

        /// <summary>
        /// Returns true if CatAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CatAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Declawed == input.Declawed ||
                    (this.Declawed != null &&
                    this.Declawed.Equals(input.Declawed))
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
                if (this.Declawed != null)
                    hashCode = hashCode * 59 + this.Declawed.GetHashCode();
                return hashCode;
            }
        }

    }

}
