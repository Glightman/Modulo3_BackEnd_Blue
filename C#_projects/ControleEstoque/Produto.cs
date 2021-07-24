namespace ControleEstoque
{
    public class Produto
    {
        public Produto()
        {
            Nome = "Monitor";
            Preco = 1000;
        }
        private double _preco;
        public string Nome { get; set; }
        public double Preco { 
            get => _preco; 
            set => _preco = value > 0? value : 0; 
        }
        public string Descricao { get => $"Nome: {Nome} - Preço: {Preco:0.00}";}
        // public string nome;
        // public double preco;
    }
}
