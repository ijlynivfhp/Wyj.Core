using Wyj.Core.IRepository.Base;
using Wyj.Core.IServices;
using Wyj.Core.Model.Models;
using Wyj.Core.Services.BASE;

namespace Wyj.Core.Services
{
    public partial class PasswordLibServices : BaseServices<PasswordLib>, IPasswordLibServices
    {
        IBaseRepository<PasswordLib> _dal;
        public PasswordLibServices(IBaseRepository<PasswordLib> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
