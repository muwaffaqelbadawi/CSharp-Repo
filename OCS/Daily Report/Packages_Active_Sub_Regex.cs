using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Packages_Active_Sub // This is the name of the file
    {

        public void testSub()
        {




            string invoice = @" Kollana Active Sub is 
179189
 RaihBalakYoum Auto Active Sub is 
159144
########################################
########################################
KADay Yesterday Order Times and Subscriber is 
44810
40422
########################################
########################################
KAWeek Active Sub is 
484150
KAWeek Yesterday Order Times and Subscriber is 
76143
75746
 ########################################
 ########################################
KAMonth Active Sub is 
247343
KAMonth Yesterday Order Times and Subscriber is 
8827
8789
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



            // ***************************** Active Packages ****************************** //
            string Kollana_Active_Sub_is = matchesSubStr[0].ToString().Substring(1);
            string RaihBalakYoum_Auto_Active_Sub_is = matchesSubStr[1].ToString().Substring(1);
            string KADay_Yesterday_Order_Times_and_Subscriber_is = matchesSubStr[1].ToString().Substring(1);
            string KAWeek_Active_Sub_is = matchesSubStr[1].ToString().Substring(1);


            Console.WriteLine(Kollana_Active_Sub_is);



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