using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenFramework
{
    public static class Functions
    {
        //Return true when Sydney location is encountered in DataFile.csv
        public static bool ReadDataFromCSV(TestContext tContext)
        {
            bool bReturn = false;

            try
            {
                string strValue = tContext.DataRow["Location"].ToString();
                if (String.Equals(strValue, "Sydney", StringComparison.OrdinalIgnoreCase))
                    bReturn = true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error occured"+e.Message);
                bReturn = true;
            }
            return bReturn;

        }
    }
}
