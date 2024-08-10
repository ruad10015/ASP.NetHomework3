using ASP.NetHomework3.Entities;
using Microsoft.AspNetCore.Http;

namespace ASP.NetHomework3.Models
{
    public class UpdateProductViewModel
    {
        public Product Product { get; set; }
        public IFormFile Image { get; set; }
        public UpdateProductViewModel()
        {
        }

    }
}