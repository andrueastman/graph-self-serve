// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models.ExternalConnectors {
    public class ExternalItem : CustomGraph.Client.Models.Entity, IParsable {
        /// <summary>An array of access control entries. Each entry specifies the access granted to a user or group. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomGraph.Client.Models.ExternalConnectors.Acl>? Acl { get; set; }
#nullable restore
#else
        public List<CustomGraph.Client.Models.ExternalConnectors.Acl> Acl { get; set; }
#endif
        /// <summary>Returns a list of activities performed on the item. Write-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExternalActivity>? Activities { get; set; }
#nullable restore
#else
        public List<ExternalActivity> Activities { get; set; }
#endif
        /// <summary>A plain-text  representation of the contents of the item. The text in this property is full-text indexed. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExternalItemContent? Content { get; set; }
#nullable restore
#else
        public ExternalItemContent Content { get; set; }
#endif
        /// <summary>A property bag with the properties of the item. The properties MUST conform to the schema defined for the externalConnection. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.ExternalConnectors.Properties? Properties { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.ExternalConnectors.Properties Properties { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternalItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acl", n => { Acl = n.GetCollectionOfObjectValues<CustomGraph.Client.Models.ExternalConnectors.Acl>(CustomGraph.Client.Models.ExternalConnectors.Acl.CreateFromDiscriminatorValue)?.ToList(); } },
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ExternalActivity>(ExternalActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetObjectValue<ExternalItemContent>(ExternalItemContent.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetObjectValue<CustomGraph.Client.Models.ExternalConnectors.Properties>(CustomGraph.Client.Models.ExternalConnectors.Properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CustomGraph.Client.Models.ExternalConnectors.Acl>("acl", Acl);
            writer.WriteCollectionOfObjectValues<ExternalActivity>("activities", Activities);
            writer.WriteObjectValue<ExternalItemContent>("content", Content);
            writer.WriteObjectValue<CustomGraph.Client.Models.ExternalConnectors.Properties>("properties", Properties);
        }
    }
}
