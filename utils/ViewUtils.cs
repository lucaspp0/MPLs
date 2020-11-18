using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace MPL.utils
{
  class ViewUtils
  {
    public static void ClearConsole(){
      // Console.Clear();
    } 

    public static void ShowScreen(string content) => Console.WriteLine(content);

    public static string GetInput(string content = "")
    {
      if (!string.IsNullOrWhiteSpace(content)) Console.Write(content);
      return Console.ReadLine().Trim();
    }

    public static void GetWaitingInput()
    {
      ShowScreen("digite algo para continuar ...");
      Console.ReadLine();
    }
  }
}