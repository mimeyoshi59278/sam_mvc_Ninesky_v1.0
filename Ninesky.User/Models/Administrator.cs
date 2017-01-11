using System;
using System.ComponentModel.DataAnnotations;

namespace Ninesky.User.Models
{
    /// <summary>
    /// 管理员模型
    /// <remarks>
    /// 创建：2014.12.13
    /// </remarks>
    /// </summary>
    public class Administrator
    {
        [Key]
        public int AdministratorID { get; set; }

        /// <summary>
        /// 管理员账号
        /// </summary>
        [Required(ErrorMessage = "必须输入{0}")]
        [Display(Name = "管理员账号")]
        public string Account { get; set; }

        /// <summary>
        /// 管理员名称
        /// </summary>
        [Required(ErrorMessage = "必须输入{0}")]
        [Display(Name = "管理员名称")]
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "必须输入{0}")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 上次登陆Ip
        /// </summary>
        public string LoginIp { get; set; }

        /// <summary>
        /// 上次登陆时间
        /// </summary>
        public Nullable<DateTime> LoginTime { get; set; }
    }
}
