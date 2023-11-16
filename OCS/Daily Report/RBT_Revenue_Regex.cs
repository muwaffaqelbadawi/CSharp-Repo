using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class RBT_Revenue_Regex // This is the name of the file
    {

        public void testSub()
        {


            string invoice = @"RBT_Subscription_Fee = 492349;
RBT_Purchase_Fee = 514341;
RBT_Gift_Fee = 58.0046;
RBT_Subscription_Renew_Fee = 2.26035e+06;
Service_Gift_Fee = 0;
Pack_Purchase_Fee = 0;
RBT_Renew_Fee = 1.30694e+06;
Recording_Fee = 11926;
Recording_Gift_Fee = 0;
Total_Fee = 6.7568e+07;
RBTVAS_Fee= 3.00403e+07;
SPAY fee= 37527774;
2020_Call_Fee = 6648.27;
2020_Dur = 41206;
2020_SMS_Fee = 0;
Beinsport_weekly_5656times  =0 Order Fee = 0 SDG;
Beinsport_Monthly_5757times =0 Order Fee = 0 SDG;
";





            // (e\+\d+)? for exponential scintific notation

            Regex regSubStr = new Regex(@"[^(\w+)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);



            // foreach (Match match in matchesSubStr)
            // {
            //     Console.WriteLine(match);
            // }



            // ************************** RBT_Revenue *************************** //
            string RBT_Subscription_Fee = matchesSubStr[0].ToString().Substring(1);

            // Console.WriteLine(RBT_Subscription_Fee);



            string Column_Name = "RBT_Subscription_Fee";


            switch (Column_Name)
            {
                case "RBT_Subscription_Fee":
                    Console.WriteLine(RBT_Subscription_Fee);
                    break;

                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }



            // string[] subStr = Str.Split("SDG= ");

            // Console.WriteLine(subStr[1]);

            // Regex regSubStr = new Regex(@"\s", RegexOptions.Compiled);

            // Regex regSubStr1 = new Regex(@"[^=]", RegexOptions.Compiled);

            // MatchCollection matches = regSubStr.Matches(Str);
        }
    }
}