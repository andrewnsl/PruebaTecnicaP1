﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaP1.DataAccess.Helpers
{
    public static class QueryableExtensions
    {
        public static IQueryable<TEntity> Includes<TEntity>(this IQueryable<TEntity> source, List<string> properties) where TEntity : class
        {

            IQueryable<TEntity> result = source.Include(properties.FirstOrDefault()!);
            foreach (var item in properties)
            {
                if (properties.FirstOrDefault() != item)
                {
                    result = result.Include(item);
                }
            }

            return result;
        }       
    }
}
