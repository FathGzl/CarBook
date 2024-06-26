﻿namespace CarBook.Dto.BlogDtos
{
    public class CreateBlogDto
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Desription { get; set; }
    }
}
