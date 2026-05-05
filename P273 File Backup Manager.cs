using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Copy("new_text_data.txt","backup.txt",true);
    }
}