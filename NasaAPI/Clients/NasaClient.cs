using System.Net.Http.Json;
using NasaAPI.Models;

namespace NasaAPI.Clients;
public class NasaClient {
    private readonly HttpClient _client;

    public NasaClient(HttpClient client) {
        _client = client;
    }

    public async Task<NasaResponse> GetNasa() {
        return await _client.GetFromJsonAsync<NasaResponse>("https://api.nasa.gov/planetary/apod?api_key=QJCYU3kBLB3hKa6nP0C7sfPRCnPnVDPCZz96PTZH");
    }

}