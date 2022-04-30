using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_RealmDB.Model;

namespace XF_RealmDB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExibeFunciPage : ContentPage
    {
        public ExibeFunciPage(Funcionario funcionario)
        {
            InitializeComponent();
        }
    }
}