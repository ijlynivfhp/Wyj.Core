using Wyj.Core.IServices.BASE;
using Wyj.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wyj.Core.IServices
{
    public interface ITopicServices : IBaseServices<Topic>
    {
        Task<List<Topic>> GetTopics();
    }
}
