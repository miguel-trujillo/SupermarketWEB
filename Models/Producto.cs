﻿namespace SupermarketWEB.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Productos { get; set; } = default!;
    }
}
