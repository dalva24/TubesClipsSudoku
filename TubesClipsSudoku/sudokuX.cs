using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TubesClipsSudoku
{
    class sudokuX
    {
        int[,] xValue;

        public int[,] readText(string FileLocation)
        { /*Reads and sets xValue according to the .txt file pointed by FileLocation*/
            xValue = new int[6, 6];
            using (StreamReader sr = File.OpenText(FileLocation))
            {
                string s = "";
                for (int i = 0; i <= 5; i++)
                {
                    s = sr.ReadLine();
                    Console.WriteLine(s);

                    string[] tempString = s.Split(' ');
                    for (int j = 0; j <= 5; j++)
                    {

                        if (tempString[j].Equals('*'))
                        {
                            xValue[i, j] = 0;
                        }
                        else
                        {
                            try
                            {
                                xValue[i, j] = int.Parse(tempString[j]);
                            }
                            catch (System.FormatException F)
                            {
                                //Console.WriteLine(F);
                            }
                        }
                        //Console.Write(xValue[i, j] + " ");
                        //Console.Write(tempString[j]);
                    }
                    //Console.WriteLine();
                }
            }
            return xValue;
        }

        public int getValue(int x, int y)
        {
            return xValue[x, y];
        }

        public void setValue(int x, int y, int value)
        {
            xValue[x, y] = value;
        }
    }


}
