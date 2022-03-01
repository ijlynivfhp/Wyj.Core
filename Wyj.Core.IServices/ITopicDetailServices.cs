using Wyj.Core.IServices.BASE;
using Wyj.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wyj.Core.IServices
{
    public interface ITopicDetailServices : IBaseServices<TopicDetail>
    {
        Task<List<TopicDetail>> GetTopicDetails();
    }
}
