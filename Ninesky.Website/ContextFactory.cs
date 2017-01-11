using System.Runtime.Remoting.Messaging;

namespace Ninesky.Website
{
    /// <summary>
    /// 上下文简单工厂
    /// <remarks>
    /// 创建：2014.12.13
    /// </remarks>
    /// </summary>
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns>数据上下文</returns>
        public static NineskyDbContext GetCurrentContext()
        {
            NineskyDbContext _nineskyDbContext = CallContext.GetData("NineskyDbContext") as NineskyDbContext;
            if (_nineskyDbContext == null)
            {
                _nineskyDbContext = new NineskyDbContext();
                CallContext.SetData("NineskyDbContext", _nineskyDbContext);
            }
            return _nineskyDbContext;
        }
    }
}