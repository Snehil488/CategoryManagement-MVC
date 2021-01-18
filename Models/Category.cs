using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        //annotation tells it is primary key and identity column (auto increments)
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill out this field.")]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="Enter a valid number")]
        public int DisplayOrder { get; set; }
    }
}
