﻿namespace CarBook.Domain.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}