using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0_Objects_and_Classes___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < counter; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            string criteria = Console.ReadLine();
            if (criteria=="title")
            {
               articles= articles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria=="content")
            {
                articles.Sort((c1, c2) => c1.Content.CompareTo(c2.Content));
            }
            else if (criteria=="author")
            {
                articles=articles.OrderBy(x => x.Author).ToList();
            }
        Console.WriteLine(string.Join(Environment.NewLine,articles));
        }
    }
    public class Article
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public Article(string title, string content, string author)
        {
            this.Content = content;
            this.Author = author;
            this.Title = title;
        }
        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
