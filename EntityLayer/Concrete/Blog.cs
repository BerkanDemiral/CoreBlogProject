using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        // her blogda o boğun hangi kategoride olduğu yazacak bu nedenle categoryid değerinin görünmesi gereken yer bloglar olacak. 1 cat - çok blog
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // her blog içerisinde birden fazla comment olabilir. 1'e çok ilişki
        public List<Comment> Comments { get; set; }
    }
}
