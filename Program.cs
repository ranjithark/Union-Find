using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
         string theInputFile = @"F:\Holidays Project\Algorithms\UnionFind\UnionFind\data.txt";
         int wordPointer=0;
            
         if (File.Exists(theInputFile))
         {

             System.IO.StreamReader myFile = new System.IO.StreamReader(theInputFile);
             string fileContents = myFile.ReadToEnd();

             myFile.Close();
             string[] words=fileContents.Split(' ','\n');
             
             //create objects
             QuickFind quickFindObj = new QuickFind(Convert.ToInt32(words[wordPointer++]));
             
             while (wordPointer < words.Length)
             {
                 if (!quickFindObj.connected(Convert.ToInt32(words[wordPointer]),Convert.ToInt32(words[wordPointer + 1])))
                 {
                     quickFindObj.Union(Convert.ToInt32(words[wordPointer]), Convert.ToInt32(words[wordPointer + 1]));
                 }
                 wordPointer=wordPointer+2;

             }



             //Check whether Nodes 4 and 7 are connected
             Console.Out.WriteLine(quickFindObj.connected(4, 7));


             //Check whether Nodes 0 and 9 are connected
             Console.Out.WriteLine(quickFindObj.connected(0, 9));


           
             
         }
         else
         {

             Console.Out.Write("Reconfigure the File path in Program.cs file");


         }
            Console.Read();

            

        }
    }
}
