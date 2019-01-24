using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Xamarin.Forms;

namespace XFNLogDemo
{
    public partial class MainPage : ContentPage
    {
        Logger logger;

        public MainPage()
        {
            InitializeComponent();

            IFileHelper fileHelper = Xamarin.Forms.DependencyService.Get<IFileHelper>();
            if (fileHelper != null)
            {
                string logFolder = fileHelper.GetDocumentPath();
                Debug.WriteLine($"Log folder : {logFolder}");
            }

            logger = LogManager.GetCurrentClassLogger();
            logger.Info("Logging successful");
        }
    }
}
