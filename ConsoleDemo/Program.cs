using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Dropbox.Api;
using Dropbox.Api.Files;
using Microsoft.Graph.CallRecords;
using Minio;
using Minio.DataModel;
using Minio.Exceptions;

namespace ConsoleDemo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var task = Task.Run((Func<Task>)Program.Run);
            task.Wait();

            Console.ReadKey();
        }
       
        static async Task Run()
        {
            var dbx = new DropboxClient("6OkAn0qCwuAAAAAAAAAAAeQfO93E3V9FD5omG57oKQId-yyxQ_lOM2R3byLGAz-Y");

            var remoteFilePath = "/GameportCloud/arena-of-valor.png";

            var link = await dbx.Sharing.ListSharedLinksAsync(remoteFilePath);
            if (link.Links.Count == 0)
            {
                var result = await dbx.Sharing.CreateSharedLinkWithSettingsAsync(remoteFilePath);
                string url = result.Url;
                Console.WriteLine("The url for sharing " + remoteFilePath + " is: " + url);
            }
            else
            {
                string url = link.Links[0].Url;
                Console.WriteLine("(ALREADY GENERATED) The url for sharing " + remoteFilePath + " is: " + url);
            }

        }

    }
}
