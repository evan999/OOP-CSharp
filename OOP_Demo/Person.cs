using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace OOP_Demo
{
    class Person : IDisposable
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // flag to check if object has been disposed
        private bool disposed = false;

        StreamReader sr;
        StreamWriter outputFile;

        public void ReadDetails(string filename)
        {
            sr = new StreamReader(filename);

            try
            {
                // Open text file using stream reader
                using (sr)
                {
                    // Read stream to a string and write string to the console
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
                   
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }
        }

        public bool WriteDetails(string fileName)
        {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            string[] lines = { this.PersonID.ToString(), this.FirstName, this.LastName, this.Gender, this.Age.ToString() };

            try
            {
                // Write string array to a new file
                using (outputFile)
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                result = true;
                    
            }

            catch (Exception e)
            {
                Console.WriteLine("This file could not be written");
                Console.WriteLine(e.Message);
                result = false;
            }

            finally
            {
                outputFile.Close();
                outputFile = null;
            }

            return result;
        }

        public void Dispose()
        {
            
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // If object hasn't been disposed yet
            if (!disposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }

                    if (outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }

            disposed = true;
        }
    }
}
