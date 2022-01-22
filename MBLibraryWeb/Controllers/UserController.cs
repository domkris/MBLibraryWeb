using MBLibraryWeb.Domain.Entities;
using MBLibraryWeb.Domain.Interfaces;
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

        [HttpGet("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = unitOfWork.Users.GetUserDetails(id);
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
                var itemsUI = unitOfWork.Users.GetAll();
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
                    var item = unitOfWork.Users.GetUserDetails(user.Id);
                    item.FirstName = user.FirstName;
                    item.LastName = user.LastName;
                    item.DateOfBirth = user.DateOfBirth;

                    List<int> addressesToRemoveFromDbIds = item.Addresses.Select(_ => _.Id).Except(user.Addresses.Select(_ => _.Id)).ToList();
                    List<int> phoneNumbersToRemoveFromDbIds = item.PhoneNumbers.Select(_ => _.Id).Except(user.PhoneNumbers.Select(_ => _.Id)).ToList();
                    List<int> emailsToRemoveFromDbIds = item.Emails.Select(_ => _.Id).Except(user.Emails.Select(_ => _.Id)).ToList();

                    var addressesToRemoveFromDb = item.Addresses
                               .Where(address => addressesToRemoveFromDbIds.Contains(address.Id));
                    var phoneNumbersToRemoveFromDb = item.PhoneNumbers
                               .Where(phoneNumber => phoneNumbersToRemoveFromDbIds.Contains(phoneNumber.Id));
                    var emailsToRemoveFromDb = item.Emails
                               .Where(email => emailsToRemoveFromDbIds.Contains(email.Id));

                    item.Addresses = user.Addresses;
                    item.Emails = user.Emails;
                    item.PhoneNumbers = user.PhoneNumbers;

                    if (addressesToRemoveFromDb.Count() > 0)
                        unitOfWork.Addresses.RemoveRange(addressesToRemoveFromDb);

                    if (phoneNumbersToRemoveFromDb.Count() > 0)
                        unitOfWork.PhoneNumbers.RemoveRange(phoneNumbersToRemoveFromDb);

                    if (emailsToRemoveFromDb.Count() > 0)
                        unitOfWork.Emails.RemoveRange(emailsToRemoveFromDb);

                    unitOfWork.Users.Update(item);

                }
                unitOfWork.Save();
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(user.Id, null));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }

        [HttpPost("[action]")]
        public IActionResult BorrowBooks(int id, IEnumerable<Book> entities)
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

        public IActionResult AddToUserRentHistory(IEnumerable<UserBookBorrowHistory> entities)
        {
            try
            {
                unitOfWork.Users.AddToUserRentHistory(entities);
                unitOfWork.Save();
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(entities, null));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult ReturnBook(int id)
        {
            try
            {
                unitOfWork.Users.ReturnBook(id);
                unitOfWork.Save();
                return StatusCode(StatusCodes.Status200OK, ResponseOb.GetSuccess(id, null));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseOb.GetError(ex));
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetUserRentHistory(int id)
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
                    unitOfWork.Users.Remove(user.Id);
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
