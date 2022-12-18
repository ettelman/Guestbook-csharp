// Guestbook by: Björn Ettelman
// Moment3

using System;

namespace Guestbook
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Welcome to the guestbook-");
            Console.WriteLine("-Select operation with numbers-");
            Console.WriteLine("1 Add Post");
            Console.WriteLine("2 Delete Post");
            Console.WriteLine("3 Display posts");
            Console.WriteLine("4 Exit program");

            var input = Console.ReadLine();
            // New guestbook class for guestbook functions
            Guestbook guestbook = new Guestbook();
            // main program loop
            while (true)
            {
                Console.Clear();
                switch (input)
                {
                    case "1":
                       
                        Console.WriteLine("Enter post owner");
                        var owner = Console.ReadLine();
                        while (String.IsNullOrEmpty(owner))
                        {
                            Console.WriteLine("Post Owner can't be empty \nTry again:");
                            owner = Console.ReadLine();
                        }
                        Console.WriteLine("Enter post");
                        var post = Console.ReadLine();
                        while (String.IsNullOrEmpty(post))
                        {
                            Console.WriteLine("Post Owner can't be empty \nTry again:");
                            post = Console.ReadLine();
                        }
                        // new post class with post information to be put into list
                        var newPost = new Post(owner, post);
                        Console.Clear();
                        guestbook.AddPost(newPost);
                        break;
                    case "2":
                        guestbook.DisplayPost();
                        Console.WriteLine("\nEnter index for post to be deleted.");
                        var index = Console.ReadLine();
                        if (!String.IsNullOrEmpty(index))
                            try
                            {
                                Console.Clear();
                                guestbook.DelPosts(Convert.ToInt32(index));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Index out of range!");
             
                            }
                        break;
                    case "3":
                        Console.WriteLine("------------Guestbook--------------\n");
                        guestbook.DisplayPost();
                        Console.WriteLine("\n-----------------------------------\n");
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Select a correct operation (1-3)");
                        break;
                }
                Console.WriteLine("-Select operation with numbers-");
                Console.WriteLine("1 Add Post");
                Console.WriteLine("2 Delete Post");
                Console.WriteLine("3 Display posts");
                Console.WriteLine("4 Exit program");

                input = Console.ReadLine();

            }
        }
       


    }





}
