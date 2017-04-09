using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManager
{
    class LinqTry
    {

        public IEnumerable<IGrouping<string,Bill>> getlinq(List<Bill> _LBill)
        {

            var billslist = _LBill;
/*
            billslist.Add(new Bill("food", "jacqui", 10, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill("rent", "jordan", 20, DateTime.Now));
            billslist.Add(new Bill("dog", "jacqui", 56, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill("school", "jordan", 12, DateTime.Now));
            billslist.Add(new Bill("car", "jacqui", 34, DateTime.Now.AddDays(3)));
*/
            var result = from p in billslist
                         orderby p.PersonsName
                         group p by p.PersonsName;
                         
            
           return result;



        }

    }
    
  


}
/*
 *  orderby p.WeeklyCost
                         select p;
 * 
 * where p.WeeklyCost < 15
                         select p;
 * //textBox1.AppendText(item.Key+Environment.NewLine);

               // textBox1.AppendText( item.Key+"-"+item.Count() + Environment.NewLine);

                //Console.WriteLine("{0} - {1}", item.Key, item.Count());


            }
  orderby c ascending
   select c;
     
     
        var sample = "i enjoy writing uber-software in c#";

IEnumerable<IGrouping<char, char>>result = from c in sample.ToLower()
                                       where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                                       orderby c
                                       group c by c;
     
     */
