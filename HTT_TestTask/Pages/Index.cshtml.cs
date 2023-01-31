using EntityFramework.Entity;
using EntityFramework.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTT_TestTask.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Product> _repository;
        public IEnumerable<Product> products;

        public IndexModel(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            products = _repository.All;
        }
    }
}