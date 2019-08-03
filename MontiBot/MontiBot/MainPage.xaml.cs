using BotsDotNet.Palringo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MontiBot
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var loggedIn = await PalBot.Create().Login(Email.Text, Password.Text,
                    "whats this ??", BotsDotNet.Palringo.Types.AuthStatus.Online, BotsDotNet.Palringo.Types.DeviceType.Android,false);

                if (!loggedIn)
                {
                    Log.Text += "Login failed...\n";
                    return;
                }
                else
                {
                    Log.Text += "Connected...\n";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            Log.Text += $"{text}\n";
            //if (this.textBox3.InvokeRequired)
            //{
            //    SetTextCallback d = new SetTextCallback(SetText);
            //    this.Invoke(d, new object[] { text });
            //}
            //else
            //{
            //    this.Log.AppendText(text);
            //}
        }
    }
}
