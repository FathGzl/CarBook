﻿namespace CarBook.Dto.BlogDtos
{
    public class ResultBlogByIdDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public int Description { get; set; }

    }
}
