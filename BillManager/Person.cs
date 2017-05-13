using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager
{
    class category
    {

        public bool _isPerson { get; set; }
        public string _name { get; set; }
        List<Bill> Categorybillslist = new List<Bill>();


        public decimal _income { get; set; }

        category(string name, bool isPerson = false, decimal income = 0)
        {

            _name = name;
            _isPerson = isPerson;  // use to check if catogory has income
            _income = income;


        }


    }
}
