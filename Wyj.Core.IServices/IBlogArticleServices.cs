using Wyj.Core.IServices.BASE;
using Wyj.Core.Model.Models;
using Wyj.Core.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wyj.Core.IServices
{
    public interface IBlogArticleServices :IBaseServices<BlogArticle>
    {
        Task<List<BlogArticle>> GetBlogs();
        Task<BlogViewModels> GetBlogDetails(int id);

    }

}
