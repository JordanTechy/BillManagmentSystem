using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager
{
    //sadfasdf
    public class Bill
        
    {
        public string PersonsName { get; set; }

        public string BillName { get; set; }

        public double WeeklyCost { get; set; }

        public DateTime PaymentDate { get; set; }
      
        public Bill(string _BillName,string _PersonName,double _cost,DateTime _PaymentDate)
        {

            this.BillName = _BillName;
            this.PersonsName = _PersonName;
            this.WeeklyCost = _cost;
            this.PaymentDate = _PaymentDate;
        }
    }
}
