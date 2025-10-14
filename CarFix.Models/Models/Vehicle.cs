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
        User = user;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public int Id { get; }
    public string? Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public User User { get; set; }
    public int Ano { get; set; }
}
