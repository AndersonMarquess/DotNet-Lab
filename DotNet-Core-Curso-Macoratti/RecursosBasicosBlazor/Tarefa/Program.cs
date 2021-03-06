﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tarefa.Repositorios;

namespace Tarefa
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

            await builder.Build().RunAsync();
        }
    }
}
