using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RestSharp;
using RestSharp.Authenticators;
using Models.Models;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using Microsoft.Win32;

namespace MailService.Services
{
    class EmailService
    {

        public static IRestResponse SendMail(Email email)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                    new HttpBasicAuthenticator("api","key-7a73be74445bddaf7eaedafa0d8aea95");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                 "provyus.com.au", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "BCA Web Application <info@provyus.com.au>");
            request.AddParameter("bcc", email.BCC);
            request.AddParameter("to", email.To);
            request.AddParameter("subject", email.Subject);
            request.AddParameter("text", email.Text);
            var attachment = CreateFile(email.FileName, email.Attachment);
            request.AddFile("attachment", attachment);
            request.Method = Method.POST;
            return client.Execute(request);
        }

        public static string CreateFile(string filename, string content)
        {
            var path =  Path.Combine(AppDomain.CurrentDomain.BaseDirectory,filename+".xls");

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(content);
                }
            }

           return  path;
        }


        //public static string Excel(string xmlFileName,string filename)
        //{
        //    Excel.Application excel2; // Create Excel app
        //    Excel.Workbook DataSource; // Create Workbook
        //    Excel.Worksheet DataSheet; // Create Worksheet
        //    excel2 = new Excel.Application(); // Start an Excel app
        //    DataSource = (Excel.Workbook)excel2.Workbooks.Add(1); // Add a Workbook inside
        //    string tempFolder = System.IO.Path.GetTempPath(); // Get folder
        //    string FileName = xmlFileName;
        //    // Open that xml file with excel
        //    DataSource = excel2.Workbooks.OpenXML(xmlFileName, Missing.Value, Missing.Value);
        //    // Get items from xml file
        //    DataSheet = DataSource.Worksheets.get_Item(1);
        //    // Create another Excel app as object
        //    Object xl_app;
        //    xl_app = new Excel.Application();
        //    // Set previous Excel app (Xml) as ReportPage
        //    Excel.Application ReportPage = (Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
        //    // Copy items from ReportPage(Xml) to current Excel object
        //    Excel.Workbook Copy_To_Excel = ReportPage.ActiveWorkbook;
        //    Copy_To_Excel.SaveAs(filename+".xlsx");
        //    return filename+".xlsx";
        //}
    }
}
