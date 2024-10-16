using Microsoft.AspNetCore.Mvc;
using prueba_tecnica_net.Models;
using prueba_tecnica_net.Services;

namespace prueba_tecnica_net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EsettController : ControllerBase
    {
        private readonly EsettService _esettService;
        private readonly AppDbContext _context;

        public EsettController(EsettService esettService, AppDbContext context)
        {
            _esettService = esettService;
            _context = context;
        }

        // Sincronizar datos desde la API de Esett y almacenarlos en la base de datos
        [HttpGet("sync-data")]
        public async Task<IActionResult> SyncEsettData()
        {
            try
            {
                var data = await _esettService.GetEsettDataAsync();

                var esettData = new EsettData
                {
                    Data = data
                };

                _context.EsettDatas.Add(esettData);
                await _context.SaveChangesAsync();

                return Ok(esettData); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDataById(int id)
        {
            var data = await _context.EsettDatas.FindAsync(id);

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }
    }
}
