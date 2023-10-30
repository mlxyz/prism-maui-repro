using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp.ViewModels
{
    internal class CustomControlViewModel
    {
        public CustomControlViewModel()
        {
            Console.WriteLine("CustomControlViewModel constructor");
        }
        public string CustomText => "This is a custom control";
    }
}
