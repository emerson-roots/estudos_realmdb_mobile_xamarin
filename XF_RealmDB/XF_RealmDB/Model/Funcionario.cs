using Realms;

namespace XF_RealmDB.Model
{
    public class Funcionario : RealmObject
    {
        [PrimaryKey]// annotation do namespace Realms
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Qualificacao { get; set; }

    }
}
