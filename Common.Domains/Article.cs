using Nest;
using System.Collections.Generic;
using System.Linq;

namespace Common.Domains
{
    [ElasticsearchType(Name = "Article", IdProperty = "ArticleId")]
    public class Article
    {
        [Number(NumberType.Integer, Name = "ArticleId")]
        public int ArticleId { get; set; }

        [String(Analyzer = "standard", Name = "Name")]
        public string Name { get; set; }

        public IEnumerable<Author> Authors { get; set; }

        public bool ShouldSerializeAuthors()
        {
            return Authors != null && Authors.Any();
        }
    }

    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }
    }
}
