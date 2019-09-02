using System;
using System.Reflection;

/*
 * C# reflection is a process to get metafata of a type at runtime.
 * the System Reflection namespace contains required classes for reflection sunc as
 *
 * Type, MemberInfo, ConstruicterInfo, MethodInfo, FieldInfo
 */

namespace ConsoleApp76
{
  class Program
  {
    public static void Main()
    {
      Type test = typeof(System.String);
      Console.WriteLine("hello harshal");
      var ci = test.GetMethods(BindingFlags.Public | BindingFlags.Instance);
      foreach (var variable in ci)
      {
        Console.WriteLine(variable);
      }


      var a = 10;
      Type t = a.GetType();
      Console.Write(t);
      Console.WriteLine(t.Assembly);
      Console.WriteLine(t.AssemblyQualifiedName);
      Console.WriteLine(t.Attributes);
      Console.WriteLine(t.ContainsGenericParameters);
      Console.WriteLine(t.FullName);
      Console.WriteLine(t.IsImport);
      Console.WriteLine(t.IsGenericType);
    }
  }

}