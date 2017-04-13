using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace BillManager
{
   
    public class BillFunctions
    {
        #region Global variables

        double total { get; set; }
        private string filePath = @"C:\CodeRepository\BillManagmentSystem\test.csv";

        #endregion

        #region constructor
        public BillFunctions()
                {
            
                }
        #endregion

        #region calculate the total weekly cost

       

        public double totalWeekleyCost(List<Bill> Bill_list)
        {
            total = 0;
            foreach (Bill item in Bill_list)
            {
                total += item.WeeklyCost;
            }
            return total;
        }
        #endregion

        #region save the data to a file

        
        public bool SaveTheData(List<Bill> Bill_list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Bill item in Bill_list)
            {
                sb.AppendFormat(item.BillName + "," + item.PersonsName + "," + Convert.ToString(item.WeeklyCost) + "," + item.PaymentDate.ToString());
                sb.AppendLine();
            }

            //string filePath = @"C:\Users\jordandogz1\Desktop\BillManager\test.csv";

            try
            {
                
                File.WriteAllText(filePath, sb.ToString());
                return true;

            }
            catch (Exception)
            {
                return false;

            }

        }
        #endregion

        #region Read the data from a file
        
        public List<Bill> ReadFromFile()
        {
            string FileAdress = (filePath);
           

            List<Bill> BillsFromFileList  = new List<Bill>();

            
            // FileStream fs = new FileStream();
            if (!(File.Exists(FileAdress)))
            {
                FileStream myFile = File.Create(FileAdress);
                myFile.Close();
            }

            FileStream fs = File.OpenRead(FileAdress);

            StreamReader reader = new StreamReader(fs);
            //StreamReader reader = new StreamReader(fs);

            StringBuilder sb = new StringBuilder();

            while (!reader.EndOfStream)
            {
                sb.AppendLine(reader.ReadLine());
            }
            
            fs.Close();// close file afterwards
           

            string[] delim = { Environment.NewLine }; // "\n" added in case you manually appended a newline
            string[] delim2 = { "," }; // 


            string[] line = sb.ToString().Split(delim, StringSplitOptions.None);

            List<string[]> splitline1 = new List<string[]>();

            string[] lineSplit;

            for (int i = 0; i < line.Length; i++)
            {
                lineSplit = line[i].ToString().Split(delim2, StringSplitOptions.None);
                splitline1.Add(lineSplit);
            }

            for (int i = 1; i < line.Length; i++)
            {

                BillsFromFileList.Add(new Bill(splitline1[i - 1][0],
                                               splitline1[i - 1][1],
                              Convert.ToDouble(splitline1[i - 1][2]),
                            Convert.ToDateTime(splitline1[i - 1][3])));
            }
            splitline1.Clear();
            
            return BillsFromFileList;
        }
        #endregion

        #region Comparing lists of bills

        public bool CompareListOfBills(List<Bill> UsersBills, List<Bill> FilesBills)
        {
            bool billsEQfile = false;

            for (int i = 0; i < UsersBills.Count; i++)
            {
                if (UsersBills.Count() == FilesBills.Count())
                {
                    if (UsersBills[i].BillName != FilesBills[i].BillName)
                    {
                        billsEQfile = false;
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
            return billsEQfile;
        }
        #endregion

        //----------------------------------------
    }

}




// asdfasdfasdfasdfsadfasfList<Bill> Bill_list
//-----------------------------------------------------------------------------------------------------------------------------------------



/* 
 * 
 * 
 ------------------------------------------------

    private int _age;

//#1
public event System.EventHandler AgeChanged;

//#2
protected virtual void OnAgeChanged()
{ 
     if (AgeChanged != null) AgeChanged(this,EventArgs.Empty); 
}

public int Age
{
    get
    {
         return _age;
    }

    set
    {
         //#3
         _age=value;
         OnAgeChanged();
    }
 }
 -----------------------------------------------------------

 * int  _theVariable;
public int TheVariable{
  get{return _theVariable;}
  set{
    _theVariable = value; 
    if ( _theVariable == 1){
      //Do stuff here.
    }
  }
}
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * using (var myFile = File.Create(myPath))
{
// interact with myFile here, it will be disposed automatically
}




 * 
 * 
 * 
 *      public static string[] CSVRowToStringArray(string r, char fieldSep = ',', char stringSep = '\"')
    {
        bool bolQuote = false;
        StringBuilder bld = new StringBuilder();
        List<string> retAry = new List<string>();

        foreach (char c in r.ToCharArray())
            if ((c == fieldSep && !bolQuote))
            {
                retAry.Add(bld.ToString());
                bld.Clear();
            }
            else
                if (c == stringSep)
                    bolQuote = !bolQuote;
                else
                    bld.Append(c);

        return retAry.ToArray();
    }


--------------------------------------------------------------------------------

        public StringBuilder  LoadCsv()
        {


        }

    */





/* 
 * 
 * -------------------------------------------------------------------------------------------------------------------------
 *  private string[] csvParser(string csv, char separator = ',')
    {
        List <string> = new <string>();
        string[] temp = csv.Split(separator);
        int counter = 0;
        string data = string.Empty;
        while (counter < temp.Length)
        {
            data = temp[counter].Trim();
            if (data.Trim().StartsWith("\""))
            {
                bool isLast = false;
                while (!isLast && counter < temp.Length)
                {
                    data += separator.ToString() + temp[counter + 1];
                    counter++;
                    isLast = (temp[counter].Trim().EndsWith("\""));
                }
            }
            parsed.Add(data);
            counter++;
        }

        return parsed.ToArray();

    }
    
    
    ---------------------------------------------------------------------------------------------------------------
 *       
 *       public static string[] CSVRowToStringArray(string r, char fieldSep = ',', char stringSep = '\"')
    {
        bool bolQuote = false;
        StringBuilder bld = new StringBuilder();
        List<string> retAry = new List<string>();

        foreach (char c in r.ToCharArray())
            if ((c == fieldSep && !bolQuote))
            {
                retAry.Add(bld.ToString());
                bld.Clear();
            }
            else
                if (c == stringSep)
                    bolQuote = !bolQuote;
                else
                    bld.Append(c);

        return retAry.ToArray();
    }
    
    -------------------------------------------------------------------------------------- 
 *           var line = reader.ReadLine();
            var values = line.Split(';');
 *           
 *           
 *           food,jacqui,10,4/04/2017 8:14:05 p.m.
 *           rent,jordan,20,1/04/2017 8:14:05 p.m.
 *           dog,jacqui,56,4/04/2017 8:14:05 p.m.
 *           school,jordan,12,1/04/2017 8:14:05 p.m.
 *           car,jacqui,34,4/04/2017 8:14:05 p.m.
 *           
 *           
 *           
 *           
 *           
 *           
 *            
1	            string filePath = @"C:\test.csv";  
2	            string delimiter = ",";  
3	 
4	            string[][] output = new string[][]{
5                   new string[]{"Col 1 Row 1", "Col 2 Row 1", "Col 3 Row 1"},
6                   new string[]{"Col1 Row 2", "Col2 Row 2", "Col3 Row 2"}
7               };  
8	            int length = output.GetLength(0);  
9	            StringBuilder sb = new StringBuilder();  
10	            for (int index = 0; index<length; index++)  
11	                sb.AppendLine(string.Join(delimiter, output[index]));  
12	 
13	           
*/
