using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{
    public class Input
    {
        
            public static void Main(string[] args)
            {

                string selection = Functions.DisplayMenu();

                switch (selection)
                {
                    case "1":

                    do
                    {
                        List<string> dataInput = Functions.GetData();
                        List<string> dateTime = Functions.Datetime();
                        List<string> status = Functions.Validator();
                        FileStream.AppendFile(dataInput, dateTime, status);
                    }
                    while (true);
                    

                    
                    case "2":
                        try
                        {
                            Console.WriteLine("Displaying your inputs in console....\n");
                            FileStream.DisplayData();
                            Console.WriteLine("\nSuccesfully displayed");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Ivalid Input");
                        break;

                }

            }








        }
        

      

        }
    

