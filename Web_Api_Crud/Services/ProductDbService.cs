using Web_Api_Crud.Data;
using Web_Api_Crud.Interface;
using Web_Api_Crud.Models;

namespace Web_Api_Crud.Services
{
    public class ProductDbService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductDbService(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetListProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int iD)
        {
            var sp = _context.Products.FirstOrDefault(p => p.Id == iD);
            return sp;
        }

        public Product CreatNewProduct(Product newproduct)
        {
             _context.Products.Add(newproduct);
            _context.SaveChanges();
            return newproduct;

        }

        public bool UpdateProduct(int Id, Product product)
        {
            var olderProduct =  _context.Products.FirstOrDefault(p => p.Id == Id);
            if (olderProduct == null) return false;
            else
            {
                olderProduct.Name = product.Name;
                olderProduct.Price = product.Price;
                olderProduct.Stock = product.Stock;
                olderProduct.CategoryId = product.CategoryId;

            }
            _context.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int Id)
        {
            var sp = _context.Products.FirstOrDefault(p => p.Id == Id);
            if (sp == null) return false;
            _context.Products.Remove(sp);
            _context.SaveChanges();
            return true;
        }
    }
}
