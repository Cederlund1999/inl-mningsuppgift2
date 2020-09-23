using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rx = new Regex("[0-9*/+-]+");
            bool loop = true;
            ArrayList arrlist = new ArrayList();
            string var;


            while (loop)
            {

                Console.WriteLine("enter a number or operator");
                var = Console.ReadLine();

                if (rx.IsMatch(var))

                {
                    arrlist.Add(var);

                }
                else if (var.Equals("="))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("invalid number or operator");

                }

            }
            int i = 0;
            try
            {




                while (i < arrlist.Count)
                {

                    if (arrlist[i].Equals("*"))
                    {
                        arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) * Convert.ToDouble(arrlist[i + 1]));
                        arrlist.RemoveAt(i);
                        arrlist.RemoveAt(i);
                        i = 0;
                    }
                    else if (arrlist.Equals("/"))
                    {
                        arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) / Convert.ToDouble(arrlist[i + 1]));
                        arrlist.RemoveAt(i);
                        arrlist.RemoveAt(i);
                        i = 0;

                    }



                    i++;
                }
                i = 0;
                while (i < arrlist.Count)

                {
                    if (arrlist.Equals("+"))
                    {
                        arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) + Convert.ToDouble(arrlist[i + 1]));
                        arrlist.RemoveAt(i);
                        arrlist.RemoveAt(i);
                        i = 0;

                    }
                    else if (arrlist.Equals("-"))
                    {
                        arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) - Convert.ToDouble(arrlist[i + 1]));
                        arrlist.RemoveAt(i);
                        arrlist.RemoveAt(i);
                        i = 0;

                    }

                    i++;
                }



                Console.WriteLine(arrlist[0]);

            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("This is the error");
                Console.WriteLine(e.StackTrace);

            }
        }
    }
}