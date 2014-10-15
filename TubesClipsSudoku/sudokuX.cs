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
            return xValue[x-1, y-1];
        }

        public void setValue(int x, int y, int value)
        {
            xValue[x-1, y-1] = value;
        }

        public string getVal(int x, int y)
        {
            if (xValue[x-1, y-1] == 0)
            {
                return "any";
            }
            else
            {
                return xValue[x-1, y-1].ToString();
            }
        }
        public void clpConversion(string FileName)
        {
            string tempAdd = "C:\"" + FileName + ".clp";
            using (StreamWriter file = new StreamWriter(@tempAdd))
            {
                file.WriteLine("(defrule grid-values\n");
                file.WriteLine("?f <- (phase grid-values)\n");
                file.WriteLine(" =>\n");
                file.WriteLine("(retract ?f)\n");
                file.WriteLine("(assert (phase expand-any))\n");
                file.WriteLine("(assert (size 3))\n");
 
   file.WriteLine("(assert (possible (row 1) (column 1) (diagonal 1) (value %s) (group 1) (id 1)))", getVal(1,1));
   file.WriteLine("(assert (possible (row 1) (column 2) (value %s) (group 1) (id 2)))", getVal(1,2));
   file.WriteLine("(assert (possible (row 1) (column 3) (value %s) (group 1) (id 3)))", getVal(1,3));
   file.WriteLine("(assert (possible (row 2) (column 1) (value %s) (group 1) (id 4)))", getVal(2, 1));
   file.WriteLine("(assert (possible (row 2) (column 2) (diagonal 1) (value %s) (group 1) (id 5)))", getVal(2, 2));
   file.WriteLine("(assert (possible (row 2) (column 3) (value %s) (group 1) (id 6)))", getVal(2, 3));

   file.WriteLine("(assert (possible (row 1) (column 4) (value %s)   (group 2) (id 7)))", getVal(1, 4));
   file.WriteLine("(assert (possible (row 1) (column 5) (value %s) (group 2) (id 8)))", getVal(1, 5));
   file.WriteLine("(assert (possible (row 1) (column 6) (diagonal 2) (value 2) (group 2) (id 9)))", getVal(1, 6));
   file.WriteLine("(assert (possible (row 2) (column 4) (value %s) (group 2) (id 10)))", getVal(2, 4));
   file.WriteLine("(assert (possible (row 2) (column 5) (diagonal 2) (value %s) (group 2) (id 11)))", getVal(2, 5));
   file.WriteLine("(assert (possible (row 2) (column 6) (value 4) (group 2) (id 12)))", getVal(2, 6));

   file.WriteLine("(assert (possible (row 3) (column 1) (value %s) (group 3) (id 13)))", getVal(3, 1));
   file.WriteLine("(assert (possible (row 3) (column 2) (value %s) (group 3) (id 14)))", getVal(3, 2));
   file.WriteLine("(assert (possible (row 3) (column 3) (diagonal 1) (value %s) (group 3) (id 15)))", getVal(3, 3));
   file.WriteLine("(assert (possible (row 4) (column 1) (value %s)   (group 3) (id 16)))", getVal(4, 1));
   file.WriteLine("(assert (possible (row 4) (column 2) (value 5)   (group 3) (id 17)))", getVal(4, 2));
   file.WriteLine("(assert (possible (row 4) (column 3) (diagonal 2) (value 6)   (group 3) (id 18)))", getVal(4, 3));

   file.WriteLine("(assert (possible (row 3) (column 4) (diagonal 2) (value 5)   (group 4) (id 19)))", getVal(3, 4));
   file.WriteLine("(assert (possible (row 3) (column 5) (value %s)   (group 4) (id 20)))", getVal(3, 5));
   file.WriteLine("(assert (possible (row 3) (column 6) (value %s)   (group 4) (id 21)))", getVal(3, 6));
   file.WriteLine("(assert (possible (row 4) (column 4) (diagonal 1) (value %s)   (group 4) (id 22)))", getVal(4, 4));
   file.WriteLine("(assert (possible (row 4) (column 5) (value 3) (group 4) (id 23)))", getVal(4, 5));
   file.WriteLine("(assert (possible (row 4) (column 6) (value %s) (group 4) (id 24)))", getVal(4, 6));

   file.WriteLine("(assert (possible (row 5) (column 1) (value 5) (group 5) (id 25)))", getVal(5, 1));
   file.WriteLine("(assert (possible (row 5) (column 2) (diagonal 2) (value %s) (group 5) (id 26)))", getVal(5, 2));
   file.WriteLine("(assert (possible (row 5) (column 3) (value %s) (group 5) (id 27)))", getVal(5, 3));
   file.WriteLine("(assert (possible (row 6) (column 1) (diagonal 2) (value %s)   (group 5) (id 28)))", getVal(6, 1));
   file.WriteLine("(assert (possible (row 6) (column 2) (value %s)   (group 5) (id 29)))", getVal(6, 2));
   file.WriteLine("(assert (possible (row 6) (column 3) (value %s)   (group 5) (id 30)))", getVal(6, 3));

   file.WriteLine("(assert (possible (row 5) (column 4) (value %s)   (group 6) (id 31)))", getVal(5, 4));
   file.WriteLine("(assert (possible (row 5) (column 5) (diagonal 1) (value %s)   (group 6) (id 32)))", getVal(5, 5));
   file.WriteLine("(assert (possible (row 5) (column 6) (value %s)   (group 6) (id 33)))", getVal(5, 6));
   file.WriteLine("(assert (possible (row 6) (column 4) (value 1)   (group 6) (id 34)))", getVal(6, 4));
   file.WriteLine("(assert (possible (row 6) (column 5) (value %s) (group 6) (id 35)))", getVal(6, 5));
   file.WriteLine("(assert (possible (row 6) (column 6) (diagonal 1) (value %s) (group 6) (id 36))))", getVal(6, 6));
            }
        }
    }


}
