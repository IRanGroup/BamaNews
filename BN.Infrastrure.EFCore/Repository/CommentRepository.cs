﻿using BN.Application.Contract.Comments;
using BN.Domain.CommentAgg;
using BN.Infrastrure.Query;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BN.Infrastrure.EFCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BamaNewsContext _Context;

        public CommentRepository(BamaNewsContext context)
        {
            _Context = context;
        }
        public void Add(Comment comment)
        {
            _Context.Comments.Add(comment);
            Save();
        }

        public IEnumerable<CommentViewModel> All()
        {
            return _Context.Comments.Include(u => u.Users).Include(n => n.News)
                .Select(x => new CommentViewModel()
                {
                    Id = x.Comment_Id,
                    Title = x.TitleComment,
                    Message = x.Message,
                    StatusComment = x.StatusComment,
                    CreationDate = x.Creationdate.Toshamsi(),
                    UserName = x.Users.UserName,
                    NewsTitle = x.News.NewsTitle,
                    UserId=x.UserId,
                    NewsId=x.NewsId
                }).AsNoTracking().OrderBy(z => z.StatusComment).ToList();
        }

        public Comment Row(int id)
        {
            return _Context.Comments.SingleOrDefault(x => x.Comment_Id == id);
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

    }
}
