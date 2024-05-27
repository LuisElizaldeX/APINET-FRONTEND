using frontendnet.Models;

namespace frontendnet.Services;

public class CategoriasClientService(HttpClient client)
{
    public async Task<List<Categoria>?> GetAsync()
    {
        return await client.GetFromJsonAsync<List<Categoria>>("api/categoria");
    }
    public async Task<Categoria?> GetAsync(int id)
    {
        return await client.GetFromJsonAsync<Categoria>($"api/categoria/{id}");
    }
    public async Task<bool> PostAsync(Categoria categoria)
    {
        var response = await client.PostAsJsonAsync($"api/categoria", categoria);
        return response.IsSuccessStatusCode;
    }
    public async Task<bool> PutAsync(Categoria categoria)
    {
        var response = await client.PutAsJsonAsync($"api/categoria/{categoria.CategoriaId}", categoria);
        return response.IsSuccessStatusCode;
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var response = await client.DeleteAsync($"api/categoria/{id}");
        return response.IsSuccessStatusCode;
    }
}