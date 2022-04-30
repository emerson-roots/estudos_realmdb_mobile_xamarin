using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF_RealmDB.Model;
using XF_RealmDB.Views;

namespace XF_RealmDB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var RealmDb = Realm.GetInstance();
            var listaFuncionarios = RealmDb.All<Funcionario>();
            lvFuncionarios.ItemsSource = listaFuncionarios;
        }
        private void lvFuncrionarios_OnSelecao(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                //O ItemSelected é chamado quando um item é deselecionado
                //e isso torna o SelectedItem null  
                return;
            }
            var funciSelecionado = (Funcionario)e.SelectedItem;
            Navigation.PushAsync(new ExibeFunciPage(funciSelecionado));
        }
        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoFunciPage());
        }
    }
}
