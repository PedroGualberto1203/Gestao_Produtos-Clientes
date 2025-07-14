using Dapper.Contrib.Extensions;

namespace PraticarAcessoDados.Repository
{
    public class Repository<T> where T : class
    {
        public IEnumerable<T> Get()
            => Database.Connection.GetAll<T>();

        public T Get(int id) //Esse nao tem void pois ele RETORNA valor, diferente dos outros
            => Database.Connection.Get<T>(id);

        public void Create(T model) //Recebe um model do tipo T, ou seja, como sera substituido, poderá ser ser por exemplo um objeto user(model) do tipo User(T)
            => Database.Connection.Insert<T>(model); //Exemplo: Vai inserir um model(um objeto user criado por exemplo) do tipo User

        public void Update(T model) 
            => Database.Connection.Update<T>(model);

        public void Delete(T model) //Dois metodos de delete, um recebe/deleta pelo o User e no outro o Id
            =>  Database.Connection.Delete<T>(model);

        public void Delete(int id) //Dois metodos de delete, um recebe/deleta pelo o User e no outro o Id
        {
            var model = Database.Connection.Get<T>(id); //Guardou qual é de acordo com o ID(exemplo: guarda qual user é pelo Id)
            Database.Connection.Delete<T>(model);
        }
    }
}