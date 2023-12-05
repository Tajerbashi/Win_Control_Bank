using AutoMapper;
using Domain.Library.Bases;
using Infrastructure.Library.ApplicationContext.AutoMapper;
using Infrastructure.Library.ApplicationContext.DapperService;
using Infrastructure.Library.ApplicationContext.EF;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Library.BaseService
{
    public interface IGenericRepository<T> where T : class
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
    //The following GenericRepository class Implement the IGenericRepository Interface
    //And Here T is going to be a class
    //While Creating an Instance of the GenericRepository type, we need to specify the Class Name
    //That is we need to specify the actual class name of the type T
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        //The following variable is going to hold the ContextDbApplication instance
        private ContextDbApplication _context = null;
        protected DapperServices _query = null;
        //The following Variable is going to hold the DbSet Entity
        private DbSet<T> table = null;
        //Using the Parameterless Constructor, 
        //we are initializing the context object and table variable
        public GenericRepository()
        {
            _query = new DapperServices();
            this._context = new ContextDbApplication();
            //Whatever class name we specify while creating the instance of GenericRepository
            //That class name will be stored in the table variable
            table = _context.Set<T>();
        }
        //Using the Parameterized Constructor, 
        //we are initializing the context object and table variable
        public GenericRepository(ContextDbApplication _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        //This method will return all the Records from the table
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        //This method will return the specified record from the table
        //based on the ID which it received as an argument
        public T GetById(object id)
        {
            return table.Find(id);
        }
        //This method will Insert one object into the table
        //It will receive the object as an argument which needs to be inserted into the database
        public void Insert(T obj)
        {
            //It will mark the Entity state as Added State
            obj.Guid = Guid.NewGuid();

            obj.CreateBy = 0;
            obj.CreateDate = DateTime.Now;

            obj.UpdateBy = 0;
            obj.UpdateDate = null;

            obj.DeleteBy = 0;
            obj.DeleteDate = null;

            obj.IsDeleted = false;
            obj.IsActive = true;
            table.Add(obj);
        }
        //This method is going to update the record in the table
        //It will receive the object as an argument
        public void Update(T obj)
        {
            obj.UpdateDate = DateTime.Now;
            obj.DeleteBy = 0;
            //First attach the object to the table
            table.Attach(obj);
            //Then set the state of the Entity as Modified
            _context.Entry(obj).State = EntityState.Modified;
        }
        //This method is going to remove the record from the table
        //It will receive the primary key value as an argument whose information needs to be removed from the table
        public void Delete(object id)
        {
            //First, fetch the record from the table
            T existing = table.Find(id);
            //This will mark the Entity State as Deleted
            existing.DeleteDate = DateTime.Now;
            existing.IsDeleted = true;
            existing.IsActive = false;
            //table.Remove(existing);
        }
        public void Delete(Guid guid)
        {
            //First, fetch the record from the table
            T existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.DeleteDate = DateTime.Now;
            existing.IsDeleted = true;
            existing.IsActive = false;
            //This will mark the Entity State as Deleted
            //table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void DisActive(Guid guid)
        {
            T existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = false;
        }

        public void Active(Guid guid)
        { 
            T existing = table.Where(x => x.Guid.Equals(guid)).Single();
            existing.UpdateDate = DateTime.Now;
            existing.IsActive = true;
        }
    }

}
