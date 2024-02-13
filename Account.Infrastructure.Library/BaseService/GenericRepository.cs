using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Account.Application.Library.BaseModels;
using Account.Application.Library.BaseService;
using Account.Application.Library.Extentions;
using Account.Application.Library.IDatabaseContext.AutoMapper;
using Account.Application.Library.IDatabaseContext.DatabaseContext;
using Account.Domain.Library.Bases;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.ApplicationContext.GridDataConnection;
using Account.Infrastructure.Library.Patterns;


namespace Account.Infrastructure.Library.BaseService
{

    public abstract class GenericRepository<TEntity, TDTO, TView>
        : IGenericRepository<TEntity, TDTO, TView>, IDisposable
         where TEntity : BaseEntity, new()
         where TDTO : BaseDTO, new()
         where TView : BaseView, new()
    {
        private DbSet<TEntity> _entities;
        private string _errorMessage = string.Empty;
        private bool _isDisposed;
        //private ContextDbApplication context;
        private MapperConfiguration ConfigMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfiler));
            });

        protected IExecuteDataTableQuery ExecuteQueryGrid;
        protected ContextDbApplication Context { get; set; }

        protected IMapper Mapper { get; }


        public GenericRepository(UnitOfWork<ContextDbApplication> unitOfWork)
            : this(unitOfWork.Context)
        {
            Mapper = ConfigMapper.CreateMapper();
        }

        protected GenericRepository(ContextDbApplication context)
        {
            _isDisposed = false;
            this.Context = context;
            ExecuteQueryGrid = new ExecuteDataTableQuery();
        }

        protected virtual DbSet<TEntity> Entities
        {
            get { return _entities ?? (_entities = Context.Set<TEntity>()); }
        }

        private Paging _paging;
        public Paging Paging { get => _paging = _paging ?? new Paging(); set => Paging = _paging; }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
            _isDisposed = true;
        }

        public virtual IEnumerable<TDTO> GetAll()
        {
            return Mapper.Map<List<TDTO>>(Entities.ToList());
        }

        public virtual TDTO GetById(object id)
        {
            return Mapper.Map<TDTO>(Entities.Find(id));
        }

        public virtual long Insert(TDTO obj)
        {
            try
            {
                var model = Mapper.Map<TEntity>(obj);
                model.Guid = Guid.NewGuid();
                model.CreateBy = 0;
                model.CreateDate = DateTime.Now;
                model.UpdateBy = 0;
                model.UpdateDate = null;
                model.IsDeleted = false;
                model.IsActive = true;
                Context.Entry(model).State = EntityState.Added;
                //Context.Set<TEntity>().Add(model);
                Entities.Add(model);
                Context.SaveChanges();
                return model.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(TDTO obj)
        {
            try
            {
                var model = Mapper.Map<TEntity>(obj);
                model.UpdateDate = DateTime.Now;
                Context.Entry(model).State = EntityState.Modified;
                Entities.Attach(model);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Delete(object id)
        {
            TEntity existing = Entities.Find(id);
            existing.IsDeleted = true;
            existing.IsActive = false;
            Context.SaveChanges();
        }

        public virtual void Delete(Guid guid)
        {
            TEntity existing = Entities.Where(x => x.Guid.Equals(guid)).Single();
            existing.IsDeleted = true;
            existing.IsActive = false;
            Context.SaveChanges();
        }

        public virtual object Save()
        {
            return Context.SaveChanges();
        }

        public virtual void DisActive(Guid guid)
        {
            TEntity existing = Entities.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = false;
            Context.SaveChanges();
        }

        public virtual void Active(Guid guid)
        {
            TEntity existing = Entities.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = true;
            Context.SaveChanges();
        }

        public long AddOrUpdate(TDTO obj)
        {
            if (obj.ID == 0)
            {
                obj.ID = this.Insert(obj);
            }
            else
            {
                this.Update(obj);
            }
            return obj.ID;
        }

        public DataTable ExecuteQuery(string query)
        {
            return ExecuteQueryGrid.Execute(query);
        }


    }

}
