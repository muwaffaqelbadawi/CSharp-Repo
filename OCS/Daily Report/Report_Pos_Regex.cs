using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Report_Pos_Regex // This is the name of the file
    {

        public void testSub()
        {



            string invoice = @"

*************** Recharge Revenue *************
5SDG=   0
10SDG=   20
20SDG=  9
50SDG=  0
100SDG=  1
250SDG=  7
500SDG= 48
1000SDG= 8
*************** Call Duration *************
calling duration = 466916324
called duration  = 216462825
*************** Revenue of Voice/SMS/AAA/Data service *************
calling fee(CDMA) = 0
called fee(GSM/WCDMA)  = 8.05502e+06
SMS fee = 5.72949e+06
AAA = 0.30938
Data service = 0
BCA is  1.75201e+07
*************** Active subscriber *************
Pos_active is  728711


*************** New subscriber *************
401
";



            Regex regSubStr = new Regex(@"[^(\w+)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);


            // ******************************* Recharge Revenue ****************************** //
            string Five_SDG = matchesSubStr[1].ToString().Substring(1); // 500SDG
            string Ten_SDG = matchesSubStr[3].ToString().Substring(1);  // 10SDG
            string Twenty_SDG = matchesSubStr[5].ToString().Substring(1); // 20SDG
            string Fifty_SDG = matchesSubStr[7].ToString().Substring(1);  // 50SDG
            string Hundread_SDG = matchesSubStr[9].ToString().Substring(1); //  100SDG
            string Twofifty_SDG = matchesSubStr[11].ToString().Substring(1); //   250SDG
            string FiveHundread_SDG = matchesSubStr[13].ToString().Substring(1); // 500SDG
            string Thousand_SDG = matchesSubStr[15].ToString().Substring(1); //  1000SDG

            // ******************************* Call Duration ********************************** //
            string calling_duration = matchesSubStr[16].ToString().Substring(1);
            string called_duration = matchesSubStr[17].ToString().Substring(1);

            // ********************* Revenue of Voice/SMS/AAA/Data service ********************* //
            string calling_fee_CDMA = matchesSubStr[18].ToString().Substring(1);
            string called_fee_GSM_WCDMA = matchesSubStr[19].ToString().Substring(1);
            string SMS_fee = matchesSubStr[20].ToString().Substring(1);
            string AAA = matchesSubStr[21].ToString().Substring(1);
            string Data_service = matchesSubStr[22].ToString().Substring(1);
            string BCA = matchesSubStr[23].ToString().Substring(1);

            // ***************************** Active Subscriber ******************************** //
            string Pos_active = matchesSubStr[24].ToString().Substring(1);

            // ***************************** Active Subscriber ******************************** //
            string New_subscriber = matchesSubStr[25].ToString().Substring(1);

            string Column_Name = "SMS fee";


            switch (Column_Name)
            {
                case "5SDG":
                    Console.WriteLine(Five_SDG);
                    break;

                case "10SDG":
                    Console.WriteLine(Ten_SDG);
                    break;

                case "20SDG":
                    Console.WriteLine(Twenty_SDG);
                    break;

                case "50SDG":
                    Console.WriteLine(Fifty_SDG);
                    break;

                case "100SDG":
                    Console.WriteLine(Hundread_SDG);
                    break;

                case "250SDG":
                    Console.WriteLine(Twofifty_SDG);
                    break;

                case "500SDG":
                    Console.WriteLine(FiveHundread_SDG);
                    break;

                case "1000SDG":
                    Console.WriteLine(Thousand_SDG);
                    break;

                case "calling duration":
                    Console.WriteLine(calling_duration);
                    break;

                case "called duration":
                    Console.WriteLine(called_duration);
                    break;

                case "calling fee(CDMA)":
                    Console.WriteLine(calling_fee_CDMA);
                    break;

                case "called fee(GSM/WCDMA)":
                    Console.WriteLine(called_fee_GSM_WCDMA);
                    break;

                case "SMS fee":
                    Console.WriteLine(SMS_fee);
                    break;

                case "AAA":
                    Console.WriteLine(AAA);
                    break;

                case "Data service":
                    Console.WriteLine(Data_service);
                    break;

                case "BCA":
                    Console.WriteLine(BCA);
                    break;

                case "Pos_active":
                    Console.WriteLine(Pos_active);
                    break;

                case "New subscriber":
                    Console.WriteLine(New_subscriber);
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