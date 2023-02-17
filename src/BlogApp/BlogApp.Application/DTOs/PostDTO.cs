using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.DTOs
{
    public class PostDTO
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Locked { get; set; }
    }
}
