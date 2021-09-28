using System;
using System.Text;
using System.Collections.Generic;
using Social_stringbuilder.Etities;

namespace Social_stringbuilder.Etities
{
    public class Post
    {
        public DateTime Moment {get; set;}
        public string  Title { get; set;}
        public string Content { get; set;}
        public int Likes { get; set; }
        public List<Comment> Comments = new List<Comment>(); // Composição com uma lista de comments

        public Post(){

        }

        public Post(DateTime date, string title, string content, int likes){
            Moment = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment){ // implementação padrão
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment){
            Comments.Remove(comment);
        }

        public override string ToString(){
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title); //Adiciona o título na string de saída
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

    }

}