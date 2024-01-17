using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookServiceAPICodeFirst.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? BookName { get; set; }

        [Required]
        [Column(TypeName = "int")]
      
        public int Price { get; set; }

      
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? Author { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string? Lang { get; set; }

        public DateOnly ReleaseDate { get; set; }



    }
}
