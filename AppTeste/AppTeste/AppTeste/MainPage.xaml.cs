using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTeste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                CompanyTypePicker.Items.Add(string.Format("Empresa {0}", i));
                FirstActivityTypePicker.Items.Add(string.Format("Atividade {0}", i));
                SecondActivityTypePicker.Items.Add(string.Format("Atividade {0}", i));
            }

            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}
