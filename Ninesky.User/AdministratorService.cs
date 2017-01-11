using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninesky.Data;
using Ninesky.User.Models;
using System.Data.Entity;

namespace Ninesky.User
{
    /// <summary>
    /// 管理员业务逻辑类
    /// <remarks>
    /// 创建：2014.12.13
    /// </remarks>
    /// </summary>
    public class AdministratorService:BaseService<Administrator>
    {
        /// <summary>
        /// 创建管理员业务逻辑
        /// </summary>
        /// <param name="dbContext">数据上下文</param>
        public AdministratorService(DbContext dbContext) : base(dbContext) { }
        
    }
}
