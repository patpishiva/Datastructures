using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ProgramsOnStrings
    {
        /// <summary>
        /// Example
        /// input: AAAABBBCCDAAA
        /// output: 4A3B2C1D3A
        /// Company : Amazon
        /// </summary>
        public string StringEncoding(string stringToEncode)
        {
            string strResult = "";
            try
            {
                int cnt = 0;
                for(int i=0;i<stringToEncode.Length;i++)
                {
                    char ch = stringToEncode[i];
                    int j = i + 1;
                    cnt = 1;
                    while (j < stringToEncode.Length  && ch == stringToEncode[j] )
                    {
                        cnt = cnt + 1;
                        j = j + 1;
                        if (j >= stringToEncode.Length)
                            break;
                    }

                    strResult = strResult + cnt.ToString() + ch;
                    i = j-1;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return strResult;
        }
    }
}
