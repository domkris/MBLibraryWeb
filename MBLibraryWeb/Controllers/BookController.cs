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

        [HttpGet("[action]")]
        public IActionResult GetBookRentHistory(int id)
        {
            try
            {
                var itemsUI = unitOfWork.Books.GetBookRentHistory(id);
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
    }
}
