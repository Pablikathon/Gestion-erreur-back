using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Persist.Entities
{
    [PrimaryKey(nameof(Id))]
    public class CustomerEntity
    {
        [Required]
        public string Id { get; set; }
        public string Title { get; set; }  
    }
}
