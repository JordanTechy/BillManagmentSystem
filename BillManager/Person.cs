using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager
{
    class Person
    {

        List<Bill> Personsbillslist = new List<Bill>();

        public string _name { get; set; }

        public decimal income { get; set; }

        Person(string name,decimal income, List<Bill> listOfBills)
        {

        }


    }
}
