// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class CustomTimeZone : TimeZoneBase, IParsable {
        /// <summary>The time offset of the time zone from Coordinated Universal Time (UTC). This value is in minutes. Time zones that are ahead of UTC have a positive offset; time zones that are behind UTC have a negative offset.</summary>
        public int? Bias { get; set; }
        /// <summary>Specifies when the time zone switches from standard time to daylight saving time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DaylightTimeZoneOffset? DaylightOffset { get; set; }
#nullable restore
#else
        public DaylightTimeZoneOffset DaylightOffset { get; set; }
#endif
        /// <summary>Specifies when the time zone switches from daylight saving time to standard time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public StandardTimeZoneOffset? StandardOffset { get; set; }
#nullable restore
#else
        public StandardTimeZoneOffset StandardOffset { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CustomTimeZone"/> and sets the default values.
        /// </summary>
        public CustomTimeZone() : base() {
            OdataType = "#microsoft.graph.customTimeZone";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomTimeZone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomTimeZone CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomTimeZone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bias", n => { Bias = n.GetIntValue(); } },
                {"daylightOffset", n => { DaylightOffset = n.GetObjectValue<DaylightTimeZoneOffset>(DaylightTimeZoneOffset.CreateFromDiscriminatorValue); } },
                {"standardOffset", n => { StandardOffset = n.GetObjectValue<StandardTimeZoneOffset>(StandardTimeZoneOffset.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("bias", Bias);
            writer.WriteObjectValue<DaylightTimeZoneOffset>("daylightOffset", DaylightOffset);
            writer.WriteObjectValue<StandardTimeZoneOffset>("standardOffset", StandardOffset);
        }
    }
}
