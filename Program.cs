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
            bool backTop = true;
            string restart = "";
            while (backTop)
            { 

                while (loop)
                {

                    Console.WriteLine("enter a number or operator // type = to get the answer");
                    var = Console.ReadLine();

                    if (rx.IsMatch(var))

                    {
                        arrlist.Add(var);

                    }
                    else if (var.Equals("="))
                    {
                        loop = false;
                        Console.Beep();
                        

                    }
                    else
                    {
                        Console.WriteLine("invalid number or operator");

                    }

                }


                try
                {
                    int i = 0;



                    while (i < arrlist.Count)
                    {

                        if (arrlist[i].Equals("*"))
                        {
                            arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) * Convert.ToDouble(arrlist[i + 1]));
                            arrlist.RemoveAt(i);
                            arrlist.RemoveAt(i);
                            i = 0;
                            
                        }

                        else if (arrlist[i].Equals("/"))
                        
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
                        if (arrlist[i].Equals("+"))
                        {
                            arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) + Convert.ToDouble(arrlist[i + 1]));
                            arrlist.RemoveAt(i);
                            arrlist.RemoveAt(i);
                            i = 0;
                            

                        }
                        else if (arrlist[i].Equals("-"))
                        {
                            arrlist[i - 1] = Convert.ToString(Convert.ToDouble(arrlist[i - 1]) - Convert.ToDouble(arrlist[i + 1]));
                            arrlist.RemoveAt(i);
                            arrlist.RemoveAt(i);
                            i = 0;
                            
                        }

                        i++;
                    }
                


                    Console.WriteLine(arrlist[0]);
                    
                    Console.WriteLine("do you want to restart the calculator? yes/no?");
                    restart = Console.ReadLine();
                    if (restart == "yes")
                    {
                        arrlist.Clear();
                        loop = true;
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using my calculator");
                        backTop = false;
                    }

                }
                
                catch (Exception e)
                {
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("This is the error");
                    Console.WriteLine(e.StackTrace);
                    backTop = false;

                }
               

                
                

            }
        }


        //RAPPORT
        /*
    Ett av problemen jag har stött på när jag har kodat min miniräknare var med uträkningen. Uträkningen gjordes bara med den första operatorn jag hade satt in i min första if sats.
    Jag testade att byta operator i första if satsen och då var det den nya operatorn som fungerade. 
    Jag märkte på så sätt att det måste vara något fel med koden i de andra if satserna.
    Jag började med att jämföra kodraderna steg för steg men hittade fortfarande inte vad skillnaden kunde vara.
    Jag testade sedan att skriva en Console.Writeline inuti alla if satser och kunde så sätt se vilka if satser den gick in i och inte.
    Då fick jag resultatet att det var bara den första if satsen som fungerade.
    Efter mycket om och men så hittade jag felet.
    Det var så enkelt att jag hade missat att ange positionen i arraylisten i if satsen. jag hade skrivit " if (arrlist.Equals("/")) " istället för " (arrlist[i].Equals("/")) ".
    På så sätt kunde koden inte hitta i listan och jämföra om "i" t.ex var equals to "/" och kom inte in i if satsen.
    Detta var ett av alla problem jag har stött på under uppgiften. 

        */
    }

}
