using Wyj.Core.IServices.BASE;
using Wyj.Core.Model;
using Wyj.Core.Model.Models;
using System.Threading.Tasks;

namespace Wyj.Core.IServices
{
    public partial interface IGuestbookServices : IBaseServices<Guestbook>
    {
        Task<MessageModel<string>> TestTranInRepository();
        Task<bool> TestTranInRepositoryAOP();
    }
}
