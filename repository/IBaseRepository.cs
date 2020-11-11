using System.Collections.Generic;
using System.Threading.Tasks;

namespace MPL.repository
{
  public interface IBaseRepository<T>
  {
    public Task<bool> save(T obj);
    public Task<bool> delete(T obj);
    public Task<bool> delete(int id);
    public Task<List<T>> selectAll();
  }
}