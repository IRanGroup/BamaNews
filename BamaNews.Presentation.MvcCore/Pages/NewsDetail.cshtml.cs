using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BN.Application.Contract.News;
using BN.Infrastrure.Query.NewsQuerys;
using BN.Infrastrure.Query.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BamaNews.Presentation.MvcCore.Pages
{
    public class NewsDetailModel : PageModel
    {
        private readonly INewsQuery _NewsQuery;

        public NewsDetailModel(INewsQuery newsQuery)
        {
            _NewsQuery = newsQuery;
        }
        public NewsView NewsModel { get; set; }

        public void OnGet(int id)
        {
            NewsModel = _NewsQuery.SelectRow(id);
        }

    }
}
