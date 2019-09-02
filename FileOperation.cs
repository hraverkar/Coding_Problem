using System;
using System.IO;
using System.Reflection;

/*
 * C# file stram class provide a stream for file opearation,
 * It can be used to perform synchronus and ascynoius read write Opearioon Haweli . 
 *
 */

namespace ConsoleApp76
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      const string path = @"C:\Users\Harshal\Desktop\Program\Test.txt";
      if (!File.Exists(path))
        return;
      var fsm = new FileStream(path,FileMode.Create);
      var sw = new StreamWriter(fsm);
      sw.WriteLine("Hello Harshal Raverkar");
      sw.Close();
      fsm.Close();

      var fpm = new FileStream(path,FileMode.OpenOrCreate);
      var sr = new StreamReader(fpm);

      var s = sr.ReadLine();
      Console.WriteLine(s);
      fpm.Close();
      sr.Close();

      using (TextWriter tw = File.CreateText(path))
      {
        tw.WriteLine("Hello Rajesh Bhai How are you");
        tw.WriteLine("Te");
        tw.Close();
      }

      using (TextReader tr = File.OpenText(path))
      {
        Console.WriteLine(tr.ReadToEnd());

      }

    }
  }
}