using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
	  public partial class MainPage : ContentPage
    {
        #region Constructor
        VisualContainer visualContainer;
        public MainPage()
        {
            InitializeComponent();
            visualContainer = listView.GetVisualContainer();
            visualContainer.PropertyChanged += VisualContainer_PropertyChanged;
        }

        private void VisualContainer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
                if (e.PropertyName == "Height" && this.HeightRequest != visualContainer.Height)
                    listView.HeightRequest = visualContainer.Height;
        }
	
        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random r=new Random();
            var contact = new Contacts();
            contact.ContactName = "Irene";
            contact.ContactNumber = "123-4056";
            contact.ContactImage = ImageSource.FromResource("SfListViewSample.Images.Image" + r.Next(0, 28) + ".png");
            viewModel.contactsinfo.Add(contact);
        }
    }
    
}
