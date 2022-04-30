using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_RealmDB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditaFunciPage : ContentPage
    {
        public EditaFunciPage(Model.Funcionario funciSelecionado)
        {
            InitializeComponent();
        }
    }
}