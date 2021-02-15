using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Employee
    {
        public int EmployeeId { get; set; }
        [Required,Range(10,50)]
        public string EmployeeName { get; set; }
        [Required, Range(5, 20)]
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
    }
}
