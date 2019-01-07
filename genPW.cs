using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WP10
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length < 3)
            {
                Console.WriteLine("command MaxLength MaxUpperCaseCnt MaxLowerCaseCnt");
                return;
            }
            else
            {
                Random rNum = new Random();
                int totalLength = Int32.Parse(args[0]);
                int MaxUpperCnt = Int32.Parse(args[1]);
                int MaxLowerCnt = Int32.Parse(args[2]);
                int MaxNumCnt = totalLength - MaxUpperCnt - MaxLowerCnt;
                int NumCnt = 0;
                int UpperCnt = 0;
                int LowerCnt = 0;
                string WP = "";
                while (true)
                {
                    int tmpNum = rNum.Next(48, 122);
                    if (tmpNum >= 48 && tmpNum <= 57)
                    {
                        WP += Convert.ToChar(tmpNum);
                        NumCnt++;
                    }
                    else if (tmpNum >= 65 && tmpNum <= 90)
                    {
                        WP += Convert.ToChar(tmpNum);
                        UpperCnt++;
                    }
                    else if (tmpNum >= 97 && tmpNum <= 122)
                    {
                        WP += Convert.ToChar(tmpNum);
                        LowerCnt++;
                    }
                    if(WP.Length==totalLength)
                    {
                        if (UpperCnt == MaxUpperCnt && LowerCnt == MaxLowerCnt)
                        {
                            break;
                        }
                        else
                        {
                            LowerCnt = UpperCnt = 0;
                            WP = "";
                        }
                    }
                }
                Console.WriteLine(WP);
            }

        }
    }
}
