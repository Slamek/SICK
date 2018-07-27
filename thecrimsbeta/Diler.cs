using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace thecrimsbeta
{
    class Diler
    {

        IWebDriver driver;
        public Diler(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<Droga> VrniVseDrogeNaLageri()
        {
            driver.Url = "https://www.thecrims.com/newspaper#/drugdealer";
            System.Threading.Thread.Sleep(1000);
            //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[2]/td[1]
            List<Droga> droge = new List<Droga>();
            int i = 1;
            try
            {
                while (true)
                {
                    Droga dr = new Droga();
                    //IME
                    string temp = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + i + "]/td[1]")).Text;

                    //CENA NA ENOTO
                    string temp1 = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + i + "]/td[2]")).Text;

                    //KOLICINA
                    string temp2 = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[" + i + "]/td[3]")).Text;


                    dr.ime = temp;
                    dr.cena = int.Parse(Regex.Match(temp1, @"\d+").ToString());
                    dr.kolicina = float.Parse(temp2);

                    droge.Add(dr);
                    i++;
                }
               

            }
            catch
            {

            }


            return droge;
            
        }

        public List<Droga> VrniVseDrogeNaTrgi()
        {
            //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[1]/td[1]
            //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[2]/td[2]
            driver.Url = "https://www.thecrims.com/newspaper#/drugdealer";
            System.Threading.Thread.Sleep(1000);

            List<Droga> droge = new List<Droga>();
            for (int i = 1; i < 15; i++)
            {
                Droga dr = new Droga();
                //IME
                //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[1]/td[1]
                string temp = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr["+i+"]/td[1]")).Text;

                //CENA NA ENOTO
                //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[1]/td[2]
                string temp1 = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr["+i+"]/td[2]")).Text;

                //KOLICINA
                //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[1]/td[3]
                string temp2 = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr["+i+"]/td[3]")).Text;

                //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[2]/td[1]
                dr.ime = temp;
                dr.cena = int.Parse(Regex.Match(temp1, @"\d+").ToString());
                dr.kolicina = float.Parse(temp2);

                droge.Add(dr);
                
            }

            return droge;
        }

        

        public void ProdajVseDroge()
        {
            System.Threading.Thread.Sleep(1000);
            try
            {
                while (true)
                {
                    //KOLICINA
                    string temp2 = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[1]/td[3]")).Text;

                    
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[1]/td[5]/input")).SendKeys(temp2);
                    System.Threading.Thread.Sleep(500);

                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr[1]/td[5]/button")).Click();
                    System.Threading.Thread.Sleep(1000);

                }


            }
            catch
            {

            }
        }

        public void KupiDrogoPoEnotah(string imeDroge,int stEnot)
        {
            //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[1]/td[5]/button
            //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[2]/td[5]/button
            driver.Url = "https://www.thecrims.com/newspaper#/drugdealer";
            System.Threading.Thread.Sleep(1000);

            int i = 1;
            foreach(Droga dr in VrniVseDrogeNaTrgi())
            {
                if(imeDroge == dr.ime)
                {

                    //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[8]/td[5]/input
                    //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[9]/td[5]/input
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr["+i+"]/td[5]/input")).SendKeys(stEnot.ToString());
                    System.Threading.Thread.Sleep(1000);

                    //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[11]/td[5]/button
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr["+i+"]/td[5]/button")).Click();
                    System.Threading.Thread.Sleep(500);
                    break;
                }
                i++;
            }
        }

        public void ProdajEnoteDroge(string imeDroge, int stEnot)
        {
            driver.Url = "https://www.thecrims.com/newspaper#/drugdealer";
            System.Threading.Thread.Sleep(1000);

            int i = 1;
            foreach (Droga dr in VrniVseDrogeNaLageri())
            {
                if (imeDroge == dr.ime)
                {

                    //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[1]/td[5]/input
                    //*[@id="content_middle"]/div/div[3]/table[2]/tbody/tr[8]/td[5]/input
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr["+i+"]/td[5]/input")).SendKeys(stEnot.ToString());
                    System.Threading.Thread.Sleep(1000);

                    //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[11]/td[5]/button
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[2]/tbody/tr["+i+"]/td[5]/input")).Click();
                    System.Threading.Thread.Sleep(500);
                    break;
                }
                i++;
            }
        }
    }
}
