using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSustitution.Entities
{
    public abstract class Document
    {
        protected string acronym;
        protected Document(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Print()
        {
            return $"Printing: {GetDescription()}";
        }

        public virtual string GetDescription()
        {
            return $"{acronym}. Id: {Id}. Fecha: {Date:dd-MM-yyyy hh:mm:ss}";
        }
    }
}
