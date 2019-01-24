using System;
using Xamarin.Forms;
using XFNLogDemo.iOS;

[assembly: Dependency(typeof(FileHelper))]
namespace XFNLogDemo.iOS
{
    public class FileHelper : IFileHelper
    {
        public string GetDocumentPath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
