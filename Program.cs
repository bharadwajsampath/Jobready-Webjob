using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using RestSharp;
using RestSharp.Authenticators;
using Worker.Services;
using Models.ViewModels;
using Models.Models;
using Worker.Helpers;
using Models;
using MailService.Services;

namespace MailService
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        public static void Main()
        {
            var host = new JobHost();
            Export.ClassList();

        }

        //[NoAutomaticTrigger]
        //public static void RunTask()
        //{

        //}



    }
}
