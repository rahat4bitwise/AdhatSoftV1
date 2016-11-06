using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.FormData.FormInterface
{
    interface FormDataHandler
    {
         void saveFormData(Form form);
         void validateFormData(Form form);
    }
}
