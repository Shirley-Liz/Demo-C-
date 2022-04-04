using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tourism.ToViewLater
{
    public class GenericService<TEntity> where TEntity : class
    {
        private TodoContext _context;
        private DbSet<TEntity> _repo;
        public GenericService()
        {
            _context = new TodoContext();

            _repo = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _repo.Add(entity);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _repo.Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _repo
                .ToList();
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = GetById(id);

            Delete(todo);
        }

        public void Delete(TEntity toDo)
        {
            _repo.Remove(toDo);
            _context.SaveChanges();
        }
    }
}
