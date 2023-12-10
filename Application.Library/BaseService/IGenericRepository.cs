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
using static Dapper.SqlMapper;

namespace Infrastructure.Library.BaseService
{
    public interface IGenericRepository<T> where T : BaseDTO
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        object Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Delete(Guid guid);
        void DisActive(Guid guid);
        void Active(Guid guid);
        object Save();
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
            try
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
                _context.Entry(model).State = EntityState.Added;
                _context.Set<TEntity>().Add(model);
                _context.SaveChanges();
                return model.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(TDTO obj)
        {
            try
            {
                var model = Mapper.Map<TEntity>(obj);
                model.UpdateDate = DateTime.Now;
                model.DeleteBy = 0;
                table.Attach(model);
                _context.Entry(model).State = EntityState.Modified;
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        public void DisActive(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = false;
            _context.SaveChanges();
        }

        public void Active(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = true;
            _context.SaveChanges();
        }
    }

}
