using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Entity.Entities;
using Site.Entity.ViewModel.Articles;
namespace Site.Service.Services.Abstractions;

public interface IArticleService
{
  Task<List<ArticleDTO>> GetAllArticleAsync();

}
