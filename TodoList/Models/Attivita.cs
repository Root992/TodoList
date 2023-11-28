using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class Attivita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Testo { get; set; }
        public int IdUtCreazione { get; set; }
        public DateTime DataCreazione { get; set; }
        public DateTime DataUltModifica { get; set; }
        public bool Completato { get; set; }
    }
}
