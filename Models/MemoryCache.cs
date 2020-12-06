
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public static class MemoryCache
    {
        public static List<Product> Products = new List<Product>
    {
        new Product() {Id=1,Name = "Bilgisayar", Price = 8},
        new Product() {Id=2,Name = "Süpürge", Price = 2},
        new Product() {Id=3,Name = "Buzdolabı", Price = 14}
    };
    }
}