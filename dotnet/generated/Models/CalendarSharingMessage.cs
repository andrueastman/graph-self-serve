// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class CalendarSharingMessage : Message, IParsable {
        /// <summary>The canAccept property</summary>
        public bool? CanAccept { get; set; }
        /// <summary>The sharingMessageAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CalendarSharingMessageAction? SharingMessageAction { get; set; }
#nullable restore
#else
        public CalendarSharingMessageAction SharingMessageAction { get; set; }
#endif
        /// <summary>The sharingMessageActions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarSharingMessageAction>? SharingMessageActions { get; set; }
#nullable restore
#else
        public List<CalendarSharingMessageAction> SharingMessageActions { get; set; }
#endif
        /// <summary>The suggestedCalendarName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestedCalendarName { get; set; }
#nullable restore
#else
        public string SuggestedCalendarName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CalendarSharingMessage"/> and sets the default values.
        /// </summary>
        public CalendarSharingMessage() : base() {
            OdataType = "#microsoft.graph.calendarSharingMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CalendarSharingMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CalendarSharingMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarSharingMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"canAccept", n => { CanAccept = n.GetBoolValue(); } },
                {"sharingMessageAction", n => { SharingMessageAction = n.GetObjectValue<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue); } },
                {"sharingMessageActions", n => { SharingMessageActions = n.GetCollectionOfObjectValues<CalendarSharingMessageAction>(CalendarSharingMessageAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"suggestedCalendarName", n => { SuggestedCalendarName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("canAccept", CanAccept);
            writer.WriteObjectValue<CalendarSharingMessageAction>("sharingMessageAction", SharingMessageAction);
            writer.WriteCollectionOfObjectValues<CalendarSharingMessageAction>("sharingMessageActions", SharingMessageActions);
            writer.WriteStringValue("suggestedCalendarName", SuggestedCalendarName);
        }
    }
}