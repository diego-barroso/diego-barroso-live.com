using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XPTO.Web.Models
{
    [Table("CLIENT")]
    public class Client
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O preenchimento do campo nome � obrigat�rio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O preenchimento do campo nome deve ter no m�nimo 3 e m�ximo 100 caracteres")]
        public string Name { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O preenchimento do campo cpf � obrigat�rio.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inv�liido")]
        public string Cpf { get; set; }

        [Column("ADDRESS")]
        [Display(Name = "Endere�o")]
        [Required(ErrorMessage = "O preenchimento do campo endere�o � obrigat�rio.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O preenchimento do campo endere�o deve ter no m�nimo 10 e m�ximo 200 caracteres")]
        public string Address { get; set; }

        [Column("EMAIL")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O preenchimento do campo email � obrigat�rio.")]
        [StringLength(50, MinimumLength = 10,  ErrorMessage = "O preenchimento do campo email deve ter no m�nimo 10 e m�ximo 50 caracteres")]
        [EmailAddress(ErrorMessage = "E-mail em formato inv�lido.")]
        public string Email { get; set; }
    }
}