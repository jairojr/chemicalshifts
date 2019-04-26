using ChemicalShifts.Domain.Entities;
using ChemicalShifts.Domain.Interfaces;
using ChemicalShifts.Infra.Data.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemicalShifts.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private BaseContext _context;

        public BaseRepository(BaseContext context)
        {
            this._context = context;
        }

        public void Create(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var remove = GetById(id);
            _context.Set<T>().Remove(remove);
            _context.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
