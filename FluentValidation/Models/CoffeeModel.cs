using System.ComponentModel.DataAnnotations;

namespace FluentValidation.Net.Models
{
    public class CoffeeModel
    {        
        public string Title { get; set; }
                
        public string? Description { get; set; }        
       
        public string? BarCode { get; set; }
    }
}
