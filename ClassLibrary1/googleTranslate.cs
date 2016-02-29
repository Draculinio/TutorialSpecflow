using ClassLibrary1.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    class googleTranslate
    {
        private IWebDriver driver;
        [Given(@"I enter to google translator site")]
        public void GivenIEnterToGoogleTranslatorSite()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.translate.google.com");
        }

        [Given(@"I enter '(.*)' in the translator textbox")]
        public void GivenIEnterInTheTranslatorTextbox(string p0)
        {
            TranslatorPage tp = new TranslatorPage(driver);
            tp.enterText(p0);
        }

        [When(@"I press the translate button")]
        public void WhenIPressTheTranslateButton()
        {
            TranslatorPage tp = new TranslatorPage(driver);
            tp.pressSubmitButton();
        }

        [Then(@"the answer should be '(.*)'")]
        public void ThenTheAnswerShouldBe(string p0)
        {
            TranslatorPage tp = new TranslatorPage(driver);
            tp.correctTranslation(p0).Should().BeTrue();
        }

        [Given(@"I change language to '(.*)'")]
        public void GivenIChangeLanguageTo(string p0)
        {
            TranslatorPage tp = new TranslatorPage(driver);
        }


    }
}
