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

namespace SeleniumTests
{
    class StockQarter
    {
        public static void QarterResult()
        {
            IWebDriver webDriver = new ChromeDriver();


            string connectionString = "Data Source=Shivangini;Initial Catalog=Dev_Market;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection is open ");

            //SqlCommand sqlCommand = new SqlCommand("Select [Security Code] ,[Security Name] from MarketWatch_22_00_2018", connection);
            //SqlDataReader dataReader = sqlCommand.ExecuteReader();


            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "http://www.bseindia.com";

            waitSeconds(5);
            void waitSeconds(int seconds)
            {
                System.Threading.Thread.Sleep(seconds * 1000);

            }
            List<string> companiesID = new List<string>();
            List<string> companiesName = new List<string>();



            using (SqlCommand sqlCommandScript = new SqlCommand("select * from [dbo].[MarketWatch_22_00_2018] where [Security Group]='B'", connection))
            {
                SqlDataReader dataReader2 = sqlCommandScript.ExecuteReader();
                while (dataReader2.Read())
                {
                    companiesID.Add(dataReader2[0].ToString());
                    companiesName.Add(dataReader2[1].ToString());
                }
                connection.Close();
                connection.Dispose();
            }



            List<string> companiesIDavailable = new List<string>();
            int n = 0;


            while (n < companiesID.Count)
            {


                SqlConnection connectionCompniesAvailbleId = new SqlConnection(connectionString);
                connectionCompniesAvailbleId.Open();

                using (SqlCommand sqlcompaniesPresent = new SqlCommand("select DISTINCT [security_Number] from [dbo].[QuarterlyResultBrief]", connectionCompniesAvailbleId))
                {
                    SqlDataReader dataReader3 = sqlcompaniesPresent.ExecuteReader();
                    while (dataReader3.Read())
                    {
                        companiesIDavailable.Add(dataReader3[0].ToString());
                    }

                    connectionCompniesAvailbleId.Close();
                    connectionCompniesAvailbleId.Dispose();
                }



                Random random = new Random();
                n = random.Next(0, companiesID.Count - 2);
                string securityNo = companiesID[n];
                string securityName = companiesName[n];


                if (companiesIDavailable.Contains(companiesID[n]) == false)
                {
                    waitSeconds(5);
                    IWebElement webElement = webDriver.FindElement(By.Id("suggestBoxEQ"));


                    webElement.SendKeys(securityNo);
                    waitSeconds(2);
                    webElement.SendKeys(Keys.Enter);

                    waitSeconds(5);
                    string prices = string.Empty;

                    WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));





                    Console.WriteLine(securityNo + " " + securityName + " " + prices);
                    var prices2 = prices.Split(' ');

                    //foreach (var item in prices2)
                    //{
                    //    if (item != string.Empty && item != null)
                    //    {
                    //        //Console.WriteLine(item.Trim());
                    //    }

                    //}
                    waitSeconds(10);

                    WebDriverWait wait22 = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                    IWebElement result = wait.Until<IWebElement>(d => d.FindElement(By.Id("aFin")));
                    result.Click();


                    waitSeconds(10);
                    WebDriverWait quartresultDiv = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                    IWebElement resultQarter = wait.Until<IWebElement>(d => d.FindElement(By.Id("ctl00_ContentPlaceHolder1_quatre")));

                    string t = resultQarter.Text;

                    List<string> s = t.Split(' ').ToList();
                    if (s.Count < 20)
                    {
                        continue;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(s[2 + i]);
                        Console.WriteLine(s[10 + i]);
                        Console.WriteLine(s[17 + i]);
                        Console.WriteLine(s[24 + i]);
                        Console.WriteLine(s[30 + i]);
                        Console.WriteLine(s[36 + i]);
                        Console.WriteLine(s[42 + i]);
                        Console.WriteLine(s[48 + i]);
                        Console.WriteLine(s[54 + i]);
                        Console.WriteLine(s[60 + i]);
                        Console.WriteLine(s[67 + i]);
                        Console.WriteLine(s[73 + i]);
                        Console.WriteLine(s[79 + i]);
                        Console.WriteLine(s[85 + i]);
                        Console.WriteLine(s[92 + i]);
                        Console.WriteLine(s[99 + i]);

                        string query = @" INSERT INTO[dbo].[QuarterlyResultBrief]
        ([security_Name]
          ,[security_Number]
          ,[Quarter]
          ,[Revenue]
          ,[Other_Income]
          ,[Total_Income]
          ,[Expenditure]
          ,[interest]
          ,[PBDT]
          ,[depereciation]
          ,[pbt]
          ,[tax]
          ,[net_Profit]
          ,[equity]
          ,[eps]
          ,[ceps]
          ,[opm]
          ,[npm])
    VALUES
          (" + "'" + securityName + "','" + securityNo + "','" + s[2 + i] + "','" + s[10 + i] + "','" + s[17 + i] + "','" + s[24 + i] + "','" + s[30 + i] + "','" + s[36 + i] + "','" + s[42 + i] + "','" + s[48 + i] + "','" + s[54 + i] + "','" + s[60 + i] + "','" + s[67 + i] + "','" + s[73 + i] + "','" + s[79 + i] + "','" + s[85 + i] + "','" + s[92 + i] + "','" + s[99 + i] + "')";


                        SqlCommand sqlQarterQuery = new SqlCommand(query, con2);
                        sqlQarterQuery.ExecuteNonQuery();

                    }




                }

                n++;
            }



        }




    }
}
