using Web_Api_Crud.Models;

namespace Web_Api_Crud.Interface
{
    public interface IProductService
    {
        List<Product> GetListProduct();
        Product GetProductById(int Id);
        Product CreatNewProduct(Product newproduct);
        bool UpdateProduct(int Id, Product inforProduct);

        bool DeleteProduct(int Id);

    }
}
