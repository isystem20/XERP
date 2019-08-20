using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Core.API.Models;
using XERP.Core.API.Models.HR;
using XERP.DataModel;
using XERP.DataModel.SYSTEM;

namespace XERP.Core.API.Controllers.System
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly AuthenticationContext _context;

        public ClientController(AuthenticationContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("list")]
        public async Task<IActionResult> GetListAsync(TableOptions options)
        {
            var list = await _context.Clients.ToListAsync();
            return Ok(new ObjectResponse { success = true, result = list });
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRecordAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Clients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (record == null)
            {
                return NotFound();
            }

            return Ok( new ObjectResponse { success = false, result = record });
        }

        [HttpPost]
        [Route("add")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(Clients model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid().ToString();
                _context.Add(model);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("edit")]
        public async Task<IActionResult> EditAsync(string id, Clients model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Ok();
            }
            return BadRequest();
        }


        [HttpDelete, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var game = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(game);
            await _context.SaveChangesAsync();
            return Ok();
        }

        private bool RecordExists(string id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}
