using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CatMall.APIGateWay.OpenApi.Extensions.ConfigHelper
{
    public class ConfigHelper
    {
        private static IConfiguration _config;

        public ConfigHelper(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// 系统运行端口
        /// </summary>
        public static string UseUrls_Port
        {
            get
            {
                IConfiguration configs = new ConfigurationBuilder().
                    SetBasePath(Directory.GetCurrentDirectory()).
                    AddJsonFile($"{ AppDomain.CurrentDomain.BaseDirectory }appsettings.json", true, true).
                    AddJsonFile("appsettings.json", true, true).Build();

                return configs.GetSection("UseUrls:Port").Value;
            }
        }

        /// <summary>
        /// 系统名称
        /// </summary>
        public static string OrderHost
        {
            get
            {
                return _config.GetSection("OrderMS:Host").Value;
            }
        }

        /// <summary>
        /// 系统名称
        /// </summary>
        public static string CompanyCentHost
        {
            get
            {
                return _config.GetSection("CompanyCentMS:Host").Value;
            }
        }

        /// <summary>
        /// 系统名称
        /// </summary>
        public static string SYSTEMNAME
        {
            get
            {
                return _config.GetSection("BPDealerChannelMSConfig:SystemName").Value;
            }
        }

        /// <summary>
        /// Redis地址链接
        /// </summary>
        public static string RedisConfig_XMLPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + _config.GetSection("ConfigXML:RedisConfigXML").Value;
            }
        }

        #region 订单服务URL

        /// <summary>
        /// 订单服务名
        /// </summary>
        public static string BPORDERMSSYSTEMNAME
        {
            get
            {
                return _config.GetSection("OrderMS:BPOrderMSSystemName").Value;
            }
        }

        /// <summary>
        /// 力生供货商名称
        /// </summary>
        public static string MCNAME
        {
            get
            {
                return _config.GetSection("SupplierChannel:Name:MC").Value;
            }
        }

        /// <summary>
        /// 京东供货商名称
        /// </summary>
        public static string JDNAME
        {
            get
            {
                return _config.GetSection("SupplierChannel:Name:JD").Value;
            }
        }

        /// <summary>
        /// 中粮供货商名称
        /// </summary>
        public static string KLTNAME
        {
            get
            {
                return _config.GetSection("SupplierChannel:Name:KLT").Value;
            }
        }

        /// <summary>
        /// 创建订单
        /// </summary>
        public static string CREATEORDERURL
        {
            get
            {
                return _config.GetSection("OrderMS:CreateOrder").Value;
            }
        }

        /// <summary>
        /// 取消订单
        /// </summary>
        public static string CANCELORDERURL
        {
            get
            {
                return _config.GetSection("OrderMS:CancelOrder").Value;
            }
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        public static string PAYORDERURL
        {
            get
            {
                return _config.GetSection("OrderMS:PayOrder").Value;
            }
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        public static string GETORDERURL
        {
            get
            {
                return _config.GetSection("OrderMS:GetOrder").Value;
            }
        }

        /// <summary>
        /// 创建售后记录
        /// </summary>
        public static string CREATESALESRECORDURL
        {
            get
            {
                return _config.GetSection("OrderMS:CreateSalesRecord").Value;
            }
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        public static string GETORDERHEADERURL
        {
            get
            {
                return _config.GetSection("OrderMS:GetOrderHeader").Value;
            }
        }

        /// <summary>
        /// 创建订单所有者
        /// </summary>
        public static string CREATEORDEROWNER
        {
            get
            {
                return _config.GetSection("OrderMS:CreateOrderOwner").Value;
            }
        }

        /// <summary>
        /// 回调取消订单中间状态
        /// </summary>
        public static string UPDATECANCELORDERSTATEURL
        {
            get
            {
                return _config.GetSection("OrderMS:UpdateCancelOrderState").Value;
            }
        }

        /// <summary>
        /// 获取订单物流信息
        /// </summary>
        public static string GETORDERTRACK
        {
            get
            {
                return _config.GetSection("OrderMS:GetOrderTrack").Value;
            }
        }

        /// <summary>
        /// 计算运费接口
        /// </summary>
        public static string GET_FREIGHT
        {
            get
            {
                return _config.GetSection("OrderMS:GetFreight").Value;
            }
        }

        #endregion 订单服务URL

        #region 企业积分服务URL

        /// <summary>
        /// 经销商积分单位
        /// </summary>
        public static string CENTUNIT
        {
            get
            {
                return _config.GetSection("CompanyCentMS:CentUnit").Value;
            }
        }

        /// <summary>
        /// 扣款积分转入的公司
        /// </summary>
        public static string CompanyCentMS_ToCompanyID
        {
            get
            {
                return _config.GetSection("CompanyCentMS:ToCompanyID").Value;
            }
        }

        /// <summary>
        /// 查询企业积分余额
        /// </summary>
        public static string GETCOMPANYCENT
        {
            get
            {
                return _config.GetSection("CompanyCentMS:GetCompanyCent").Value;
            }
        }

        /// <summary>
        /// 扣除企业积分
        /// </summary>
        public static string DEDUCTCOCENTSACCOUNTCENT
        {
            get
            {
                return _config.GetSection("CompanyCentMS:DeductCoCentsAccountCent").Value;
            }
        }

        /// <summary>
        /// 退还企业积分
        /// </summary>
        public static string REFUNDCOCENTSACCOUNTCENT
        {
            get
            {
                return _config.GetSection("CompanyCentMS:RefundCoCentsAccountCent").Value;
            }
        }

        #endregion 企业积分服务URL

        #region 供货商渠道URL

        /// <summary>
        /// 供货商渠道host
        /// </summary>
        public static string SupplierChannelHost
        {
            get
            {
                return _config.GetSection("SupplierChannel:Host").Value;
            }
        }

        /// <summary>
        ///  根据供货商渠道简称,查询供货商渠道信息
        /// </summary>
        public static string GETSUPPLIERCHANNELBYARNAMEURL
        {
            get
            {
                return _config.GetSection("SupplierChannel:GetSupplierChannelByArName").Value;
            }
        }

        /// <summary>
        /// 查询全部供货商渠道信息
        /// </summary>
        public static string GETALLSUPPLIERCHANNELURL
        {
            get
            {
                return _config.GetSection("SupplierChannel:GetAllSupplierChannel").Value;
            }
        }

        /// <summary>
        /// 供货商服务名
        /// </summary>
        public static string SUPPLIERCHANNELAERVICENAME
        {
            get
            {
                return _config.GetSection("SupplierChannel:SupplierChannelServiceName").Value;
            }
        }

        #endregion 供货商渠道URL

        #region 其他配置

        /// <summary>
        /// 日志记录
        /// </summary>
        public static string MSMQLOGGINGURL
        {
            get
            {
                return _config.GetSection("MSMQLoggingUrl").Value;
            }
        }

        public static string APIResultState
        {
            get
            {
                return _config.GetSection("APIResultState:State").Value;
            }
        }

        /// <summary>
        /// 订单服务ID
        /// </summary>
        public static string OrderServiceId
        {
            get
            {
                return _config.GetSection("ServiceID:orderId").Value;
            }
        }

        /// <summary>
        /// 商品服务ID
        /// </summary>
        public static string ProductServiceId
        {
            get
            {
                return _config.GetSection("ServiceID:productId").Value;
            }
        }

        #endregion 其他配置

        #region RabbitMQ

        /// <summary>
        /// 地址
        /// </summary>
        public static string RabbitMQ_UserUrl
        {
            get
            {
                return _config.GetSection("RabbitMQ:UserUrl").Value;
            }
        }

        /// <summary>
        /// 账号
        /// </summary>
        public static string RabbitMQ_UserName
        {
            get
            {
                return _config.GetSection("RabbitMQ:UserName").Value;
            }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public static string RabbitMQ_Password
        {
            get
            {
                return _config.GetSection("RabbitMQ:Password").Value;
            }
        }

        /// <summary>
        /// 订单队列名
        /// </summary>
        public static string RabbitMQ_OrderQueuesName
        {
            get
            {
                return _config.GetSection("RabbitMQ:OrderQueuesName").Value;
            }
        }

        /// <summary>
        /// 消息失效时间
        /// </summary>
        public static string RabbitMQ_MsgInvalidMonthTime
        {
            get
            {
                return _config.GetSection("RabbitMQ:MsgInvalidMonthTime").Value;
            }
        }

        /// <summary>
        /// 是否开始BPOrderMQ推送消息消费
        /// </summary>
        public static bool RabbitMQ_BPOrderMQIsConsume
        {
            get
            {
                return bool.Parse(_config.GetSection("RabbitMQ:BPOrderMQIsConsume").Value);
            }
        }

        /// <summary>
        /// MQ配置端口号
        /// </summary>
        public static int RabbitMQ_Port
        {
            get
            {
                return int.Parse(_config.GetSection("RabbitMQ:Port").Value);
            }
        }

        #endregion RabbitMQ

        #region 商品服务URL

        /// <summary>
        /// 商品服务名
        /// </summary>
        public static string PRODUCTSERVICENAME
        {
            get
            {
                return _config.GetSection("ProductMS:BPProductMSSystemName").Value;
            }
        }

        /// <summary>
        /// 商品服务HOST
        /// </summary>
        public static string ProductMS_Host
        {
            get
            {
                return _config.GetSection("ProductMS:Host").Value;
            }
        }

        /// <summary>
        /// 获取商品列表
        /// </summary>
        public static string ProductMS_queryGoodsListUrl
        {
            get
            {
                // return ProductMS_Host + _config.GetSection("ProductMS:queryGoodsListUrl").Value;
                return _config.GetSection("ProductMS:queryGoodsListUrl").Value;
            }
        }

        /// <summary>
        /// 获取商品上下架状态
        /// </summary>
        public static string ProductMS_queryGoodsOnShelvesUrl
        {
            get
            {
                return _config.GetSection("ProductMS:queryGoodsOnShelvesUrl").Value;
            }
        }

        /// <summary>
        /// 查询商品分类详情
        /// </summary>
        public static string ProductMS_queryCategoryInfoUrl
        {
            get
            {
                return _config.GetSection("ProductMS:queryCategoryInfoUrl").Value;
            }
        }
        /// <summary>
        /// 查询商品分类详情V2
        /// </summary>
        public static string ProductMS_queryCategoryInfoV2Url
        {
            get
            {
                return _config.GetSection("ProductMS:queryCategoryInfoV2Url").Value;
            }
        }
        /// <summary>
        /// 查询商品分类列表
        /// </summary>
        public static string ProductMS_queryCategoryListUrl
        {
            get
            {
                return _config.GetSection("ProductMS:queryCategoryListUrl").Value;
            }
        }
        /// <summary>
        /// 查询商品分类列表V2
        /// </summary>
        public static string ProductMS_queryCategoryListV2Url
        {
            get
            {
                return _config.GetSection("ProductMS:queryCategoryListV2Url").Value;
            }
        }

        /// <summary>
        /// 查询商品区域购买限制
        /// </summary>
        public static string ProductMS_queryAreaLimitUrl
        {
            get
            {
                return _config.GetSection("ProductMS:queryAreaLimitUrl").Value;
            }
        }

        /// <summary>
        /// 查询供货商-查询京东库存
        /// </summary>
        public static string ProductMS_QueryInventoryUrl
        {
            get
            {
                return _config.GetSection("ProductMS:queryInventoryUrl").Value;
            }
        }

        /// <summary>
        /// 查询供货商-查询京东库存
        /// </summary>
        public static string ProductMS_QueryInventoryV2Url
        {
            get
            {
                return _config.GetSection("ProductMS:queryInventoryV2Url").Value;
            }
        }


        /// <summary>
        /// 查询商品详情
        /// </summary>
        public static string ProductMS_querySkuInfoUrl
        {
            get
            {
                return _config.GetSection("ProductMS:querySkuInfoUrl").Value;
            }
        }

        /// <summary>
        /// 查询商品详情V2
        /// </summary>
        public static string ProductMS_querySkuInfoV2Url
        {
            get
            {
                return _config.GetSection("ProductMS:querySkuInfoV2Url").Value;
            }
        }

        /// <summary>
        /// 批量验证商品与商品池关系
        /// </summary>
        public static string ProductMS_checkSkuContactUrl
        {
            get
            {
                return _config.GetSection("ProductMS:checkSkuContact").Value;
            }
        }

        /// <summary>
        /// 批量增加商品库存
        /// </summary>
        public static string ProductMS_addSkuStockUrl
        {
            get
            {
                return _config.GetSection("ProductMS:addSkuStock").Value;
            }
        }

        /// <summary>
        /// 批量减少商品库存
        /// </summary>
        public static string ProductMS_delSkuStockUrl
        {
            get
            {
                return _config.GetSection("ProductMS:delSkuStock").Value;
            }
        }

        /// <summary>
        /// 商品池详情
        /// </summary>
        public static string ProductMS_queryPool
        {
            get
            {
                return _config.GetSection("ProductMS:queryPool").Value;
            }
        }

        /// <summary>
        /// 商品库存
        /// </summary>
        public static string ProductMS_querySkuStock
        {
            get
            {
                return _config.GetSection("ProductMS:querySkuStock").Value;
            }
        }

        /// <summary>
        /// 批量查询商品库存
        /// </summary>
        public static string ProductMS_querySkuPriceUrl
        {
            get
            {
                return _config.GetSection("ProductMS:querySkuPrice").Value;
            }
        }

        /// <summary>
        /// 检查商品可售性
        /// </summary>
        public static string ProductMS_checkSkuEffectiveUrl
        {
            get
            {
                return _config.GetSection("ProductMS:checkSkuEffective").Value;
            }
        }

        /// <summary>
        /// 更新商品信息
        /// </summary>
        public static string ProductMS_queryUpdateSku
        {
            get
            {
                return _config.GetSection("ProductMS:queryUpdateSku").Value;
            }
        }

        /// <summary>
        /// 查询赠品信息
        /// </summary>
        public static string PRODUCTMS_QUERYGIFTINFOURL
        {
            get
            {
                return _config.GetSection("ProductMS:queryGiftInfoUrl").Value;
            }
        }

        #endregion 商品服务URL

        #region 服务

        /// <summary>
        /// 获取服务列表地址
        /// </summary>
        public static string ServiceMS_Host
        {
            get
            {
                return _config.GetSection("ServiceMS:Host").Value;
            }
        }

        /// <summary>
        /// 获取服务列表地址
        /// </summary>
        public static string ServiceMS_queryServiceList
        {
            get
            {
                return _config.GetSection("ServiceMS:queryServiceList").Value;
            }
        }

        /// <summary>
        /// 授权服务naocs服务名
        /// </summary>
        public static string ANTHENTICATIONSERVICENAME
        {
            get
            {
                return _config.GetSection("ServiceMS:AnthenticationServiceName").Value;
            }
        }

        #endregion 服务

        /// <summary>
        /// HTTP请求头
        /// </summary>
        public static string HTTPRequest_Headers
        {
            get
            {
                return _config.GetSection("HTTPRequest:Headers").Value;
            }
        }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionStrings_SqlServerConnection
        {
            get
            {
                return _config.GetSection("ConnectionStrings:SqlServerConnection").Value;
            }
        }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionStrings_MySQLConnection
        {
            get
            {
                return _config.GetSection("ConnectionStrings:MySQLConnection").Value;
            }
        }

        ///// <summary>
        ///// 端口
        ///// </summary>
        //public static string UseUrls_Port
        //{
        //    get
        //    {
        //        return _config.GetSection("UseUrls:Port").Value;
        //    }
        //}
        /// <summary>
        /// 是否启动服务调用
        /// </summary>
        public static string IsStartUpServive
        {
            get
            {
                return _config.GetSection("IsStartUpServive:Service").Value;
            }
        }

        /// <summary>
        /// 内网关服务id
        /// </summary>
        public static string Innergateway_ServiceId
        {
            get
            {
                return _config.GetSection("Innergateway:serviceId").Value;
            }
        }

        /// <summary>
        /// 内网关签名
        /// </summary>
        public static string Innergateway_Sign
        {
            get
            {
                return _config.GetSection("Innergateway:sign").Value;
            }
        }

        #region ISP网关相关配置

        /// <summary>
        /// AES密钥
        /// </summary>
        public static string GateWayConfig_AESKey
        {
            get
            {
                return _config.GetSection("GateWayConfig:AESKey").Value;
            }
        }

        /// <summary>
        /// 请求的ServiceId
        /// </summary>
        public static string GateWayConfig_ServiceId
        {
            get
            {
                return _config.GetSection("GateWayConfig:ServiceId").Value;
            }
        }

        /// <summary>
        /// 参与签名的秘钥
        /// </summary>
        public static string GateWayConfig_Secretkey
        {
            get
            {
                return _config.GetSection("GateWayConfig:Secretkey").Value;
            }
        }

        /// <summary>
        /// 请求其他系统接口需要的报文头签名
        /// </summary>
        public static string GateWayConfig_Sign
        {
            get
            {
                return _config.GetSection("GateWayConfig:Sign").Value;
            }
        }

        /// <summary>
        /// consulIP
        /// </summary>
        public static string CONSULIP
        {
            get
            {
                return _config.GetSection("Consul:IP").Value;
            }
        }

        /// <summary>
        /// consul端口
        /// </summary>
        public static string CONSULPORT
        {
            get
            {
                return _config.GetSection("Consul:Port").Value;
            }
        }

        #endregion ISP网关相关配置

        #region 账户服务

        /// <summary>
        /// 账户服务naocs服务名
        /// </summary>
        public static string ACCOUNTSERVICENAME
        {
            get
            {
                return _config.GetSection("AccountMS:AccountServiceName").Value;
            }
        }

        /// <summary>
        /// 账户Host
        /// </summary>
        public static string ACCOUNTMS_HOST
        {
            get
            {
                return _config.GetSection("AccountMS:Host").Value;
            }
        }

        /// <summary>
        /// 获取企业下所有一般账户
        /// </summary>
        public static string ACCOUNTMS_GENERALCOCENTACCOUNT
        {
            get
            {
                return ACCOUNTMS_HOST + _config.GetSection("AccountMS:GeneralCoCentAccount").Value;
            }
        }

        /// <summary>
        /// 获取企业下所有账户 V3获取的积分账户过多
        /// </summary>
        public static string ACCOUNTMS_GENERALCOCENTACCOUNTV3
        {
            get
            {
                return _config.GetSection("AccountMS:GeneralCoCentAccountv3").Value;
            }
        }

        //GetDataDictByPCode
        /// <summary>
        /// 获取企业下所有一般账户
        /// </summary>
        public static string ACCOUNTMS_GETDATADICTBYPCODEV3
        {
            get
            {
                return _config.GetSection("AccountMS:GetDataDictByPCodev3").Value;
            }
        }

        /// <summary>
        /// 获取企业下所有一般账户 V3
        /// </summary>
        public static string GET_GENERAL_CO_CENTS_BYCOMPANY_V3
        {
            get
            {
                return _config.GetSection("AccountMS:GetGeneralCoCentsByCompanyV3").Value;
            }
        }
        #endregion 账户服务

        #region 积分服务

        /// <summary>
        /// 收款企业id
        /// </summary>
        public static string COMPANYID
        {
            get
            {
                return _config.GetSection("CentMS:CompanyID").Value;
            }
        }

        /// <summary>
        /// 积分用途
        /// </summary>
        public static int MAID
        {
            get
            {
                return int.Parse(_config.GetSection("CentMS:MAID").Value);
            }
        }

        /// <summary>
        /// 交易类型
        /// </summary>
        public static int TBID
        {
            get
            {
                return int.Parse(_config.GetSection("CentMS:TBID").Value);
            }
        }

        /// <summary>
        /// 积分服务naocs服务名
        /// </summary>
        public static string CENTSERVICENAME
        {
            get
            {
                return _config.GetSection("CentMS:CentServiceName").Value;
            }
        }

        /// <summary>
        /// 账户Host
        /// </summary>
        public static string CENTMS_HOST
        {
            get
            {
                return _config.GetSection("CentMS:Host").Value;
            }
        }

        /// <summary>
        /// 通过企业积分账号ID获取其余额信息
        /// </summary>
        public static string CENTMS_COCENTSACCOUNTBALANCE
        {
            get
            {
                return CENTMS_HOST + _config.GetSection("CentMS:CoCentsAccountBalance").Value;
            }
        }

        /// <summary>
        /// 企业积分账户互转
        /// </summary>
        public static string CENTMS_TRANSFERCOATOCOA
        {
            get
            {
                // CENTMS_HOST + 
                return _config.GetSection("CentMS:TransferCoAToCoAv3").Value;
            }
        }

        /// <summary>
        /// 通过企业积分账号ID获取其余额信息
        /// </summary>
        public static string CENTMS_COCENTSACCOUNTBALANCEV3
        {
            get
            {
                return _config.GetSection("CentMS:CoCentsAccountBalancev3").Value;
            }
        }

        /// <summary>
        /// 企业积分账户互转
        /// </summary>
        public static string CENTMS_TRANSFERCOATOCOAV3
        {
            get
            {
                return _config.GetSection("CentMS:TransferCoAToCoA").Value;
            }
        }

        #endregion 积分服务

        #region nacos配置

        /// <summary>
        /// nacos配置 IP
        /// </summary>
        public static string NACOSIP
        {
            get
            {
                return _config.GetSection("nacos:NacosIp").Value;
            }
        }

        /// <summary>
        /// nacos配置 Port
        /// </summary>
        public static string NACOSPORT
        {
            get
            {
                return _config.GetSection("nacos:NacosPort").Value;
            }
        }

        /// <summary>
        /// nacos配置 组名
        /// </summary>
        public static string NACOSGROUPNAME
        {
            get
            {
                return _config.GetSection("nacos:GroupName").Value;
            }
        }

        /// <summary>
        /// nacos配置 命名空间id
        /// </summary>
        public static string NACOSNAMESPACE
        {
            get
            {
                return _config.GetSection("nacos:Namespace").Value;
            }
        }

        /// <summary>
        /// nacos配置 服务名
        /// </summary>
        public static string NACOSSERVICENAME
        {
            get
            {
                return _config.GetSection("nacos:ServiceName").Value;
            }
        }

        #endregion nacos配置

        #region 字典表配置

        /// <summary>
        /// 规则父节点
        /// </summary>
        public static string DICTIONARYRULEPCODE
        {
            get
            {
                return _config.GetSection("Dictionary:RulePCode").Value;
            }
        }

        #endregion 字典表配置

        #region 查询商品库存不足判断Code
        /// <summary>
        /// 京东库存不足判断Code
        /// </summary>
        public static List<string> JD_INVENTORY_SHORTAGE_STATUS_CODE_LIST
        {
            get
            {
                return _config.GetSection("QueryInventoryStatusCode:JD").Value.Split(",").ToList();
            }
        }

        /// <summary>
        /// 京东库存不足判断Code
        /// </summary>
        public static List<string> KLT_INVENTORY_SHORTAGE_STATUS_CODE_LIST
        {
            get
            {
                return _config.GetSection("QueryInventoryStatusCode:KLT").Value.Split(",").ToList();
            }
        }
        #endregion

        #region 商品服务配置

        #region 商品上下架服务配置

        /// <summary>
        /// 查询商品服务--商品上下架每次商品数量限制
        /// </summary>
        public static int BPDCMSProduct_queryGoodsOnShelvesV2MaxLimit
        {
            get
            {
                return int.Parse(_config.GetSection("BPDCMSProduct:queryGoodsOnShelvesV2Maxlimit").Value);
            }
        }

        /// <summary>
        /// 查询商品上下架商品skuids分割符
        /// </summary>
        public static string BPDCMSProduct_queryGoodsOnShelvesV2Separator
        {
            get
            {
                return _config.GetSection("BPDCMSProduct:queryGoodsOnShelvesV2Separator").Value;
            }
        }

        #endregion

        #endregion

    }
}
