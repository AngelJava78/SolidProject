using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Entities
{
    public abstract class Document
    {
        public Document(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public abstract void Print();

        public abstract void Send();
    }
}
