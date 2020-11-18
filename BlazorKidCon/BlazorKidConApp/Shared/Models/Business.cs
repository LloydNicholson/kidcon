using System;

namespace BlazorKidConApp.Shared.Models
{
    public enum BusinessType
    {
        Service,
        Product
    }

    public class Business
    {
        public long Id { get; set; }
        public BusinessType Type { get; set; }
        public string Description { get; set; }
    }
}
