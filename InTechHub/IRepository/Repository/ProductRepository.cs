using InTechHub.IRepository.Repository;
using InTechHub.Models;

namespace InTechHub.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context) { }
    }
}
