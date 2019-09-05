using System.Runtime.InteropServices;

namespace ConsoleApp87
{
  public class API
  {
    [DllImport("user32.dll", EntryPoint = "MessageBox")]
    public static extern int ShowMessage(int hwnd, string text, string caption, uint type);
  }
  class Program
  {
    static void Main()
    {
      string caption = "Message Box";
      string text = "Hello Harshal Raverkar";
      API.ShowMessage(0,text, caption,0);

    }
  }
}
