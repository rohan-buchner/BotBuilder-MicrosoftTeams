// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Compose extension response
    /// </summary>
    public partial class ComposeExtensionResponse
    {
        /// <summary>
        /// Initializes a new instance of the ComposeExtensionResponse class.
        /// </summary>
        public ComposeExtensionResponse() { }

        /// <summary>
        /// Initializes a new instance of the ComposeExtensionResponse class.
        /// </summary>
        public ComposeExtensionResponse(ComposeExtensionResult composeExtension = default(ComposeExtensionResult))
        {
            ComposeExtension = composeExtension;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "composeExtension")]
        public ComposeExtensionResult ComposeExtension { get; set; }

    }
}
