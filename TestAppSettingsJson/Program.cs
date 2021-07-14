using Microsoft.Extensions.Configuration;

using System;
using System.Configuration;

namespace TestAppSettingsJson {
    class Program {
        static void Main(string[] args) {
            var config = new ConfigurationBuilder()
                            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .Build();
            var data = config["files:infile"];

            var path = System.IO.Directory.GetCurrentDirectory();
            var filename = "appsettings.json";
            var fullpath = System.IO.Path.Combine(path, filename);
            Console.WriteLine($"Fullpath is {fullpath}");
        }
    }
}
