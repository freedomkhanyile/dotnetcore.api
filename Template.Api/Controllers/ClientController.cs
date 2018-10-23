using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.Contracts;
using Template.Contracts.ILoggerManager;
using Template.Entities.Extensions;
using Template.Entities.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Template.Api.Controllers
{
    [Route("api/client")]
    public class ClientController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public ClientController(ILoggerManager logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repository = repositoryWrapper;
        }

        [HttpGet]
        public IActionResult GetAllClients()
        {
            try
            {
                var clients = _repository.Client.GetAllClients();
                _logger.LogInfo($"Returned all owneres from database at: {DateTime.Now}");
                return Ok(clients);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllClients error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name ="ClientById")]
        public IActionResult GetClientById(Guid id)
        {
            try
            {
                var client = _repository.Client.GetClientById(id);

                if(client.IsEmptyObject())
                {
                    _logger.LogError($"Client with id: {id}, has'nt been found in our records");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned owner with id: {id}");
                    return Ok(client);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetClientById error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}/account")]
        public IActionResult GetClientWIthAccountDetails(Guid id)
        {
            try
            {
                var client = _repository.Client.GetClientWithAccountDetails(id);
                if (client.IsEmptyObject())
                {
                    _logger.LogError($"Client with id: {id}, has'nt been found in our records");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned owner with account details for id: {id}");
                    return Ok(client);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetClientWIthAccountDetails error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateClient([FromBody]User client)
        {
            try
            {
                if(client.IsObjectNull())
                {
                    _logger.LogError("Client object sent from client is null.");
                    return BadRequest("Client object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Client object from the client.");
                    return BadRequest("Invalid model object");
                }

                _repository.Client.CreateClient(client);

                return CreatedAtRoute("ClientById", new { id = client.Id }, client);

            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateClient error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateClient(Guid id, [FromBody]User client)
        {
            try
            {
                if (client.IsObjectNull())
                {
                    _logger.LogError("Client object sent from client is null.");
                    return BadRequest("Client object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid Client object from the client.");
                    return BadRequest("Invalid model object");
                }

                var dbClient = _repository.Client.GetClientById(id);

                if (dbClient.IsEmptyObject())
                {
                    _logger.LogError($"Client with id: {id}, has not been found in our records");
                    return NotFound();
                }

                _repository.Client.UpdateClient(dbClient, client);

                //uncomment to see the updated valies from api for test purposes only.
                //return CreatedAtRoute("ClientById", new { id = dbClient.Id }, dbClient);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateClient error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
         
    }
}
