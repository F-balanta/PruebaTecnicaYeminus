using YeminusSoftware.Domain;

namespace YeminusSoftware.Infrastructure.Data
{
    public static class SeedData
    {
        public static readonly List<Product> Products = new()
        {
            new Product
            {
                Code = 1,
                Description = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                ImgUrl = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 100000
            },new Product
            {
                Code = 2,
                Description = "Mens Casual Premium Slim Fit T-Shirts",
                ImgUrl = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 50505
            },new Product
            {
                Code = 3,
                Description = "Mens Cotton Jacket",
                ImgUrl = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 10000
            },new Product
            {
                Code = 4,
                Description = "Mens Casual Slim Fit",
                ImgUrl = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 10000
            },new Product
            {
                Code = 5,
                Description = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                ImgUrl = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 10000
            },new Product
            {
                Code = 6,
                Description = "Solid Gold Petite Micropave",
                ImgUrl = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 10000
            },new Product
            {
                Code = 7,
                Description = "White Gold Plated Princess",
                ImgUrl = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 100000
            },new Product
            {
                Code = 8,
                Description = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                ImgUrl = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 10000
            },new Product
            {
                Code = 9,
                Description = "WD 2TB Elements Portable External Hard Drive - USB 3.0",
                ImgUrl = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg",
                ForSale = true,
                Vat = 19,
                Price = 10000
            },
        };
    }
}
