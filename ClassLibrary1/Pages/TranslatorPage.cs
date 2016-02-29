using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.Pages
{
    class TranslatorPage
    {
        private string translateTextBoxId = "source";
        private string translateButtonId = "gt-submit";
        //private string resultBoxId = "result-box";
        private string resultBoxCSS = "span[class='hps']";
        private string languageDropdownId = "gt-sl-gms";
        private string languageSelectorId = "lj";
        private IWebDriver webDriver;
        public TranslatorPage(IWebDriver driver) {
            webDriver = driver;
        } 

        public void enterText(string text)
        {
            webDriver.FindElement(By.Id(translateTextBoxId)).SendKeys(text);
        }

        public void pressSubmitButton()
        {
            webDriver.FindElement(By.Id(translateButtonId)).Click();
        }

        public bool correctTranslation(string translation)
        {
            Thread.Sleep(8000);
            return webDriver.FindElement(By.CssSelector(resultBoxCSS)).Text.Contains(translation);
       }

        public void changeLanguage(string language)
        {
            webDriver.FindElement(By.XPath(".//*[contains(text(),'"+language+"')]")).Click();
        }

       


    }
}
