using Realms;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_RealmDB.Model;

namespace XF_RealmDB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditaFunciPage : ContentPage
    {
        private Funcionario funciSelecionado;

        public EditaFunciPage(Funcionario _funcionario)
        {
            InitializeComponent();
            this.funciSelecionado = _funcionario;
            BindingContext = funciSelecionado;
        }

        private void btnOnSalvarClicked(object sender, EventArgs e)
        {
            var RealmDb = Realm.GetInstance();
            using (var trans = RealmDb.BeginWrite())
            {
                funciSelecionado.Nome = txtNome.Text;
                funciSelecionado.Setor = txtSetor.Text;
                funciSelecionado.Cargo = txtCargo.Text;
                funciSelecionado.Qualificacao = txtQualificacao.Text;
                trans.Commit();
            }
            Navigation.PopToRootAsync();
        }
    }
}