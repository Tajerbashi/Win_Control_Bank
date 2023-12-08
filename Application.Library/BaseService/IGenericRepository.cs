using AutoMapper;
using Domain.Library.Bases;
using Infrastructure.Library.ApplicationContext.AutoMapper;
using Infrastructure.Library.ApplicationContext.Configurations;
using Infrastructure.Library.ApplicationContext.DapperService;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.ApplicationContext.GridDataConnection;
using Infrastructure.Library.BaseModels;
using Infrastructure.Library.Extentions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace Infrastructure.Library.BaseService
{
    public interface IGenericRepository<T> where T : BaseDTO
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        object Insert(T obj);
        object Update(T obj);
        void Delete(object id);
        void Delete(Guid guid);
        object DisActive(Guid guid);
        object Active(Guid guid);
        object Save();
        void BeginTransaction();
        void BeginTransactionAsync();
        void CommitTransaction();
        void CommitTransactionAync();
        void RollBackTransaction();
        void RollBackTransactionAsyn();
    }

    public abstract class GenericRepository<TEntity, TDTO, TView> : IGenericRepository<TDTO>
        where TEntity : BaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
        private DbSet<TEntity> table;

        protected IMapper Mapper { get; }
        protected ContextDbApplication _context;


        public GenericRepository(IMapper mapper)
        {
            MapperConfiguration ConfigMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(MapperProfiler));
                //cfg.AddProfile(new MapperProfiler());
            });
            Mapper = ConfigMapper.CreateMapper();
            this._context = new ContextDbApplication();
            table = _context.Set<TEntity>();
        }
        public GenericRepository(ContextDbApplication _context)
        {
            this._context = _context;
            table = _context.Set<TEntity>();
        }
        public IEnumerable<TDTO> GetAll()
        {
            return Mapper.Map<List<TDTO>>(table.ToList());
        }
        public TDTO GetById(object id)
        {
            return Mapper.Map<TDTO>(table.Find(id));
        }
        public object Insert(TDTO obj)
        {

            var model = Mapper.Map<TEntity>(obj);
            model.Guid = Guid.NewGuid();

            model.CreateBy = 0;
            model.CreateDate = DateTime.Now;

            model.UpdateBy = 0;
            model.UpdateDate = null;

            model.DeleteBy = 0;
            model.DeleteDate = null;

            model.IsDeleted = false;
            model.IsActive = true;
            table.Add(model);
            _context.SaveChanges();
            return model.ID;
        }
        public object Update(TDTO obj)
        {
            var model = Mapper.Map<TEntity>(obj);
            model.UpdateDate = DateTime.Now;
            model.DeleteBy = 0;
            table.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model.ID;
        }
        public void Delete(object id)
        {
            TEntity existing = table.Find(id);
            existing.DeleteDate = DateTime.Now;
            existing.IsDeleted = true;
            existing.IsActive = false;
        }
        public void Delete(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.DeleteDate = DateTime.Now;
            existing.IsDeleted = true;
            existing.IsActive = false;
        }
        public object Save()
        {
            return _context.SaveChanges();
        }

        public object DisActive(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = false;
            _context.SaveChanges();
            return existing.ID;
        }

        public object Active(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = true;
            _context.SaveChanges();
            return existing.ID;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollBackTransaction()
        {
            _context.Database.RollbackTransaction();
        }

        public void BeginTransactionAsync()
        {
            _context.Database.BeginTransactionAsync();
        }

        public void CommitTransactionAync()
        {
            _context.Database.CommitTransactionAsync();
        }

        public void RollBackTransactionAsyn()
        {
            _context.Database.RollbackTransactionAsync();
        }
    }

}
