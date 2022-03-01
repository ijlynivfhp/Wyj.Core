using System;
using System.Collections.Generic;
using System.Text;

namespace Wyj.Core.Model.ViewModels
{
    /// <summary>
    /// 微信OpenID列表Dto
    /// </summary>
    public class WeChatOpenIDsDto
    {
        public List<string> openid { get; set; } = new List<string>();
    }
}
