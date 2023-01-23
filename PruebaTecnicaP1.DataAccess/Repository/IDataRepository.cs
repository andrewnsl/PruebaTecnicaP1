using System.Linq.Expressions;

namespace PruebaTecnicaP1.DataAccess.Repository
{
    public interface IDataRepository<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// Obtiene una lista de registros por una expresion
        /// </summary>
        /// <param name="expresion"></param>
        /// <returns></returns>
        Task<List<TEntity>> List(Expression<Func<TEntity, bool>>? expresion = null);
        /// <summary>
        /// Obtiene una lista de registro con relaciones
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<List<TEntity>> ListInclude(List<string> properties, Expression<Func<TEntity, bool>>? expression = null);
    }
}
