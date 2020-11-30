using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpanderXamarin.ExtendedListView
{
    #region ExtendedListView
    public class ExtendedListView : SfListView
    {
        VisualContainer container;

        public ExtendedListView()
        {
            container = this.GetVisualContainer();
            container.PropertyChanged += Container_PropertyChanged;
        }

        private void Container_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(async() =>
            {
                var extent = (double)container.GetType().GetRuntimeProperties().FirstOrDefault(container => container.Name == "TotalExtent").GetValue(container);
                await Task.Delay(250);

                if (e.PropertyName == "Height")
                    this.HeightRequest = extent;
            });
        }
    }
    #endregion
}
