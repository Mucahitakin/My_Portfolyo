using System.ComponentModel.DataAnnotations;

namespace Mucahit_akin.Model
{
    public class Gorusme
    {
        public int id { get; set; }
        [Required]
        public string isim { get; set; }
        [Required]
        public string soyisim { get; set; }
        [Required]
        public string e_mail { get; set; }
        
    }
}
