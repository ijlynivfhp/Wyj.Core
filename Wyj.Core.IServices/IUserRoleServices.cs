using Wyj.Core.IServices.BASE;
using Wyj.Core.Model.Models;
using System.Threading.Tasks;

namespace Wyj.Core.IServices
{	
	/// <summary>
	/// UserRoleServices
	/// </summary>	
    public interface IUserRoleServices :IBaseServices<UserRole>
	{

        Task<UserRole> SaveUserRole(int uid, int rid);
        Task<int> GetRoleIdByUid(int uid);
    }
}

