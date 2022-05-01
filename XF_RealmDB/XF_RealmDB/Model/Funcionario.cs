using MongoDB.Bson;
using Realms;

namespace XF_RealmDB.Model
{
    public class Funcionario : RealmObject
    {
        [PrimaryKey]// annotation do namespace Realms
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string Qualificacao { get; set; }

    }
}
