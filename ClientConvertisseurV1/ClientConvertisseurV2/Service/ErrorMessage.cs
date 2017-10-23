using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ClientConvertisseurV2.Service
{
    class ErrorMessage
    {
        public async Task sendMessageErrorAsync(String message) {
            var message_erreur = new MessageDialog(message, "Erreur");
            await message_erreur.ShowAsync();
        }
    }
}
