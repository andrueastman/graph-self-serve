// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class EndUserNotification : Entity, IParsable {
        /// <summary>Identity of the user who created the notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public EmailIdentity CreatedBy { get; set; }
#endif
        /// <summary>Date and time when the notification was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the notification as defined by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EndUserNotificationDetail>? Details { get; set; }
#nullable restore
#else
        public List<EndUserNotificationDetail> Details { get; set; }
#endif
        /// <summary>Name of the notification as defined by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Identity of the user who last modified the notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? LastModifiedBy { get; set; }
#nullable restore
#else
        public EmailIdentity LastModifiedBy { get; set; }
#endif
        /// <summary>Date and time when the notification was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Type of notification. Possible values are: unknown, positiveReinforcement, noTraining, trainingAssignment, trainingReminder, unknownFutureValue.</summary>
        public EndUserNotificationType? NotificationType { get; set; }
        /// <summary>The source of the content. Possible values are: unknown, global, tenant, unknownFutureValue.</summary>
        public SimulationContentSource? Source { get; set; }
        /// <summary>The status of the notification. Possible values are: unknown, draft, ready, archive, delete, unknownFutureValue.</summary>
        public SimulationContentStatus? Status { get; set; }
        /// <summary>Supported locales for endUserNotification content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedLocales { get; set; }
#nullable restore
#else
        public List<string> SupportedLocales { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EndUserNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EndUserNotification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EndUserNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfObjectValues<EndUserNotificationDetail>(EndUserNotificationDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notificationType", n => { NotificationType = n.GetEnumValue<EndUserNotificationType>(); } },
                {"source", n => { Source = n.GetEnumValue<SimulationContentSource>(); } },
                {"status", n => { Status = n.GetEnumValue<SimulationContentStatus>(); } },
                {"supportedLocales", n => { SupportedLocales = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<EndUserNotificationDetail>("details", Details);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<EndUserNotificationType>("notificationType", NotificationType);
            writer.WriteEnumValue<SimulationContentSource>("source", Source);
            writer.WriteEnumValue<SimulationContentStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedLocales", SupportedLocales);
        }
    }
}
