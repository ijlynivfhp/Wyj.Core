using Wyj.Core.IRepository.Base;
using Wyj.Core.IServices;
using Wyj.Core.Model.Models;
using Wyj.Core.Services.BASE;

namespace Wyj.Core.Services
{
    public partial class AccessTrendLogServices : BaseServices<AccessTrendLog>, IAccessTrendLogServices
    {
        IBaseRepository<AccessTrendLog> _dal;
        public AccessTrendLogServices(IBaseRepository<AccessTrendLog> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
