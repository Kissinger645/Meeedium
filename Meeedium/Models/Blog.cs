using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Meeedium.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Teaser { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public bool Public { get; set; }

        public string OwnerId { get; set; } //Guid

        [ForeignKey("OwnerId")]
        public virtual ApplicationUser Owner { get; set; }

    }
}