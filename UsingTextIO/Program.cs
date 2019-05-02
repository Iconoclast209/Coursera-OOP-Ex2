using System;
using System.IO;

namespace UsingTextIO
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = null;
            try
            {
                input = File.OpenText("quotes.txt");

                string line = input.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = input.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (input != null)
                {
                    input.Close();
                }
            }
        }
    }
}
