using Wyj.Core.IRepository.Base;
using Wyj.Core.IServices;
using Wyj.Core.Model.Models;
using Wyj.Core.Services.BASE;

namespace Wyj.Core.Services
{
    public partial class OperateLogServices : BaseServices<OperateLog>, IOperateLogServices
    {
        IBaseRepository<OperateLog> _dal;
        public OperateLogServices(IBaseRepository<OperateLog> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
