using Ecommerce3.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce3.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Column(TypeName ="varchar(30)")]   //by default it will be store nvarchar(max) this is why i put typename... ,so here we tell the db what type to use 
        [MinLength(3)] 
        public string name { get; set; }

        public  CategoryStatus status { get; set; }   // to make a validation that status can be one of the values in enum

    }

}
