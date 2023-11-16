using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Call_Chargeduration_Regex // This is the name of the file
    {

        public void testSub()
        {


            string invoice = @"#*************** Charge Duration *************
charge duration|9.799e+06
3241811393
*************** Called Duration *************
3341033480";



            // (e\+\d+)? for exponential scintific notation

            Regex regSubStr = new Regex(@"[^\w+]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);



            foreach (Match match in matchesSubStr)
            {
                Console.WriteLine(match);
            }

            // Console.WriteLine(RBT_Fee_Bonus);



            // ********************************* Call Charge Duration  *********************************//

            string Charge_Durtion = matchesSubStr[0].ToString().Substring(1);
            string Called_Durtion = matchesSubStr[0].ToString().Substring(1);



            /*

                        string Column_Name = "SMS Fee";


                        switch (Column_Name)
                        {
                            case "Date":
                                Console.WriteLine(Date);
                                break;

                            case "Recharge Card : 5SDG":
                                Console.WriteLine(Recharge_Card_Five_SDG);
                                break;

                            default:
                                Console.WriteLine("Incorrect input");
                                break;
                        }


            */

            // string[] subStr = Str.Split("SDG= ");

            // Console.WriteLine(subStr[1]);

            // Regex regSubStr = new Regex(@"\s", RegexOptions.Compiled);

            // Regex regSubStr1 = new Regex(@"[^=]", RegexOptions.Compiled);

            // MatchCollection matches = regSubStr.Matches(Str);

            // foreach (Match match in matches1)
            // {
            //     Console.WriteLine(match);
            //  }
        }
    }
}