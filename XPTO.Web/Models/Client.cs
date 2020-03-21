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
        [Required(ErrorMessage = "O preenchimento do campo nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O preenchimento do campo nome deve ter no mínimo 3 e máximo 100 caracteres")]
        public string Name { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O preenchimento do campo cpf é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inváliido")]
        public string Cpf { get; set; }

        [Column("ADDRESS")]
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O preenchimento do campo endereço é obrigatório.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O preenchimento do campo endereço deve ter no mínimo 10 e máximo 200 caracteres")]
        public string Address { get; set; }

        [Column("EMAIL")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O preenchimento do campo email é obrigatório.")]
        [StringLength(50, MinimumLength = 10,  ErrorMessage = "O preenchimento do campo email deve ter no mínimo 10 e máximo 50 caracteres")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
    }
}