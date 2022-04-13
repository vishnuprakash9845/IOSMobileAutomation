using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;

namespace MobAutomation
{
    [TestClass]
    public class AndroidAutomation
    {
        [TestInitialize]
        public void SETUP()
        {

        }

        [TestCleanup]
        public void CLEANUP()
        {





        }


        [TestMethod]
        public void InstallAppTest()
        {
            Console.WriteLine("Testing");

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "mototrola one");//mototrola one
            option.AddAdditionalCapability("app", "/Users/muniswamyv/Downloads/Demo.apk");

            option.AddAdditionalCapability("udid", "emulator-5554");

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), option);
        }

        [TestMethod]
        public void WebAppTest()
        {
            Console.WriteLine("Testing");

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            //option.AddAdditionalCapability("deviceName", "sdk_gphone_x86");//mototrola one
            option.AddAdditionalCapability("browserName", "Chrome");
            option.AddAdditionalCapability("udid", "emulator-5554");
            option.AddAdditionalCapability("chromedriverExecutable", "/Users/muniswamyv/Downloads/chromedriver");

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), option);

            driver.Url = "http://www.google.com";
        }

        [TestMethod]
        public void IOSHealthAppTest()
        {
            Console.WriteLine("IOS Testing");

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "iOS");
            option.AddAdditionalCapability("deviceName", "Vishnu Prakash M");//mototrola one
            option.AddAdditionalCapability("bundleId", "com.apple.Health");
            option.AddAdditionalCapability("udid", "524b89b424c613c5996ac14a6b9b769d05296fe0");
            option.AddAdditionalCapability("automationName", "XCUITest");

            IOSDriver<IWebElement> driver = new IOSDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), option);

            driver.FindElementByXPath("//*[@name='Edit']").Click();

            driver.FindElementByXPath("//*[@name='All']").Click();

            Console.WriteLine(driver.FindElementsByXPath("//*[@name='Selenium']").Count);

            ScrollToElementByPercentageAndClick(driver,"Selenium");

            driver.Quit();
        }

        [TestMethod]
        public void IOSKhanAppTest()
        {
            Console.WriteLine("IOS Testing");

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "iOS");
            option.AddAdditionalCapability("deviceName", "Vishnu Prakash M");//mototrola one
            option.AddAdditionalCapability("bundleId", "org.khanacademy.Khan-Academy");
            option.AddAdditionalCapability("udid", "524b89b424c613c5996ac14a6b9b769d05296fe0");
            option.AddAdditionalCapability("automationName", "XCUITest");

            IOSDriver<IWebElement> driver = new IOSDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), option);

        }

        [TestMethod]
        public void IOSBSAppTest()
        {
            Console.WriteLine("IOS Testing");

            AppiumOptions caps = new AppiumOptions();// Set your BrowserStack access credentials
            caps.AddAdditionalCapability("browserstack.user", "vishnuprakashmun_qbOvJP");
            caps.AddAdditionalCapability("browserstack.key", "PQaiEzmBB6f597myFPU1");// Set URL of the application under test
            caps.AddAdditionalCapability("app", "bs://ec56d2729807154d6e541ea4c966475ed7bcb136");// Specify device and os_version
            caps.AddAdditionalCapability("device", "iPhone 11 Pro");
            caps.AddAdditionalCapability("os_version", "13");// Specify the platformName
            caps.PlatformName = "iOS";// Set other BrowserStack capabilities
            caps.AddAdditionalCapability("project", "First CSharp project");
            caps.AddAdditionalCapability("build", "CSharp iOS");
            caps.AddAdditionalCapability("name", "first_test");// Initialize the remote Webdriver using BrowserStack remote URL// and desired capabilities defined above
            IOSDriver<IOSElement> driver = new IOSDriver<IOSElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

            try
            {
                driver.FindElementByAccessibilityId("test-Username").SendKeys("standard_user");

                driver.FindElementByAccessibilityId("test-Password").SendKeys("secret_sauce");

                driver.FindElementByAccessibilityId("test-LOGIN").Click();
                Thread.Sleep(2000);
                driver.FindElementByXPath("//XCUIElementTypeOther[@name='test-ADD TO CART']").Click();
                Thread.Sleep(1500);
                driver.FindElementByXPath("//XCUIElementTypeOther[@name='test-ADD TO CART']").Click();
                Thread.Sleep(1500);
                driver.FindElementByXPath("//XCUIElementTypeOther[@name='test-ADD TO CART']").Click();
                Thread.Sleep(1500);
                driver.FindElementByXPath("(//XCUIElementTypeOther[@name='3'])[4]").Click();
                Thread.Sleep(1500);
                //ScrollToElementByPercentageAndClick(driver, "test-CHECKOUT");
                ScrollToElementByXCUICommandsAndClick(driver, "test-CHECKOUT");
                Thread.Sleep(1500);

                //Dictionary<string, string> dic = new Dictionary<string, string>();
                //dic.Add("bundleId", "com.apple.Health");
                //dynamic output = driver.ExecuteScript("mobile: launchApp", dic);
                //Thread.Sleep(3000);
                //driver.ExecuteScript("mobile: terminateApp", dic);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(driver.PageSource);

            driver.Quit();

        }

        [TestMethod]
        public void IOSClockAppTest()
        {
            Console.WriteLine("IOS Testing");

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "iOS");
            option.AddAdditionalCapability("deviceName", "Vishnu Prakash M");//mototrola one
            option.AddAdditionalCapability("bundleId", "com.apple.mobiletimer");
            option.AddAdditionalCapability("udid", "524b89b424c613c5996ac14a6b9b769d05296fe0");
            option.AddAdditionalCapability("automationName", "XCUITest");

            IOSDriver<IWebElement> driver = new IOSDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), option);

            IOSElement elements = (IOSElement)driver.FindElementByXPath("//XCUIElementTypePickerWheel");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("elementId", elements.Id);
            dic.Add("order", "next");
            dic.Add("offset", 0.15);

            driver.ExecuteScript("mobile: selectPickerWheelValue", dic);
            driver.ExecuteScript("mobile: selectPickerWheelValue", dic);
            driver.ExecuteScript("mobile: selectPickerWheelValue", dic);

            string vlaueText = elements.GetAttribute("value");
            Console.WriteLine(vlaueText);

            elements = (IOSElement)driver.FindElementByXPath("(//XCUIElementTypePickerWheel)[2]");
            dic.Clear();
            dic.Add("elementId", elements.Id);
            dic.Add("order", "next");
            dic.Add("offset", 0.15);

            driver.ExecuteScript("mobile: selectPickerWheelValue", dic);
            driver.ExecuteScript("mobile: selectPickerWheelValue", dic);
            driver.ExecuteScript("mobile: selectPickerWheelValue", dic);

            elements.SendKeys("9 min");

            elements = (IOSElement)driver.FindElementByXPath("(//XCUIElementTypePickerWheel)[3]");
            elements.SendKeys("5 sec");
            driver.Quit();
        }

        [TestMethod]
        public void StaringAppiumServerTest()
        {
            Environment.SetEnvironmentVariable("ANDROID_HOME", "/Users/muniswamyv/Library/Android/sdk", EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable("ANDROID_HOME", "/Users/muniswamyv/Library/Android/sdk");
            Environment.SetEnvironmentVariable("JAVA_HOME", "/Library/Java/JavaVirtualMachines/jdk-15.0.2.jdk/Contents/Home");

            OptionCollector opt = new OptionCollector()
                .AddArguments(GeneralOptionList.OverrideSession())
                .AddArguments(new KeyValuePair<string, string>("--relaxed-security", string.Empty));
            AppiumServiceBuilder builder = new AppiumServiceBuilder().UsingAnyFreePort().WithArguments(opt);

            AppiumLocalService service = builder.Build(); //uses port - 4723 
            service.Start();

            Console.WriteLine(service.ServiceUrl);
            Console.WriteLine(service.IsRunning);

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "android");
            option.AddAdditionalCapability("deviceName", "motorola one");
            option.AddAdditionalCapability("appActivity", "org.khanacademy.android.ui.library.MainActivity");
            option.AddAdditionalCapability("appPackage", "org.khanacademy.android");
            //option.AddAdditionalCapability("app", @"C:\Components\khan-academy-7-3-2.apk");

            AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(service, option);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            if (driver.FindElementsByXPath("//*[@text='Dismiss']").Count > 0)
            {
                driver.FindElementByXPath("//*[@text='Dismiss']").Click();
            }
            driver.FindElementByXPath("//*[@text='Sign in']").Click();
            driver.FindElementByXPath("//*[@text='Sign in']").Click();
            driver.FindElementByXPath("//*[@content-desc='Enter an e-mail address or username']").SendKeys("test@gmail.com");
            driver.FindElementByXPath("//*[contains(@text,'Pass')]").SendKeys("pass@123");

            if (driver.IsKeyboardShown())
            {
                driver.HideKeyboard();
            }

            //*[@text='Sign in' and @index='0']
            driver.FindElementByXPath("(//*[@text='Sign in'])[2]").Click();

            String actualError = driver.FindElementByXPath("//*[contains(@text,'issue')]").Text;
            Console.WriteLine(actualError);

            // Assert.AreEqual("There is an issue",actualError);

            Thread.Sleep(5000);
            driver.Quit();

            //stop the server
            service.Dispose();
        }

        [TestMethod]
        public void IOSGoogLeMapsTest()
        {
            Console.WriteLine("IOS Testing");

            AppiumOptions option = new AppiumOptions();
            option.AddAdditionalCapability("platformName", "iOS");
            option.AddAdditionalCapability("deviceName", "Vishnu Prakash M");//mototrola one
            option.AddAdditionalCapability("bundleId", "com.google.Maps");
            option.AddAdditionalCapability("udid", "524b89b424c613c5996ac14a6b9b769d05296fe0");
            option.AddAdditionalCapability("automationName", "XCUITest");

            IOSDriver<IWebElement> driver = new IOSDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), option);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Tap - SearchHeaderSearchTxtView
            IOSElement searchHeader = (IOSElement)driver.FindElementByAccessibilityId("SearchHeaderSearchTxtView");
            searchHeader.Click();

            searchHeader = (IOSElement)driver.FindElementByAccessibilityId("SearchHeaderSearchTxtView");
            searchHeader.SendKeys("Mantri");
            Thread.Sleep(2000);

            IOSElement autoSuggestion = (IOSElement)driver.FindElementByXPath("//XCUIElementTypeCell[contains(@name,'Mantri Square')]");
            autoSuggestion.Click();
            Thread.Sleep(2000);

            IOSElement directions = (IOSElement)driver.FindElementByAccessibilityId("Directions");
            directions.Click();
            Thread.Sleep(2000);

            IOSElement youLocation = (IOSElement)driver.FindElementByAccessibilityId("Your location");
            youLocation.Click();
            Thread.Sleep(2000);

            searchHeader = (IOSElement)driver.FindElementByAccessibilityId("SearchHeaderSearchTxtView");
            searchHeader.SendKeys("Mysuru Junction");
            Thread.Sleep(2000);

            autoSuggestion = (IOSElement)driver.FindElementByXPath("//XCUIElementTypeButton[contains(@name,'Mysuru Junction')]");
            autoSuggestion.Click();

            IOSElement swapButton = (IOSElement)driver.FindElementByAccessibilityId("SwapLocationBtn");
            swapButton.Click();

            IOSElement ditanceTimne = (IOSElement)driver.FindElementByXPath("//XCUIElementTypeButton[@name='Preview']/preceding-sibling:: XCUIElementTypeButton");
            //Console.WriteLine(ditanceTimne.Text);

            string[] output = ditanceTimne.Text.Split(',');
            Console.WriteLine("Distance : "+ output[1]);
            Console.WriteLine("Time : " + output[3]);

            Thread.Sleep(3000);
            driver.Quit();
        }

        #region
        public void ScrollToElementByPercentageAndClick(IOSDriver<IWebElement> driver, string fieldName)
        {
            Size size = driver.Manage().Window.Size;
            Console.WriteLine("Width : " + size.Width);
            Console.WriteLine("Height : " + size.Height);

            double startX = size.Width / 2.0;
            double startY = size.Height * 0.80;
            double endX = startX;
            double endY = size.Height * 0.20;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            while (driver.FindElementsByXPath($"//*[@name='{fieldName}']").Count == 0)
            {
                TouchAction action = new TouchAction(driver);
                action.Press(startX, startY).Wait(1000).MoveTo(endX, endY).Release().Perform();
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElementByXPath($"//*[@name='{fieldName}']").Click();
        }
        public void ScrollToElementByPercentageAndClick(IOSDriver<IOSElement> driver, string fieldName)
        {
            Size size = driver.Manage().Window.Size;
            Console.WriteLine("Width : " + size.Width);
            Console.WriteLine("Height : " + size.Height);

            double startX = size.Width / 2.0;
            double startY = size.Height * 0.80;
            double endX = startX;
            double endY = size.Height * 0.20;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            while (!driver.FindElementByXPath($"//*[@name='{fieldName}']").Displayed)
            {
                TouchAction action = new TouchAction(driver);
                action.Press(startX, startY).Wait(1000).MoveTo(endX, endY).Release().Perform();
                Console.WriteLine("Scrolled from logic");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElementByXPath($"//*[@name='{fieldName}']").Click();
        }

        public void ScrollToElementByXCUICommandsAndClick(IOSDriver<IOSElement> driver, string fieldName)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            while (!driver.FindElementByXPath($"//*[@name='{fieldName}']").Displayed)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("direction","down");
                driver.ExecuteScript("mobile: scroll",dic);
                Console.WriteLine("Scrolled from XCUICommands");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElementByXPath($"//*[@name='{fieldName}']").Click();
        }

        #endregion
    }
}
