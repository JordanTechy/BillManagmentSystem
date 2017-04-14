using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace BillManager
{
    public partial class Main_form : Form
    {
        #region Global Variables

        static DataTable mytable = new DataTable(); // mytable 

        List<Bill> billslist = new List<Bill>(); // main bills list

        BillFunctions billFunctions = new BillFunctions(); // create a object to use all the bill functions

        #endregion

        #region Main entry point for the aplication

        public Main_form()
        {
            InitializeComponent();

        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            setUpcalender();

            dataGridView1.DataSource = mytable;

            myTable_init();

            loadfile(); // this replaces the sample data 

           //addSampleDate();
        }
        #endregion

        #region Button event handlers

        private void BT_AddBill_Click(object sender, EventArgs e)  // adding bill button
        {
            addbill();
        }
      
        private void BT_totalweekcost_Click(object sender, EventArgs e)
        {
             textBox1.Text = Convert.ToString(billFunctions.totalWeekleyCost(billslist));
        }

        private void BT_printbillList_Click(object sender, EventArgs e)
        {
            printBillsList(billslist);
        }
       
        // DELETING ROW

        private void BT_Delete_Click(object sender, EventArgs e)
        {
           
         // work oout how to do this the normail way
            billslist.RemoveAll(x => x.BillName.ToLower() == TB_deletebill.Text.ToLower());
         
            
            updateGrid(billslist);


        }
        public delegate bool Predicate<in T>(T obj);

        #endregion


        #region Tool strip event handlers
        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
            {
            compareFile();
            }
        private void saveFromFileToolStripMenuItem_Click(object sender, EventArgs e)
            {
            saveToFile();
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        #endregion

        #region Billl adding method
        public void addbill()
                {
                    // check if the bill already exists 
                    bool billAlreadyExists = billFunctions.checkIfBillExists(billslist, TB_BillsName.Text);

                    if (billAlreadyExists)
                    {
                        textBox1.Text = "bill already exists please rename bill";
                    }
                    else
                    {
                        
                    
                        double cost = 0;

                        if (Double.TryParse(TB_BillCost.Text, out cost) == true)
                        {
                            billslist.Add(new Bill(TB_BillsName.Text, TB_PersonName.Text, Convert.ToDouble(TB_BillCost.Text), dateTimePicker.Value.Date));

                            updateGrid(billslist);
                        }
                        else
                        {
                            MessageBox.Show("Please Enter number for cost");
                        }
                }
        }

        #endregion
      
        #region Update data grid method
         public void updateGrid(List<Bill> _billlist)
                {
                    mytable.Clear();

                    foreach (var bill in _billlist)
                    {
                        mytable.Rows.Add(bill.BillName, bill.PersonsName, bill.WeeklyCost, bill.PaymentDate);
                    }

                }
        #endregion

        #region Print the bills list methos

        
        void printBillsList(List<Bill> _billslist)
        {
            foreach (Bill item in _billslist)
            {
                textBox1.AppendText(item.BillName + "  " + item.PersonsName + "  " + item.WeeklyCost + " " + item.PaymentDate.ToString() + Environment.NewLine);
            }
        }
        #endregion

        #region initalisation of the data grid view table methods
       
        private void myTable_init()
        {
            mytable.Columns.Add("Bill name", typeof(string));
            mytable.Columns.Add("person name", typeof(string));
            mytable.Columns.Add("bill cost", typeof(int));
            mytable.Columns.Add("date ", typeof(DateTime));

           // addSampleDate();
        }

        void addSampleDate()
        {
            billslist.Add(new Bill("car", "jacqui", 10, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill("food", "jordan", 20, DateTime.Now));
            billslist.Add(new Bill("rent", "jacqui", 56, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill("sky", "jordan", 12, DateTime.Now));
            billslist.Add(new Bill("power", "jacqui", 34, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill("fuel", "jacqui", 34, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill("internet", "jacqui", 34, DateTime.Now.AddDays(3)));

            updateGrid(billslist);
        }
        #endregion

        #region File handling methods
       /// <summary>
       /// inhdsaofjnhdsa
       /// 
       /// </summary>
        private void loadfile()
        {
            billslist = billFunctions.ReadFromFile();

            updateGrid(billslist);

        }

        public void saveToFile()
            {
            bool IfSavedProperly = false;

            IfSavedProperly = billFunctions.SaveTheData(billslist);

            if (IfSavedProperly == false)
            {
                textBox1.Text = ("Failed TO SAVE");
            }
            else
            {
                textBox1.Text = "File Saved";
            }
        }

        public void compareFile()// change
        {
            // get the csv converted to my object
            List<Bill> BillsInFile = billFunctions.ReadFromFile();

            bool billsEQfile = billFunctions.CompareListOfBills(billslist, BillsInFile);

            if (billsEQfile)
            {
                textBox1.Text = "bills list = equsl list of bill in file";
            }
            else
            {
                billslist = BillsInFile;

                updateGrid(billslist);

                textBox1.Text = "Billslist doesent equsl list of bill \n in file would you like to save";
            }
        }
        #endregion

        #region set up calender
          void setUpcalender()
                {
                    dateTimePicker.Format = DateTimePickerFormat.Custom;
                    dateTimePicker.CustomFormat = "dd - MMM - yy";
                    //dateTimePicker.ShowUpDown = true;
                }


        #endregion
      
        #region Testing region
        //-------------------------------------linq----------------------------------------------------------
        private void BT_TestButton_Click(object sender, EventArgs e)
        {


            var result = from p in billslist
                             orderby p.PersonsName
                             group p by p.PersonsName;

            foreach (var item in result)
            {
                textBox1.AppendText(item.Key + "  - " + item.Count()+Environment.NewLine);
                foreach (var Bill in item)
                {
                    textBox1.AppendText('\t'+ Bill.PersonsName + "  " + Bill.WeeklyCost);
                    textBox1.AppendText(Environment.NewLine);
                }
            }

        }
        //------------------------delagate-----------------------------------
       delegate void Operation(int num);

        private void BT_Testevent_Click(object sender, EventArgs e)
        {
            Operation op = delegate(int num) 
            {
                textBox1.AppendText((num * 2) + "\r\n");
                textBox1.AppendText((num * 3) + "\r\n");
                textBox1.AppendText((num * 4) + "\r\n");
                textBox1.AppendText((num * 5) + "\r\n");
            };

            op(2);
        }


        //-----------------------------------------------------------------------
        #endregion

       
    }
}






/*
 * 
 * 
 * 
 food    ,      jacqui    ,    10     ,     5/04/2017 11:40:12 a.m.   

rent,jordan,20,2/04/2017 11:40:12 a.m.

dog,jacqui,56,5/04/2017 11:40:12 a.m.
school,jordan,12,2/04/2017 11:40:12 a.m.
car,jacqui,34,5/04/2017 11:40:12 a.m.

      DataRow RowHolder = null;

            foreach (DataRow row in mytable.Rows)
            {
                if (row["bill name"].ToString() == BillToDelete)
                {
                    RowHolder = row;
                }
            }

            try
            {
                mytable.Rows.Remove(RowHolder);
            }
            catch (Exception)
            {
                textBox1.Text = "Name Doesnt exist ";
            }

   
            billslist.Add(new Bill( "food", "jacqui", 10, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill( "rent", "jordan" ,20, DateTime.Now));
            billslist.Add(new Bill( "dog", "jacqui", 56, DateTime.Now.AddDays(3)));
            billslist.Add(new Bill( "school", "jordan" ,12, DateTime.Now));
            billslist.Add(new Bill( "car", "jacqui", 34, DateTime.Now.AddDays(3)));




            foreach (Bill item in billslist)
            {
                mytable.Rows.Add(item.BillName, item.PersonsName, item.WeeklyCost, item.PaymentDate);
            }
              bool billsEQfile = false;

            for (int i = 0; i < billslist.Count; i++)
            {
                if (billslist.Count() == BillsInFile.Count())
                {
                    if (BillsInFile[i].BillName!=billslist[i].BillName)
                    {
                        billsEQfile = false;
                        
                        break;
                    }
                    else
                    {
                        billsEQfile = true;
                    }
                }
                else
                {
                    billsEQfile = false;
                }
               

            }

     textBox1.AppendText((num * 3) + "\r\n");
*/

