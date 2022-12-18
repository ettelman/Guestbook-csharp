// Guestbook by: Björn Ettelman
// Moment3
// Class for Posts
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guestbook
{
    class Post
    {
        public Post(string owner, string text)
        {
            Owner = owner;
            Text = text;
           
        }

        public string Owner { get; set; }
        public string Text { get; set; }

       
    }
}
