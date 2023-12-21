using Site.Service.Services.Concretes;
using Site.Service.Services.Abstractions;
using Site.Entity.Entities;
using Site.Data.UnitOfWorks;
using Site.Entity.ViewModel.Articles;
using AutoMapper;
namespace Site.Service.Services.Concretes;

public class ArticleService : IArticleService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<List<ArticleDTO>> GetAllArticleAsync()
    {

        var articles= await unitOfWork.GetRepository<Article>().GetAllAsycn();

        var map =mapper.Map<List<ArticleDTO>>(articles);

        return map;
    }
}
