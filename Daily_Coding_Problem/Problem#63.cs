using System;

namespace ConsoleApp57
{
  class Program
  {
    static void Main()
    {
      char[,] arr = { { 'F', 'A', 'C', 'I' }, { 'O', 'B', 'Q', 'P' }, { 'A', 'N', 'O', 'B' }, { 'M', 'A', 'S', 'S' } };
      var Row = 4;
      var Column = 4;
      var str = "MASS";
      char[] ch = str.ToCharArray();
      var T = 0;
      int B = Row - 1;
      int L = 0;
      int R = Column - 1;
      int dir=0;
      while(T <= Row && L <= Column)
      {
        if(dir == 0)
        {
          for(int i = 0; i <= R; i++)
          {
            Console.WriteLine(arr[i,0]);
          }
          //R--;
         // T++;
          dir = 1;
        }

        Console.WriteLine("**********//*********");
        if(dir == 1)
        {
          for(int i=T;i<=B;i++)
          {
            Console.WriteLine(arr[R, i]);
          }
          //R--;
          dir = 2;
        }
        Console.WriteLine("**********//*********");
        if (dir == 2)
        {
          for(int i=R;i>=0;i--)
          {
            Console.WriteLine(arr[i,B]);
          }
         // B--;
        }


      }
      /*
       for(int j=0; j<ch.Length;j++)
            {
              if(ch[j] == arr[0][i])
              {

              }
            }*/
    }
  }
}

