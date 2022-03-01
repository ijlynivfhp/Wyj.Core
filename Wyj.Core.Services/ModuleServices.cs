using Wyj.Core.IRepository.Base;
using Wyj.Core.IServices;
using Wyj.Core.Model.Models;
using Wyj.Core.Services.BASE;

namespace Wyj.Core.Services
{
    /// <summary>
    /// ModuleServices
    /// </summary>	
    public class ModuleServices : BaseServices<Modules>, IModuleServices
    {

        IBaseRepository<Modules> _dal;
        public ModuleServices(IBaseRepository<Modules> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
