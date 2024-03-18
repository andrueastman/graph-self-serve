// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class CloudPcRestorePointSetting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The frequencyType property</summary>
        public CloudPcRestorePointFrequencyType? FrequencyType { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The userRestoreEnabled property</summary>
        public bool? UserRestoreEnabled { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CloudPcRestorePointSetting"/> and sets the default values.
        /// </summary>
        public CloudPcRestorePointSetting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcRestorePointSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcRestorePointSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcRestorePointSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"frequencyType", n => { FrequencyType = n.GetEnumValue<CloudPcRestorePointFrequencyType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"userRestoreEnabled", n => { UserRestoreEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CloudPcRestorePointFrequencyType>("frequencyType", FrequencyType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("userRestoreEnabled", UserRestoreEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
