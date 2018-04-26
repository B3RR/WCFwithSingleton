using WCFwithSingleton.WS;
using WCFwithSingleton.WS.WCFHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace WCFwithSingleton.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var ServicesToRun = new ServiceBase[]
            {
                new WCFwithSingletonService()
            };
            ServiceBase.Run(ServicesToRun);
        }

    }

    /// <summary>
    /// Установшик через девелоперскую консоль (installUtil WCFwithSingleton.Service.exe)
    /// </summary>
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public ProjectInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            service = new ServiceInstaller();
            service.ServiceName = "WCFwithSingletonService";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
