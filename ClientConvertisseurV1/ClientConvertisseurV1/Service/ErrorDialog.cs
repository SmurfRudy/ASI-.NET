using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ClientConvertisseurV1.Service
{
    class ErrorDialog
    {

        public async Task showErrorAsync(String message)
        {
            var messageDialog = new MessageDialog(message);
            await messageDialog.ShowAsync();
        }
    }
}
