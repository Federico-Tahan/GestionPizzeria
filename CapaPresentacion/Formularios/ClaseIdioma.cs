using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPresentacion.Properties;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{

    public static class MessageHelper
    {
        public static void ShowMessage(string messageKey)
        {
            var cultureInfo = Thread.CurrentThread.CurrentUICulture;
            var resourceManager = new System.Resources.ResourceManager(typeof(Resources));
            var message = resourceManager.GetString(messageKey, cultureInfo);
            MessageBox.Show(message);
        }

        public static void ChangeLanguage(string languageCode)
        {
            var cultureInfo = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
