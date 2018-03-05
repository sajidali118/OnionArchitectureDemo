﻿using OnionArchitectureDemo.Domain.Common;
using OnionArchitectureDemo.DomainServices.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitectureDemo.Data.Static.Common
{
    public class Repository<T> : IRepository<T> where T : IDomainEntity
    {
        protected static List<T> StaticData { get; set; }

        public void Add(T entity)
        {
            StaticData.Add(entity);
        }

        public void Delete(T entity)
        {
            StaticData.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return StaticData.AsQueryable();
        }

        public T Single(Func<T, bool> function)
        {
            return StaticData.SingleOrDefault(function);
        }
    }
}
