using BusinessLayer.Abstract;
using DataAccesLayer.EntityFramework;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategroyRepository efCategroyRepository;

        public CategoryManager()
        {
            efCategroyRepository = new EfCategroyRepository();
        }
        
        public void categoryAdd(Category category)
        {
            efCategroyRepository.Insert(category);
        }

        public void categoryDelete(Category category)
        {
            efCategroyRepository.Delete(category);
        }

        public void categoryUpdate(Category category)
        {
            efCategroyRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategroyRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategroyRepository.GetListAll();
        }
    }
}
