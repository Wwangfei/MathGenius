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
    public partial class QuestionOne : ContentPage
    {
        public QuestionOne()
        {
            InitializeComponent();
        }

        private void CheckButtonClicked(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "Please try again!";
            this.MessageLabel.TextColor = Color.Red;
        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new QuestionTwo(), this);
            Navigation.PopAsync();
        }
    }
}
