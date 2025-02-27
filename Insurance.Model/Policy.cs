using Insurance.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Model
{
   public record Policy
    {
        public int Id { get; set; }
        public int CustomerId  { get; set; }
        public string PolicyType { get; set; } 
        public string PolicyName { get; set; }
        public PolicyStatusEnum Status { get; set; } =PolicyStatusEnum.Initial;
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set;}

    }
}
