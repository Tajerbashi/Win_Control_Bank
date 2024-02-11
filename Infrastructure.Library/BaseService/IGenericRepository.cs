using AutoMapper;
using Account.Domain.Library.Bases;
using Account.Infrastructure.Library.ApplicationContext.AutoMapper;
using Account.Infrastructure.Library.ApplicationContext.DapperService;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseModels;
using Account.Infrastructure.Library.Patterns;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Account.Infrastructure.Library.BaseService
{
    public interface IGenericRepository<T> where T : BaseDTO
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        long Insert(T obj);
        long AddOrUpdate(T obj);
        void Update(T obj);
        void Delete(object id);
        void Delete(Guid guid);
        void DisActive(Guid guid);
        void Active(Guid guid);
        object Save();
    }

    public abstract class GenericRepository<TEntity, TDTO, TView> : IGenericRepository<TDTO>, IDisposable
        where TEntity : BaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
        private DbSet<TEntity> _entities;
        private string _errorMessage = string.Empty;
        private bool _isDisposed;
        //private ContextDbApplication context;
        public ContextDbApplication Context { get; set; }
        protected IMapper Mapper { get; }

        protected IDbConnection DapperServices;


        public GenericRepository(IUnitOfWork<ContextDbApplication> unitOfWork)
            : this(unitOfWork.Context)
        {
            MapperConfiguration ConfigMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfiler));
            });
            Mapper = ConfigMapper.CreateMapper();
            DapperServices = new DapperServices().Execute;
        }

        protected GenericRepository(ContextDbApplication context)
        {
            _isDisposed = false;
            this.Context = context;
            DapperServices = new DapperServices().Execute;
        }

        protected virtual DbSet<TEntity> Entities
        {
            get { return _entities ?? (_entities = Context.Set<TEntity>()); }
        }


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
    }

}
