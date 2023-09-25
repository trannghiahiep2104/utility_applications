using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace utility_applications
{
    internal class getPath
    {
        public string Getpath()
        {
            string pathSaved = "";
            string path = "";
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.InitialDirectory = @pathSaved;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                pathSaved = path = dialog.FileName;

            }
            return path;
        }
    }
}
