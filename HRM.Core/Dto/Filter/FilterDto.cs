using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core.Dto.Filter
{
    public class FilterDto
    {
        public string? CodeOrName { get; set; }
        public string? PositionId { get; set; }
        public string? UnitId { get; set; }
        public Gender? Gender { get; set; }
        public ContractType? ContractType { get; set; }
        public WorkType? WorkType { get; set; }
        public int? Limit { get; set; }
        public int? Offset { get; set; }
        
    }
}
