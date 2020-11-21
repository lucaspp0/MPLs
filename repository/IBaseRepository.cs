using System.Collections.Generic;
using System.Threading.Tasks;

namespace MPL.repository
{
  public interface IBaseRepository<T>
  {
    public bool save(T obj);
    public bool delete(T obj);
    public bool delete(int id);
    public List<T> selectAll();
  }
}