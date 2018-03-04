using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotBackEnd.Models
{
    public class UserReview
    {
        public string username { get; set; }
        public string text { get; set; }
        public int rating { get; set; }
    }
}
