using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFHandsOn
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(100)]
        [Required]
        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}
