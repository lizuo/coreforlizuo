using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace coreforzhihu.Models
{
    /// <summary>
    /// Json模板类
    /// </summary>
    /// <typeparam name="T">HTTP接口返回的数据类型</typeparam>
    public class JsonModel<T>
    {

        /// <summary>
        /// 返回代码
        /// </summary>
       [JsonProperty("")]
        public int Code { get; set; }
         /// <summary>
        /// 返回消息
        /// </summary>
        [JsonProperty("")]
       
        public string Message { get; set; }

        [JsonProperty("")]
        /// <summary>
        /// 返回结果
        /// </summary>
        public T Data { get; set; }

    }
}
