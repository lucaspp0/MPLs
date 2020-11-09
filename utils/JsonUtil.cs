using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace MPL.utils
{
  public static class JsonUtil<T>
  {
      public static async Task<string> Serialize(T obj){
        string json = string.Empty;
        try
        {
          using (var stream = new MemoryStream()) { 
            await JsonSerializer.SerializeAsync<T>(stream, obj);
            stream.Position = 0; 
            using var reader = new StreamReader(stream);
            json = await reader.ReadToEndAsync(); 
          } 
          return json;
        }
        catch (Exception) { return String.Empty; }
      }

      public static T Deserialize(string text) => JsonSerializer.Deserialize<T>(text);

  }
}