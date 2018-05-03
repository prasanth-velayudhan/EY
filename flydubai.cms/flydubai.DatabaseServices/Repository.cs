using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using flydubai.Common.Contracts.DatabaseServices;
using flydubai.Common.Exceptions;
using flydubai.Common.Resources;

namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Helper class to abstract the Entity Framework into a Repository pattern.
    /// </summary>
    /// <remarks></remarks>
    public class Repository : IRepository
    {
        private readonly FlydubaiContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <remarks></remarks>
        public Repository(FlydubaiContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <remarks></remarks>
        public Repository()
        {
            this.context = new FlydubaiContext();
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <remarks></remarks>
        public FlydubaiContext Context
        {
            get { return this.context; }
        }

        /// <summary>
        /// Retrieves all entities as queryable (no tracking).
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <returns>List of entities</returns>
        /// <remarks></remarks>
        public IQueryable<TModel> AsQueryable<TModel>() where TModel : class
        {
            return this.context.Set<TModel>().AsNoTracking().AsQueryable();
        }

        /// <summary>
        /// Retrieves all entities as queryable with tracking.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <returns></returns>
        /// <remarks></remarks>
        public IQueryable<TModel> AsQueryableWithTracking<TModel>() where TModel : class
        {
            return this.context.Set<TModel>().AsQueryable();
        }

        /// <summary>
        /// Finds the specified entity using the id.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="id">The id.</param>
        /// <returns>The entity</returns>
        /// <remarks></remarks>
        public TModel Find<TModel>(int id) where TModel : class
        {
            return this.context.Set<TModel>().Find(id);
        }

        /// <summary>
        /// Adds the specified model item.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="modelItem">The model item.</param>
        /// <remarks></remarks>
        public void Add<TModel>(TModel modelItem) where TModel : class
        {
            this.context.Set<TModel>().Add(modelItem);
        }

        /// <summary>
        /// Deletes the specified model item.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="modelItem">The model item.</param>
        /// <remarks></remarks>
        public void Delete<TModel>(TModel modelItem) where TModel : class
        {
            this.context.Set<TModel>().Remove(modelItem);
        }

        /// <summary>
        /// Attaches the specified model item.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="modelItem">The model item.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public TModel Attach<TModel>(TModel modelItem) where TModel : class
        {
            return this.context.Set<TModel>().Attach(modelItem);
        }

        /// <summary>
        /// Detaches the specified model item.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="modelItem">The model item.</param>
        /// <remarks></remarks>
        public void Detach<TModel>(TModel modelItem) where TModel : class
        {
            if (modelItem != null && this.context.Entry(modelItem).State != EntityState.Detached)
            {
                this.context.Entry(modelItem).State = EntityState.Detached;    
            }
        }

        /// <summary>
        /// SQLs the query.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="query">The query.</param>
        /// <returns>List of entities</returns>
        /// <remarks></remarks>
        public IQueryable<TModel> SqlQuery<TModel>(string query) where TModel : class
        {
            return this.context.Database.SqlQuery<TModel>(query).AsQueryable();
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        /// <remarks></remarks>
        public void SaveChanges()
        {
            try
            {
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbException)
            { 
                FlyDubaiDataException flyDubaiDataException = new FlyDubaiDataException(Messages.SaveChangesError);
                foreach (var validationErrors in dbException.EntityValidationErrors)
                {
                    var entityException = new FlyDubaiEntityException(validationErrors.Entry.Entity.ToString());

                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        entityException.EntityPropertyExceptions.Add(
                            new FlyDubaiEntityPropertyException(
                                validationError.PropertyName,
                                validationErrors.Entry.CurrentValues[validationError.PropertyName].ToString(),
                                validationError.ErrorMessage));
                    }
                    flyDubaiDataException.EntityExceptions.Add(entityException);
                }
                throw flyDubaiDataException;
            }
        }

        /// <summary>
        /// Disposes the context
        /// </summary>
        /// <remarks></remarks>
        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
