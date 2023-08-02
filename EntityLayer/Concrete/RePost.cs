using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RePost
    {
        [Key]
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
