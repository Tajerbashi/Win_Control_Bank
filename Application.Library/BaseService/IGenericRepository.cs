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
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Delete(Guid guid);
        void DisActive(Guid guid);
        void Active(Guid guid);
        void Save();
        DapperServices Dapper { get; }
    }

    public abstract class GenericRepository<TEntity, TDTO, TView> : IGenericRepository<TDTO>
        where TEntity : BaseEntity
        where TDTO : BaseDTO
        where TView : BaseView
    {
        public readonly Paging paging = new Paging();
        private DbSet<TEntity> table;
        private IBaseQuery _gridQuery;
        protected IBaseQuery GridQuery { get => _gridQuery = _gridQuery ?? new BaseQuery(); }
        protected IMapper Mapper { get; }
        protected ContextDbApplication _context;
        private DapperServices _dapper;
        public DapperServices Dapper { get => _dapper = _dapper ?? new DapperServices(); }

        public GenericRepository(IMapper mapper)
        {
            Mapper = mapper;
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
        public void Insert(TDTO obj)
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
        }
        public void Update(TDTO obj)
        {
            var model = Mapper.Map<TEntity>(obj);
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
        public DataTable ExecuteQuery(string query)
        {
            return GridQuery.Execute(query);
        }
    }

}
