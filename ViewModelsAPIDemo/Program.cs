using System.Net;
using System.Text.Json.Serialization;
using ViewModelsAPIDemo.ViewModels;

namespace ViewModelsAPIDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/{hostname}", (string hostname) =>
            {
                IPHostEntry record = Dns.GetHostByName(hostname);

                DnsEntryViewModel entry = new DnsEntryViewModel()
                {
                    Hostname = record.HostName,
                    IpAddr = record.AddressList.Select(e => e.ToString()).ToArray(),
                };

                return Results.Json(entry);
            });

            app.Run();
        }
    }
}
