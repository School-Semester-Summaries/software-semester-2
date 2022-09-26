using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulesOnForms.Models
{
    class AccountCollection
    {
        // Field
        static List<Account> accountList = new List<Account>();
        static List<Account> studentList = new List<Account>();

        // Properties
        public List<Account> AccountList { get { return accountList; } }
        public List<Account> StudentList { get { return studentList; } }
    }
}
