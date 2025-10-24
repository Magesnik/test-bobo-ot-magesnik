using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PetClinic
{
    public class Animal : User
    {
        [Key]
        public string id;

        [Required]
        [MaxLength(50)]
        [Comment("Product name")]
        public string Names { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("Owner name")]
        public string Owner { get; set; }

        [Required]
        [Range(0, 255)]
        [Comment("Animal age")]
        public ushort Age { get; set; }

        [Required]
        [MaxLength(50)]
        [Comment("Animal type")]
        public string Type { get; set; }

        [Required]
        [Comment("Is the animal sick or not")]
        public bool SickOrNot { get; set; } = false;

        [MaxLength(1_000)]
        [Comment("Additional notes about the animal")]
        public string Notes { get; set; } = "";

        public void MakeOlder()
        {
            Age += 3;
        }

        public void Heal()
        {
            SickOrNot = false;
            Notes = "feeling ok i guess";
        }
    }
}