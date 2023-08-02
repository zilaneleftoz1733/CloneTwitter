using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? PostContent { get; set; }
        public DateTime CreateDate { get; set; }
        public int CountFavori { get; set; }
        public int Countrepost { get; set; }
        public int CountHit { get; set; }
        public int isDeleted { get; set; }
        public DateTime isDeleteDate { get; set; }
    }
}
