using Realms;
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
    public partial class NovoFunciPage : ContentPage
    {
        public NovoFunciPage()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var RealmDb = Realm.GetInstance();
            Funcionario ultimoIdFuncionario = RealmDb.All<Funcionario>().OrderBy(x => x.Id).LastOrDefault();
            var newId = ultimoIdFuncionario != null ? ultimoIdFuncionario.Id + 1 : 1;


            var funcionario = new Funcionario()
            {
                Id = newId,
                Nome = txtNome.Text,
                Setor = txtSetor.Text,
                Cargo = txtCargo.Text,
                Qualificacao = txtQualificacao.Text
            };
            RealmDb.Write(() =>
            {
                funcionario = RealmDb.Add(funcionario);
            });
            Navigation.PopAsync();
        }

    }
}