using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
        public class Book
        {
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name="Заглавие")]
            public string Title { get; set; }

            [Required]
            [StringLength(50)]
            [Display(Name = "Автор")]
            public string Author { get; set; }

            [Display(Name = "Жанр")]   
            public string Genre { get; set; }

            [Display(Name = "Година")]
            public int Year { get; set; }

            [Display(Name = "Корица")]
            public byte[] Cover { get; set; }

            [Display(Name = "Налична")]
            public bool IsAvailable { get; set; } = true;
        }
}
