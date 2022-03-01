using Wyj.Core.Common;
using Wyj.Core.IRepository.Base;
using Wyj.Core.IServices;
using Wyj.Core.Model.Models;
using Wyj.Core.Services.BASE;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wyj.Core.Services
{
    public class TopicServices: BaseServices<Topic>, ITopicServices
    {

        IBaseRepository<Topic> _dal;
        public TopicServices(IBaseRepository<Topic> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        /// <summary>
        /// 获取开Bug专题分类（缓存）
        /// </summary>
        /// <returns></returns>
        [Caching(AbsoluteExpiration = 60)]
        public async Task<List<Topic>> GetTopics()
        {
            return await base.Query(a => !a.tIsDelete && a.tSectendDetail == "tbug");
        }

    }
}
