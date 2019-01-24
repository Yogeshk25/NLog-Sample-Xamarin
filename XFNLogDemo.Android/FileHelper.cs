using System;
using Xamarin.Forms;
using XFNLogDemo.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace XFNLogDemo.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetDocumentPath()
        {
            return System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
