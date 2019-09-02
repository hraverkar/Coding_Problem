using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

/*. Serialization :
      Is the process of converting object into byte stream so 
      that it can be saved to memory file or database.
      the reverse process of serialization is called Deserilization
 */

namespace ConsoleApp76
{
  public class Test
  {
    private static void Validate(int age)
    {
      if (age < 18)
      {
        throw new InvalidAgeException("Hello Wrong Test");
      }
    }

    public static void Main(string[] args)
    {
      try
      {
        Validate(12);
      }
      catch (InvalidAgeException e)
      {
        Console.WriteLine(e.ToString());
      }
    }
  }

  internal class InvalidAgeException : Exception
  {
    public InvalidAgeException(string helloWrongTest):base(helloWrongTest)
    {
    }
  }
}