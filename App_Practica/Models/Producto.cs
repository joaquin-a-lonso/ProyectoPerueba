using System.ComponentModel.DataAnnotations;

namespace App_Practica.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Display(Name = "Descripcion")] public string descripcion { get; set; }
        [Display(Name = "Medida")] public string umedida { get; set; }
        [Display(Name = "Precio unitario")] public decimal precio { get; set; }
        [Display(Name = "Stock")] public int stock { get; set; }
    }
}
