using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioAPI.Data.Entities
{
    public class Experience
    {
        // decorador que indica a Id como clave primaria y genera automaticamente un Id que no se repite
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string ImgPath { get; set; }
        public string State { get; set; } = "Active";
        public int Order { get; set; } = 1;
    }
}
