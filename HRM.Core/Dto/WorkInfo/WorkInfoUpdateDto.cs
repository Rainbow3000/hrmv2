using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto.WorkInfo
{
    public class WorkInfoUpdateDto:BaseDto
    {
        public Guid WorkInfoId { get; set; }
        public Guid EmployeeId { get; set; }
        public string PositionId { get; set; }
        public string UnitId { get; set; }
        public string managerId { get; set; }
        public Enum.WorkStatus Status { get; set; }
        public Enum.ContractType ContractType { get; set; }
        public Enum.WorkType WorkType { get; set; }
        public string TimeKeeperCode { get; set; }
        public bool IsExemptTimeKeeper { get; set; }
        public string GoogleCalendarId { get; set; }
    }
}
