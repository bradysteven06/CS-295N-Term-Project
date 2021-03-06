using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class GameInfoModel
    {
        [Key]
        public int GameID { get; set; }
        [Required]
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string Platform { get; set; }
    }
}
