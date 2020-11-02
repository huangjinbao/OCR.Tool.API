using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace OCR.Tool.API.Common.ConfigurationConstant
{
    public class BaseConstant
    {
        protected static IConfiguration Configuration { get; set; }

        static BaseConstant()
        {
            //ReloadOnChange = true 当appsettings.json被修改时重新加载
            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
                .Build();
        }
    }
}