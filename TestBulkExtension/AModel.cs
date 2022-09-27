using System.ComponentModel.DataAnnotations;

namespace TestBulkExtension
{
    public class AModel
    {
        [Key]
        public int Id { get; set; }

        public string A { get; set; }
    }
}