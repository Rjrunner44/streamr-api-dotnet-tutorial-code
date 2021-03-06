/* 
 * Streamr API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// StartRequest
    /// </summary>
    [DataContract]
    public partial class StartRequest :  IEquatable<StartRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartRequest" /> class.
        /// </summary>
        /// <param name="clearState">If true, previously saved state will be cleared before starting canvas. (default to false).</param>
        public StartRequest(bool? clearState = false)
        {
            // use default value if no "clearState" provided
            if (clearState == null)
            {
                this.ClearState = false;
            }
            else
            {
                this.ClearState = clearState;
            }
        }
        
        /// <summary>
        /// If true, previously saved state will be cleared before starting canvas.
        /// </summary>
        /// <value>If true, previously saved state will be cleared before starting canvas.</value>
        [DataMember(Name="clearState", EmitDefaultValue=false)]
        public bool? ClearState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartRequest {\n");
            sb.Append("  ClearState: ").Append(ClearState).Append("\n");
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
            return this.Equals(input as StartRequest);
        }

        /// <summary>
        /// Returns true if StartRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClearState == input.ClearState ||
                    (this.ClearState != null &&
                    this.ClearState.Equals(input.ClearState))
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
                if (this.ClearState != null)
                    hashCode = hashCode * 59 + this.ClearState.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
