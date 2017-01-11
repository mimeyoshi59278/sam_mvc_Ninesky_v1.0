using System.ComponentModel.DataAnnotations;

namespace Ninesky.Website.Areas.Config.Models
{
    /// <summary>
    /// 登陆模型
    /// <remarks>
    /// 创建：2014.12.13
    /// </remarks>
    /// </summary>
    public class LoginViewModel
    {
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0}长度{2}-{1}个字符")]
        [Display(Name = "账号")]
        public string Account { get; set; }

        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0}长度{2}-{1}个字符")]
        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}