using System.Collections.Generic;
using System.Linq;
using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.DataAccess.Contexts;

namespace AgriculturePresentation.DataAccess.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Insert(T t)
        {
            using var context = new AgriculturePresentationContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            using var context = new AgriculturePresentationContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new AgriculturePresentationContext();
            context.Update(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new AgriculturePresentationContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new AgriculturePresentationContext();
            return context.Set<T>().ToList();
        }
    }
}