namespace Interfaces18.Classes
{
    public interface ICarrinho
    {

        //No sistema de interfaces nãos se decreta uma classe completa como: public string...

         //CRUD
         //CREATE
            void Cadastrar(Produto produto);

         //READ
            void Listar();

         //UPDATE
            void Alterar(int cod, Produto novoProduto);

         //DELETE
         void Deletar(int cod);
    }
}