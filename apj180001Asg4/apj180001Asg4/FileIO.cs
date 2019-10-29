/* Written by Abhishek Jajal for CS6326.001, assignment 4, starting October 11, 2019.
 * This class interacts with the Files and also with Form1.cs via function calls.
    NetID: apj180001 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace apj180001Asg4
{
    class FileIO
    {
        private static string filePath; // path for the file, which user has opened.
        private static int lineNumber; // to store the line number.
        private static long currentStatus; // stores the size of data already been processed.
        private static long fileSize; // stores the file size of the .txt file.
        public static Boolean matchCaseEnabled = false; // for matchCase option
        public static Boolean click2CopyEnabled = false; // for click2Copy feature
        // Queue that stores the results as resultSet class.
        public static Queue<resultSet> resultQueue = new Queue<resultSet>();

        public static void setFilePath(string path) // sets the filePath
        {
            filePath = path; 
        }
        public static Boolean searchFile(String searchTerm, Form1 form1)
        {
            // Searches the file for the searchTerm
            if (File.Exists(filePath)) //if the file already exisits then only we can read from it.
            {
                string line;
                FileInfo fileInfo = new FileInfo(filePath);
                //Emptying the queue, to store new results.
                resultQueue.Clear();
               
                System.IO.StreamReader file =
        new System.IO.StreamReader(filePath);
                lineNumber = 0;

                currentStatus = 0;
                fileSize = fileInfo.Length;           
                while ((line = file.ReadLine()) != null) // Repeating for each line in .txt file.
                {
                    Thread.Sleep(1); // pause of 1 millisecond, to simulate a long document. 
                    lineNumber++;
                    //If matchCase is Enabled, do a case sensitive search, else to case in-sensitive search (default option).
                    if (matchCaseEnabled==true)
                    {
                        if (line.IndexOf(searchTerm, StringComparison.Ordinal) >= 0)
                        {
                            //Putting the results into Queue
                            resultQueue.Enqueue(new resultSet(lineNumber, line));
                    
                        }
                    }
                    else
                    {
                        if (line.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            //Putting the results into Queue
                            resultQueue.Enqueue(new resultSet(lineNumber, line));
                        }
                    }
                    /* I opened the file, in hex editor, and got to know, that 
                     * at the end of every line there is '0d' '0a' ( 2 bytes)
                    which are the two characters not returned by line.length in
                    every line, hence adding 2 to compensate for it*/
                    currentStatus += line.Length+2;
                    //Reports the progress, which in turn leads to printing of results into the listView.
                    form1.backgroundWorker1.ReportProgress(Convert.ToInt32(Math.Ceiling(currentStatus * 100.0 / fileSize)));
                    if (form1.backgroundWorker1.CancellationPending)
                    {
                        //If Cancel button was pressed.
                        // Reset progress percentage to ZERO and return
                        form1.backgroundWorker1.ReportProgress(0);
                        return true;
                    }
                }    
            }
            return false; // If cancel button, wasn't pressed.
        }
    }
}

