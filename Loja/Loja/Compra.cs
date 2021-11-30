// Projeto em Console app recriado em .NET 6.0 LTS e Entity Framework 6 + SQL Express para o curso Entity Framework Core:
// Banco de dados de forma eficiente.
// O curso tem por objetivo apresentar o Framework Entity como uma alternativa para criação e manipulação de Banco de Dados
// em aplicações C#.
// O principal objetivo foi apresentar as funcionalidades do Framework e mostrar um exemplo prático de como o mesmo facilita
// a manipulação de Banco de Dados.

public class Compra
{
    public int Id { get; set; }
    public int Quantidade { get; internal set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; internal set; }
    public double Preco { get; internal set; }

    public override string ToString()
    {
        return $"Compra de {this.Quantidade} {this.Produto.Unidade} do produto {this.Produto.Nome} a R$ {this.Preco}";
    }
}
