using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Domain.Models;
using MBLibraryWeb.UI.Models;
using MBLibraryWeb.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MBLibraryWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("[action]")]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = unitOfWork.Users.GetById(id);
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

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            try
            {
                var itemsUI = unitOfWork.Users.GetSimpleList();
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

        [HttpPost("[action]")]
        public IActionResult Post(User user)
        {
            try
            {
                if (user.Id < 1)
                {
                    unitOfWork.Users.Add(user);
                  
                }
                else 
                {
                    unitOfWork.Users.Update(user);

                }
                unitOfWork.Save();
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(user, null));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }

        [HttpPost("[action]")]
        public IActionResult BorrowBooks(int id, IEnumerable<BookUI> entities)
        {
            try
            {
                unitOfWork.Users.BorrowBooks(id, entities);
                unitOfWork.Save();
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(id, null));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }

        [HttpPost("[action]")]
        public IActionResult ReturnBooks(int id, IEnumerable<BookUI> entities)
        {
            try
            {
                unitOfWork.Users.ReturnBooks(id, entities);
                unitOfWork.Save();
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(id, null));

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
                var itemsUI = unitOfWork.Users.GetUserRentHistory(id);
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
        public IActionResult GetTopUsersByOverDueTime(int numberOfUsers)
        {
            try
            {
                var itemsUI = unitOfWork.Users.GetTopUsersByOverDueTime(numberOfUsers);
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

        [HttpDelete("[action]")]
        public IActionResult Delete(int id)
        {
            try
            {
                var user = unitOfWork.Users.GetById(id);
                if (user == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, ResponseOb.GetCustomError(ErrorResponseMessage.NoDataInDatabaseWithId));
                }
                else 
                {
                    unitOfWork.Users.Remove(user);
                    unitOfWork.Save();
                }
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(id, null));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }
    }
}
