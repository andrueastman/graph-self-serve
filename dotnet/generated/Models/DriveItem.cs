// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace CustomGraph.Client.Models {
    public class DriveItem : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Read-only. Only on OneDrive Personal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Audio? Audio { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Audio Audio { get; set; }
#endif
        /// <summary>Bundle metadata, if the item is a bundle. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Bundle? Bundle { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Bundle Bundle { get; set; }
#endif
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Children { get; set; }
#nullable restore
#else
        public List<DriveItem> Children { get; set; }
#endif
        /// <summary>The content stream, if the item represents a file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content { get; set; }
#nullable restore
#else
        public byte[] Content { get; set; }
#endif
        /// <summary>An eTag for the content of the item. This eTag isn&apos;t changed if only the metadata is changed. Note This property isn&apos;t returned if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CTag { get; set; }
#nullable restore
#else
        public string CTag { get; set; }
#endif
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Deleted? Deleted { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Deleted Deleted { get; set; }
#endif
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FileObject? File { get; set; }
#nullable restore
#else
        public FileObject File { get; set; }
#endif
        /// <summary>File system information on client. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.FileSystemInfo? FileSystemInfo { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.FileSystemInfo FileSystemInfo { get; set; }
#endif
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Folder? Folder { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Folder Folder { get; set; }
#endif
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Image? Image { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Image Image { get; set; }
#endif
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.ListItem? ListItem { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.ListItem ListItem { get; set; }
#endif
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GeoCoordinates? Location { get; set; }
#nullable restore
#else
        public GeoCoordinates Location { get; set; }
#endif
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Malware? Malware { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Malware Malware { get; set; }
#endif
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Package? Package { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Package Package { get; set; }
#endif
        /// <summary>If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.PendingOperations? PendingOperations { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.PendingOperations PendingOperations { get; set; }
#endif
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? Permissions { get; set; }
#nullable restore
#else
        public List<Permission> Permissions { get; set; }
#endif
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Photo? Photo { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Photo Photo { get; set; }
#endif
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property isn&apos;t returned by default. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicationFacet? Publication { get; set; }
#nullable restore
#else
        public PublicationFacet Publication { get; set; }
#endif
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.RemoteItem? RemoteItem { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.RemoteItem RemoteItem { get; set; }
#endif
        /// <summary>Information about retention label and settings enforced on the driveItem. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemRetentionLabel? RetentionLabel { get; set; }
#nullable restore
#else
        public ItemRetentionLabel RetentionLabel { get; set; }
#endif
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Root? Root { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Root Root { get; set; }
#endif
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.SearchResult? SearchResult { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.SearchResult SearchResult { get; set; }
#endif
        /// <summary>Indicates that the item was shared with others and provides information about the shared state of the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Shared? Shared { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Shared Shared { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.SpecialFolder? SpecialFolder { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.SpecialFolder SpecialFolder { get; set; }
#endif
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subscription>? Subscriptions { get; set; }
#nullable restore
#else
        public List<Subscription> Subscriptions { get; set; }
#endif
        /// <summary>Collection of [thumbnailSet][] objects associated with the item. For more information, see [getting thumbnails][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ThumbnailSet>? Thumbnails { get; set; }
#nullable restore
#else
        public List<ThumbnailSet> Thumbnails { get; set; }
#endif
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItemVersion>? Versions { get; set; }
#nullable restore
#else
        public List<DriveItemVersion> Versions { get; set; }
#endif
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Video? Video { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Video Video { get; set; }
#endif
        /// <summary>WebDAV compatible URL for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebDavUrl { get; set; }
#nullable restore
#else
        public string WebDavUrl { get; set; }
#endif
        /// <summary>For files that are Excel spreadsheets, access to the workbook API to work with the spreadsheet&apos;s contents. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomGraph.Client.Models.Workbook? Workbook { get; set; }
#nullable restore
#else
        public CustomGraph.Client.Models.Workbook Workbook { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DriveItem"/> and sets the default values.
        /// </summary>
        public DriveItem() : base() {
            OdataType = "#microsoft.graph.driveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DriveItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", n => { Audio = n.GetObjectValue<CustomGraph.Client.Models.Audio>(CustomGraph.Client.Models.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", n => { Bundle = n.GetObjectValue<CustomGraph.Client.Models.Bundle>(CustomGraph.Client.Models.Bundle.CreateFromDiscriminatorValue); } },
                {"cTag", n => { CTag = n.GetStringValue(); } },
                {"children", n => { Children = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<CustomGraph.Client.Models.Deleted>(CustomGraph.Client.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"file", n => { File = n.GetObjectValue<FileObject>(FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<CustomGraph.Client.Models.FileSystemInfo>(CustomGraph.Client.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { Folder = n.GetObjectValue<CustomGraph.Client.Models.Folder>(CustomGraph.Client.Models.Folder.CreateFromDiscriminatorValue); } },
                {"image", n => { Image = n.GetObjectValue<CustomGraph.Client.Models.Image>(CustomGraph.Client.Models.Image.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<CustomGraph.Client.Models.ListItem>(CustomGraph.Client.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"location", n => { Location = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", n => { Malware = n.GetObjectValue<CustomGraph.Client.Models.Malware>(CustomGraph.Client.Models.Malware.CreateFromDiscriminatorValue); } },
                {"package", n => { Package = n.GetObjectValue<CustomGraph.Client.Models.Package>(CustomGraph.Client.Models.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", n => { PendingOperations = n.GetObjectValue<CustomGraph.Client.Models.PendingOperations>(CustomGraph.Client.Models.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<CustomGraph.Client.Models.Photo>(CustomGraph.Client.Models.Photo.CreateFromDiscriminatorValue); } },
                {"publication", n => { Publication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", n => { RemoteItem = n.GetObjectValue<CustomGraph.Client.Models.RemoteItem>(CustomGraph.Client.Models.RemoteItem.CreateFromDiscriminatorValue); } },
                {"retentionLabel", n => { RetentionLabel = n.GetObjectValue<ItemRetentionLabel>(ItemRetentionLabel.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<CustomGraph.Client.Models.Root>(CustomGraph.Client.Models.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", n => { SearchResult = n.GetObjectValue<CustomGraph.Client.Models.SearchResult>(CustomGraph.Client.Models.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", n => { Shared = n.GetObjectValue<CustomGraph.Client.Models.Shared>(CustomGraph.Client.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<CustomGraph.Client.Models.SharepointIds>(CustomGraph.Client.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"specialFolder", n => { SpecialFolder = n.GetObjectValue<CustomGraph.Client.Models.SpecialFolder>(CustomGraph.Client.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue)?.ToList(); } },
                {"thumbnails", n => { Thumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"video", n => { Video = n.GetObjectValue<CustomGraph.Client.Models.Video>(CustomGraph.Client.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                {"workbook", n => { Workbook = n.GetObjectValue<CustomGraph.Client.Models.Workbook>(CustomGraph.Client.Models.Workbook.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<CustomGraph.Client.Models.Audio>("audio", Audio);
            writer.WriteObjectValue<CustomGraph.Client.Models.Bundle>("bundle", Bundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", Children);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("cTag", CTag);
            writer.WriteObjectValue<CustomGraph.Client.Models.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<FileObject>("file", File);
            writer.WriteObjectValue<CustomGraph.Client.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<CustomGraph.Client.Models.Folder>("folder", Folder);
            writer.WriteObjectValue<CustomGraph.Client.Models.Image>("image", Image);
            writer.WriteObjectValue<CustomGraph.Client.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", Location);
            writer.WriteObjectValue<CustomGraph.Client.Models.Malware>("malware", Malware);
            writer.WriteObjectValue<CustomGraph.Client.Models.Package>("package", Package);
            writer.WriteObjectValue<CustomGraph.Client.Models.PendingOperations>("pendingOperations", PendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<CustomGraph.Client.Models.Photo>("photo", Photo);
            writer.WriteObjectValue<PublicationFacet>("publication", Publication);
            writer.WriteObjectValue<CustomGraph.Client.Models.RemoteItem>("remoteItem", RemoteItem);
            writer.WriteObjectValue<ItemRetentionLabel>("retentionLabel", RetentionLabel);
            writer.WriteObjectValue<CustomGraph.Client.Models.Root>("root", Root);
            writer.WriteObjectValue<CustomGraph.Client.Models.SearchResult>("searchResult", SearchResult);
            writer.WriteObjectValue<CustomGraph.Client.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<CustomGraph.Client.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<CustomGraph.Client.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", Thumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", Versions);
            writer.WriteObjectValue<CustomGraph.Client.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteObjectValue<CustomGraph.Client.Models.Workbook>("workbook", Workbook);
        }
    }
}
