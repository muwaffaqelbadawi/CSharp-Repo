namespace dotnet // Note: actual namespace depends on the project name.
{

    class Get_File_Name // This is the name of the file
    {
        public string[] FileNamesArr(string path)
        {
            string[] fName = Directory.GetFiles(path: path);
            return fName;
        }

        public string PureFileName(string f_path)
        {
            string f_name = Path.GetFileNameWithoutExtension(path: f_path);
            return f_name;
        }

        public string Get_Single_FileName()
        {
            string[] file_Name = FileNamesArr("D:\\UIpath\\OCS\\05\\20230405\\bak");
            return file_Name[6];
        }

        public void GetFileNames()
        {
            foreach (string f_name in FileNamesArr("D:\\UIpath\\OCS\\05\\20230405\\bak"))
            {
                Console.WriteLine(f_name);
            }
        }

        public void Get_Pure_FileName()
        {
            string f_path = Get_Single_FileName();
            Console.WriteLine(PureFileName(f_path));
        }

        public void Current_Day()
        {


            // Console.WriteLine(DateTime.Now.Day);


            // string today = "d:\\uipath\\ocs\\05\\20230405\\bak\\Report_Pos_" + String.Format("{0:yyyyMMdd}", DateTime.Now.Date);

            DateTime date = new DateTime(2023, 04, 04);
            string extension = ".unl";

            string Report_Pos = "d:\\uipath\\ocs\\05\\20230405\\bak\\Report_Pos_" + String.Format("{0:yyyyMMdd}", date) + extension;


            Console.WriteLine(Report_Pos);
        }
    }
}