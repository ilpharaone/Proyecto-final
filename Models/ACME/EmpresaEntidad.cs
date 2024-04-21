using System.ComponentModel.DataAnnotations;
using System;
namespace Models.ACME
{
    public class EmpresaEntidad
    {
        [Range(0, int.MaxValue, ErrorMessage = "Debe seleccionar una empresa: ")]
        [Display(Name ="Codigo")]
        public int IDEmpresa { get; set; }
        
        
        [Required(ErrorMessage = "Debe sellecionar un tipo de Empresa: ")]
        [Range(1, int.MaxValue, ErrorMessage ="Debe sellecionar un tipo de empresa: ")]
        [Display(Name = "Tipo de empresa")]
        public int? IDTipoEmpresa { get; set; }
        
        [Required(ErrorMessage ="El nombre de la empresa es obligatorio")]
        [Display(Name ="Nombre Empresa")]
        public string Empresa { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "La direccion de la empresa es obligatorio")]
        [Display(Name = "Direccion Empresa")]
        public string Direccion { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "El RUC de la empresa es obligatorio")]
        [Display(Name = "RUC Empresa")]
        public string RUC { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Debe ingresar la fecha de creacion:")]
        [Display(Name = "Fecha creacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe ingresar el presupuesto")]
        [Display(Name = "Presupuesto")]
        public decimal Presupuesto { get; set; }

        public bool Activo { get; set; } = true;

        //Prpiedad de navegacion a Tipo Empresa

        public TipoEmpresaEntidad TipoEmpresaEntidad { get; set; }


    }
}
