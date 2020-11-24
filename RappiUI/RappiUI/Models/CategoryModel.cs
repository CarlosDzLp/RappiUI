using System;
using RappiUI.ViewModels.Base;
using Xamarin.Forms.PancakeView;

namespace RappiUI.Models
{
    public class CategoryModel : BindableBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DropShadow Shadow { get; set; }
    }
}
