﻿namespace CarBook.Application.Features.Mediator.Results.BlogResult
{
    public class GetBlogByAuthorIdQueryResult
    {
        public int BlogID { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
    }
}
