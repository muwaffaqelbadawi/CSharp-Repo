using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Revenue_Roam // This is the name of the file
    {

        public void testSub()
        {


            string invoice = @"Revenue of Voice Roam is:
fee = 1.78965e+06;
Revenue of SMS Roam is:
fee = 41219.5;
Revenue of Data Roam is:
fee = 0;
Number of Cost is:
26312 MDN_Roam_temp.unl
";





            // (e\+\d+)? for exponential scintific notation

            Regex regSubStr = new Regex(@"[^(\w+)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);



            // foreach (Match match in matchesSubStr)
            // {
            //     Console.WriteLine(match);
            // }



            // ************************** Revenue of international roam *************************** //
            string Voice = matchesSubStr[0].ToString().Substring(1);
            string SMS = matchesSubStr[1].ToString().Substring(1);
            string Data = matchesSubStr[2].ToString().Substring(1);
            string MDN = matchesSubStr[2].ToString().Substring(1);



            Console.WriteLine(Data);




















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