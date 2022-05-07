using InventoryLib.Interfaces;
using InventoryLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBAL.Service
{
    public class InventoryService
    {
        private readonly Interface<Inventory> _inventory;

        public InventoryService(Interface<Inventory> inventory)
        {
            _inventory = inventory;
        }
        
        //GET All Inventory Details   
        public IEnumerable<Inventory> GetAllInventories()
        {
            try
            {
                return _inventory.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        //Add Inventory
        public async Task<Inventory> AddInventory(Inventory inventoryDetail)
        {
            return await _inventory.Create(inventoryDetail);
        }
        //Delete Inventory   
        public bool DeleteInventory(Guid unInventoryId)
        {

            try
            {
                var DataList = _inventory.GetAll().Where(x => x.unInventoryID == unInventoryId).ToList();
                foreach (var item in DataList)
                {
                    _inventory.Delete(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }
        //Update Inventory Details  
        public bool UpdateInventory(Inventory inventoryDetail)
        {
            try
            {
                var DataList = _inventory.GetAll().Where(x => x.unInventoryID == inventoryDetail.unInventoryID).ToList();
                foreach (var item in DataList)
                {
                    _inventory.Update(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
