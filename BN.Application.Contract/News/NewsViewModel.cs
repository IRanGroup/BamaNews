﻿namespace BN.Application.Contract.News
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string NewsCategory { get; set; }
        public bool IsDeleted { get; set; }
        public string CreationDate { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
    }
}
