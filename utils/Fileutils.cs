using System;
using System.IO;
using System.Threading.Tasks;

namespace MPL.utils
{
  public class Fileutils{

    public static async Task<bool> WriteFile(string content, string path){
      try
      {
        if(!File.Exists(path))
          File.Create(path);

        await File.WriteAllTextAsync(path, content);
        return true;
      }
      catch (Exception){ return false; }
      
    }

    public static async Task<string> ReadFile(string path){
      try
      {
        if(!File.Exists(path)) return string.Empty;
        
        return await File.ReadAllTextAsync(path);
      }
      catch (Exception){ return string.Empty; }
    }

  }   
}