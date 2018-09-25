using System.ComponentModel.DataAnnotations;

namespace CURD_Web_App
{
    public class Customer
    {
        public int ID { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}