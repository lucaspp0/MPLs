
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;

using MPL.model;
using MPL.utils;

namespace MPL.repository.impl
{
  public class BaseRepository<T> : IBaseRepository<T>
  {
    List<T> _ListObj;

    private const string ID_STR = "Id";

    public BaseRepository(List<T> ListObj ) => this._ListObj = ListObj;

    public async Task<bool> save(T obj){
      int index = _ListObj.FindIndex(modelo => getIdFromObj(modelo) == getIdFromObj(obj));
      if(index > -1) {
        _ListObj[index] = obj;
      }
      else{
        int nextId = _ListObj.Max( x => getIdFromObj(x)) + 1;
        setIdFromObj(obj, nextId);
        _ListObj.Add(obj);
      }

      return await FillFileByBd();
    }
    public async Task<bool> delete(T obj){
      if(_ListObj.RemoveAll(x => getIdFromObj(x) == getIdFromObj(obj) ) > 0)
        return await FillFileByBd();
        
      return true;
    }
    public async Task<bool> delete(int id){
      
      if(_ListObj.RemoveAll(x =>getIdFromObj(x) == id) > 0)
        return await FillFileByBd();
        
      return true;
    }
    public async Task<List<T>> selectAll(){
      await FillFileByBd();
      return _ListObj;
    }

    public static async Task FillBd(){
      bool filledByFile = await FillBdByFile();
      if(!filledByFile) InitializeBd();
    }

    private static async Task<bool> FillFileByBd(){
      Console.WriteLine("inicio FillBd: ");
      if(DataBaseGod._DATABASE == null) await FillBd();
      Console.WriteLine("fillbd");
      string content = await JsonUtil<DataBaseGod>.Serialize(DataBaseGod._DATABASE);
      Console.WriteLine("Conteudo: "+content);
      return await Fileutils.WriteFile(content, Constants.Path_BD);
    }

    private static async Task<bool> FillBdByFile(){
      string content = await Fileutils.ReadFile(Constants.Path_BD);
      if(string.IsNullOrWhiteSpace(content)) return false;
      DataBaseGod._DATABASE = JsonUtil<DataBaseGod>.Deserialize(content);
      return true;
    }

    private static void InitializeBd(){
      DataBaseGod._DATABASE = new DataBaseGod();
      DataBaseGod._DATABASE.UsuarioConsumidor = new List<UsuarioConsumidor>();
    }

    private void setIdFromObj(T obj, int id){
        Type TypeObj = typeof(T);
        PropertyInfo[] properties = TypeObj.GetProperties();
        TypeObj.GetProperty(ID_STR).SetValue(obj, id);
    }

    private object getValueObj(T obj, string NameProp)
    {
        Type TypeObj = typeof(T);
        PropertyInfo[] properties = TypeObj.GetProperties();
        return TypeObj.GetProperty(NameProp).GetValue(obj, null);
    }

    private int getIdFromObj(T obj) => (int) getValueObj(obj, ID_STR);

  }
}