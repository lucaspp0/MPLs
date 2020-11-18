
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

    public  bool save(T obj){
      int index = _ListObj.FindIndex(modelo => getIdFromObj(modelo) == getIdFromObj(obj));
      if(index > -1) {
        _ListObj[index] = obj;
      }
      else{
        int nextId = 1;
        if(_ListObj.Count != 0) nextId = _ListObj.Max( x => getIdFromObj(x)) + 1;
        setIdFromObj(obj, nextId);
        _ListObj.Add(obj);
      }

      return FillFileByBd();
    }
    public  bool delete(T obj){
      if(_ListObj.RemoveAll(x => getIdFromObj(x) == getIdFromObj(obj) ) > 0)
        return FillFileByBd();
        
      return true;
    }
    public  bool delete(int id){
      
      if(_ListObj.RemoveAll(x =>getIdFromObj(x) == id) > 0)
        return FillFileByBd();
        
      return true;
    }
    public  List<T> selectAll(){
      FillFileByBd();
      return _ListObj;
    }

    private static  bool FillFileByBd(){
      string content = JsonUtil<DataBaseGod>.Serialize(DataBaseGod._DATABASE);
      return Fileutils.WriteFile(content, Constants.Path_BD);
    }

    public static  bool FillBdByFile(){
      string content = Fileutils.ReadFile(Constants.Path_BD);
      if(string.IsNullOrWhiteSpace(content)) return false;
      DataBaseGod._DATABASE = JsonUtil<DataBaseGod>.Deserialize(content);
      return true;
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