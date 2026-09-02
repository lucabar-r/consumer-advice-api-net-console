using System.Text.Json;
using ConsumerAdviceApi.Models;
using static System.Console;

var url = "https://api.adviceslip.com/advice";

WriteLine("Iniciando requisição para obter dados de um conselho:");
WriteLine(url);

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();

    string responseString = await response.Content.ReadAsStringAsync();

    AdviceResponse? resultado = JsonSerializer.Deserialize<AdviceResponse>(responseString);

    WriteLine("\nConselho de Hoje:");
    WriteLine(resultado?.Slip?.Advice);
}
catch (Exception e)
{
    WriteLine("Aconteceu um erro ao consultar a api: " + e.Message);
}