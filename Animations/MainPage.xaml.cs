using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Animations
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnTranslate_Clicked(object sender, System.EventArgs e)
        {
            await Frame.TranslateTo(100, 0, 1000); //Translation to the right
            await Frame.TranslateTo(100, -100, 1000); //Translation to the top
            await Frame.TranslateTo(0, 0, 1000); //Translation to the original position
        }

        private async void BtnScale_Clicked(object sender, System.EventArgs e)
        {
            await Frame.ScaleTo(2, 1000); //Scale to double its size
            await Frame.ScaleTo(0.5, 1000); //Scale to half its size
            await Frame.ScaleTo(1, 1000); //Scale to original size
        }

        private async void BtnFade_Clicked(object sender, System.EventArgs e)
        {
            await Frame.FadeTo(0, 1000); //Make it transparent
            await Frame.FadeTo(1, 1000); //Make it opaque
        }

        private async void BtnRotate_Clicked(object sender, System.EventArgs e)
        {
            await Frame.RotateTo(90, 1000); //Rotate it 90 degrees
            await Frame.RotateTo(0, 1000); //Rotate it back to the initial position
        }

        private async void BtnRotateX_Clicked(object sender, System.EventArgs e)
        {
            await Frame.RotateXTo(180, 1000); //Rotate it 180 degrees in the X axis
            await Frame.RotateXTo(0, 1000); //Rotate the X axis back to the initial position
        }

        private async void BtnRotateY_Clicked(object sender, System.EventArgs e)
        {
            await Frame.RotateYTo(180, 1000); //Rotate it 180 degrees in the Y axis
            await Frame.RotateYTo(0, 1000); //Rotate the Y axis back to the inital position
        }
    }
}
