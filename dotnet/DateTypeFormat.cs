namespace dotnet // Note: actual namespace depends on the (project name).
{
    class DateTypeFormat // File name
    {

        public void DateFormat()
        {
            // Console.WriteLine("Welcome to the show!");

            // Console.WriteLine(DateTime.Now);


            DateTime date = new DateTime(2021, 11, 31);

            string newDateFormat = String.Format("{0:d/M/yyyy}", date);


            Console.WriteLine(newDateFormat);


            // CultureInfo myCItrad = new CultureInfo(0x040A, false);

            // CultureInfo ci = CultureInfo.GetCultureInfo("es-ES");


            // string result = date.ToString( @"\'dd-MMM-yyyy\'", ci).ToUpper();

            //CultureInfo ci = CultureInfo.GetCultureInfo("en-US");
            // string result = date.ToString( @"\'dd-MMM-yyyy\'", ci ).ToUpper();
            // Console.WriteLine(date);

        }


    }
}