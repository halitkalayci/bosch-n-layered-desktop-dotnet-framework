using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bosch.MVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}