using System.Text.Json.Serialization;

namespace Toltech.Cad.Model
{
    /// <summary>
    /// Point 3D provenant d'un logiciel de CAO.
    /// </summary>
    public class CadPoint
    {
        [JsonPropertyName("x")]
        public double X { get; set; }
        [JsonPropertyName("y")]
        public double Y { get; set; }
        [JsonPropertyName("z")]
        public double Z { get; set; }
    }
    public class CadDirection
    {
        [JsonPropertyName("u")]
        public double U { get; set; }
        [JsonPropertyName("v")]
        public double V { get; set; }
        [JsonPropertyName("w")]
        public double W { get; set; }
    }

  

}