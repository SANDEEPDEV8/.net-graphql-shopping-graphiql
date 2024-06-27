﻿namespace ShoppingGraphQL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
