using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class SubDailyReport // This is the name of the file
    {

        public void testSub()
        {




            string invoice = @"--------------------------------------------------------------------------------
            Report : Subscriber Trend
            --------------------------------------------------------------------------------
            Date                           20230404            
            New Subscriber                 7077                
            Active Subscriber.CBP1         12455527            
            Active Subscriber.Total        12455527            
            Blacklist Subscriber           8048                
            Loss Subscriber                626850              
            Idle Subscriber                1601954             
            Barred Subscriber              99                  
            Suspended Subscriber           1016665             
            Expired Subscriber             1240                
            Pool Subscriber                1140408             
            Total Subscriber.CBP1          16214656            
            Total Subscriber.Total         16214656            


            --------------------------------------------------------------------------------
            Report : Subscriber Balance Scatter
            --------------------------------------------------------------------------------
            Date                           20230404            
            Stuff                          627450.397150       
            Customer                       2264824798.953170   
            Idle                           157498077.049350    
            Total                          2422950326.399670   


            Date                                        20230404  
            Balance =  0                     SDG        1594139   
            Balance <  0.1965                SDG        3394207   
            Balance >= 0.1965 and Balance < 2  SDG      991397    
            Balance >= 2    and Balance < 5  SDG        918756    
            Balance >= 5    and Balance < 8  SDG        311637    
            Balance >= 8    and Balance < 10 SDG        162100    
            Balance >= 10                    SDG        5083291   


            --------------------------------------------------------------------------------
            Report : Cash Recharge
            --------------------------------------------------------------------------------
            Date                           20230404            
            Cash_Recharge Amount           757513164           
            Total Cash_Recharge Times      1011811             


            --------------------------------------------------------------------------------
            Report : Fakka_Recharge
            --------------------------------------------------------------------------------
            Date                           20230404            
            0.5_Recharge Times             0                   
            0.5_Recharge Amount            0                   
            1.0_Recharge Times             0                   
            1.0_Recharge Amount            0                   
            1.5_Recharge Times             0                   
            1.5_Recharge Amount            0                   


            ";


            // (e\+\d+)? for exponential scintific notation

            Regex regSubStr = new Regex(@"[^(\w+d+(d+\.d+)?)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);



            // int index = 0;
            // foreach (Match match in matchesSubStr)
            // {
            //     // Console.WriteLine(match + " = " + index);
            //     Console.WriteLine(match);
            //     // ++index;
            // }





            // ************************** Report : Subscriber Trend *************************** //
            string New_Active_Sub = matchesSubStr[1].ToString().Substring(1);
            string Active_Sub_CBP1 = matchesSubStr[1].ToString().Substring(1);
            string Barred_Sub = matchesSubStr[1].ToString().Substring(1);
            string Suspended_Sub = matchesSubStr[1].ToString().Substring(1);
            string Expired_Sub = matchesSubStr[1].ToString().Substring(1);
            string New_Subscriber = matchesSubStr[1].ToString().Substring(1);









            // ************************** Revenue of international roam *************************** //
            string balance_Equal_0 = matchesSubStr[20].ToString().Substring(1); // balance = 0
            string balance_lessThan_0_1965_SDG = matchesSubStr[22].ToString().Substring(1); // balance < 0.1965  SDG
            string Balance_greaterThan_or_EqualTo_0_1965_and_Balance_lessThan_2_SDG = matchesSubStr[25].ToString().Substring(1); // Balance >=0.1965 and Balance < 2  SDG
            string Balance_greaterThan_or_EqualTo_2_and_Balance_lessThan_5_SDG = matchesSubStr[28].ToString().Substring(1); // Balance >=2 and Balance < 5 SDG
            string Balance_greaterThan_or_EqualTo_5_and_Balance_lessThan_8_SDG = matchesSubStr[31].ToString().Substring(1); // Balance >= 5  and Balance < 8SDG
            string Balance_greaterThan_or_EqualTo_8_and_Balance_lessThan_10_SDG = matchesSubStr[34].ToString().Substring(1); // Balance>=8 and Balance < 10 SDG
            string Balance_greaterThan_or_EqualTo_10SDG = matchesSubStr[36].ToString().Substring(1); // Balance > =10SDG

            Console.WriteLine(New_Subscriber);














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