using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTutorial.EntityDAL
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public  int PostId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PostName { get; set; }

        [Required]
        public int Grade { get; set; }
        public ICollection<PersonInfo> PersonInfos { get; set; }
    }
}
