using AcunmedyaLisesi.Repository.Shared.Abstract;
using AcunmedyaLisesi.Web.Models;
using AcunmedyaUzmanlık.Business.Shared.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaUzmanlık.Business.Shared.Concrete
{
    public class Service<T> : IService<T> where T : BaseModel
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }

        public T Add(T entity)
        {
            return _repo.Add(entity);
        }

        public List<T> AddRange(List<T> entities)
        {
            _repo.AddRange(entities);
            return entities;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public ICollection<T> GetAll()
        {
            return _repo.GetAll().ToList();
        }

        public T GetById(int id)
        {
            return _repo.GetById(id);
        }

        public ICollection<T> GetByName(string name)
        {
            return _repo.GetByName(name).ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _repo.GetFirstOrDefault(predicate);
        }
        public T Update(T entity)
        {
            return _repo.Update(entity);
        }

        
    }
}
