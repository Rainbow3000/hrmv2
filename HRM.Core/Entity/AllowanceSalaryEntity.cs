﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class AllowanceSalaryEntity:BaseEntity
    {
        [Key]
        public Guid AllowanceSalaryId { get; set; }
        public Guid EmployeeId { get; set; }
        public string? AllowanceName { get; set; }
        public double? Value { get; set; }
        public EmployeeEntity Employee { get; set; }

    }
}
