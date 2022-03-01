using Wyj.Core.IRepository.Base;
using Wyj.Core.Model.IDS4DbModels;
using Wyj.Core.Services.BASE;

namespace Wyj.Core.IServices
{
    public class ApplicationUserServices : BaseServices<ApplicationUser>, IApplicationUserServices
    {

        IBaseRepository<ApplicationUser> _dal;
        public ApplicationUserServices(IBaseRepository<ApplicationUser> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}