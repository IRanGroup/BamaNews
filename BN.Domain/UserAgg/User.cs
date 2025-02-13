﻿using BN.Domain.CommentAgg;
using FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Domain.UserAgg
{
    public class User:DomainBase<int>
    {

        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string UserRole { get; private set; }
        public string UserAvatar { get; private set; }
        public string Passwoard { get; private set; }
        public bool IsAdmin { get; private set; }

        //Relation Shipts

        //User To Comment
        public IEnumerable<Comment> Comment { get; set; }

        protected User()
        {
        }

        public User(string userName, string email, string userAvatar, string passwoard)
        {
            UserName = userName;
            Email = email;
            UserAvatar = userAvatar;
            Passwoard = passwoard;
            UserRole = "user";
            IsAdmin = false;
        }

        public void Edit(string userName, string email, string userAvatar, string passwoard, string userRole)
        {
            UserName = userName;
            Email = email;
            UserAvatar = userAvatar;
            Passwoard = passwoard;
            UserRole = userRole;
        }



    }
}
