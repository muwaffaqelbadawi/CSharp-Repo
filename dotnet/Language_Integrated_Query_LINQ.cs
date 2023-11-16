


namespace dotnet // Note: actual namespace depends on the project name.
{

    class Language_Integrated_Query_Class // This is the name of the file
    {


        // string collection
        public void LINQC_method()
        {
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

            // LINQ Method Syntax
            var results = stringList.Where(s => s.Contains("T"));

            foreach (var item in results)
            {
                Console.Write(item + " ");
            }

        }

    }
}