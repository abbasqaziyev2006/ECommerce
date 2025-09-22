using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageName { get; set; }
        public bool IsDeleted { get; set; }
    }



    public class CreateCategoryViewModel
    {
        public string Name { get; set; } = null!;
        public IFormFile? ImageFile { get; set; }
        public string? ImageName { get; set; }
    }


    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public IFormFile? ImageFile { get; set; }
        public string? ImageName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
