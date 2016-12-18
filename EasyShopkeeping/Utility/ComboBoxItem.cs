using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Utility
{
    public class ComboBoxItem
{
   string displayVal;
   string hiddenVal;

   //Constructor
   public ComboBoxItem (string displayValue, string hiddenValue)
   {
       displayVal = displayValue;
       hiddenVal = hiddenValue;
   }

   //Accessor
   public string HiddenValue
   {
        get
        {
            return hiddenVal;
        }
   }

   //Override ToString method
   public override string ToString()
   {
       return displayVal;
   }
}
}
