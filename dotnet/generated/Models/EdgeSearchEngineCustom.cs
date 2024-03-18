// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    /// <summary>
    /// Allows IT admins to set a custom default search engine for MDM-Controlled devices.
    /// </summary>
    public class EdgeSearchEngineCustom : EdgeSearchEngineBase, IParsable {
        /// <summary>Points to a https link containing the OpenSearch xml file that contains, at minimum, the short name and the URL to the search Engine.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeSearchEngineOpenSearchXmlUrl { get; set; }
#nullable restore
#else
        public string EdgeSearchEngineOpenSearchXmlUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EdgeSearchEngineCustom"/> and sets the default values.
        /// </summary>
        public EdgeSearchEngineCustom() : base() {
            OdataType = "#microsoft.graph.edgeSearchEngineCustom";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EdgeSearchEngineCustom"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdgeSearchEngineCustom CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdgeSearchEngineCustom();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"edgeSearchEngineOpenSearchXmlUrl", n => { EdgeSearchEngineOpenSearchXmlUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("edgeSearchEngineOpenSearchXmlUrl", EdgeSearchEngineOpenSearchXmlUrl);
        }
    }
}