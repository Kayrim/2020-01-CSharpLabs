using System;
using System.IO;

namespace lab_20_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            // Overall System
            try
            {
                // Department
                try
                {
                    // Yourself
                    try
                    {
                        // custom exception
                        // read database and it fails

                        throw new Exception("Database read has failed for user JOE");

                    }
                    catch 
                    {

                        throw;
                    }
                }
                catch
                {

                    throw;
                }
            }
            catch (Exception e)
            {
                File.AppendAllText("errorLog.txt", Environment.NewLine + e.Message);

                
            }
        }
    }
}
