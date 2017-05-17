using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MathGenius
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionThree : ContentPage
    {
        public QuestionThree()
        {
            InitializeComponent();
        }

        private void CheckButtonClicked(object sender, EventArgs e)
        {

        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            MessageLabel.Text = "You are done!";
            MessageLabel.TextColor = Color.Blue;
        }
    }
}
