using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Net;

namespace _02._Articles_2._0
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleParts = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string title = articleParts[0];
                string content = articleParts[1];
                string author = articleParts[2];
                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}