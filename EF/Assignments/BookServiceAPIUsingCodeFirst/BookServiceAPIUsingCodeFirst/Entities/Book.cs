using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookServiceAPIUsingCodeFirst.Entities
{
    [Table("Tbl_Book")]
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

        public int ReleaseDate { get; set; }
    }
}
