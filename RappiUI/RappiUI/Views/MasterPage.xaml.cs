using System;
using System.Collections.Generic;
using System.Linq;
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

                    var itemgroup = vm.ListProductGroup.Where(c => c.IdCat == item.Id).FirstOrDefault();
                    var itemproduct = itemgroup.FirstOrDefault();
                    collectionViewVertical.ScrollTo(itemproduct, position: ScrollToPosition.Start, animate: true);
                }
            }
            catch(Exception ex)
            {

            }
        }

        void collectionViewVertical_ScrollToRequested(System.Object sender, Xamarin.Forms.ScrollToRequestEventArgs e)
        {
            if (e.ScrollToPosition == ScrollToPosition.Center)
            {
                var group = e.Item as ProductModel;
                Console.WriteLine("-------------------------------"+group.Name);
            }
        }

        void collectionViewVertical_Scrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
        {
            var collect = sender as CollectionView;
            if(e.CenterItemIndex == 0)
            {
                Console.WriteLine("-------------ES UN GRUPO------------------" + e.CenterItemIndex);
            }
            
        }
    }
}
