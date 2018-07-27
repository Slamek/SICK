using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thecrimsbeta
{
    public class Zgradba
    {
        IWebDriver driver;

        public string ime;
        int proizvedeno;
        
        public Zgradba(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<Zgradba> VrniVseZgradbe()
        {
            driver.Url = "https://www.thecrims.com/buildings#/";
            System.Threading.Thread.Sleep(1000);

            int stevec = 1;
            List<Zgradba> zgradbice = new List<Zgradba>();
            IWebElement d = driver.FindElement(By.XPath(" //*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[1]"));

            while (driver.FindElement(By.XPath(" //*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[1]")).Text != " " )
            {
                Zgradba zgdb = new Zgradba(null);
                zgdb.ime = driver.FindElement(By.XPath(" //*[@id='content_middle']/div/div[3]/table[2]/tbody/tr["+stevec+"]/td[1]")).Text;
                zgdb.proizvedeno = int.Parse(driver.FindElement(By.XPath(" //*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[4]")).Text);
                zgradbice.Add(zgdb);

                stevec = stevec +2;
            }

            return zgradbice;
        }

        public void PoberiVsePridelke()
        {
            try
            {
                //*[@id="content_middle"]/div/div[3]/form/table/tbody/tr[2]/td[1]/select
                driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form/table/tbody/tr[2]/td[1]/select/option[1]"));
            }
            catch
            {

            }
        }
    }
}
