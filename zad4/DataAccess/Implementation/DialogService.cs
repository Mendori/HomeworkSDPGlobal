using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad4.DataAccess.Interface;

namespace zad4.DataAccess.Implementation
{
    public class DialogService : IDialogService
    {
        public string OpenFileDialog()
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = ".json",
                Filter = "JSON Files (*.json)|*.json|XML Files (*.xml)|*.xml"
            };
            bool? result = dialog.ShowDialog();
            return result == true ? dialog.FileName : null;
        }



        public string SaveFileDialog()
        {
            var dialog = new SaveFileDialog
            {
                DefaultExt = ".json",
                Filter = "JSON Files (*.json)|*.json|XML Files (*.xml)|*.xml",
                Title = "Save the file", 
            };
            bool? result = dialog.ShowDialog();

            return result == true ? dialog.FileName : null;

        }
    }
}
