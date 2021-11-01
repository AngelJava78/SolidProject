using DependencyInjection.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Entities
{
    public class Payslip : IPrintable
    {
        public Payslip(int employeeId, decimal total)
        {
            EmployeeId = employeeId;
            Total = total;
        }
        public int EmployeeId { get; set; }
        public decimal Total { get; set; }

        public void Print()
        {
            Console.WriteLine($"Printing payslip: {EmployeeId}. Amount: {Total:c}");
        }
    }
}
