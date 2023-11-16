using System.Text.RegularExpressions;

namespace dotnet // Note: actual namespace depends on the project name.
{

    class Packages_Statistcs_Regex // This is the name of the file
    {

        public void testSub()
        {



            string invoice = @"Voice package order times and subscribers
0
0
Data package order times and subscribers
0
0
 Active FlatRat Subscribers are 
85187
####OffPeak###
 OffPeak Order Times and Fee 
OffPeakOrder = 0;OffPeakFee= 0
####ICB###
 ICB Order Times and Fee 
ICBOrder = 0;ICBFee= 0
####Week Klam, KlamSMS, SMS, Ramadan###
WeekKlamOrder = 0;WeekKlamFee= 0
WeekKlamSMSOrder = 0;WeekKlamSMSFee= 0
WeekSMSOrder = 156;WeekSMSFee= 54697.5
WeekRamadanOrder = 0;WeekRamadanFee= 0
####Handset Data Packages 2,5,9###
Hanset2SDGOrder = 12431;Hanset2SDGFee= 6837050
Hanset5SDGOrder = 18409;Hanset5SDGFee= 1.33465e+07
Hanset9SDGOrder = 1315;Hanset9SDGFee= 1578000
####5 Data Packages 3G,6G,10G,20G,30G Month###
120MB_Week_OrderTimes  = 51947;120MB_Week_OrderFee  = 1.12206e+07
6GB_OrderTimes  = 136;6GB_OrderFee  = 544000
10GB_OrderTimes = 135;10GB_OrderFee= 877500
Welcome_OfferB_OrderTimes = 0;Welcome_OfferB_OrderFee= 0
Welcome_OfferC_OrderTimes = 0;Welcome_OfferC_OrderFee= 0
";


            Regex regSubStr = new Regex(@"[^(\w+\b)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            MatchCollection matchesSubStr = regSubStr.Matches(invoice);


            foreach (Match match in matchesSubStr)
            {
                Console.WriteLine(match);
            }


            /*
            ####New Week Kullna Offer###
            NewWeekOffer_OrderTimes  = 25737;NewWeekOffer_OrderFee  = 1.19934e+07
            ####DataUnlimited Offer###
            1hourRamadan_OrderTimes = 137043;1HourRamadan_Fee= 20555400
            DataUnlimited1Day = 2758;DataUnlimited1DayFee= 1.2411e+06
            Sudani_InterNational_OrderTimes = 8;Sudani_InterNational_OrderFee= 11220
            Sudani_WCupRoaming_OrderTimes = 0;Sudani_WCupRoaming_OrderFee= 0
            Sudani_WeekEnd_OrderTimes = 0;Sudani_WeekEnd_OrderFee= 0
            ####Me2U Charging###
            Me2U Charging = 845955
            ####Ramadan 20 Minutes Offer###
            Ramadan20Offer_OrderTimes  = 0;Ramadan20Offer_OrderFee  = 0
            ####Gift Offers RaihBalak,40M,120M,300M,500MB,1GB,5GB###
            RBY_Gift_Donor_OrderTimes  = 115;RBY_Gift_Donor_OrderFee  = 9315
            40M_24H_Gift_Donor_OrderTimes  = 0;40M_24H_Gift_Donor_OrderFee  = 0
            120MB_Week_Gift_Donor_OrderTimes  = 172;120MB_Gift_Donor_OrderFee  = 37152
            300MB_2weeks_Gift_Donor_OrderTimes  = 95;300MB_Gift_Donor_OrderFee  = 52250
            500MB_Month_Gift_Donor_OrderTimes  = 79;500MB_Gift_Donor_OrderFee  = 57275
            1GB_Month_Gift_Donor_OrderTimes  = 145;1GB_Gift_Donor_OrderFee  = 174000
            5GB_Month_Gift_Donor_OrderTimes  = 33;5GB_Gift_Donor_OrderFee  = 132000
            Flatrate_V1.4_Donor_OrderTimes  = 22;Flatrate_V1.4_Donor_OrderFee  = 76978
            2SDG_Donor_OrderTimes  = 64;2SDG_Donor_OrderFee  = 10368
            Kullna_Week_Donor_OrderTimes  = 148;Kullna_Week_Donor_OrderFee  = 68968
            Money_Back_Youm_Donor_OrderTimes  = 155;Money_Back_Youm_Donor_OrderFee  = 10695
            Money_Back_Week_Donor_OrderTimes  = 547;Money_Back_Week_Donor_OrderFee  = 228646
            Money_Back_Month_Donor_OrderTimes  = 118;Money_Back_Month_Donor_OrderFee  = 165082
            Sudani_LTE_1.5GB_24Hours_Donor_OrderTimes  = 397;Sudani_LTE_1.5GB_24Hours_Donor_OrderFee  = 265990
            ####2SDG OfferAutoRenewal###
            Sudani_2SDG_AutoRenewal_OrderTimes  = 59697;Sudani_2SDG_AutoRenewal_OrderFee  = 9670914
            ####Sudani_Raih_Balak_Month###
            Rayh_Balk_Month_OrderTimes  = 2768;Rayh_Balk_Month_OrderFee  = 9685232
            ####Money_Back_Youm OfferAutoRenewal###
            Money_Back_Youm_AutoRenewal_OrderTimes  = 58313;Money_Back_Youm_AutoRenewal_OrderFee  = 4023597
            ####Money_Back_week Offer###
            Money_Back_week_OrderTimes  = 76143;Money_Back_week_OrderFee  = 3.18278e+07
            ####Money_Back_Month Offer###
            Money_Back_Month_OrderTimes  = 8827;Money_Back_Month_OrderFee  = 1.2349e+07
            ####40MB Offer###
            40MBOffer_OrderTimes  = 16591;40MBOffer_OrderFee  = 2.23978e+06
            #### 6 LTE Data Packages 2G,5G,15G,30G,50G,100G###
            LTE_2GB_Week_OrderTimes  = 3269;LTE_2GB_Week_OrderFee  = 7518700
            LTE_5GB_15Days_OrderTimes  = 4596;LTE_5GB_15Days_OrderFee  = 18384000
            LTE_15GB_15Days_OrderTimes  = 677;LTE_15GB_15Days_OrderFee  = 5754500
            LTE_30GB_30Days_OrderTimes  = 2774;LTE_30GB_30Days_OrderFee  = 27740000
            LTE_50GB_30Days_OrderTimes  = 420;LTE_50GB_30Days_OrderFee  = 6533520
            LTE_100GB_30Days_OrderTimes  = 37;LTE_100GB_30Days_OrderFee  = 920856
            LTE_10GB_30Days_OrderTimes  = 5932;LTE_10GB_30Days_OrderFee  = 3.8558e+07
            LTE_300MB_1Day_OrderTimes  = 71636;LTE_300MB_1Day_OrderFee  = 25072600
            LTE_1GB_24Hours_OrderTimes  = 211568;LTE_1GB_24Hours_OrderFee  = 141750560
            LTE_1GB_30days_OrderTimes  = 13872;LTE_1GB_30days_OrderFee  = 16646400
            LTE_5GB_7days_OrderTimes  = 12241;LTE_5GB_7days_OrderFee  = 3.05975e+07
            LTE_10GB_7days_OrderTimes  = 5129;LTE_10GB_7days_OrderFee  = 17951500
            LTE_2GB_daily_Ordertimes = 1821;LTE_2GB_daily_Orderfee= 18210000
            LTE_250GB_30Days_OrderTimes  = 77;LTE_250GB_30Days_OrderFee  = 2874564
            LTE_500GB_30Days_OrderTimes  = 7;LTE_500GB_30Days_OrderFee  = 406504
            LTE_1GB_Daily_30Day_OrderTimes  = 2209;LTE_1GB_Daily_30Day_OrderFee  = 1.43585e+07
            LTE_5GB_Daily_30Day_OrderTimes  = 411;LTE_5GB_Daily_30Day_OrderFee  = 6393105
            #### BoltOn Data Packages 2G,5G,15G,30G,50G,100G###
            Sudani_POS_500MB_OrderTimes  = 0;Sudani_POS_500MB_OrderFee  = 0
            Sudani_POS_LTE_1GB_OrderTimes  = 11881;Sudani_POS_LTE_1GB_OrderFee  = 6.1703e+06
            Sudani_POS_LTE_3GB_OrderTimes  = 1098; Sudani_POS_LTE_3GB_OrderFee  = 1.95624e+06
            B2B_BoltOn_1GB_OrderTimes   = 2026;B2B_BoltOn_1GB_OrderFee   = 1.02384e+06
            B2B_BoltOn_G5B_OrderTimes   = 610;B2B_BoltOn_G5B_OrderFee   = 1.22779e+06
            B2B_BoltOn_10GB_OrderTimes  = 1304;B2B_BoltOn_10GB_OrderFee  = 4.58558e+06
            B2B_BoltOn_3GB_OrderTimes  = 889;B2B_BoltOn_3GB_OrderFee  = 1.10013e+06
            B2B_BoltOn_30GB_OrderTimes  = 323;B2B_BoltOn_30GB_OrderFee  = 2.41832e+06
            B2B_BoltOn_50GB_OrderTimes  = 109;B2B_BoltOn_50GB_OrderFee  = 1.01521e+06
            B2B_BoltOn_100GB_OrderTimes  = 84;B2B_BoltOn_100GB_OrderFee  = 990846
            LTE_BoltOn_30GB_OrderTimes  = 238;LTE_BoltOn_30GB_OrderFee  = 2.41508e+06
            LTE_BoltOn_50GB_OrderTimes  = 118;LTE_BoltOn_50GB_OrderFee   = 1.4538e+06
            LTE_BoltOn_100GB_OrderTimes  = 227; LTE_BoltOn_100GB_OrderFee  = 3.26525e+06
            B2C_BoltOn_5GB_OrderTimes  = 674;B2C_BoltOn_5GB_OrderFee  = 1.86892e+06
            B2C_BoltOn_10GB_Ordertimes = 2300;B2C_BoltOn_10GB_Orderfee= 9.18069e+06
            Sudani_Postpaid1GB30Day_Ordertimes = 0;Sudani_Postpaid1GB30Day_Orderfee= 0
            #### Auto-Renewual Data Packages 40MB,RBD,120MB,1G,5G,10G,25G ###
            40MB_AutoRenew_OrderTimes  = 474;40MB_AutoRenew_OrderFee  = 63990
            RayhbalakDay_AutoRenew_OrderTimes  = 0;RayhbalakDay_AutoRenew_OrderFee  = 0
            120MB_Week_AutoRenew_OrderTimes  = 2680;120MB_Week_AutoRenew_OrderFee  = 578880
            300MB_AutoRenew_OrderTimes  = 850;300MB_AutoRenew_OrderFee  = 467500
            500MB_AutoRenew_OrderTimes  = 1274;500MB_AutoRenew_OrderFee  = 923650
            1GB_AutoRenew_OrderTimes  = 623;1GB_AutoRenew_OrderFee  = 747600
            5GB_AutoRenew_OrderTimes  = 288;5GB_AutoRenew_OrderFee  = 1152000
            10GB_AutoRenew_OrderTimes  = 394;10GB_AutoRenew_OrderFee  = 2.561e+06
            25GB_AutoRenew_OrderTimes  = 0;25GB_AutoRenew_OrderFee  = 0
            Sudani_Mini_RaibalkDay_AutoRenew_OrderTimes  = 185;Sudani_ Mini_RaibalkDay_AutoRenew_OrderFee  = 1297.31
            RaihBalakYoum_AutoRenewal_OrderTimes  = 216057;RaihBalakYoum_AutoRenewal_OrderFee  = 17500617
            ";

            */



            // Regex regSubStr = new Regex(@"[^(\w+)]\d+(\.\d+)?(e\+\d+)?", RegexOptions.Compiled);
            // MatchCollection matchesSubStr = regSubStr.Matches(invoice);


            // foreach (Match match in matchesSubStr)
            // {
            //     Console.WriteLine(match);
            // }




            /*

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



            */


            /*
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


            */








            // string[] subStr = Str.Split("SDG= ");

            // Console.WriteLine(subStr[1]);

            // Regex regSubStr = new Regex(@"\s", RegexOptions.Compiled);

            // Regex regSubStr1 = new Regex(@"[^=]", RegexOptions.Compiled);

            // MatchCollection matches = regSubStr.Matches(Str);
        }
    }
}