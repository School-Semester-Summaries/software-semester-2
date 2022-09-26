using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlankoMundo.Models
{
    public enum Roles
    {
        user,
        admin
    }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Roles roles { get; set; }
    }
}
