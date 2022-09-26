using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulesOnForms.Models
{
    // Enums
    public enum Roles
    {
        Leerling,
        Docent
    }

    public class Account
    {
        // Constructor
        public Account(string username, string password, Roles role)
        {
            Username = username;
            Password = password;
            Role = role;
            accountCollection.AccountList.Add(this);

            if (Role == Roles.Leerling)
            {
                accountCollection.StudentList.Add(this);
            }
        }

        // Fields
        AccountCollection accountCollection = new AccountCollection();
        List<Toets> toetsLijst = new List<Toets>();
        // Properties
        public string Username { get; private set; }
        public string Password { get; private set; }
        public Roles Role { get; private set; }
        public List<Toets> ToetsLijst { get { return toetsLijst; } }

        // Methods
        public void AddCijfer(int nToets, decimal cijfer)
        {
            ToetsLijst[nToets].AddCijfer(cijfer);
        }
    }
}
