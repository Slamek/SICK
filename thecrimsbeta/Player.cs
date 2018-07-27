using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace thecrimsbeta
{
    public class Player
    {
        IWebDriver driver;
        int browser; //0 chrome 1 firefox

        public Player(IWebDriver driver,int brwsr)
        {
            this.driver = driver;
            browser = brwsr;

        }
        //*[@id="user-profile-level"]/a[1]
        public string poklic;

        //*[@id="user-profile-info"]/div[4]/span
        public int spostovanje;

        //*[@id="user-profile-info"]/div[3]/span
        string duh;

        //*[@id="user-profile-info"]/div[5]/span
        int vstopnice;

        //*[@id="content_right"]/div/div[6]/div[1]/span[1]
        //*[@id="content_right"]/div/div[6]/div[2]/span[1]
        //*[@id="content_right"]/div/div[6]/div[1]/span[2]
        //*[@id="content_right"]/div/div[6]/div[2]/span[2]
        int inteligenca, moc, karizma, toleranca;

        public int ticket;

        public int energija, zasvojenost;

        public List<Dejavnost> dejavnosti;

        public List<Zgradba> zgradbe;

        public void RefreshStats(int tudiZgradbeInDejavnosti) // 1-da 0-ne
        {
            
            string temp = driver.FindElement(By.XPath("//*[@id='user-profile-stamina']")).Text;           
            energija = int.Parse(Regex.Match(temp, @"\d+").ToString());

            temp = driver.FindElement(By.XPath("//*[@id='user-profile-addiction']")).Text;
            zasvojenost = int.Parse(Regex.Match(temp, @"\d+").ToString());
            //*[@id="user-profile-info"]/div[4]/span
            temp = driver.FindElement(By.XPath("//*[@id='user-profile-info']/div[4]/span")).Text;
            spostovanje = int.Parse(Regex.Match(temp, @"\d+").ToString());

            if(tudiZgradbeInDejavnosti == 1)
            {
                Dejavnost dv = new Dejavnost(driver);
                dejavnosti = dv.VrniVseDejavnosti();
                
                //Zgradba zg = new Zgradba(driver);
                //zgradbe = zg.VrniVseZgradbe();
            }




        }

        public int GetElvlP()
        {
                string temp = driver.FindElement(By.XPath("//*[@id='user-profile-stamina']")).Text;
                return int.Parse(Regex.Match(temp, @"\d+").ToString());
        }

        public int GetTickets()
        {
           return int.Parse(Regex.Match(driver.FindElement(By.XPath("//*[@id='user-profile-info']/div[5]/span")).Text, @"\d+").ToString());
        }

        public void SetElvlP()
        {
            this.energija = GetElvlP();
        }
        public void SetTicket()
        {
            this.ticket = GetTicket();
        }
        public void SetDejavnosti()
        {
            Dejavnost dejavnost = new Dejavnost(driver);
            this.dejavnosti = dejavnost.VrniVseDejavnosti();
        }
        public void SetZasvojenost()
        {
            zasvojenost = int.Parse(Regex.Match(driver.FindElement(By.XPath("//*[@id='user-profile-addiction']")).Text, @"\d+").ToString());
        }
        public void SetSpostovanje()
        {          
            spostovanje = int.Parse(Regex.Match(driver.FindElement(By.XPath("//*[@id='user-profile-info']/div[4]/span")).Text, @"\d+").ToString());
        }
        public int GetTicket()
        {
            string temp = driver.FindElement(By.XPath("//*[@id='user-profile-info']/div[5]/span")).Text;
            return int.Parse(Regex.Match(temp, @"\d+").ToString());
        }

        

        public void FillEnergy(int tipKluba) //0 je tvoj klub,1 je prvi random
        {
            try
            {
                driver.Url = " https://www.thecrims.com/newspaper#/nightlife";
                System.Threading.Thread.Sleep(1500);
                //*[@id="content_middle"]/div/div[3]/div/div[2]/table/tbody/tr/td[5]/div/button
                //*[@id="content_middle"]/div/div[3]/div/div[2]/table/tbody/tr/td[5]/div/button

                if(tipKluba == 0)
                {
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div/div[2]/table/tbody/tr/td[5]/div/button")).Click();
                }
                else
                {
                    switch (browser)
                    {
                        case 0:
                            driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div/div[3]/ul/li[1]/table/tbody/tr[3]/td[2]/div/button")).Click();
                            break;
                        case 1:
                            driver.FindElement(By.XPath("/html/body/div[2]/div/table/tbody/tr/td[1]/div[2]/table/tbody/tr/td/div[2]/div/div[3]/div/div[2]/table/tbody/tr/td[5]/div/button")).Click();                            
                            break;
                    }
                    
                }
                          
                System.Threading.Thread.Sleep(1500);


                string temp = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div/table[2]/tbody/tr/td[2]")).Text;
                string temp1 = temp.Substring(0, temp.Length - 1).Replace('.', ',');
                System.Threading.Thread.Sleep(800);
                float elvld = float.Parse(temp1);
                int y = 0;
                while ((y * elvld) + energija <= 97)
                {
                    y++;
                }
                if (y != 0)
                {

                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div/table[2]/tbody/tr/td[4]/input")).SendKeys(y.ToString());
                    System.Threading.Thread.Sleep(500);

                    if (GetElvlP() < 30)
                    {
                        driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div/table[2]/tbody/tr/td[4]/button")).Click();
                        System.Threading.Thread.Sleep(500);
                    }

                }

                energija = GetElvlP();
            }
            catch
            {
                //Page load se ni bil
            }

            Detox();
        }

        public void Detox()
        {
            SetZasvojenost();
            if (zasvojenost > 5)
            {
                driver.Url = " https://www.thecrims.com/newspaper#/hospital";
                while(zasvojenost > 5)
                {
                    System.Threading.Thread.Sleep(1000);
                    ////*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[5]/td[4]/input
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr[5]/td[4]/input")).SendKeys(zasvojenost+"");
                    System.Threading.Thread.Sleep(1000);
                    //*[@id="content_middle"]/div/div[3]/table[1]/tbody/tr[5]/td[4]/button
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/table[1]/tbody/tr[5]/td[4]/button")).Click();
                    System.Threading.Thread.Sleep(1000);
                    RefreshStats(0);
                }
            }
        }
    }


}
