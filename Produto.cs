using (HttpClient client = new HttpClient())
{

    string resposta = await client.GetStringAsync(/ "https://fakestoreapi.com/products.json"));
    Console.WriteLine(resposta);



}







//public class Produto
{

    //public string nomeDoProduto;
    //public string descricaoDoproduto;
    //public int valorProduto;
    // public int quantidadeProduto;

}
