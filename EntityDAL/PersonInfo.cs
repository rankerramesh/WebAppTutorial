using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTutorial.EntityDAL
{

    [Table("PersonInfo")]
    public class PersonInfo
    {
        [Key]
        public int PersonId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
