using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BásicoFacil.API.DTO.Request
{
    public class AddDataRequest
    {
        [Required]
        public virtual String Name { get; set; }
        [Required]
        public virtual String Cpf { get; set; }
        [Required]
        public virtual bool Agua { get; set; }
        [Required]
        public virtual bool Esgoto { get; set; }
        [Required]
        public virtual bool Drenagem { get; set; }
        [Required]
        public virtual bool Coleta { get; set; }
    }
}
