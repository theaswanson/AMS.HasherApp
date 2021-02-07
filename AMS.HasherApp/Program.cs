using AMS.Hasher;
using AMS.Hasher.Hashers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.HasherApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            var form = serviceProvider.GetRequiredService<Form1>();
            Application.Run(form);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            ConfigureHashers(services);
            services.AddSingleton<IHashUpdater, HashUpdater>();
            services.AddSingleton<Form1>();
        }

        private static void ConfigureHashers(ServiceCollection services)
        {
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.Base64>, AMS.Hasher.Hashers.Base64>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.MD4>, AMS.Hasher.Hashers.MD4>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.MD5>, AMS.Hasher.Hashers.MD5>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.SHA1>, AMS.Hasher.Hashers.SHA1>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.SHA256>, AMS.Hasher.Hashers.SHA256>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.SHA512>, AMS.Hasher.Hashers.SHA512>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.Whirlpool>, AMS.Hasher.Hashers.Whirlpool>();
            services.AddSingleton<ITextHasher<AMS.Hasher.HashTypes.ROT13>, AMS.Hasher.Hashers.ROT13>();
        }
    }
}