using AcunmedyaLisesi.Data;
using AcunmedyaLisesi.Repository.Shared.Abstract;
using AcunmedyaLisesi.Repository.Shared.Concrete;
using AcunmedyaLisesi.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaLisesi.Repository.Shared.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
            return entity;
        }

        public List<T> AddRange(List<T> entities)
        {
            _dbSet.AddRange(entities);
            Save();
            return entities;
        }

        public void Delete(int id)
        {
            T entity = _dbSet.Find(id);
            entity.IsDeleted = true;
            _dbSet.Remove(entity);
            Save();
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted).ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public ICollection<T> GetByName(string name)
        {
            return _dbSet.Where(x=>x.Name==name).ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            Save();
            return entity;
        }
    }
}
    //Ev (repository)

    //Salon - Class
    //[koltuk, yemek masası] - Repository (Business) (Misafir(User))
    //Oturma Odası - Class- Class
    //[Kanepe Tv Çekyat Sehpa]- Repository (Business)(Ev Sahibi(Admin)
    //Yatak Odası- Class- Class
    //[Yatak Gardılop Tuvalet Masası]- Repository (Business)
    //Çocuk Odası- Class- Class
    //[Dolap Yatak Çalışma Masası]- Repository (Business
    //Banyo- Class- Class
    //[Duşakabin tuvalet lavabo]- Repository (Business)
    //Tuvalet- Class- Class
    //[Tuvalet] - Repository(Business)
    //Mutfak- Class- Class
    //[Tezgah Dolaplar Beyaz eşya] - Repository(Business)
