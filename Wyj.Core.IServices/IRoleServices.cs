using Wyj.Core.IServices.BASE;
using Wyj.Core.Model.Models;
using System.Threading.Tasks;

namespace Wyj.Core.IServices
{	
	/// <summary>
	/// RoleServices
	/// </summary>	
    public interface IRoleServices :IBaseServices<Role>
	{
        Task<Role> SaveRole(string roleName);
        Task<string> GetRoleNameByRid(int rid);

    }
}
