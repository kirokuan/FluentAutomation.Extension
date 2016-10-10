using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAutomation.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace FluentAutomation.Extension
{
    public static class Extension
    {
        public static void Quit(this IActionSyntaxProvider I)
        {
            var browser = FluentTest.ProviderInstance as IWebDriver;
            browser.Quit();
        }
        public static void OpenNewWindow(this IActionSyntaxProvider I)
        {
            var browser = FluentTest.ProviderInstance as IWebDriver;
            browser.ExecuteJavaScript<object>("window.open();");
        }
    }
}
