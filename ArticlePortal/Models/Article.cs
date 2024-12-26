using System;
using System.ComponentModel.DataAnnotations;

namespace ArticlePortal.Models
{
	public class Article
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Content { get; set; }

		public string? Author { get; set; }
		public DateTime PublishedDate { get; set; }
	}
}
