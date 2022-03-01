using Wyj.Core.IRepository.Base;
using Wyj.Core.IServices;
using Wyj.Core.Model.Models;
using Wyj.Core.Services.BASE;

namespace Wyj.Core.Services
{
    /// <summary>
    /// PermissionServices
    /// </summary>	
    public class PermissionServices : BaseServices<Permission>, IPermissionServices
    {

        IBaseRepository<Permission> _dal;
        public PermissionServices(IBaseRepository<Permission> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
