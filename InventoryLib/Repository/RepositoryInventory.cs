using InventoryLib.Data;
using InventoryLib.Interfaces;
using InventoryLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Repository
{
    public class RepositoryInventory: Interface<Inventory>
    {
        InventoryDBContext _dbContext;
        public RepositoryInventory(InventoryDBContext inventoryDBContext)
        {
            _dbContext = inventoryDBContext;
        }
        public async Task<Inventory> Create(Inventory _object)
        {
            var obj = await _dbContext.GetInventoryResult.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public void Delete(Inventory _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Inventory> GetAll()
        {
            try
            {
                return _dbContext.GetInventoryResult.ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public Inventory GetById(Guid Id)
        {
            return _dbContext.GetInventoryResult.Where(x => x.unInventoryID == Id).FirstOrDefault();
        }

        public void Update(Inventory _object)
        {
            _dbContext.GetInventoryResult.Update(_object);
            _dbContext.SaveChanges();
        }
    }
}
