using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WebAPI_FITPRO.Models;

namespace WebAPI_FITPRO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FptController : ControllerBase
    {
        #region Connection
        private string connectionString;
        public FptController()
        {
            connectionString = @"Persist Security Info=False;User ID=sa;password=alberto1597;Initial Catalog=FPTBD; Data Source=DESKTOP-RLSPPB2\SQLEXPRESS;Connection Timeout=100000";
        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<IEnumerable<Fpt>> GetAll()
        {
            const string sQuery = @"SELECT * FROM Customer";

            using (var dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                var customer = await dbConnection.QueryAsync<Fpt>(sQuery);

                return customer.AsList();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Fpt fpt)
        {
            using (var dbConnection = new SqlConnection(connectionString))
            {
                string sQuery = @"INSERT INTO Customer (Name, Phone, Email, Notes) VALUES(@Name, @Phone, @Email, @Notes)";
                dbConnection.Open();
                await dbConnection.ExecuteAsync(sQuery, fpt);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            using (var dbConnection = new SqlConnection(connectionString))
            {
                string sQuery = @"DELETE FROM Customer WHERE Id =@Id";
                dbConnection.Open();
                await dbConnection.ExecuteAsync(sQuery, new { Id = id });
            }
            return Ok();
        } 
        #endregion
    }
}
