using AcunmedyaLisesi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YeniAcunmedyaLisesi.Models.Dto;

namespace AcunmedyaUzmanlık.Business.Shared.Abstract
{
    public interface IService<T> where T : BaseModel
    {
        ICollection<T> GetAll();
        T Add(T entity);
        List<T> AddRange(List<T> entities);
        T Update(T entity);
        void Delete(int id);
        T GetById(int id);

        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);

        List<T> GetByName(string name);
        
        
    }
}
