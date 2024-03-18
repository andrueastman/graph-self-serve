// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class SharedDriveItem : BaseItem, IParsable {
        /// <summary>Used to access the underlying driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.DriveItem? DriveItem { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.DriveItem DriveItem { get; set; }
#endif
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomGraph.Client.Models.DriveItem>? Items { get; set; }
#nullable restore
#else
        public List<CustomGraph.Client.Models.DriveItem> Items { get; set; }
#endif
        /// <summary>Used to access the underlying list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.List? List { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.List List { get; set; }
#endif
        /// <summary>Used to access the underlying listItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.ListItem? ListItem { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.ListItem ListItem { get; set; }
#endif
        /// <summary>Information about the owner of the shared item being referenced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Owner { get; set; }
#nullable restore
#else
        public IdentitySet Owner { get; set; }
#endif
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Permission? Permission { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Permission Permission { get; set; }
#endif
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.DriveItem? Root { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.DriveItem Root { get; set; }
#endif
        /// <summary>Used to access the underlying site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Site? Site { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Site Site { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SharedDriveItem"/> and sets the default values.
        /// </summary>
        public SharedDriveItem() : base() {
            OdataType = "#microsoft.graph.sharedDriveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SharedDriveItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"driveItem", n => { DriveItem = n.GetObjectValue<CustomGraph.Client.Models.DriveItem>(CustomGraph.Client.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<CustomGraph.Client.Models.DriveItem>(CustomGraph.Client.Models.DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"list", n => { List = n.GetObjectValue<CustomGraph.Client.Models.List>(CustomGraph.Client.Models.List.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<CustomGraph.Client.Models.ListItem>(CustomGraph.Client.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"permission", n => { Permission = n.GetObjectValue<CustomGraph.Client.Models.Permission>(CustomGraph.Client.Models.Permission.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<CustomGraph.Client.Models.DriveItem>(CustomGraph.Client.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"site", n => { Site = n.GetObjectValue<CustomGraph.Client.Models.Site>(CustomGraph.Client.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomGraph.Client.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<CustomGraph.Client.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<CustomGraph.Client.Models.List>("list", List);
            writer.WriteObjectValue<CustomGraph.Client.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<CustomGraph.Client.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<CustomGraph.Client.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<CustomGraph.Client.Models.Site>("site", Site);
        }
    }
}