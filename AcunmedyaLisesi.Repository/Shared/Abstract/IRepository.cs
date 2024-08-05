﻿using AcunmedyaLisesi.Data;
using AcunmedyaLisesi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaLisesi.Repository.Shared.Abstract
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> GetAll();
        T Add(T entity);
        List<T> AddRange(List<T> entities);
        T Update(T entity);
        void Delete(int id);
        T GetById(int id);

        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);
        void Save();

        ICollection<T> GetByName(string name);


    }

}
