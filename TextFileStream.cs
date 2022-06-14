using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{
    public class FileStream
    {
        internal static string fileName = $"StudentAttendance.txt";
         

        internal static void AppendFile(List<string> dataInput, List<string> dateTime, List<string> status)
        {


            using (StreamWriter file = File.AppendText(fileName))
            {
                
                    WriteDataInFile(file, dataInput, dateTime, status);

            }
                
        }

        internal static void WriteDataInFile(StreamWriter file, List<string> dataInput, List<string> dateTime, List <string> status)
        {
            
            foreach (var data in dataInput)
            {

                if (data.Length == 2)
                {
                    file.Close();
                }
                else
                {
                    file.Write(data);
                    foreach (var data1 in dateTime)
                    {
                        file.Write($"\t\t{data1}");
                    }

                    foreach (var data2 in status)
                    {
                        file.Write($"\t\t{data2}\n");
                    }
                }
               
            }

        }


        internal static List<string> ReadFile()
        {
            List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    dataContent.Add(line);
                    line = sr.ReadLine();
                }
            }

            return dataContent;
        }


        internal static void DisplayData()
        {
            List<string> dataContent = ReadFile();

            foreach (var data in dataContent)
            {
                Console.WriteLine(data);
            }
        }
    }
}