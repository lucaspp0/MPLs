using System;
using System.IO;
using System.Threading.Tasks;

namespace MPL.utils
{
  public class Fileutils{

    public static bool WriteFile(string content, string path){
      try
      {
        if(!File.Exists(path))
          File.Create(path);

        File.WriteAllText(path, content);
        return true;
      }
      catch (Exception){ return false; }
      
    }

    public static string ReadFile(string path){
      try
      {
        if(!File.Exists(path)) return string.Empty;
        
        return File.ReadAllText(path);
      }
      catch (Exception){ return string.Empty; }
    }

  }   
}