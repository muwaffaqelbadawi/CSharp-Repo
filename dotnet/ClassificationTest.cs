namespace dotnet // Note: actual namespace depends on the (project name).
{
    class ClassificationTest // File name
    {
        String[] ErrCodeArr = new String[12] { "Ax001", "Ax002", "Ax003", "Ax004", "Ax005", "Bx001", "Bx002", "Bx003", "Cx001", "Cx002", "Cx003", "Cx004" };

        String[] AxArr = new String[]{};
        String[] BxArr = { };
        String[] CxArr = { };

        List<String> AxList = new List<String>();




        public void ClassifyErr()
        {
            foreach (string ErrCode in ErrCodeArr)
            {
                if (ErrCode[0] == 'A')
                {
                    // AxArr = AxArr.Append(ErrCode).ToArray();
                    // AxArr = AxArr.Concat({ErrCode}).ToArray();
                    AxList.Add(ErrCode);
                    AxList.Append(ErrCode);
                    // Console.WriteLine(ErrCode);
                }

                else if (ErrCode[0] == 'B')
                {
                    BxArr = BxArr.Append(ErrCode).ToArray();
                    // Console.WriteLine(ErrCode);
                }

                else if (ErrCode[0] == 'C')
                {
                    CxArr = CxArr.Append(ErrCode).ToArray();
                    // Console.WriteLine(ErrCode);
                }

            }
        }

        public void Show()
        {
            Console.WriteLine("AxList: ");

            foreach (string ErrCode in AxList)
            {
                Console.WriteLine(ErrCode);
            }

            // Console.WriteLine();

            // Console.WriteLine("BxArr: ");

            // foreach (string ErrCode in BxArr)
            // {
            //     Console.WriteLine(ErrCode);
            // }

            // Console.WriteLine();

            // Console.WriteLine("CxArr: ");

            // foreach (string ErrCode in CxArr)
            // {
            //     Console.WriteLine(ErrCode);
            // }
        }
    }
}