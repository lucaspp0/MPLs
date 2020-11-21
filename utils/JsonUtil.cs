using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace MPL.utils
{
  public static class JsonUtil<T>
  {
      public static string Serialize(T obj){
        try   { return JsonSerializer.Serialize(obj); }
        catch (Exception) { return String.Empty; }
      }

      public static T Deserialize(string text) => JsonSerializer.Deserialize<T>(text);

  }
}