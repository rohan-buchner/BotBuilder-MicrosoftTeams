// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// File info card.
    /// </summary>
    public partial class FileInfoCard
    {
        /// <summary>
        /// Initializes a new instance of the FileInfoCard class.
        /// </summary>
        public FileInfoCard() { }

        /// <summary>
        /// Initializes a new instance of the FileInfoCard class.
        /// </summary>
        /// <param name="uniqueId">Unique Id for the file.</param>
        /// <param name="fileType">Type of file.</param>
        public FileInfoCard(string uniqueId = default(string), string fileType = default(string))
        {
            UniqueId = uniqueId;
            FileType = fileType;
        }

        /// <summary>
        /// Gets or sets unique Id for the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uniqueId")]
        public string UniqueId { get; set; }

        /// <summary>
        /// Gets or sets type of file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileType")]
        public string FileType { get; set; }

    }
}
