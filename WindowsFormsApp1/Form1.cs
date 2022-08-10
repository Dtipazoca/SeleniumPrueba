using System;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        IWebDriver driver;
        ChromeOptions opt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirChrome_Click(object sender, EventArgs e)
        {
            opt = new ChromeOptions();
            opt.AddArguments("--disable-gpu");
            opt.AddArgument("--no-sandbox");
            driver = new ChromeDriver(opt);
        }

        private void btnNavegar_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl(new Uri("https://demoqa.com/login"));
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newUser")).Click();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            driver.FindElement(By.Id("firstname")).SendKeys(txtNombre.Text);
            Thread.Sleep(200);
            driver.FindElement(By.Id("lastname")).SendKeys(txtApellido.Text);
            Thread.Sleep(200);
            driver.FindElement(By.Id("userName")).SendKeys(txtUsuario.Text);
            Thread.Sleep(200);
            driver.FindElement(By.Id("password")).SendKeys(txtcontrasena.Text);
            Thread.Sleep(500);
            driver.FindElement(By.Id("register")).Click();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //driver.Navigate().GoToUrl(new Uri("https://demoqa.com/text-box"));
            try
            {
                driver.FindElements(By.ClassName("pr-1"))[0].Click();
                Thread.Sleep(500);
                driver.FindElements(By.TagName("li"))[0].Click();
                Thread.Sleep(500);
                driver.FindElement(By.Id("userName")).SendKeys(txtName.Text);
                Thread.Sleep(500);
                driver.FindElement(By.Id("userEmail")).SendKeys(txtEmail.Text);
                Thread.Sleep(500);
                driver.FindElement(By.Id("currentAddress")).SendKeys(txtDireccion1.Text);
                Thread.Sleep(500);
                driver.FindElement(By.Id("permanentAddress")).SendKeys(txtDireccion2.Text);
                Thread.Sleep(500);
                driver.FindElement(By.Id("submit")).Click();
            }
            catch (Exception ex)
            {
                string x = ex.Message;
                return;
            }
            
        }
    }
}
