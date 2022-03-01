using Wyj.Core.Common;
using Wyj.Core.Common.Helper;
using Wyj.Core.IRepository.Base;
using Wyj.Core.IRepository.UnitOfWork;
using Wyj.Core.IServices;
using Wyj.Core.Model;
using Wyj.Core.Model.Models;
using Wyj.Core.Model.ViewModels;
using Wyj.Core.Services.BASE;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wyj.Core.Services
{
    /// <summary>
	/// WeChatSubServices
	/// </summary>
    public class WeChatSubServices : BaseServices<WeChatSub>, IWeChatSubServices
    {
        readonly IBaseRepository<WeChatSub> _dal;
        readonly IUnitOfWork _unitOfWork;
        readonly ILogger<WeChatSubServices> _logger;
        public WeChatSubServices(IBaseRepository<WeChatSub> dal,IUnitOfWork unitOfWork, ILogger<WeChatSubServices> logger)
        {
            this._dal = dal;
            base.BaseDal = dal;
            this._unitOfWork = unitOfWork;
            this._logger = logger;
        }  
        
    }
}