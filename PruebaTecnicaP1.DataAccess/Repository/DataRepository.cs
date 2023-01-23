using Microsoft.EntityFrameworkCore;
using PruebaTecnicaP1.DataAccess.Helpers;
using System.Linq.Expressions;

namespace PruebaTecnicaP1.DataAccess.Repository
{
    public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class, new()
    {
        #region Fields
        public DbContext _context { get; set; }
        public DbSet<TEntity> _entity { get; set; }
        #endregion

        #region Builder

        public DataRepository(DbContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }
        #endregion

        public async Task<List<TEntity>> List(Expression<Func<TEntity, bool>>? expresion = null)
        {
            await _context.Database.EnsureCreatedAsync();
            List<TEntity> result;
            if (expresion == null)
            {
                result = await _entity.ToListAsync();
            }
            else
            {
                result = await _entity.Where(expresion).ToListAsync();
            }

            return result;
        }

        public async Task<List<TEntity>> ListInclude(List<string> properties, Expression<Func<TEntity, bool>>? expression = null)
        {
            List<TEntity> result;

            if ((uint)properties.Count <= 0)
                return await List(expression);

            IQueryable<TEntity> source = _entity.Includes(properties);

            if (expression == null)
            {
                result = await source.ToListAsync();
            }
            else
            {
                result = await source.Where(expression).ToListAsync();
            }

            return result;
        }
    }
}
