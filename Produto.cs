namespace MetodosConstrutores
{
    public class Produto
    {
        //Atributos
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Descricao{get; set;}
        public int Estoque{get; set;}

        //Metodo construtor
        public Produto(){

        }

        public Produto(int valor){
            Codigo = valor;
        }

        public Produto(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }


    }
}