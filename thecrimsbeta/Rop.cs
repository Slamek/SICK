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
   public class Rop
    {
        IWebDriver driver;
        string ime;
        int elvl;
        int sp;
        int energija;


        public Rop(IWebDriver driver)
        {
            this.driver = driver;
            if(driver != null)
            {
                this.driver.Url = "https://www.thecrims.com/newspaper#/robberies";
                System.Threading.Thread.Sleep(1000);
            }
            
            
        }

        public void RopajGang()
        {
            try
            {
                //Če mama na voljo da izberema novi gang rop -> izberema trenutno 3 ker rabi samo 2 lopova)
                if (driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[4]/table/tr/td[1]/select/option[3]")).Displayed == true)
                {
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[4]/table/tr/td[1]/select/option[3]")).Click();
                    System.Threading.Thread.Sleep(1000);
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[4]/table/tr/td[1]/button")).Click();
                    System.Threading.Thread.Sleep(1000);
                    return;

                }
            }
            catch
            {

            }

            try
            {
                //Če vijima da je rop naret in mama join button na voljo -> kliknema join
                if (driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[5]/div/div[4]/button[1]")).Displayed == true)
                {
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[5]/div/div[4]/button[1]")).Click();
                    System.Threading.Thread.Sleep(1000);
                }

            }
            catch
            {

            }
            //*[@id="content_middle"]/div/div[3]/div[5]/div/div[4]/button[2]
            //Poglejama ce se nama je pojavo Izvedi rop -> ga kliknema
            try
            {
                if (driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[5]/div/div[4]/button[2]")).Displayed == true)
                {
                    System.Threading.Thread.Sleep(1000);
                    driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[5]/div/div[4]/button[2]")).Click();
                    System.Threading.Thread.Sleep(1000);
                }

            }

            catch
            {

            }





        }
        //Če ga ni, poglejamo če obstaja accept Button, če ja ga kliknemo
        //Če ga kliknemo in se pojavo do the score ga kliknemo

    

        public void Ropaj()
        {


          
            System.Threading.Thread.Sleep(500);
            List<Rop> ropi = VrniRopeNaVoljo();

            if(ropi.Count == 0)
            {
                return; //sfukalo je neke ker neki ropi morjo vedno bit -> verjetno page load
            }

            int i = 0;
           

            while (ropi[i].sp == 100 && ropi[i].elvl <= ropi[i].energija)
            {
                i++;
                if(i == ropi.Count)
                {
                    break;
                }
            }

            try
            {


                driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[3]/div/table/tr/td[1]/select/option[" + (i + 1) + "]")).Click();

                System.Threading.Thread.Sleep(200);

                driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[3]/div/table/tr/td[1]/button")).Click();

                System.Threading.Thread.Sleep(800);

            }
            catch
            {
                //Ker se page ni naložo pa dejansko ropov ni na voljo -> Zaraji tega ker so te cuznli pa si jih faso
            }
         

       }

        public List<Rop> VrniRopeNaVoljo()
        {
            //*[@id="content_middle"]/div/div[3]/div[3]/div/table/tr/td[1]/select/option[2]
            //*[@id="content_middle"]/div/div[3]/div[3]/div/table/tr/td[1]/select/option[2]


            IWebElement d;
            int stevec = 2;
            Player player = new Player(driver,-1);
           
            List<Rop> vsiropi = new List<Rop>();
            try
            {
                while ((d = driver.FindElement(By.XPath("//*[@id='content_middle']/div/div[3]/div[3]/div/table/tr/td[1]/select/option[" + stevec + "]"))) != null)
                {
                    Rop rop = new Rop(null);
                    string abc = d.Text;
                    rop.ime = abc.Split('-')[0].Trim();
                    rop.elvl = int.Parse(Regex.Match(abc.Split(':')[0], @"\d+").ToString());
                    rop.sp = int.Parse(Regex.Match(abc.Split(':')[1], @"\d+").ToString());
                   rop.energija=player.GetElvlP();
                    vsiropi.Add(rop);
                    stevec++;
                }
            }
            catch(NoSuchElementException eee)
            {
                //Ni se se page nalozo
            }
            


                
            return vsiropi;
        }
    }
}
