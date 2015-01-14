using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

using Owin.POC;

namespace POS.ProductService
{
    public partial class ProductServiceHost : ServiceBase
    {
        public string baseAddress = "http://localhost:9010/";
        private IDisposable server = null;

        public ProductServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            server = WebApp.Start<Startup>(url: baseAddress);
        }

        protected override void OnStop()
        {
            if (null != server)
            {
                server.Dispose();
            }

            base.OnStop();
        }

    }
}
