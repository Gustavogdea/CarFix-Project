using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CarFix.Models.Models;

public class Quotation
{
    public Quotation(int id, ICollection<FixService> services, Vehicle vehicle)
    {
        Id = id;
        this.services = services;
        Vehicle = vehicle;
    }

    public int Id { get; }
    public ICollection<FixService> services { get; set; }
    public Vehicle Vehicle { get; set; }
    public DateTime? StartJob { get; set; }
    public DateTime? EndJob { get; set; }
    public decimal TotalPrice => services.Sum(s => s.Price);

}
