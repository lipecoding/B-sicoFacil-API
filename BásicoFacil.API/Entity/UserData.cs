using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BásicoFacil.API.Entity
{
    public class UserData
    {
        public UserData () 
        { 
            Id = Guid.NewGuid ();
        }
        [Key]
        [Column("id")]
        public virtual Guid Id { get; set; }
        [Required]
        [Column ("name")]
        public virtual String Name { get; set;}
        [Required]
        [Column("cpf")]
        public virtual String Cpf { get; set;}
        [Required]
        [Column("agua_potavel")]
        public virtual bool Agua { get; set;}
        [Required]
        [Column("rede_esgoto")]
        public virtual bool Esgoto { get; set;}
        [Required]
        [Column("drenagem")]
        public virtual bool Drenagem { get; set;}
        [Required]
        [Column("coleta_lixo")]
        public virtual bool Coleta { get; set;}
        [Required]
        [Column("pontos")]
        public virtual int pontos { get; set;}
    }
}
