using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MathGenius
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new QuestionOne(), this);
            Navigation.PopAsync();
        }
    }
}
