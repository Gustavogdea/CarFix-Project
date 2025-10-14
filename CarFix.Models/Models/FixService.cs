using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarFix.Models.Models
{
    public class FixService
    {
        public FixService(int id, string title, string description, decimal price)
        {
            this.id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public int id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartService { get; set; }
        public DateTime EndService { get; set; }
        public string Status { get; set; } //Terá os seguintes status: Em Andamento, Rejeitado Pelo Cliente, Finalizado, Pendente
        public decimal Price { get; set; }
    }
}
