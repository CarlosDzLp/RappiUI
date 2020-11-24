using System;
using System.Collections.ObjectModel;
using RappiUI.Models;
using Xamarin.Forms;

namespace RappiUI.ViewModels
{
    public class MasterPageViewModel
    {
        #region Properties
        public ObservableCollection<CategoryModel> ListCategory { get; set; }
        #endregion

        #region Constrcutor
        public MasterPageViewModel()
        {
            LoadCategory();
        }
        #endregion

        #region Methods
        private void LoadCategory()
        {
            try
            {
                ListCategory = new ObservableCollection<CategoryModel>();
                ListCategory.Add(new CategoryModel
                {
                    Id = 0,
                    Name ="Pizzas",
                    Shadow = new Xamarin.Forms.PancakeView.DropShadow() { Color = Color.White,Offset = new Point(0,0)}
                });
                ListCategory.Add(new CategoryModel
                {
                    Id = 1,
                    Name = "Burger",
                    Shadow = new Xamarin.Forms.PancakeView.DropShadow() { Color = Color.White, Offset = new Point(0, 0) }
                });
                ListCategory.Add(new CategoryModel
                {
                    Id = 2,
                    Name = "Sandwich",
                    Shadow = new Xamarin.Forms.PancakeView.DropShadow() { Color = Color.White, Offset = new Point(0, 0) }
                });
                ListCategory.Add(new CategoryModel
                {
                    Id = 3,
                    Name = "Desayuno",
                    Shadow = new Xamarin.Forms.PancakeView.DropShadow() { Color = Color.White, Offset = new Point(0, 0) }
                });
                ListCategory.Add(new CategoryModel
                {
                    Id = 4,
                    Name = "Comidas",
                    Shadow = new Xamarin.Forms.PancakeView.DropShadow() { Color = Color.White, Offset = new Point(0, 0) }
                });
                ListCategory.Add(new CategoryModel
                {
                    Id = 5,
                    Name = "Tacos",
                    Shadow = new Xamarin.Forms.PancakeView.DropShadow() { Color = Color.White, Offset = new Point(0, 0) }
                });
            }
            catch(Exception ex)
            {

            }

            LoadProduct();
        }


        private void LoadProduct()
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }

        public void ResetItemHorizontal(CategoryModel cat)
        {
            foreach(var item in ListCategory)
            {
                if(item.Id == cat.Id)
                {
                    item.Shadow = new Xamarin.Forms.PancakeView.DropShadow()
                    {
                        Color = Color.DimGray,
                        Offset = new Point(0, 2)
                    };
                }
                else
                {
                    item.Shadow = new Xamarin.Forms.PancakeView.DropShadow()
                    {
                        Color = Color.White,
                        Offset = new Point(0, 0)
                    };
                }
            }
        }
        #endregion
    }
}
