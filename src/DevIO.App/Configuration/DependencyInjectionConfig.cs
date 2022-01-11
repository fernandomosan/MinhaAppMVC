using DevIO.Business.Interfaces;
using DevIO.Business.Interfaces.InterfacesServices;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Date.Context;
using DevIO.Date.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DevIO.App.Extensions.MoedaAttribute;

namespace DevIO.App.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorServices, FornecedorService>();
            services.AddScoped<IProdutoServices, ProdutoServise>();

            return services;
        }
    }
}
