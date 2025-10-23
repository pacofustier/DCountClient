using DCountClientMvc.Models;

namespace DCountClientMvc.Services;

public class WorkerApiService
{
    private readonly HttpClient _httpClient;
    public WorkerApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:5555/");
    }

    public async Task<List<Worker>> GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<Worker>>("worker") ?? [];
    }

    public async Task<Worker?> GetById(int id)
    {
        return await _httpClient.GetFromJsonAsync<Worker>($"worker/{id}");
    }

}
