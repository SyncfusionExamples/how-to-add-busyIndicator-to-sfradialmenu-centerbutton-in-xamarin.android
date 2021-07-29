using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Syncfusion.SfRadialMenu.Android;
using Android.Graphics;
using Com.Syncfusion.Sfbusyindicator;
using System.Threading.Tasks;

namespace Xamarin_Android
{
    [Activity(Label = "Xamarin_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        public MainActivity()
        {
        }
        SfRadialMenu radialMenu;
        SfBusyIndicator busyIndicator;
        Typeface typeface;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            float density;
            //Context con;
            LinearLayout mainLayout;
            //SfRadialMenu radialMenu;

            mainLayout = new LinearLayout(this);
            mainLayout.Orientation = Orientation.Vertical;
            mainLayout.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            busyIndicator = new SfBusyIndicator(this);
            density = this.Resources.DisplayMetrics.Density;
           
            FrameLayout backFrame = new FrameLayout(this);
            backFrame.SetBackgroundColor(Color.Gray);
            mainLayout.AddView(backFrame, new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent));
            FrameLayout frontFrame = new FrameLayout(this);
            frontFrame.SetBackgroundColor(Color.White);
            frontFrame.SetPadding(5, 5, 5, 5);
            typeface = Typeface.CreateFromAsset(this.Assets, "socialicons.ttf");
            radialMenu = new SfRadialMenu(this);
            radialMenu.RimColor = Color.Gray;
            radialMenu.SelectionColor = Color.Transparent;

            FrameLayout facebookLayout = new FrameLayout(this);
            facebookLayout.LayoutParameters = new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent);
            ImageView facebookImage = new ImageView(this);

            facebookImage.LayoutParameters = facebookLayout.LayoutParameters;
            facebookImage.SetImageResource(Resource.Drawable.facebook);
            facebookImage.SetScaleType(ImageView.ScaleType.FitXy);
            TextView facebookText = new TextView(this);
            facebookText.LayoutParameters = facebookLayout.LayoutParameters;
            facebookText.Text = "\uE700";
            facebookText.Typeface = typeface;
            facebookText.TextSize = 20;
            facebookText.TextAlignment = TextAlignment.Center;
            facebookText.Gravity = GravityFlags.Center;
            facebookText.SetTextColor(Color.White);
            facebookLayout.AddView(facebookImage);
            facebookLayout.AddView(facebookText, new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent));
            SfRadialMenuItem facebookItem = new SfRadialMenuItem(this) { View = facebookLayout, ItemWidth = 50, ItemHeight = 50 }; //Image height and Width can be set here
            facebookItem.ItemTapped += FacebookItem_ItemTapped;
            facebookItem.SetBackgroundColor(Color.Transparent);
            radialMenu.Items.Add(facebookItem);

            FrameLayout gplusLayout = new FrameLayout(this);
            gplusLayout.LayoutParameters = new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent);
            ImageView gplusImage = new ImageView(this);
            gplusImage.LayoutParameters = gplusLayout.LayoutParameters;
            gplusImage.SetImageResource(Resource.Drawable.gplus);
            gplusImage.SetScaleType(ImageView.ScaleType.FitXy);
            TextView gplusText = new TextView(this);
            gplusText.LayoutParameters = gplusLayout.LayoutParameters;
            gplusText.Text = "\uE707";
            gplusText.Typeface = typeface;
            gplusText.TextSize = 20;
            gplusText.TextAlignment = TextAlignment.Center;
            gplusText.Gravity = GravityFlags.Center;
            gplusText.SetTextColor(Color.White);
            gplusLayout.AddView(gplusImage);
            gplusLayout.AddView(gplusText, new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent));
            SfRadialMenuItem gplusItem = new SfRadialMenuItem(this) { View = gplusLayout, ItemWidth = 50, ItemHeight = 50 }; //Image height and Width can be set here
            gplusItem.ItemTapped += GplusItem_ItemTapped;
            gplusItem.SetBackgroundColor(Color.Transparent);
            radialMenu.Items.Add(gplusItem);

            FrameLayout twitterLayout = new FrameLayout(this);
            twitterLayout.LayoutParameters = new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent);
            ImageView twitterImage = new ImageView(this);
            twitterImage.LayoutParameters = twitterLayout.LayoutParameters;
            twitterImage.SetImageResource(Resource.Drawable.twitter);
            twitterImage.SetScaleType(ImageView.ScaleType.FitXy);
            TextView twitterText = new TextView(this);
            twitterText.LayoutParameters = twitterLayout.LayoutParameters;
            twitterText.Text = "\uE704";
            twitterText.Typeface = typeface;
            twitterText.TextSize = 20;
            twitterText.TextAlignment = TextAlignment.Center;
            twitterText.Gravity = GravityFlags.Center;
            twitterText.SetTextColor(Color.White);
            twitterLayout.AddView(twitterImage);
            twitterLayout.AddView(twitterText, new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent));
            SfRadialMenuItem twitterItem = new SfRadialMenuItem(this) { View = twitterLayout, ItemWidth = 50, ItemHeight = 50 }; //Image height and Width can be set here
            twitterItem.ItemTapped += TwitterItem_ItemTapped;
            twitterItem.SetBackgroundColor(Color.Transparent);
            radialMenu.Items.Add(twitterItem);

            FrameLayout pinterestLayout = new FrameLayout(this);
            pinterestLayout.LayoutParameters = new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent);
            ImageView pinterestImage = new ImageView(this);
            pinterestImage.LayoutParameters = pinterestLayout.LayoutParameters;
            pinterestImage.SetImageResource(Resource.Drawable.pinterest);
            pinterestImage.SetScaleType(ImageView.ScaleType.FitXy);
            TextView pinterestText = new TextView(this);
            pinterestText.LayoutParameters = pinterestLayout.LayoutParameters;
            pinterestText.Text = "\uE705";
            pinterestText.Typeface = typeface;
            pinterestText.TextSize = 20;
            pinterestText.TextAlignment = TextAlignment.Center;
            pinterestText.Gravity = GravityFlags.Center;
            pinterestText.SetTextColor(Color.White);
            pinterestLayout.AddView(pinterestImage);
            pinterestLayout.AddView(pinterestText, new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent));
            SfRadialMenuItem pinterestItem = new SfRadialMenuItem(this) { View = pinterestLayout, ItemWidth = 50, ItemHeight = 50 }; //Image height and Width can be set here
            pinterestItem.ItemTapped += PinterestItem_ItemTapped;
            pinterestItem.SetBackgroundColor(Color.Transparent);
            radialMenu.Items.Add(pinterestItem);

            FrameLayout linkedInLayout = new FrameLayout(this);
            linkedInLayout.LayoutParameters = new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.FillParent);
            ImageView linkedInImage = new ImageView(this);
            linkedInImage.LayoutParameters = linkedInLayout.LayoutParameters;
            linkedInImage.SetImageResource(Resource.Drawable.linkedin);
            linkedInImage.SetScaleType(ImageView.ScaleType.FitXy);
            TextView linkedInText = new TextView(this);
            linkedInText.LayoutParameters = linkedInLayout.LayoutParameters;
            linkedInText.Text = "\uE706";
            linkedInText.Typeface = typeface;
            linkedInText.TextSize = 20;
            linkedInText.TextAlignment = TextAlignment.Center;
            linkedInText.Gravity = GravityFlags.Center;
            linkedInText.SetTextColor(Color.White);
            linkedInLayout.AddView(linkedInImage);
            linkedInLayout.AddView(linkedInText, new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent));
            SfRadialMenuItem linkedInItem = new SfRadialMenuItem(this) { View = linkedInLayout, ItemWidth = 50, ItemHeight = 50 }; //Image height and Width can be set here
            linkedInItem.ItemTapped += LinkedInItem_ItemTapped;
            linkedInItem.SetBackgroundColor(Color.Transparent);
            radialMenu.Items.Add(linkedInItem);

            FrameLayout instagramLayout = new FrameLayout(this);
            instagramLayout.LayoutParameters = new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent);
            ImageView instagramImage = new ImageView(this);
            instagramImage.LayoutParameters = instagramLayout.LayoutParameters;
            instagramImage.SetImageResource(Resource.Drawable.instagram);
            instagramImage.SetScaleType(ImageView.ScaleType.FitXy);
            TextView instagramText = new TextView(this);
            instagramText.LayoutParameters = instagramLayout.LayoutParameters;
            instagramText.Text = "\uE708";
            instagramText.Typeface = typeface;
            instagramText.TextSize = 20;
            instagramText.TextAlignment = TextAlignment.Center;
            instagramText.Gravity = GravityFlags.Center;
            instagramText.SetTextColor(Color.White);
            instagramLayout.AddView(instagramImage);
            instagramLayout.AddView(instagramText, new ViewGroup.LayoutParams(FrameLayout.LayoutParams.MatchParent, FrameLayout.LayoutParams.MatchParent));
            SfRadialMenuItem instagramItem = new SfRadialMenuItem(this) { View = instagramLayout, ItemWidth = 50, ItemHeight = 50 }; //Image height and Width can be set here
            instagramItem.ItemTapped += InstagramItem_ItemTapped;
            instagramItem.SetBackgroundColor(Color.Transparent);
            radialMenu.Items.Add(instagramItem);

            backFrame.AddView(frontFrame, new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent));
            busyIndicator.LayoutParameters = new FrameLayout.LayoutParams((int)40, (int)40, GravityFlags.Center);
            busyIndicator.AnimationType = Com.Syncfusion.Sfbusyindicator.Enums.AnimationTypes.SingleCircle;
            busyIndicator.SetForegroundGravity(GravityFlags.Center);
            busyIndicator.SetBackgroundColor(Color.Transparent);
            busyIndicator.ViewBoxHeight = 50;
            busyIndicator.ViewBoxWidth = 50;

            radialMenu.Visibility = ViewStates.Visible;
            radialMenu.CenterButtonView = busyIndicator;
            radialMenu.IsDragEnabled = true;
            radialMenu.EnableRotation = true;
            radialMenu.OuterRimColor = Color.Gray;
            radialMenu.CenterButtonBackground = Color.Gray;
            radialMenu.CenterButtonRadius = 25;
            radialMenu.RimRadius = 100; // We can also change the Rim to set the image inside the RadialMenu item.
            frontFrame.AddView(radialMenu);
            RunMethod();
            SetContentView(mainLayout);
        }

        public async void RunMethod()
        {
            busyIndicator.IsBusy = true;
            await Task.Delay(5000);
            busyIndicator.IsBusy = false;
            busyIndicator.Visibility = ViewStates.Invisible;
            radialMenu.CenterButtonText = "\uE703";
            radialMenu.CenterButtonTextSize = 17;
            radialMenu.CenterButtonTypeface = typeface;
            radialMenu.CenterButtonTextColor = Color.White;
        }
      

        void FacebookItem_ItemTapped(object sender, RadialMenuItemTappedEventArgs e)
        {
            radialMenu.Close();
            Toast.MakeText(this, "Shared with Facebook", ToastLength.Short).Show();
        }

        void GplusItem_ItemTapped(object sender, RadialMenuItemTappedEventArgs e)
        {
            radialMenu.Close();
            Toast.MakeText(this, "Shared with G+", ToastLength.Short).Show();
        }

        void PinterestItem_ItemTapped(object sender, RadialMenuItemTappedEventArgs e)
        {
            if(radialMenu != null)
            {
                radialMenu.Close();
                Toast.MakeText(this, "Shared with Pinterest", ToastLength.Short).Show();
            }
        }

        void LinkedInItem_ItemTapped(object sender, RadialMenuItemTappedEventArgs e)
        {
            radialMenu.Close();
            Toast.MakeText(this, "Shared with Linked in", ToastLength.Short).Show();
        }

        void TwitterItem_ItemTapped(object sender, RadialMenuItemTappedEventArgs e)
        {
            radialMenu.Close();
            Toast.MakeText(this, "Shared with Twitter", ToastLength.Short).Show();
        }

        void InstagramItem_ItemTapped(object sender, RadialMenuItemTappedEventArgs e)
        {
            radialMenu.Close();
            Toast.MakeText(this, "Shared with Instagram", ToastLength.Short).Show();
        }
    } 
}

