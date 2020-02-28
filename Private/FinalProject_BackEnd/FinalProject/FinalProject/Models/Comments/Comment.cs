using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Comments
{
    public class Comment
    {
        public Comment()
        {
            SubComments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey("BaseComment")]
        public int? BaseId { get; set; }

        public Comment BaseComment { get; set; }


        public ICollection<Comment> SubComments { get; set; }
    }
}
