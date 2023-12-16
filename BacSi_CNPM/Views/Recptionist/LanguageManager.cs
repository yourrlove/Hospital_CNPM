using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Views.Recptionist
{
    public static class LanguageManager
    {
        public static CultureInfo CurrentCulture { get; private set; }

        public static void ChangeLanguage(CultureInfo newCulture)
        {
            CurrentCulture = newCulture;
        }
    }
}
