// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class EducationFeedbackResourceOutcome : EducationOutcome, IParsable {
        /// <summary>The actual feedback resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationResource? FeedbackResource { get; set; }
#nullable restore
#else
        public EducationResource FeedbackResource { get; set; }
#endif
        /// <summary>The status of the feedback resource. The possible values are: notPublished, pendingPublish, published, failedPublish, unknownFutureValue.</summary>
        public EducationFeedbackResourceOutcomeStatus? ResourceStatus { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="EducationFeedbackResourceOutcome"/> and sets the default values.
        /// </summary>
        public EducationFeedbackResourceOutcome() : base() {
            OdataType = "#microsoft.graph.educationFeedbackResourceOutcome";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationFeedbackResourceOutcome"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationFeedbackResourceOutcome CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationFeedbackResourceOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"feedbackResource", n => { FeedbackResource = n.GetObjectValue<EducationResource>(EducationResource.CreateFromDiscriminatorValue); } },
                {"resourceStatus", n => { ResourceStatus = n.GetEnumValue<EducationFeedbackResourceOutcomeStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationResource>("feedbackResource", FeedbackResource);
            writer.WriteEnumValue<EducationFeedbackResourceOutcomeStatus>("resourceStatus", ResourceStatus);
        }
    }
}
