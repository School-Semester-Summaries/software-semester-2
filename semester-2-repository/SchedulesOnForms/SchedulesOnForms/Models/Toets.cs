using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulesOnForms.Models
{
    public enum Schoolvakken
    {
        Wiskunde, 
        Natuurkunde, 
        Scheikunde,
        Nederlands,
        Engels
    }
    public class Toets
    {
        // Constructors
        public Toets()
        {

        }
        public Toets(int weging, string name, string schoolvak)
        {
            Weging = weging;
            Name = name;
            Schoolvak = SchoolvakDefiniëren(schoolvak);

            toetsCollection.AlleToetsen.Add(this);

            foreach (Account student in accountCollection.StudentList)
            {
                student.ToetsLijst.Add(this);
            }
        }

        // Fields
        ToetsCollection toetsCollection = new ToetsCollection();
        AccountCollection accountCollection = new AccountCollection();

        // Properties
        public int Weging { get; private set; }
        public string Name { get; private set; }
        public Schoolvakken Schoolvak { get; private set; }
        public decimal Cijfer { get; private set; }

        // Methods
        public Schoolvakken SchoolvakDefiniëren(string schoolvak)
        {
            if (schoolvak == Schoolvakken.Wiskunde.ToString())
            {
                return Schoolvakken.Wiskunde;
            }
            else if (schoolvak == Schoolvakken.Natuurkunde.ToString())
            {
                return Schoolvakken.Natuurkunde;
            }
            else if (schoolvak == Schoolvakken.Scheikunde.ToString())
            {
                return Schoolvakken.Scheikunde;
            }
            else if (schoolvak == Schoolvakken.Nederlands.ToString())
            {
                return Schoolvakken.Nederlands;
            }
            else
            {
                return Schoolvakken.Engels;
            }
        }
        public void AddCijfer(decimal cijfer)
        {
            Cijfer = cijfer;
        }
    }
}
