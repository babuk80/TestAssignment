using Insurance.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Insurance.Model
{
   public record Policy
    {
        [JsonPropertyName("id")]

        public int Id { get; set; }
        [JsonPropertyName("customerid")]

        public int CustomerId  { get; set; }
        [JsonPropertyName("policytype")]

        public string PolicyType { get; set; }
        [JsonPropertyName("policyname")]

        public string PolicyName { get; set; }
        [JsonPropertyName("status")]

        public PolicyStatusEnum Status { get; set; } =PolicyStatusEnum.Initial;
        [JsonPropertyName("startdate")]

        public DateTime? StartDate { get; set; }
        [JsonPropertyName("expirydate")]

        public DateTime? ExpiryDate { get; set;}
        [JsonPropertyName("premium")]

        public decimal? Premium { get; set; }

    }
}
