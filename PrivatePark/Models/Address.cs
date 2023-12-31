﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mnacr22.Models;

public class Address
{
    
    public Address (){}

    public Address(string street, string city, string ziptCode, float price, bool active, string suitability, int quantity)
    {
        Street = street;
        City = city;
        ZiptCode = ziptCode;
        Price = price;
        Active = active;
        Suitability = suitability;
        Quantity = quantity;
        MaxQuantity = quantity;
    }
    
    public int Id { get; set; }
    
    [Required]
    [DisplayName("Street")]
    public string Street { get; set; }
    
    
    [Required]
    [DisplayName("Zip code")]
    public string ZiptCode { get; set; }
    
    [Required]
    [DisplayName("City")]
    public string City { get; set; }
    
    [Required]
    [DisplayName("Price")]
    public float Price { get; set; }
    
    public int MaxQuantity { get; set; }
    
    public int Quantity { get; set; }
    
    public bool Active { get; set; }
    
    [Required]
    [DisplayName("Suitability")]
    public string Suitability { get; set; }
    
    public ApplicationUser User { get; set; }
    
    public Location Location { get; set;} 
    
    
}