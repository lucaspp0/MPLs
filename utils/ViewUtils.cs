using System;
using System.Text.Json;

using System.IO;

namespace MPL.utils
{
  class ViewUtils
  {
    public static void ClearConsole(){
      Console.Clear();
    } 

    public static void ShowScreen(string content) => Console.WriteLine(content);

    public static string GetInput(string content = "")
    {
      if (!string.IsNullOrWhiteSpace(content)) Console.Write(content);
      return Console.ReadLine().Trim();
    }
    
    public static float GetInputFloat(string content = "")
    {
      if (!string.IsNullOrWhiteSpace(content)) Console.Write(content);
      float resultFloat;
      string resultStr = Console.ReadLine().Trim();
      while(!float.TryParse(resultStr, out resultFloat)){
        ShowScreen("Valor inválido, digite um valor decimal válido ");
        resultStr = Console.ReadLine().Trim();
      }
      return resultFloat;
    }
    
    public static int GetInputInt(string content = "")
    {
      
      if (!string.IsNullOrWhiteSpace(content)) Console.Write(content);
      int resultInt;
      string resultStr = Console.ReadLine().Trim();
      while(!int.TryParse(resultStr, out resultInt)){
        ShowScreen("Valor inválido, digite um valor numérico válido ");
        resultStr = Console.ReadLine().Trim();
      }
      return resultInt;
    }

    public static void GetWaitingInput()
    {
      ShowScreen("digite algo para continuar ...");
      Console.ReadKey();
    }
  }
}
