using DependencyInjection.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class Payslip 
    {
        public Payslip(int employeeId, decimal total)
        {
            EmployeeId = employeeId;
            Total = total;
        }
        public int EmployeeId { get; set; }
        public decimal Total { get; set; }
    }
}
