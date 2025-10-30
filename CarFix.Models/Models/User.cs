using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix.Models.Models;

public class User
{
    public User(int id, string name, string email, string senha, string phone, string cellPhone, bool administrator)
    {
        Id = id;
        Name = name;
        Email = email;
        Senha = senha;
        Phone = phone;
        CellPhone = cellPhone;
        Administrator = administrator;  
    }

    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Phone { get; set; }
    public string CellPhone { get; set; }
    public bool Administrator { get; set; }
}
