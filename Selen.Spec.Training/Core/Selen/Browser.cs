﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace Core.Selen
{
    public class Browser
    {
        private static string pvName = "Chrome";
        private static string driversPath;

        public static string Name
        {
            get { return pvName; }
            set { pvName = value; }
        }

        public static string DriversPath
        {
            get { return driversPath; }
            set { driversPath = value; }
        }

        public static WebDriverWait Wait(int seconds)
        {
            WebDriverWait wait = new WebDriverWait(currentDriver, TimeSpan.FromSeconds(seconds));
            wait.Timeout = TimeSpan.FromSeconds(seconds);
            wait.PollingInterval = TimeSpan.FromSeconds(seconds / 5);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

            return wait;
        }

        private static IWebDriver currentDriver;
        public static IWebDriver Current
        {
            get
            {
                if (currentDriver == null)
                {
                    switch (pvName)
                    {
                        case "IE":
                            currentDriver = new InternetExplorerDriver(driversPath);
                            break;
                        case "Chrome":
                            currentDriver = new ChromeDriver(driversPath);
                            break;
                        case "Firefox":
                            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", driversPath);
                            //Skip crash dialog
                            System.Environment.SetEnvironmentVariable("XRE_NO_WINDOWS_CRASH_DIALOG", "1");
                            currentDriver = new FirefoxDriver();
                            break;
                        default: break;
                    }
                    currentDriver.Manage().Window.Maximize();
                }
                return currentDriver;
            }
            set { currentDriver = value; }
        }

        public string CurrentWindowHandle
        {
            get { throw new NotImplementedException(); }
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new NotImplementedException();
        }

        public string PageSource
        {
            get { throw new NotImplementedException(); }
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }

        public string Title
        {
            get { throw new NotImplementedException(); }
        }

        public string Url
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<string> WindowHandles
        {
            get { throw new NotImplementedException(); }
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
