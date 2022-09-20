using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasilShopModels
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingresa Nombre a la Categoria")]
        [Display (Name="Nombre Categoria")]
        public  string? Nombre { get; set; }

        [Required]
        [Display(Name = "Orden de Visualizacion")]
        public string? Orden { get; set; }


    }
}
