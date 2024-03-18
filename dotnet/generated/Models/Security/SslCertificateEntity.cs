// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models.Security {
    public class SslCertificateEntity : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A physical address of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.PhysicalAddress? Address { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.PhysicalAddress Address { get; set; }
#endif
        /// <summary>Alternate names for this entity that are part of the certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlternateNames { get; set; }
#nullable restore
#else
        public List<string> AlternateNames { get; set; }
#endif
        /// <summary>A common name for this entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommonName { get; set; }
#nullable restore
#else
        public string CommonName { get; set; }
#endif
        /// <summary>An email for this entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>If the entity is a person, this is the person&apos;s given name (first name).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName { get; set; }
#nullable restore
#else
        public string GivenName { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>If the entity is an organization, this is the name of the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName { get; set; }
#nullable restore
#else
        public string OrganizationName { get; set; }
#endif
        /// <summary>If the entity is an organization, this communicates if a unit in the organization is named on the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationUnitName { get; set; }
#nullable restore
#else
        public string OrganizationUnitName { get; set; }
#endif
        /// <summary>A serial number assigned to the entity; usually only available if the entity is the issuer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>If the entity is a person, this is the person&apos;s surname (last name).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname { get; set; }
#nullable restore
#else
        public string Surname { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SslCertificateEntity"/> and sets the default values.
        /// </summary>
        public SslCertificateEntity() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SslCertificateEntity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SslCertificateEntity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SslCertificateEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<CustomGraph.Client.Models.PhysicalAddress>(CustomGraph.Client.Models.PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"alternateNames", n => { AlternateNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"commonName", n => { CommonName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"organizationUnitName", n => { OrganizationUnitName = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CustomGraph.Client.Models.PhysicalAddress>("address", Address);
            writer.WriteCollectionOfPrimitiveValues<string>("alternateNames", AlternateNames);
            writer.WriteStringValue("commonName", CommonName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteStringValue("organizationUnitName", OrganizationUnitName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("surname", Surname);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
