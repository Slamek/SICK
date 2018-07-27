using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thecrimsbeta
{
    public class Dejavnost
    {
        IWebDriver driver;

        public string ime;
        public string url;

        public int maxRespect;
        public List<Droga> droge;


        //List<string> imena = new List<string> { "Ana", "Brezno", "Ciganija", "Drava", "Edroge", "Fukarija", "Gnojnica", "Horsland", "IglePoceni", "Jama", "Kurbnhaus" };
        public Dejavnost(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<Dejavnost> VrniVseDejavnosti()
        {
            driver.Url = "https://www.thecrims.com/businesses#/";
            System.Threading.Thread.Sleep(1000);
            //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[1]/td[1]/a
            //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[2]/td[1]/a
            //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[3]/td[1]
            //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[3]/td[1]
            List<Dejavnost> vseDejavnosti = new List<Dejavnost>();

            int stevec = 1;

            while (!driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[1]")).Text.Contains("cost") &
               !driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[1]")).Text.Contains("Max"))
            {
                Dejavnost dv = new Dejavnost(null);
                dv.ime = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[1]/a")).Text;
                //var url = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[1]/td["+stevec+"]/@href"));
                dv.url = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + stevec + "]/td[1]/a")).GetAttribute("href");

                stevec++;
                vseDejavnosti.Add(dv);
            }

            foreach (Dejavnost dv in vseDejavnosti)
            {
                driver.Url = dv.url;
                System.Threading.Thread.Sleep(1000);

                IWebElement temp = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form[1]/table/tbody/tr[4]/td[2]/input"));
                var temp1 = temp.GetAttribute("value");
                dv.maxRespect = int.Parse(temp1);
                //ČE ŠE ČEMA VEJET KERE DROGE SE DILAJO V KLUBI BO to tu
            }


            return vseDejavnosti;

        }

        public void NastaviMaxSpostovanjeKlubu(int spostovanje, string url, IWebDriver driver)
        {

            driver.Url = url;
            this.maxRespect = spostovanje;
            System.Threading.Thread.Sleep(1000);
            //*[@id="content_middle"]/div/div[3]/form[1]/table/tbody/tr[4]/td[2]/input          
            
            driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form[1]/table/tbody/tr[4]/td[2]/input")).Clear();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form[1]/table/tbody/tr[4]/td[2]/input")).SendKeys(spostovanje.ToString());
            System.Threading.Thread.Sleep(1000);

            if (spostovanje != 1)
            {
           
            Random rnd = new Random();
                //*[@id="content_middle"]/div/div[3]/form[1]/table/tbody/tr[1]/td[2]/input
                //*[@id="content_middle"]/div/div[3]/form[1]/table/tbody/tr[1]/td[2]/input
            driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form[1]/table/tbody/tr[1]/td[2]/input")).Clear();
            System.Threading.Thread.Sleep(1000);
            
            driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form[1]/table/tbody/tr[1]/td[2]/input")).SendKeys(CreateRandomName());
            System.Threading.Thread.Sleep(1000);

            }

            //*[@id="content_middle"]/div/div[3]/form[1]/table/tbody/tr[5]/td[2]/input
            driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/form[1]/table/tbody/tr[5]/td[2]/input")).Click();




        }
        
        public string CreateRandomName()
        {
            string name = "";
           char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random rn = new Random();
            for (int i = 0; i < 10; i++)
            {
                name = name + alpha[rn.Next(0, alpha.Length - 1)];

            }

            return name;

        }

    }
}
