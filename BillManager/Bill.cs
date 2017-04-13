using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager
{
    //sadfasdf23212121212
    public class Bill
    {
        #region Propertys
        public string PersonsName { get; set; }

        public string BillName { get; set; }

        public double WeeklyCost { get; set; }

        public DateTime PaymentDate { get; set; }
        #endregion

        #region Constructor
        public Bill(string _BillName,string _PersonName,double _cost,DateTime _PaymentDate)
                {

                    BillName = _BillName;
                    PersonsName = _PersonName;
                    WeeklyCost = _cost;
                    PaymentDate = _PaymentDate;
                }
        #endregion
        
    }
}
