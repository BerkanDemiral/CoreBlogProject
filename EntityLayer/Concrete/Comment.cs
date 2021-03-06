using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string CommetTitle { get; set; }
        public string CommetContent { get; set; }
        public DateTime CommetDate { get; set; }
        public bool CommetStatus { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }


    }
}
