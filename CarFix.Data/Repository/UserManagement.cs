using CarFix.Data.Data;
using CarFix.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix.Data.Repository;

public class UserManagement
{
    private readonly CarFixContext _context;
    public UserManagement(CarFixContext context)
    {
        _context = context;
    }

    public void AddProfile(User User)
    {
        _context.Add(User);
        _context.SaveChanges(); 
    }

    public void UpdateProfile(User User) 
    {
        _context.Update(User);
        _context.SaveChanges();
    }

    public void DeleteProfile(User user)
    {
        _context.Remove(user);
        _context.SaveChanges();
    }

    public IEnumerable listar()
    {
        return _context.Set<User>().ToList();
    }
}
