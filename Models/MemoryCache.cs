
using System.Collections.Generic;
using SignalRChat.Models;

namespace SignalRChat.Models
{
    public static class MemoryCache
    {
        public static List<Product> Products = new List<Product>
    {
        new Product() {Id=1,Name = "Sylvester", Price = 8},
        new Product() {Id=2,Name = "Whiskers", Price = 2},
        new Product() {Id=3,Name = "Sasha", Price = 14}
    };
    }
}