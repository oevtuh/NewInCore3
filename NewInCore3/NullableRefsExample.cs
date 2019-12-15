using System;
using System.Collections.Generic;
using System.Text;
#nullable enable

namespace NewInCore3
{
    public static class NullableRefsExample
    {
        public static void Demo()
        {
            var post = new BlogPost("Test1");
            post.Comments.Add(new Comment("Test2", new Author("John", "test@gmail.com")));
            post.Comments.Add(new Comment("Test3", new Author("Leah", "test@gmail.com")));
            //post.Comments.Add(null);

            PrintPostInfo(post);

        }

        public static void PrintPostInfo(BlogPost post)
        {
            Console.WriteLine($"{post.Title} ({post.Title.Length})");

            foreach (var comment in post.Comments)
            {
                var commentPreview = comment.Body.Length > 10 ?
                    $"{comment.Body.Substring(0, 10)}..." :
                    comment.Body;

                Console.WriteLine($"{comment.PostedBy.Name} ({comment.PostedBy.Email}): " + $"{commentPreview}");
            }
        }
    }
}
