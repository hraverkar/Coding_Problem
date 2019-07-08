using System;
using System.IO;
using System.Linq;

namespace ConsoleApp40
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = File.ReadAllText(@"C:\Users\Harshal\Documents\p022_names.txt").Split(',').
        Select(x => x.Trim('"').Trim()).OrderBy(x => x);
      var result = names.Select((x, i) => x.ToCharArray().Sum(y => (int)y- 64) * (i + 1)).Sum();
      Console.WriteLine(result);
    }
  }
}
