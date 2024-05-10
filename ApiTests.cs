using RestSharp;

namespace Tests
{
    public class ApiTests
    {
        [Test]
        public void TestGetUsers()
        {
            // Criar uma instância do cliente RestSharp
            var client = new RestClient("https://reqres.in/api");

            // Criar uma requisição GET para a rota '/users'
            var request = new RestRequest("users", Method.Get);

            // Executar a requisição
            var response = client.Execute(request);

            // Verificar se a resposta foi bem-sucedida
            Assert.That(response.IsSuccessful, Is.True, $"Erro: código de status {response.StatusCode}");

            // Obter o conteúdo da resposta como uma string (JSON)
            var content = response.Content;
            System.Console.WriteLine(content);
        }
    }
}
