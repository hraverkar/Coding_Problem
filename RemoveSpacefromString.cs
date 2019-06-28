using System;
using System.Linq;
using System.Text;

namespace ConsoleApp24
{
  class Program
  {
    static void Main(string[] args)
    {
      string sentence = "T    his is b  ett     er.";
      //sentence =new string( sentence.ToCharArray().Where
      //  (c => !char.IsWhiteSpace(c)).ToArray());
      //Console.WriteLine(sentence);

      StringBuilder sb = new StringBuilder(sentence);
      var t =sentence.ToCharArray();
      for(int i=0;i<t.Length;i++)
      {
        {
          sb.Replace( " ",string.Empty);
        }
      }
     Console.WriteLine( new string(sb.ToString()));

    }
  }
}
