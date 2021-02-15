using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        public IList<Employee> Employees { get; set; }
    }
}
