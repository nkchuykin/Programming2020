using System.Collections.Generic;

public class Shop
{
    private readonly List<Product> products;

    public Product this[int index] => products[index];

    public Shop(List<Product> products)
    {
        this.products = products;
    }
}