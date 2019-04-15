using System;
using System.IO;
using Microsoft.Azure;

namespace ShimandFackes
    {
    public static class Y2KChecker
        {
        public static void Check ()
            {
            DateTime dateTime = new DateTime(2000, 1, 1);
           
            DateTime now = DateTime.Now;
            if ( now == dateTime )
                throw new ApplicationException("y2kbug!");
            }
        public static string ReadFileText ()
            {
            var file = File.ReadAllText("c:\temp");
            return file;
            }
        }
    
    public class Program
        {
        static void Main (string[] args)
            {
             
            //var result  = CloudConfigurationManager.GetSetting("name");
            Console.WriteLine("running console app");
            }
        }
    }
