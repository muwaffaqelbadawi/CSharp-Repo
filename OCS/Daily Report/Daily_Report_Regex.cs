using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Daily_Report_Regex // This is the name of the file
    {

        public void testSub()
        {


            string invoice = @"--------------------------------------------------------------------------------
Report : Card Recharge
--------------------------------------------------------------------------------
Date                           20230404            
Recharge Card : 5SDG           138                 
Recharge Card : 2000SDG        138                 
Recharge Card : 10SDG          1048                
Recharge Card : 20SDG          4422                
Recharge Card : 50SDG          4                   
Recharge Card : 5000SDG        0                   
Recharge Card : 100SDG         51                  
Recharge Card : 250SDG         611                 
Recharge Card : 500SDG         1615                
Recharge Card : 1000SDG        351                 
Recharge Card : Others         0                   
Total Recharge Card            8378                
Total Recharge Revenue         1692160             

--------------------------------------------------------------------------------
Report : Call Duration
--------------------------------------------------------------------------------
Date                           20230404            
Calling Duration               3241811393          
Called Duration                3344119281          
Total Duration                 6585930674          
Calling Dur(Min)               54030189            
Called Dur(Min)                55735321            
Total Dur(Min)                 109765511           


--------------------------------------------------------------------------------
Report : SP Revenue
--------------------------------------------------------------------------------
Date                           20230404            
Backup                         0.000000            
Oneresult                      0.000000            
RiNResult                      0.000000            
MMSSP                          11839856.053380     
KHALWA                         0.000000            
arabcall                       41789.986070        
Integral                       0.000000            
newresult                      0.000000            
Taybaradio                     0.000000            
Mazarcom                       6432807.855730      
WrongIndex                     0.000000            
Hawana                         0.000000            
datanet                        0.000000            
Zinanet                        0.000000            
omdsms                         0.000000            
FIT                            0.000000            
OneResult                      0.000000            
InfoTel                        0.000000            
ZTE_CRBT                       0.000000            
result                         0.000000            
Datanet                        5750218.083260      
Common                         0.000000            
Jazeera                        0.000000            
AUDIOTEL                       0.000000            
Integraltanet                  0.000000            
M_MSN                          690749.769750       
DATA_NET                       131039.956320       
Alahram                        19999.995880        
WASL                           0.000000            
SUNA                           396749.867750       
mobilink                       0.000000            


--------------------------------------------------------------------------------
Report : Subscriber Consumption
--------------------------------------------------------------------------------
Date                                     20230404            
Total Calling Fee                        98762899            
GSM Calling Fee                          97805936            
Total Calling Fee.Bonus                  3770                
GSM Calling Fee.Bonus                    3770                
Total Calling Fee.RechargeBonus          0                   
GSM Calling Fee.RechargeBonus            0                   
Revenue of subscription product 239824 (SDG) 467500              
Revenue of subscription product 243996 (SDG) 0                   
Revenue of subscription product 243280 (SDG) 21500               
Revenue of subscription product 239825 (SDG) 923649              
Revenue of subscription product 243281 (SDG) 0                   
Revenue of subscription product 239992 (SDG) 0                   
Revenue of subscription product 243282 (SDG) 0                   
Revenue of subscription product 240180 (SDG) 877499              
Revenue of subscription product 239827 (SDG) 578879              
Revenue of subscription product 243283 (SDG) 0                   
Revenue of subscription product 232985 (SDG) 0                   
Revenue of subscription product 243284 (SDG) 0                   
Revenue of subscription product 244078 (SDG) 0                   
Revenue of subscription product 243288 (SDG) 0                   
Revenue of subscription product 239710 (SDG) 5                   
Revenue of subscription product 270710 (SDG) 0                   
Revenue of subscription product 243586 (SDG) 9670914             
Revenue of subscription product 243587 (SDG) 10368               
Revenue of subscription product 270711 (SDG) 0                   
Revenue of subscription product 270712 (SDG) 0                   
Revenue of subscription product 243589 (SDG) 0                   
Revenue of subscription product 237120 (SDG) 9315                
Revenue of subscription product 237121 (SDG) 0                   
Revenue of subscription product 270714 (SDG) 2570638             
Revenue of subscription product 239585 (SDG) 0                   
Revenue of subscription product 270715 (SDG) 1534000             
Revenue of subscription product 270716 (SDG) 3404999             
Revenue of subscription product 239883 (SDG) 2360700             
Revenue of subscription product 239884 (SDG) 2190500             
Revenue of subscription product 239885 (SDG) 10352300            
Revenue of subscription product 243190 (SDG) 52250               
Revenue of subscription product 239887 (SDG) 9219656             
Revenue of subscription product 243191 (SDG) 0                   
Revenue of subscription product 243192 (SDG) 174000              
Revenue of subscription product 243193 (SDG) 0                   
Revenue of subscription product 243194 (SDG) 132000              
Revenue of subscription product 1620005372 (SDG) 0                   
Revenue of subscription product 239179 (SDG) 1297                
Revenue of subscription product 239770 (SDG) 0                   
Revenue of subscription product 239771 (SDG) 0                   
Revenue of subscription product 239772 (SDG) 0                   
Revenue of subscription product 239773 (SDG) 0                   
Revenue of subscription product 239906 (SDG) 747600              
Revenue of subscription product 244450 (SDG) 0                   
Revenue of subscription product 241782 (SDG) 0                   
Revenue of subscription product 244451 (SDG) 0                   
Revenue of subscription product 243213 (SDG) 217000              
Revenue of subscription product 243214 (SDG) 26599               
Revenue of subscription product 241785 (SDG) 0                   
Revenue of subscription product 243215 (SDG) 105003              
Revenue of subscription product 244454 (SDG) 0                   
Revenue of subscription product 243216 (SDG) 37332               
Revenue of subscription product 240280 (SDG) 2560999             
Revenue of subscription product 243217 (SDG) 0                   
Revenue of subscription product 244456 (SDG) 18210000            
Revenue of subscription product 244470 (SDG) 2874564             
Revenue of subscription product 244457 (SDG) 0                   
Revenue of subscription product 244471 (SDG) 406503              
Revenue of subscription product 244458 (SDG) 0                   
Revenue of subscription product 244459 (SDG) 0                   
Revenue of subscription product 244472 (SDG) 14358499            
Revenue of subscription product 223800 (SDG) 0                   
Revenue of subscription product 232950 (SDG) 0                   
Revenue of subscription product 244473 (SDG) 6393105             
Revenue of subscription product 244474 (SDG) 0                   
Revenue of subscription product 241078 (SDG) 0                   
Revenue of subscription product 244475 (SDG) 0                   
Revenue of subscription product 234100 (SDG) 54697               
Revenue of subscription product 244476 (SDG) 0                   
Revenue of subscription product 243980 (SDG) 12348972            
Revenue of subscription product 243981 (SDG) 0                   
Revenue of subscription product 239962 (SDG) 1357420             
Revenue of subscription product 241506 (SDG) 0                   
Revenue of subscription product 243982 (SDG) 0                   
Revenue of subscription product 239963 (SDG) 1445700             
Revenue of subscription product 243983 (SDG) 10695               
Revenue of subscription product 239964 (SDG) 5059520             
Revenue of subscription product 244340 (SDG) 30597499            
Revenue of subscription product 243255 (SDG) 0                   
Revenue of subscription product 243984 (SDG) 0                   
Revenue of subscription product 239965 (SDG) 1324610             
Revenue of subscription product 244341 (SDG) 17951500            
Revenue of subscription product 239966 (SDG) 2713200             
Revenue of subscription product 243986 (SDG) 0                   
Revenue of subscription product 239967 (SDG) 1195730             
Revenue of subscription product 239981 (SDG) 0                   
Revenue of subscription product 239968 (SDG) 1102920             
Revenue of subscription product 243987 (SDG) 165081              
Revenue of subscription product 243988 (SDG) 228645              
Revenue of subscription product 244346 (SDG) 0                   
Revenue of subscription product 239983 (SDG) 0                   
Revenue of subscription product 244347 (SDG) 0                   
Revenue of subscription product 239984 (SDG) 0                   
Revenue of subscription product 1480934079 (SDG) 0                   
Revenue of subscription product 243290 (SDG) 4300                
Revenue of subscription product 239988 (SDG) 0                   
Revenue of subscription product 243291 (SDG) 0                   
Revenue of subscription product 239989 (SDG) 0                   
Revenue of subscription product 244661 (SDG) 0                   
Revenue of subscription product 231901 (SDG) 8                   
Revenue of subscription product 240179 (SDG) 544000              
Revenue of subscription product 243295 (SDG) 0                   
Revenue of subscription product 241266 (SDG) 1241099             
Revenue of subscription product 231903 (SDG) 28                  
Revenue of subscription product 243591 (SDG) 68967               
Revenue of subscription product 239704 (SDG) 6837050             
Revenue of subscription product 239705 (SDG) 13346524            
Revenue of subscription product 243594 (SDG) 0                   
Revenue of subscription product 239706 (SDG) 1578000             
Revenue of subscription product 243595 (SDG) 76978               
Revenue of subscription product 243598 (SDG) 0                   
Revenue of subscription product 243182 (SDG) 265990              
Revenue of subscription product 243183 (SDG) 0                   
Revenue of subscription product 243184 (SDG) 0                   
Revenue of subscription product 243185 (SDG) 0                   
Revenue of subscription product 243186 (SDG) 37151               
Revenue of subscription product 243187 (SDG) 0                   
Revenue of subscription product 243188 (SDG) 57274               
Revenue of subscription product 243189 (SDG) 0                   
Revenue of subscription product 231232 (SDG) 31827773            
Revenue of subscription product 240980 (SDG) 0                   
Revenue of subscription product 244440 (SDG) 16646400            
Revenue of subscription product 237602 (SDG) 17500617            
Revenue of subscription product 244441 (SDG) 18384000            
Revenue of subscription product 244442 (SDG) 5754500             
Revenue of subscription product 244443 (SDG) 27740000            
Revenue of subscription product 244444 (SDG) 6533520             
Revenue of subscription product 244445 (SDG) 920855              
Revenue of subscription product 244446 (SDG) 7518700             
Revenue of subscription product 244447 (SDG) 38557999            
Revenue of subscription product 239932 (SDG) 2239784             
Revenue of subscription product 239933 (SDG) 63989               
Revenue of subscription product 244448 (SDG) 25072600            
Revenue of subscription product 244449 (SDG) 141750560           
Revenue of subscription product 240407 (SDG) 0                   
Revenue of subscription product 240279 (SDG) 1152000             
Revenue of subscription product 244481 (SDG) 0                   
Revenue of subscription product 244483 (SDG) 5999                
Revenue of subscription product 245556 (SDG) 11220               
Revenue of subscription product 232960 (SDG) 0                   
Revenue of subscription product 238883 (SDG) 9685232             
Revenue of subscription product 239806 (SDG) 11220551            
Revenue of subscription product 240441 (SDG) 0                   
Revenue of subscription product 240442 (SDG) 0                   
Revenue of subscription product 240877 (SDG) 0                   
Revenue of subscription product 240890 (SDG) 11993441            
Revenue of subscription product 243979 (SDG) 4023597             
Transfer Handling Fee                    0                   
Transfer Handling Fee.Bonus              0                   
Transfer Handling Fee.RechargeBonus      0                   
SMS Fee                                  36387523            
SMS Fee.Bonus                            130                 
SMS Fee.RechargeBonus                    0                   
AAA Fee                                  0                   
Data Fee                                 271884              
AAA Fee.Bonus                            723                 
Data Fee.Bonus                           0                   
AAA Fee.RechargeBonus                    0                   
Data Fee.RechargeBonus                   0                   
RBT Fee                                  67568044            
RBT Fee.Bonus                            0                   
RBT Fee.RechargeBonus                    0                   
Total Fee.Bonus                          4624                
Total Fee.RechargeBonus                  0                   
";



            // (e\+\d+)? for exponential scintific notation

            Regex regSubStr = new Regex(@"[^(\w+:?\d?)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);

            // ********************************** Report : Card Recharge ********************************** //
            string Date = matchesSubStr[0].ToString().Substring(1);
            string Recharge_Card_Five_SDG = matchesSubStr[2].ToString().Substring(1);
            string Recharge_Card_TwoThousand_SDG = matchesSubStr[4].ToString().Substring(1);
            string Recharge_Card_Ten_SDG = matchesSubStr[6].ToString().Substring(1);
            string Recharge_Card_Twenty_SDG = matchesSubStr[8].ToString().Substring(1);
            string Recharge_Card_Fifty_SDG = matchesSubStr[10].ToString().Substring(1);
            string Recharge_Card_FiveThousand_SDG = matchesSubStr[12].ToString().Substring(1);
            string Recharge_Card_Hundread_SDG = matchesSubStr[14].ToString().Substring(1);
            string Recharge_Card_TwoFifty_SDG = matchesSubStr[16].ToString().Substring(1);
            string Recharge_Card_FiveHundread_SDG = matchesSubStr[18].ToString().Substring(1);
            string Recharge_Card_Thousand_SDG = matchesSubStr[20].ToString().Substring(1);
            string Recharge_Card_Others = matchesSubStr[21].ToString().Substring(1);
            string Total_Recharge_Card = matchesSubStr[22].ToString().Substring(1);
            string Total_Recharge_Revenue = matchesSubStr[23].ToString().Substring(1);


            // ********************************** Report : Subscriber Consumption ********************************** //
            string Total_Calling_Fee = matchesSubStr[64].ToString().Substring(1);
            string SMS_Fee = matchesSubStr[367].ToString().Substring(1);
            string Data_Fee = matchesSubStr[371].ToString().Substring(1);
            string RBT_Fee_Bonus = matchesSubStr[377].ToString().Substring(1);



            // Console.WriteLine(RBT_Fee_Bonus);


            string Column_Name = "SMS Fee";


            switch (Column_Name)
            {
                case "Date":
                    Console.WriteLine(Date);
                    break;

                case "Recharge Card : 5SDG":
                    Console.WriteLine(Recharge_Card_Five_SDG);
                    break;

                case "Recharge Card : 2000SDG":
                    Console.WriteLine(Recharge_Card_TwoThousand_SDG);
                    break;

                case "Recharge Card : 10SDG":
                    Console.WriteLine(Recharge_Card_Ten_SDG);
                    break;

                case "Recharge Card : 20SDG":
                    Console.WriteLine(Recharge_Card_Twenty_SDG);
                    break;

                case "Recharge Card : 50SDG":
                    Console.WriteLine(Recharge_Card_Fifty_SDG);
                    break;

                case "Recharge Card : 5000SDG":
                    Console.WriteLine(Recharge_Card_FiveThousand_SDG);
                    break;

                case "Recharge Card : 100SDG":
                    Console.WriteLine(Recharge_Card_Hundread_SDG);
                    break;

                case "Recharge Card : 250SDG":
                    Console.WriteLine(Recharge_Card_TwoFifty_SDG);
                    break;

                case "Recharge Card : 500SDG":
                    Console.WriteLine(Recharge_Card_FiveHundread_SDG);
                    break;

                case "Recharge Card : 1000SDG":
                    Console.WriteLine(Recharge_Card_Thousand_SDG);
                    break;

                case "Recharge Card : Others":
                    Console.WriteLine(Recharge_Card_Others);
                    break;

                case "Total Recharge Card":
                    Console.WriteLine(Total_Recharge_Card);
                    break;

                case "Total Recharge Revenue":
                    Console.WriteLine(Total_Recharge_Revenue);
                    break;

                case "Total Calling Fee":
                    Console.WriteLine(Total_Calling_Fee);
                    break;

                case "SMS Fee":
                    Console.WriteLine(SMS_Fee);
                    break;

                case "Data Fee":
                    Console.WriteLine(Data_Fee);
                    break;

                case "Data Fee.Bonus":
                    Console.WriteLine(RBT_Fee_Bonus);
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


            // foreach (Match match in matches1)
            // {
            //     Console.WriteLine(match);
            //  }
        }
    }
}