// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models.Security {
    public class SslCertificate : Artifact, IParsable {
        /// <summary>The date and time when a certificate expires. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>A hash of the certificate calculated on the data and signature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fingerprint { get; set; }
#nullable restore
#else
        public string Fingerprint { get; set; }
#endif
        /// <summary>The first date and time when this sslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The date and time when a certificate was issued. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? IssueDateTime { get; set; }
        /// <summary>The entity that grants this certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SslCertificateEntity? Issuer { get; set; }
#nullable restore
#else
        public SslCertificateEntity Issuer { get; set; }
#endif
        /// <summary>The most recent date and time when this sslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The hosts related with this sslCertificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Host>? RelatedHosts { get; set; }
#nullable restore
#else
        public List<Host> RelatedHosts { get; set; }
#endif
        /// <summary>The serial number associated with an SSL certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>A SHA-1 hash of the certificate. Note: This is not the signature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1 { get; set; }
#nullable restore
#else
        public string Sha1 { get; set; }
#endif
        /// <summary>The person, site, machine, and so on, this certificate is for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SslCertificateEntity? Subject { get; set; }
#nullable restore
#else
        public SslCertificateEntity Subject { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SslCertificate"/> and sets the default values.
        /// </summary>
        public SslCertificate() : base() {
            OdataType = "#microsoft.graph.security.sslCertificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SslCertificate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SslCertificate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SslCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"issueDateTime", n => { IssueDateTime = n.GetDateTimeOffsetValue(); } },
                {"issuer", n => { Issuer = n.GetObjectValue<SslCertificateEntity>(SslCertificateEntity.CreateFromDiscriminatorValue); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"relatedHosts", n => { RelatedHosts = n.GetCollectionOfObjectValues<Host>(Host.CreateFromDiscriminatorValue)?.ToList(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"sha1", n => { Sha1 = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetObjectValue<SslCertificateEntity>(SslCertificateEntity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("issueDateTime", IssueDateTime);
            writer.WriteObjectValue<SslCertificateEntity>("issuer", Issuer);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<Host>("relatedHosts", RelatedHosts);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("sha1", Sha1);
            writer.WriteObjectValue<SslCertificateEntity>("subject", Subject);
        }
    }
}
