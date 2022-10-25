using System.Globalization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chaves.Core.Tests
{

    public class Startup
    {
        public IConfiguration Configuracao { get; }
        public Startup()
        {
            Configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddEnvironmentVariables()
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuracao);

            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        }
    }

}

