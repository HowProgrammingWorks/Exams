using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Size
    {
        static void Main()
        {
            Console.Clear();
            
            long userFileSize = Convert.ToInt64(Console.ReadLine());
            
            string result = FileSizeConverter(userFileSize);
            Console.WriteLine(result);
        }

        private static readonly (long coeficient, string suffix)[] Coefficients = 
        {
            (1, "Byte"),
            (1000, "KB"),
            (1000000, "MB"),
            (1000000000, "GB")
        };
            
        public static string FileSizeConverter( long fileSize )
        {
            if(fileSize <= 0)
            {
                return "0";   
            }

            long exp = (long) Math.Floor(Math.Log10(fileSize)/Math.Log10(1000));

            if (exp >= Coefficients.Length)
            {
                exp = Coefficients.Length - 1;
            }

            var multiplier = Coefficients[exp];
            return fileSize / multiplier.coeficient + " " + multiplier.suffix;
        }
    }
}
