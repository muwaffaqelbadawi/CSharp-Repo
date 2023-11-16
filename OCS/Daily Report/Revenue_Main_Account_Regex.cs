using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Revenue_Main_Account // This is the name of the file
    {

        public void testSub()
        {




            string invoice = @"--------------------------------------------------------------------------------
-------------------- 20230405 Main Account Revenue------------------------------


------------------------------- Call Revenue----------------------------------
Main Account Call Revenue                87726395            
Main Account CDMA Call Revenue           0                   
Main Account W&GSM Call Revenue          87726395            


----------------------------- Message Revenue---------------------------
Main Account SMS Revenue                 28834456            
-------------------------- Data Revenue---------------------------------------
Main Account AAA Revenue                 0                   
Main Account MDSP Revenue                271157              


-------------------------- Total VAS Revenue ---------------------------------
Main Account RBT+VAS+SPay Revenue        49678572            
-------------------------- Details VAS Revenue--------------------------------
Main Account RBT+VAS Revenue             24715754            
Main Account S-Pay Revenue               24962818            
-------------------------------------------------------------------------------


-------------------------- Adjustment  ----------------------------------------
S-Pay Revenue From Adjustment            0                   
--------------------------------------------------------------------------------


------------------------------------- Finish -----------------------------------
";


            // (e\+\d+)? for exponential scintific notation

            Regex regSubStr = new Regex(@"[^(\w+)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);



            // int index = 0;
            // foreach (Match match in matchesSubStr)
            // {
            //     // Console.WriteLine(match + " = " + index);
            //     Console.WriteLine(match);
            //     // ++index;
            // }



            // ***************************** Call Revenue ****************************** //
            string Main_Account_Call_Revenue = matchesSubStr[0].ToString().Substring(1);
            string Main_Account_CDMA_Call_Revenue = matchesSubStr[1].ToString().Substring(1);
            string Main_Account_WGSM_Call_Revenue = matchesSubStr[2].ToString().Substring(1);

            // ***************************** Message Revenue ****************************** //
            string Main_Account_SMS_Revenue = matchesSubStr[3].ToString().Substring(1);

            // ***************************** Data Revenue ****************************** //
            string Main_Account_AAA_Revenue = matchesSubStr[4].ToString().Substring(1);
            string Main_Account_MDSP_Revenue = matchesSubStr[4].ToString().Substring(1);

            // ***************************** Total VAS Revenue ****************************** //
            string Main_Account_RBT_Plus_VAS_Plus_SPay_Revenue = matchesSubStr[4].ToString().Substring(1);

            // ***************************** Details VAS Revenue ****************************** //
            string Main_Account_RBT_Plus_VAS_Revenue = matchesSubStr[4].ToString().Substring(1);
            string Main_Account_S_Pay_Revenue = matchesSubStr[4].ToString().Substring(1);

            // ***************************** Adjustment ****************************** //
            string S_Pay_Revenue_From_Adjustment = matchesSubStr[4].ToString().Substring(1);








            // Console.WriteLine(Main_Account_Call_Revenue);










            // string Column_Name = "RBT_Subscription_Fee";


            // switch (Column_Name)
            // {
            //     case "RBT_Subscription_Fee":
            //         Console.WriteLine(RBT_Subscription_Fee);
            //         break;

            //     default:
            //         Console.WriteLine("Incorrect input");
            //         break;
            // }



            // string[] subStr = Str.Split("SDG= ");

            // Console.WriteLine(subStr[1]);

            // Regex regSubStr = new Regex(@"\s", RegexOptions.Compiled);

            // Regex regSubStr1 = new Regex(@"[^=]", RegexOptions.Compiled);

            // MatchCollection matches = regSubStr.Matches(Str);
        }
    }
}