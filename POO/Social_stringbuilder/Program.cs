using System;
using Social_stringbuilder.Etities;
using System.Text;
using System.Collections.Generic;

namespace Social_stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime time = new DateTime(2018,6,21,13,5,44);
            string title = "Traveling to new Zeland";
            string content = "I'm going to visit this wonderful country!";
            int like = 12;

            Post p1 = new Post(time,title,content,like);
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            p1.AddComment(c1);
            p1.AddComment(c2);

            System.Console.WriteLine(p1);
        }
    }
}
