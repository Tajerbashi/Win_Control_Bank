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

namespace Infrastructure.Library.BaseService
{
    public interface IGenericRepository<T> where T : BaseDTO
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Delete(Guid guid);
        void DisActive(Guid guid);
        void Active(Guid guid);
        void Save();
    }

    public abstract class GenericRepository<TEntity, TDTO, TView> : IGenericRepository<TDTO>
        where TEntity : BaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
        protected readonly IBaseQuery _gridQuery;
        private MapperConfiguration mapper;
        private DbSet<TEntity> table;
        protected readonly Paging _paging;
        protected IMapper _mapper;
        protected ContextDbApplication _context;
        protected DapperServices _query;

        public GenericRepository()
        {
            _gridQuery = new BaseQuery();
            _paging = new Paging();
            AutoMapperProfile profile = new AutoMapperProfile();
            mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TEntity, TDTO>();
                cfg.CreateMap<TEntity, TView>();
                cfg.AddProfile(new MapperProfiler());
            });
            _mapper = mapper.CreateMapper();
            _query = new DapperServices();
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
            return _mapper.Map<List<TDTO>>(table.ToList());
        }
        public TDTO GetById(object id)
        {
            return _mapper.Map<TDTO>(table.Find(id));
        }
        public void Insert(TDTO obj)
        {

            var model = _mapper.Map<TEntity>(obj);
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
        }
        public void Update(TDTO obj)
        {
            var model = _mapper.Map<TEntity>(obj);
            model.UpdateDate = DateTime.Now;
            model.DeleteBy = 0;
            table.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
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
        public void Save()
        {
            _context.SaveChanges();
        }

        public void DisActive(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = false;
        }

        public void Active(Guid guid)
        {
            TEntity existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = true;
        }
    }

}
