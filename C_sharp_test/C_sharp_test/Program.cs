using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C_sharp_test
{
    public class Program
    {
        public struct FullAddress
        {
            public readonly string Street;
            public readonly int Number;
            public readonly string PostCode;
            public string PhoneNumber;

            public FullAddress(string street, int number, string postCode, string phoneNumber = "")
            {
                Street = street;
                Number = number;
                PostCode = postCode;
                PhoneNumber = phoneNumber;
            }
        }
        public readonly static void Main(string[] args)
        {
            // Will Throw An Error if attempting to change.
            var address = new FullAddress("1031", 42, "1234");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
