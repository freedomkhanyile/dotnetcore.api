﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Template.Contracts.IRepositoryBase;
using System.Linq;
 
using Template.Entities;

namespace Template.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression);
        }

        public void Save()
        {
            this.RepositoryContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }
    }
}
