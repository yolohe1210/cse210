using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer GetCustomer() 
    { 
        return _customer; 
    }
    public void SetCustomer(Customer customer) 
    { 
        _customer = customer; 
    }

    public List<Product> GetProducts() 
    { 
        return _products; 
    }

    public void AddProduct(Product product) 
    { 
        _products.Add(product); 
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingInfo();
    }
}