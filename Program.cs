// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
            int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
            //This will use the file Ext as the Key and the MIME type as the value.
            Dictionary <string, string> fileExtention = new Dictionary<string, string>();
            List<string> fileName = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string EXT = inputs[0].ToLower(); // file extension
                string MT = inputs[1]; // MIME type.
                fileExtention.Add(EXT, MT);
            }
            for (int i = 0; i < Q; i++)
            {
                string FNAME = Console.ReadLine();// One file name per line.
                FNAME = FNAME.ToLower();
                if (FNAME.Contains('.'))
                {
                     FNAME = FNAME.Substring(FNAME.LastIndexOf('.')+1);
                }
                else
                {
                    FNAME = "N/A";
                }
                fileName.Add(FNAME);
            }
             
            foreach(string extention in fileName)
            {
                if(extention == "N/A")
                {
                    Console.WriteLine("UNKNOWN");
                }
                else if (fileExtention.ContainsKey(extention))
                {
                    string MIMETypeToReturn = string.Empty;
                    fileExtention.TryGetValue(extention, out MIMETypeToReturn);
                    Console.WriteLine(MIMETypeToReturn);
                }
                else
                {
                    Console.WriteLine("UNKNOWN"); 
                }
            }  
        }
} 