using Delegete_part2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Enums;

namespace Delegete_part2.Models
{
    internal class User: IEntity
    {
        private static int _id;
        public int Id { get; }
        public string UsarName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        public User()
        {
            _id++;
            Id = _id; 
            Role = new Role();  

        }
        public void Showinfo()
        {
            Console.WriteLine($"Id:{Id}- UsarName:{UsarName}- Email{Email}- Role{Role}");
        }
    }
}
