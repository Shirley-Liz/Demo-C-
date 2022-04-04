using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tourism.Services
{
    public class ToDoServices
    {
        private TodoContext _cotext;
        private DbSet<ToDo> toDoRepository;
        public ToDoServices()
        {
            _cotext = new TodoContext();

            toDoRepository = _cotext.Tasks;
        }

        public void Add(ToDo toDo)
        {
            toDoRepository.Add(toDo);
            _cotext.SaveChanges();
        }

        public ToDo GetById(int id)
        {
            var todo = toDoRepository.Find(id);
            return todo;
        }

        public List<ToDo> GetAll()
        {
            return toDoRepository
                .ToList();
        }

        public void Update(ToDo toDo)
        {
            toDoRepository.Update(toDo);

            _cotext.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = GetById(id);

            Delete(todo);
        }

        public void Delete(ToDo toDo)
        {
            toDoRepository.Remove(toDo);
            _cotext.SaveChanges();
        }
    }
}
