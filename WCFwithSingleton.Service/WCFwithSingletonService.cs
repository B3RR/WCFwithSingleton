using WCFwithSingleton.Model.Common;
using WCFwithSingleton.WS;
using WCFwithSingleton.WS.WCFHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFwithSingleton.Service
{
    public partial class WCFwithSingletonService : ServiceBase
    {
        private InitSingleton _initService;
        public ServiceHost serviceHost = null;
        public WCFwithSingletonService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
            _initService = new InitSingleton()
            {
                Type = "Windows.Service"
            };
            serviceHost = new ServiceHost(new WCFwithSingletonWS(_initService));
            serviceHost.Open();

        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
