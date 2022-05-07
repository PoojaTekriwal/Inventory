using InventoryBAL.Service;
using InventoryLib.Interfaces;
using InventoryLib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryDetailsController : ControllerBase
    {
        private readonly InventoryService _inventoryService;

        private readonly Interface<Inventory> _inventory;

        public InventoryDetailsController(Interface<Inventory> inventory, InventoryService inventoryService)
        {
            _inventoryService = inventoryService;
            _inventory = inventory;

        }
        //Add Inventory  
        [HttpPost("AddInventory")]
        public async Task<Object> AddInventory([FromBody] Inventory inventoryDetail)
        {
            try
            {
                await _inventoryService.AddInventory(inventoryDetail);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Inventory  
        [HttpDelete("DeleteInventory")]
        public bool DeleteInventory(Guid unInventoryId)
        {
            try
            {
                _inventoryService.DeleteInventory(unInventoryId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Update Inventory  
        [HttpPut("UpdateInventory")]
        public bool UpdateInventory(Inventory inventoryDetail)
        {
            try
            {
                _inventoryService.UpdateInventory(inventoryDetail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        

        //GET All Inventory  
        [HttpGet("GetAllInventory")]
        public Object GetAllInventory()
        {
            var data = _inventoryService.GetAllInventories();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
    }
}
