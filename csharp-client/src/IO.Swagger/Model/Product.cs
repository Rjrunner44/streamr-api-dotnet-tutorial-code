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
    /// Product
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Type of Product
        /// </summary>
        /// <value>Type of Product</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMAL = 1,
            
            /// <summary>
            /// Enum DATAUNION for value: DATAUNION
            /// </summary>
            [EnumMember(Value = "DATAUNION")]
            DATAUNION = 2
        }

        /// <summary>
        /// Type of Product
        /// </summary>
        /// <value>Type of Product</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// State of Product
        /// </summary>
        /// <value>State of Product</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum NOTDEPLOYED for value: NOT_DEPLOYED
            /// </summary>
            [EnumMember(Value = "NOT_DEPLOYED")]
            NOTDEPLOYED = 1,
            
            /// <summary>
            /// Enum DEPLOYING for value: DEPLOYING
            /// </summary>
            [EnumMember(Value = "DEPLOYING")]
            DEPLOYING = 2,
            
            /// <summary>
            /// Enum DEPLOYED for value: DEPLOYED
            /// </summary>
            [EnumMember(Value = "DEPLOYED")]
            DEPLOYED = 3,
            
            /// <summary>
            /// Enum UNDEPLOYING for value: UNDEPLOYING
            /// </summary>
            [EnumMember(Value = "UNDEPLOYING")]
            UNDEPLOYING = 4
        }

        /// <summary>
        /// State of Product
        /// </summary>
        /// <value>State of Product</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Unit currency
        /// </summary>
        /// <value>Unit currency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriceCurrencyEnum
        {
            
            /// <summary>
            /// Enum DATA for value: DATA
            /// </summary>
            [EnumMember(Value = "DATA")]
            DATA = 1,
            
            /// <summary>
            /// Enum USD for value: USD
            /// </summary>
            [EnumMember(Value = "USD")]
            USD = 2
        }

        /// <summary>
        /// Unit currency
        /// </summary>
        /// <value>Unit currency</value>
        [DataMember(Name="priceCurrency", EmitDefaultValue=false)]
        public PriceCurrencyEnum PriceCurrency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Product() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="id">unique identifier (required).</param>
        /// <param name="type">Type of Product (required).</param>
        /// <param name="state">State of Product (required).</param>
        /// <param name="created">ISO-8601 datetime (required).</param>
        /// <param name="updated">ISO-8601 datetime (required).</param>
        /// <param name="owner">Username of the creator of this Product (required).</param>
        /// <param name="imageUrl">URL of image (required).</param>
        /// <param name="thumbnailUrl">URL of thumbnail image (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="category">identifier of Category this Product belong to (required).</param>
        /// <param name="streams">List of Stream identifiers that belong to this Product (required).</param>
        /// <param name="previewStream">Identifier of Stream selected for preview.</param>
        /// <param name="previewConfigJson">Configuration of previewStream.</param>
        /// <param name="ownerAddress">Ethereum address of owner (required).</param>
        /// <param name="beneficiaryAddress">Ethereum address of beneficiary (required).</param>
        /// <param name="pricePerSecond">Unit cost per second (required).</param>
        /// <param name="priceCurrency">Unit currency (required).</param>
        /// <param name="minimumSubscriptionInSeconds">Minimum subscription length (in seconds) (required).</param>
        /// <param name="pendingChanges">Pending changes that are not published to blockchain.</param>
        /// <param name="contact">contact.</param>
        /// <param name="termsOfUse">termsOfUse.</param>
        public Product(string id = default(string), TypeEnum type = default(TypeEnum), StateEnum state = default(StateEnum), string created = default(string), string updated = default(string), string owner = default(string), string imageUrl = default(string), string thumbnailUrl = default(string), string name = default(string), string description = default(string), string category = default(string), List<string> streams = default(List<string>), string previewStream = default(string), string previewConfigJson = default(string), string ownerAddress = default(string), string beneficiaryAddress = default(string), int? pricePerSecond = default(int?), PriceCurrencyEnum priceCurrency = default(PriceCurrencyEnum), int? minimumSubscriptionInSeconds = default(int?), string pendingChanges = default(string), ProductContact contact = default(ProductContact), ProductTermsOfUse termsOfUse = default(ProductTermsOfUse))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Product and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Product and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for Product and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Product and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new InvalidDataException("updated is a required property for Product and cannot be null");
            }
            else
            {
                this.Updated = updated;
            }
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new InvalidDataException("owner is a required property for Product and cannot be null");
            }
            else
            {
                this.Owner = owner;
            }
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new InvalidDataException("imageUrl is a required property for Product and cannot be null");
            }
            else
            {
                this.ImageUrl = imageUrl;
            }
            // to ensure "thumbnailUrl" is required (not null)
            if (thumbnailUrl == null)
            {
                throw new InvalidDataException("thumbnailUrl is a required property for Product and cannot be null");
            }
            else
            {
                this.ThumbnailUrl = thumbnailUrl;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Product and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Product and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for Product and cannot be null");
            }
            else
            {
                this.Category = category;
            }
            // to ensure "streams" is required (not null)
            if (streams == null)
            {
                throw new InvalidDataException("streams is a required property for Product and cannot be null");
            }
            else
            {
                this.Streams = streams;
            }
            // to ensure "ownerAddress" is required (not null)
            if (ownerAddress == null)
            {
                throw new InvalidDataException("ownerAddress is a required property for Product and cannot be null");
            }
            else
            {
                this.OwnerAddress = ownerAddress;
            }
            // to ensure "beneficiaryAddress" is required (not null)
            if (beneficiaryAddress == null)
            {
                throw new InvalidDataException("beneficiaryAddress is a required property for Product and cannot be null");
            }
            else
            {
                this.BeneficiaryAddress = beneficiaryAddress;
            }
            // to ensure "pricePerSecond" is required (not null)
            if (pricePerSecond == null)
            {
                throw new InvalidDataException("pricePerSecond is a required property for Product and cannot be null");
            }
            else
            {
                this.PricePerSecond = pricePerSecond;
            }
            // to ensure "priceCurrency" is required (not null)
            if (priceCurrency == null)
            {
                throw new InvalidDataException("priceCurrency is a required property for Product and cannot be null");
            }
            else
            {
                this.PriceCurrency = priceCurrency;
            }
            // to ensure "minimumSubscriptionInSeconds" is required (not null)
            if (minimumSubscriptionInSeconds == null)
            {
                throw new InvalidDataException("minimumSubscriptionInSeconds is a required property for Product and cannot be null");
            }
            else
            {
                this.MinimumSubscriptionInSeconds = minimumSubscriptionInSeconds;
            }
            this.PreviewStream = previewStream;
            this.PreviewConfigJson = previewConfigJson;
            this.PendingChanges = pendingChanges;
            this.Contact = contact;
            this.TermsOfUse = termsOfUse;
        }
        
        /// <summary>
        /// unique identifier
        /// </summary>
        /// <value>unique identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// ISO-8601 datetime
        /// </summary>
        /// <value>ISO-8601 datetime</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// ISO-8601 datetime
        /// </summary>
        /// <value>ISO-8601 datetime</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public string Updated { get; set; }

        /// <summary>
        /// Username of the creator of this Product
        /// </summary>
        /// <value>Username of the creator of this Product</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// URL of image
        /// </summary>
        /// <value>URL of image</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL of thumbnail image
        /// </summary>
        /// <value>URL of thumbnail image</value>
        [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// identifier of Category this Product belong to
        /// </summary>
        /// <value>identifier of Category this Product belong to</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// List of Stream identifiers that belong to this Product
        /// </summary>
        /// <value>List of Stream identifiers that belong to this Product</value>
        [DataMember(Name="streams", EmitDefaultValue=false)]
        public List<string> Streams { get; set; }

        /// <summary>
        /// Identifier of Stream selected for preview
        /// </summary>
        /// <value>Identifier of Stream selected for preview</value>
        [DataMember(Name="previewStream", EmitDefaultValue=false)]
        public string PreviewStream { get; set; }

        /// <summary>
        /// Configuration of previewStream
        /// </summary>
        /// <value>Configuration of previewStream</value>
        [DataMember(Name="previewConfigJson", EmitDefaultValue=false)]
        public string PreviewConfigJson { get; set; }

        /// <summary>
        /// Ethereum address of owner
        /// </summary>
        /// <value>Ethereum address of owner</value>
        [DataMember(Name="ownerAddress", EmitDefaultValue=false)]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// Ethereum address of beneficiary
        /// </summary>
        /// <value>Ethereum address of beneficiary</value>
        [DataMember(Name="beneficiaryAddress", EmitDefaultValue=false)]
        public string BeneficiaryAddress { get; set; }

        /// <summary>
        /// Unit cost per second
        /// </summary>
        /// <value>Unit cost per second</value>
        [DataMember(Name="pricePerSecond", EmitDefaultValue=false)]
        public int? PricePerSecond { get; set; }


        /// <summary>
        /// Minimum subscription length (in seconds)
        /// </summary>
        /// <value>Minimum subscription length (in seconds)</value>
        [DataMember(Name="minimumSubscriptionInSeconds", EmitDefaultValue=false)]
        public int? MinimumSubscriptionInSeconds { get; set; }

        /// <summary>
        /// Pending changes that are not published to blockchain
        /// </summary>
        /// <value>Pending changes that are not published to blockchain</value>
        [DataMember(Name="pendingChanges", EmitDefaultValue=false)]
        public string PendingChanges { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ProductContact Contact { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfUse
        /// </summary>
        [DataMember(Name="termsOfUse", EmitDefaultValue=false)]
        public ProductTermsOfUse TermsOfUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Streams: ").Append(Streams).Append("\n");
            sb.Append("  PreviewStream: ").Append(PreviewStream).Append("\n");
            sb.Append("  PreviewConfigJson: ").Append(PreviewConfigJson).Append("\n");
            sb.Append("  OwnerAddress: ").Append(OwnerAddress).Append("\n");
            sb.Append("  BeneficiaryAddress: ").Append(BeneficiaryAddress).Append("\n");
            sb.Append("  PricePerSecond: ").Append(PricePerSecond).Append("\n");
            sb.Append("  PriceCurrency: ").Append(PriceCurrency).Append("\n");
            sb.Append("  MinimumSubscriptionInSeconds: ").Append(MinimumSubscriptionInSeconds).Append("\n");
            sb.Append("  PendingChanges: ").Append(PendingChanges).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  TermsOfUse: ").Append(TermsOfUse).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.ThumbnailUrl == input.ThumbnailUrl ||
                    (this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(input.ThumbnailUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Streams == input.Streams ||
                    this.Streams != null &&
                    this.Streams.SequenceEqual(input.Streams)
                ) && 
                (
                    this.PreviewStream == input.PreviewStream ||
                    (this.PreviewStream != null &&
                    this.PreviewStream.Equals(input.PreviewStream))
                ) && 
                (
                    this.PreviewConfigJson == input.PreviewConfigJson ||
                    (this.PreviewConfigJson != null &&
                    this.PreviewConfigJson.Equals(input.PreviewConfigJson))
                ) && 
                (
                    this.OwnerAddress == input.OwnerAddress ||
                    (this.OwnerAddress != null &&
                    this.OwnerAddress.Equals(input.OwnerAddress))
                ) && 
                (
                    this.BeneficiaryAddress == input.BeneficiaryAddress ||
                    (this.BeneficiaryAddress != null &&
                    this.BeneficiaryAddress.Equals(input.BeneficiaryAddress))
                ) && 
                (
                    this.PricePerSecond == input.PricePerSecond ||
                    (this.PricePerSecond != null &&
                    this.PricePerSecond.Equals(input.PricePerSecond))
                ) && 
                (
                    this.PriceCurrency == input.PriceCurrency ||
                    (this.PriceCurrency != null &&
                    this.PriceCurrency.Equals(input.PriceCurrency))
                ) && 
                (
                    this.MinimumSubscriptionInSeconds == input.MinimumSubscriptionInSeconds ||
                    (this.MinimumSubscriptionInSeconds != null &&
                    this.MinimumSubscriptionInSeconds.Equals(input.MinimumSubscriptionInSeconds))
                ) && 
                (
                    this.PendingChanges == input.PendingChanges ||
                    (this.PendingChanges != null &&
                    this.PendingChanges.Equals(input.PendingChanges))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.TermsOfUse == input.TermsOfUse ||
                    (this.TermsOfUse != null &&
                    this.TermsOfUse.Equals(input.TermsOfUse))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Streams != null)
                    hashCode = hashCode * 59 + this.Streams.GetHashCode();
                if (this.PreviewStream != null)
                    hashCode = hashCode * 59 + this.PreviewStream.GetHashCode();
                if (this.PreviewConfigJson != null)
                    hashCode = hashCode * 59 + this.PreviewConfigJson.GetHashCode();
                if (this.OwnerAddress != null)
                    hashCode = hashCode * 59 + this.OwnerAddress.GetHashCode();
                if (this.BeneficiaryAddress != null)
                    hashCode = hashCode * 59 + this.BeneficiaryAddress.GetHashCode();
                if (this.PricePerSecond != null)
                    hashCode = hashCode * 59 + this.PricePerSecond.GetHashCode();
                if (this.PriceCurrency != null)
                    hashCode = hashCode * 59 + this.PriceCurrency.GetHashCode();
                if (this.MinimumSubscriptionInSeconds != null)
                    hashCode = hashCode * 59 + this.MinimumSubscriptionInSeconds.GetHashCode();
                if (this.PendingChanges != null)
                    hashCode = hashCode * 59 + this.PendingChanges.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.TermsOfUse != null)
                    hashCode = hashCode * 59 + this.TermsOfUse.GetHashCode();
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