using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Common.Contracts.DatabaseServices
{
    /// <summary>
    /// Repository Interface. Inherits from IDisposable
    /// </summary>
    public interface IRepository : IDisposable
    {
        IQueryable<TModel> AsQueryable<TModel>() where TModel : class;

        IQueryable<TModel> AsQueryableWithTracking<TModel>() where TModel : class;

        TModel Find<TModel>(int id) where TModel : class;

        void Add<TModel>(TModel modelItem) where TModel : class;

        void Delete<TModel>(TModel modelItem) where TModel : class;

        TModel Attach<TModel>(TModel modelItem) where TModel : class;

        void Detach<TModel>(TModel modelItem) where TModel : class;

        IQueryable<TModel> SqlQuery<TModel>(string query) where TModel : class;

        void SaveChanges();
    }
}
