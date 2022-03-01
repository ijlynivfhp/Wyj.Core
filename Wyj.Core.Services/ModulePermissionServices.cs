using Wyj.Core.Services.BASE;
using Wyj.Core.Model.Models;
using Wyj.Core.IRepository;
using Wyj.Core.IServices;
using Wyj.Core.IRepository.Base;

namespace Wyj.Core.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {

        IBaseRepository<ModulePermission> _dal;
        public ModulePermissionServices(IBaseRepository<ModulePermission> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
