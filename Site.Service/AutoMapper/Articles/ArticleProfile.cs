using AutoMapper;
using Site.Entity.Entities;
using Site.Entity.ViewModel.Articles;


namespace Site.Service.AutoMapper.Articles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<ArticleDTO,Article>().ReverseMap();
    }
}
