using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyDiary.BusinessLogic.Interfaces;
using MoneyDiary.ViewModels.Account;

namespace MoneyDiary.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountController : Controller
  {
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
      _accountService = accountService;
    }

    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<GetAllAccountViewModel> GetAll()
    {
      GetAllAccountViewModel result = _accountService.GetAll();
      return Ok(result);
    }

    [HttpPost("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<GetAllAccountViewModel> Insert(InsertAccountViewModel request)
    {
      _accountService.Insert(request);
      return Ok();
    }
  }
}