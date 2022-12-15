using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace TestEF.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int Points { get; set; }
    }
}
