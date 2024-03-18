// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models.Security {
    public class NetworkConnectionEvidence : AlertEvidence, IParsable {
        /// <summary>The destinationAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? DestinationAddress { get; set; }
#nullable restore
#else
        public IpEvidence DestinationAddress { get; set; }
#endif
        /// <summary>The destinationPort property</summary>
        public int? DestinationPort { get; set; }
        /// <summary>The protocol property</summary>
        public ProtocolType? Protocol { get; set; }
        /// <summary>The sourceAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? SourceAddress { get; set; }
#nullable restore
#else
        public IpEvidence SourceAddress { get; set; }
#endif
        /// <summary>The sourcePort property</summary>
        public int? SourcePort { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="NetworkConnectionEvidence"/> and sets the default values.
        /// </summary>
        public NetworkConnectionEvidence() : base() {
            OdataType = "#microsoft.graph.security.networkConnectionEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NetworkConnectionEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NetworkConnectionEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkConnectionEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"destinationAddress", n => { DestinationAddress = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"destinationPort", n => { DestinationPort = n.GetIntValue(); } },
                {"protocol", n => { Protocol = n.GetEnumValue<ProtocolType>(); } },
                {"sourceAddress", n => { SourceAddress = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"sourcePort", n => { SourcePort = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IpEvidence>("destinationAddress", DestinationAddress);
            writer.WriteIntValue("destinationPort", DestinationPort);
            writer.WriteEnumValue<ProtocolType>("protocol", Protocol);
            writer.WriteObjectValue<IpEvidence>("sourceAddress", SourceAddress);
            writer.WriteIntValue("sourcePort", SourcePort);
        }
    }
}
