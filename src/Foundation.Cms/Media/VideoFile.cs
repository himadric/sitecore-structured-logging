using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Labs.ContentManager.Cards;
using EPiServer.Labs.ContentManager.Dashboard;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Cms.Media
{
    [ContentType(DisplayName = "Video File",
        GUID = "8a9d9d4b-cd4b-40e8-a777-414cfbda7770", 
        Description = "Used for video file types such as mp4, flv, webm")]
    [MediaDescriptor(ExtensionString = "mp4,flv,webm")]
    public class VideoFile : VideoData, IDashboardItem
    {
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public virtual string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the URL to the preview image.
        /// </summary>
        [UIHint(UIHint.Image)]
        public virtual ContentReference PreviewImage { get; set; }

        [Editable(false)]
        public virtual string FileSize { get; set; }

        public void SetItem(ItemModel itemModel)
        {
            itemModel.Description = Copyright;
            itemModel.Image = PreviewImage;
        }
    }
}