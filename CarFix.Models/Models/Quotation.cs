using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        VehicleId = vehicle;
    }
    [Key] public int Id { get; set; }
    public ICollection<FixService> services { get; set; }
    public Vehicle VehicleId { get; set; }
    public DateTime? StartJob { get; set; }
    public DateTime? EndJob { get; set; }
    public decimal TotalPrice => services.Sum(s => s.Price);

}
