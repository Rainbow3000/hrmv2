using Core.Entity;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.WorkInfo
{
    public class WorkInfoCreateDto:BaseDto
    {
        public Guid WorkInfoId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? PositionId { get; set; }
        public string? UnitId { get; set; }
        public string? ManagerId { get; set; }
        public WorkStatus? Status { get; set; }
        public ContractType? ContractType { get; set; }
        public WorkType? WorkType { get; set; }
        public string? TimeKeeperCode { get; set; }
        public bool? IsExemptTimeKeeper { get; set; }
        public string? GoogleCalendarId { get; set; }
}
    }

