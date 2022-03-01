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
	/// WeChatPushLogServices
	/// </summary>
    public class WeChatPushLogServices : BaseServices<WeChatPushLog>, IWeChatPushLogServices
    {
        readonly IBaseRepository<WeChatPushLog> _dal;
        readonly IUnitOfWork _unitOfWork;
        readonly ILogger<WeChatPushLogServices> _logger;
        public WeChatPushLogServices(IBaseRepository<WeChatPushLog> dal,IUnitOfWork unitOfWork, ILogger<WeChatPushLogServices> logger)
        {
            this._dal = dal;
            base.BaseDal = dal;
            this._unitOfWork = unitOfWork;
            this._logger = logger;
        }  
        
    }
}