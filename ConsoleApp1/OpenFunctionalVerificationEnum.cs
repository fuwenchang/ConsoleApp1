using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum OpenFunctionalVerificationEnum
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,
        /// <summary>
        /// 是否仅管理员可见
        /// </summary>
        IsOnlyAdmin = 1,
        /// <summary>
        /// 是否允许查询，多选下拉使用
        /// </summary>
        IsAllowSearch = 2,
        /// <summary>
        /// 报名后不允许修改
        /// </summary>
        IsJoinAfterAllowModify = 4,
        /// <summary>
        /// 缓存该字段，在填写下一个表单时自动填写
        /// </summary>
        IsNeedCookie = 8,
        /// <summary>
        /// 是否启用国际区号
        /// </summary>
        IsGlobalRoaming = 16,
        /// <summary>
        /// 是否禁用
        /// </summary>
        IsForbidden = 32,
        /// <summary>
        /// 是否显示详细地址
        /// </summary>
        IsShowDetailAddress = 64,
        /// <summary>
        /// 启用其他属性
        /// </summary>
        EnableOther = 128,
        /// <summary>
        /// 手机是否开启动态验证码
        /// </summary>
        IsOpenMobileAuthCode = 256,
        /// <summary>
        /// 手机是否开启动态验证码
        /// </summary>
        IsOpenEmailAuthCode = 512,
        /// <summary>
        /// 是否隐藏二次密码
        /// </summary>
        IsHideSecoundPassword = 1024,
        /// <summary>
        /// 是否唯一
        /// </summary>
        IsUnique = 2048,
        /// <summary>
        /// 是否必须
        /// </summary>
        IsNeeded = 4096,
        /// <summary>
        /// 是否显示
        /// </summary>
        IsShow = 8192
    }
}
