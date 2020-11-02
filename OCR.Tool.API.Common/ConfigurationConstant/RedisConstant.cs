namespace OCR.Tool.API.Common.ConfigurationConstant
{
    public class RedisConstant : BaseConstant
    {
        /// <summary>
        /// 可写的Redis链接地址
        /// format:ip1,ip2
        ///
        /// 默认6379端口
        /// </summary>
        public static readonly string WriteServerList = Configuration["Redis:WriteServerList"];

        /// <summary>
        /// 可读的Redis链接地址
        /// format:ip1,ip2
        /// </summary>
        public static readonly string ReadServerList = Configuration["Redis:ReadServerList"];

        /// <summary>
        /// 最大写链接数
        /// </summary>
        public static readonly int MaxWritePoolSize = int.Parse(Configuration["Redis:MaxWritePoolSize"]);

        /// <summary>
        /// 默认连接的DB
        /// </summary>
        public static readonly int DefaultDb = int.Parse(Configuration["Redis:DefaultDb"]);

        /// <summary>
        /// 最大读链接数
        /// </summary>
        public static readonly int MaxReadPoolSize = int.Parse(Configuration["Redis:MaxReadPoolSize"]);

        /// <summary>
        /// 本地缓存到期时间，单位:秒
        /// </summary>
        public static readonly int LocalCacheTime = int.Parse(Configuration["Redis:LocalCacheTime"]);

        /// <summary>
        /// 自动重启
        /// </summary>
        public static readonly bool AutoStart = bool.Parse(Configuration["Redis:AutoStart"]);

        /// <summary>
        /// 是否记录日志,该设置仅用于排查redis运行时出现的问题,
        /// 如redis工作正常,请关闭该项
        /// </summary>
        public static readonly bool RecordeLog = bool.Parse(Configuration["Redis:RecordeLog"]);
    }
}