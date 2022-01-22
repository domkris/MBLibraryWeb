using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBLibraryWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public BookController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            try
            {
                var itemsUI = unitOfWork.Books.GetAll();
                if (itemsUI.Any())
                {
                    return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(itemsUI, null));
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(itemsUI, ErrorResponseMessage.NoDataInDatabase));
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = unitOfWork.Books.GetById(id);
                if (user == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, ResponseOb.GetCustomError(ErrorResponseMessage.NoDataInDatabaseWithId));
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(user, null));
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetBookRentHistory(int id)
        {
            try
            {
                var items = unitOfWork.Books.GetBookRentHistory(id);
                if (items.Any())
                {
                    return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(items, null));
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(items, ErrorResponseMessage.NoDataInDatabase));
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }
    }
}
