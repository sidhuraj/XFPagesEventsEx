using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesEventsEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventPages : ContentPage
    {
        public EventPages()
        {
            InitializeComponent();

            etUserName.TextChanged += EtUserName_TextChanged;
            btnSubmit.Clicked += BtnSubmit_Clicked;
            chkHobbies.CheckedChanged += ChkHobbies_CheckedChanged;
            stOnOff.Toggled += StOnOff_Toggled;

            slValue.ValueChanged += SlValue_ValueChanged;

            bindDancesData();


            TapGestureRecognizer objTap = new TapGestureRecognizer();
            objTap.Tapped += ObjTap_Tapped;
            lblUserName.GestureRecognizers.Add(objTap);

            TapGestureRecognizer objImgTap = new TapGestureRecognizer();
            objImgTap.Tapped += ObjImgTap_Tapped;
            imgPhoto.GestureRecognizers.Add(objImgTap);

        }

        private void ObjImgTap_Tapped(object sender, EventArgs e)
        {
          
        }

        private void ObjTap_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WhatsupPage());
        }

        private void bindDancesData()
        {
            List<Dance> objDancers = new List<Dance>();

            objDancers.Add(new Dance { DancersPhoto = "Michael.jpg", Dancerscountry = "USA", Dancersuniverse = "world" });
            objDancers.Add(new Dance { DancersPhoto = "shakria.jpg", Dancerscountry = "spanish", Dancersuniverse = "world" });
            objDancers.Add(new Dance { DancersPhoto = "prabhu.jpg", Dancerscountry = "indian", Dancersuniverse = "world" });
            objDancers.Add(new Dance { DancersPhoto = "hrithik.jpg", Dancerscountry = "indian", Dancersuniverse = "world" });

            lblDanersList.ItemsSource = objDancers;
            lblDanersList.ItemSelected += LblDanersList_ItemSelected;
        }

        private void LblDanersList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Dance;

            Navigation.PushAsync(new DancerDetailsPage(item.Dancerscountry));
          
        }

        private void SlValue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
           

        }

        private void StOnOff_Toggled(object sender, ToggledEventArgs e)
        {
          

        }

        private void ChkHobbies_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
           

        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            
        }

        private void EtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}