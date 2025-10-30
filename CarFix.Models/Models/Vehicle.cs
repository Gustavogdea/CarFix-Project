using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix.Models.Models;

public class Vehicle
{
    public Vehicle(int id, string? placa, User user, string marca, string modelo, int ano)
    {
        Id = id;
        Placa = placa;
        UserId = user;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    [Key] public int Id { get; set; }
    public string? Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public User UserId { get; set; }
    public int Ano { get; set; }
}
