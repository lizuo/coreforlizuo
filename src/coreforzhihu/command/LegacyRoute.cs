using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreforzhihu.command
{
    /// <summary>
    /// 实现一个类，继承IRouter接口
    /// </summary>
    public class LegacyRoute: IRouter
    {
        private readonly string[] _urls;

        public LegacyRoute(params string[] urls)
        {
            _urls = urls;
        }

        public Task RouteAsync(RouteContext context)
        {
            var requestedUrl = context.HttpContext.Request.Path.Value.TrimEnd('/');
            if (_urls.Contains(requestedUrl, StringComparer.OrdinalIgnoreCase))
            {
                context.Handler = async ctx => {
                    var response = ctx.Response;
                    byte[] bytes = Encoding.ASCII.GetBytes($"This URL: {requestedUrl} is not available now");
                    await response.Body.WriteAsync(bytes, 0, bytes.Length);
                };
            }
            return Task.CompletedTask;
        }

        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            return null;
        }
    }
}
