using Microsoft.EntityFrameworkCore;
using Web_Api_Crud.Models;

namespace Web_Api_Crud.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        // Constructor bắt buộc phải có để truyền cấu hình kết nối DB
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Khai báo các Bảng (Tables) sẽ có trong PostgreSQL. 
        // Em có Model Product, thì khai báo bảng DbSet<Product> tên là Products.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
