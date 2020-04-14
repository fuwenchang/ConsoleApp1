using System;
using System.Collections.Generic;
using System.Text;
using Bayantu.Evos.Services.Match.Domain.SeedWork;

namespace Bayantu.Evos.Services.Match.Domain.Aggregates.PsaBusinessNegotiationAggregate
{
    /// <summary>
    /// 洽谈状态
    /// </summary>
    public class NegotiationStatusType : EnumerationExtend<NegotiationStatusType>
    {
        /// <summary>
        /// 买家发起洽谈请求
        /// </summary>
        public static readonly NegotiationStatusType BuyerSend = new NegotiationStatusType("BuyerSend", "买家发起洽谈请求");

        /// <summary>
        /// 买家拒绝
        /// </summary>
        public static readonly NegotiationStatusType BuyerRefuse = new NegotiationStatusType("BuyerRefuse", "买家拒绝");

        /// <summary>
        /// 买家取消
        /// </summary>
        public static readonly NegotiationStatusType BuyerCancel = new NegotiationStatusType("BuyerCancel", "买家取消");

        /// <summary>
        /// 卖家发起洽谈请求
        /// </summary>
        public static readonly NegotiationStatusType SellerSend = new NegotiationStatusType("SellerSend", "卖家发起洽谈请求");

        /// <summary>
        /// 卖家拒绝
        /// </summary>
        public static readonly NegotiationStatusType SellerRefuse = new NegotiationStatusType("SellerRefuse", "卖家拒绝");

        /// <summary>
        /// 卖家取消
        /// </summary>
        public static readonly NegotiationStatusType SellerCancel = new NegotiationStatusType("SellerCancel", "卖家取消");

        /// <summary>
        /// 已过期
        /// </summary>
        public static readonly NegotiationStatusType Expired = new NegotiationStatusType("Expired", "已过期");

        /// <summary>
        /// 等待洽谈
        /// </summary>
        public static readonly NegotiationStatusType Wait = new NegotiationStatusType("Wait", "等待洽谈");

        /// <summary>
        /// 已洽谈 
        /// </summary>
        public static readonly NegotiationStatusType Finish = new NegotiationStatusType("Finish", "已洽谈");

        public static readonly NegotiationStatusType None = new NegotiationStatusType("None", "无");
        public NegotiationStatusType(string code, string codeName) : base(code, codeName)
        {
        }
    }
}
