using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrLeaveManagement.Application.DTOs.LeaveType.validators
{
    public class LeaveTypeCustomValidation : ValidationAttribute
    {
        readonly string allowedDomain;
        public LeaveTypeCustomValidation(string domain)
        {
            allowedDomain = domain;
        }

        public bool IsValid(int? value)
        { 
            return value < 5 && value > 2;
        }
    }
}

