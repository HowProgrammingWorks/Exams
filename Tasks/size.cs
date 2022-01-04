using System;

namespace ConsoleApplication1
{
    internal class Size
    {
        static void Main()
        {
            Console.Clear();
            
            long userFileSize = Convert.ToInt64(Console.ReadLine());
            
            string result = FileSizeConverter(userFileSize);
            Console.WriteLine(result);
        }

        static string FileSizeConverter( long fileSize )
        {
            if(fileSize <= 0)
            {
                return "0";   
            }
            else
            {
                long exp = (long) Math.Floor(Math.Log(fileSize)/Math.Log(1000));
        
                if(exp == 0)
                {
                    return fileSize + " byte";
                }
                else if(exp == 1)
                {
                    return fileSize / 1000 + " kb";
                }
                else if(exp == 2)
                {
                    return fileSize / 1000000 + " mb";
                }
                else if(exp >= 3)
                {
                    return fileSize / 1000000000 + " gb";
                }
            }

            return "Invalid number";
        }
    }
}