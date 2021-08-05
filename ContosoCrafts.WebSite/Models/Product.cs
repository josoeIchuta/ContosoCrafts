using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public String Id { get; set; }
        public string Maker { get; set; }

        //Lo que hacemos es mapear Image a img, como esta el archivo Json
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        //Con esto Serializamos los datos JSON del archivo product.json
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
