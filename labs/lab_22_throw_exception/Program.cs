using System;
using System.IO;

namespace lab_22_throw_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // OVERALL SYSTEM
            try {
                // DEPARTMENT
                try {
                    // YOU!
                    try {
                        // custom exception
                        // read database and FAILS
                        throw new Exception("Database read has failed for user Joe");
                    }
                    catch {
                        // don't handle
                        // pass up
                        throw;
                    }
                }
                catch {
                    throw;
                }
            }
            catch(Exception e) {
                File.AppendAllText("ErrorLog.txt", Environment.NewLine + e.Message);  // LOGGING SYSTEM
            }
        }
    }
}
