using System;
using System.Collections.Generic;
using RappiUI.Models;
using RappiUI.ViewModels;
using Xamarin.Forms;

namespace RappiUI.Views
{
    public partial class MasterPage : ContentPage
    {
        MasterPageViewModel vm;
        public MasterPage()
        {
            InitializeComponent();
            this.BindingContext = vm = new MasterPageViewModel();
        }

        void collectionViewHorizontal_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            try
            {
                if(e.CurrentSelection.Count > 0)
                {
                    var item = e.CurrentSelection[0] as CategoryModel;                    
                    vm.ResetItemHorizontal(item);
                    collectionViewHorizontal.ScrollTo(item, position: ScrollToPosition.Center, animate: true);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
