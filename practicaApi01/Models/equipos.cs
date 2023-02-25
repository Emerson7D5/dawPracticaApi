using System.ComponentModel.DataAnnotations;

namespace practicaApi01.Models
{
    public class equipos
    {
        [Key]
        public int id_equipos { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
