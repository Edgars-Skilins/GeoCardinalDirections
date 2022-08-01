using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace GeoCardinalDirections.Models
{
    public class Cordinate
    {
        private string kods;
        private string tips_CD;
        private string nosaukums;
        private string vkur_CD;
        private string vkur_tips;
        private string std;
        private string koord_X;
        private string koord_Y;
        private string dd_N;
        private string dd_E;

        [Name("#KODS#")]
        public string Kods { get => kods; set => kods = value.Replace("#", ""); }

        [Name("#TIPS_CD#")]
        public string Tips_CD { get => tips_CD; set => tips_CD = value.Replace("#", ""); }

        [Name("#NOSAUKUMS#")]
        public string Nosaukums { get => nosaukums; set => nosaukums = value.Replace("#", ""); }

        [Name("#VKUR_CD#")]
        public string VKUR_CD { get => vkur_CD; set => vkur_CD = value.Replace("#", ""); }

        [Name("#VKUR_TIPS#")]
        public string VKUR_Tips { get => vkur_tips; set => vkur_tips = value.Replace("#", ""); }

        [Name("#STD#")]
        public string STD { get => std; set => std = value.Replace("#", ""); }

        [Name("#KOORD_X#")]
        public string KOORD_X { get => koord_X; set => koord_X = value.Replace("#", ""); }

        [Name("#KOORD_Y#")]
        public string KOORD_Y { get => koord_Y; set => koord_Y = value.Replace("#", ""); }

        [Name("#DD_N#")]
        public string DD_N { get => dd_N; set => dd_N = value.Replace("#", ""); }

        [Name("#DD_E#")]
        public string DD_E { get => dd_E; set => dd_E = value.Replace("#", ""); }
    }
}
