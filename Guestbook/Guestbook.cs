// Guestbook by: Björn Ettelman
// Moment3
// Class for Guestbook
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Guestbook
{
    class Guestbook
    {
        private string filename = @"guest.json";
        // New list to save the posts in
        private List<Post> _posts { get; set; } = new List<Post>();

        // Constructor to check for file
        public Guestbook()
        {
            if (File.Exists(filename) == true)
            { // If stored json data exists then read
                string jsonString = File.ReadAllText(filename);
                _posts = JsonSerializer.Deserialize<List<Post>>(jsonString);
            }
        }
        // Function to add post with the class Post
            public void AddPost(Post post)
        {
            _posts.Add(post);
            ToFile();
            Console.WriteLine("-Post Added-\n");
        }

        // Function to display all posts, adding index
        public void DisplayPost()
        {
            int numberPost = 0;
           foreach (var post in _posts)
            {
                Console.WriteLine($"[{numberPost}] {post.Owner} - {post.Text}");
                numberPost++;
            }
            if (!_posts.Any()) Console.WriteLine("Guestbook is empty");
        }

        // Function to add the current list to file
        private void ToFile()
        {
            // Serialize all the objects and save to file
            var jsonString = JsonSerializer.Serialize(_posts);
            Console.WriteLine("::" + jsonString);
            File.WriteAllText(filename, jsonString);
        }

        // Function to remove a post @ chosen index
        public int DelPosts(int index)
        {

            _posts.RemoveAt(index);
            ToFile();
            Console.WriteLine("-Post deleted-\n");
            return index;
        }

    }
}
