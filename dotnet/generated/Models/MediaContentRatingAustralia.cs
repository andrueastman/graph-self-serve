// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class MediaContentRatingAustralia : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Movies rating labels in Australia</summary>
        public RatingAustraliaMoviesType? MovieRating { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>TV content rating labels in Australia</summary>
        public RatingAustraliaTelevisionType? TvRating { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="MediaContentRatingAustralia"/> and sets the default values.
        /// </summary>
        public MediaContentRatingAustralia() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MediaContentRatingAustralia"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MediaContentRatingAustralia CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingAustralia();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingAustraliaMoviesType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingAustraliaTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingAustraliaMoviesType>("movieRating", MovieRating);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RatingAustraliaTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
