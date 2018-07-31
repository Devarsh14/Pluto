using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.IO;
using OpenQA.Selenium.Interactions;


namespace SeleniumTests
{
  public  class Program
    {
        



        static void Main(string[] args)
        {
            StockQarter.QarterResult();

            //webDriver.Navigate().GoToUrl("https://web-dev.oversi.com.au");
            //Thread.Sleep(5000);

            //IWebElement emailInput  = webDriver.FindElement(By.Id("Email"));
            //emailInput.SendKeys("devarsh.shukla@orgcanvas.com.au");

            //IWebElement  pwd = webDriver.FindElement(By.Id("Password"));
            //pwd.SendKeys("aBc123(");
            //Thread.Sleep(5000);
            //IWebElement btnclick= webDriver.FindElement(By.ClassName("btn-raised"));
            //btnclick.Click();

            

            //string url = @"https://web-dev.oversi.com.au/Risks/Register/Details?id=c1ca89d7-c603-4940-9157-f37613042238";
            //webDriver.Navigate().GoToUrl(url);
            //Thread.Sleep(10000);


            //string classnameforSwap = "a.ajaxLinkUpdateSingle.btn.btn-primary.bmd-btn-icon.mdi.mdi-18px.mdi-swap-vertical:nth-child(3)";
            //IWebElement clickswap = webDriver.FindElement(By.CssSelector(classnameforSwap));
            //clickswap.Click();

            //Thread.Sleep(10000);

            //IWebElement dragelemtnOutOfscreen = webDriver.FindElement(By.CssSelector("div.sidebar-l.sidebar-o.side-scroll.header-navbar-fixed div.slimScrollDiv div.content:nth-child(2) div.container-fluid:nth-child(17) div.card:nth-child(10) div.section.collapse.show div.table-responsive table.table.w-100 tbody:nth-child(2) tr.sortable-tr:nth-child(2) td:nth-child(1) div.btn.bmd-btn-icon:nth-child(1) > i.mdi.mdi-reorder-horizontal.bmd-btn-icon.icon-color.dragitem"));
            //IWebElement dropto= webDriver.FindElement(By.CssSelector("div.sidebar-l.sidebar-o.side-scroll.header-navbar-fixed div.slimScrollDiv div.content:nth-child(2) div.container-fluid:nth-child(17) div.card:nth-child(10) div.section.collapse.show div.table-responsive table.table.w-100 tbody:nth-child(2) tr.sortable-tr:nth-child(3) td:nth-child(1) div.btn.bmd-btn-icon:nth-child(1) > i.mdi.mdi-reorder-horizontal.bmd-btn-icon.icon-color.dragitem"));
            //IWebElement dropto2 = webDriver.FindElement(By.CssSelector("div.sidebar-l.sidebar-o.side-scroll.header-navbar-fixed div.slimScrollDiv div.content:nth-child(2) div.container-fluid:nth-child(17) div.card:nth-child(10) div.section.collapse.show div.table-responsive table.table.w-100 tbody:nth-child(2) tr.sortable-tr:nth-child(1) td:nth-child(1) div.btn.bmd-btn-icon:nth-child(1) > i.mdi.mdi-reorder-horizontal.bmd-btn-icon.icon-color.dragitem"));

            ////dragdrop(By.CssSelector("div.sidebar-l.sidebar-o.side-scroll.header-navbar-fixed div.slimScrollDiv div.content:nth-child(2) div.container-fluid:nth-child(17) div.card:nth-child(10) div.section.collapse.show div.table-responsive table.table.w-100 tbody:nth-child(2) tr.sortable-tr:nth-child(1) td:nth-child(1) div.btn.bmd-btn-icon:nth-child(1) > i.mdi.mdi-reorder-horizontal.bmd-btn-icon.icon-color.dragitem")
            ////    , By.CssSelector("div.sidebar-l.sidebar-o.side-scroll.header-navbar-fixed div.slimScrollDiv div.content:nth-child(2) div.container-fluid:nth-child(17) div.card:nth-child(10) div.section.collapse.show div.table-responsive table.table.w-100 tbody:nth-child(2) tr.sortable-tr:nth-child(3) td:nth-child(1) div.btn.bmd-btn-icon:nth-child(1) > i.mdi.mdi-reorder-horizontal.bmd-btn-icon.icon-color.dragitem"));




            //Actions builder = new Actions(webDriver);


            ////builder.dragAndDrop(sourceelement, destelement);



            //webDriver.SwitchTo().ActiveElement();
            //builder.DragAndDrop(dragelemtnOutOfscreen, dropto).SendKeys(Keys.Alt+"F").SendKeys(Keys.Escape).Build().Perform();
            //builder.ContextClick().Build().Perform();
            //builder.SendKeys(Keys.Escape).Build().Perform();
            //builder.SendKeys(Keys.F11).Build().Perform();
            //builder.DragAndDrop(dragelemtnOutOfscreen, dropto2).SendKeys(Keys.Escape).Perform();
            

            // void dragdrop(By ByFrom, By ByTo)
            //{
            //    IWebElement LocatorFrom = webDriver.FindElement(ByFrom);
            //    IWebElement LocatorTo = webDriver.FindElement(ByTo);
            //    string xto = LocatorTo.Location.X.ToString();
            //    string yto = LocatorTo.Location.Y.ToString();
            //    ((IJavaScriptExecutor)webDriver).ExecuteScript("function simulate(f,c,d,e){var b,a=null;for(b in eventMatchers)if(eventMatchers[b].test(c)){a=b;break}if(!a)return!1;document.createEvent?(b=document.createEvent(a),a==\"HTMLEvents\"?b.initEvent(c,!0,!0):b.initMouseEvent(c,!0,!0,document.defaultView,0,d,e,d,e,!1,!1,!1,!1,0,null),f.dispatchEvent(b)):(a=document.createEventObject(),a.detail=0,a.screenX=d,a.screenY=e,a.clientX=d,a.clientY=e,a.ctrlKey=!1,a.altKey=!1,a.shiftKey=!1,a.metaKey=!1,a.button=1,f.fireEvent(\"on\"+c,a));return!0} var eventMatchers={HTMLEvents:/^(?:load|unload|abort|error|select|change|submit|reset|focus|blur|resize|scroll)$/,MouseEvents:/^(?:click|dblclick|mouse(?:down|up|over|move|out))$/}; " +
            //    "simulate(arguments[0],\"mousedown\",0,0); simulate(arguments[0],\"mousemove\",arguments[1],arguments[2]); simulate(arguments[0],\"mouseup\",arguments[1],arguments[2]); ",
            //    LocatorFrom, xto, yto);
            //}



      


        }

    }



    }

    



