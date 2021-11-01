using DependencyInjection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Framework
{
    public class Printer
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
