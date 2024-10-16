namespace prueba_tecnica_net.Services
{
    public class EsettService
    {
        private readonly HttpClient _httpClient;

        public EsettService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetEsettDataAsync()
        {
            var url = "https://api.opendata.esett.com/";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            throw new Exception("Error al obtener los datos de la API.");
        }
    }
}
