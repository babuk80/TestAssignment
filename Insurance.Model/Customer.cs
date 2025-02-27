using System.Text.Json.Serialization;

namespace Insurance.Model
{
    public record Customer
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]

        public string Name { get; set; }
        [JsonPropertyName("email")]

        public string Email { get; set; }
        [JsonPropertyName("phone")]

        public string? Phone { get; set; }
        [JsonPropertyName("address")]

        public string? Address { get; set; }
        [JsonPropertyName("city")]

        public string? City { get; set; }
        [JsonPropertyName("state")]

        public string? State  { get; set; }
        [JsonPropertyName("postalcode")]

        public string PostalCode { get; set; }
        [JsonPropertyName("country")]

        public string Country { get; set; }  

    }
}
