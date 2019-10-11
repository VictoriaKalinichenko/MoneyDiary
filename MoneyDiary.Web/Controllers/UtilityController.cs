using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyDiary.BusinessLogic.Interfaces;
using MoneyDiary.ViewModels.Utility;
using System;
using System.Collections.Generic;

namespace MoneyDiary.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UtilityController : ControllerBase
  {
    private readonly IUtilityService _utilityService;

    public UtilityController(IUtilityService utilityService)
    {
      _utilityService = utilityService;
    }

    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<EnumViewItem>> GetAccountTypeList()
    {
      List<EnumViewItem> result = _utilityService.GetAccountTypeList();

      throw new Exception("Test");
    }

    [HttpGet("[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<EnumViewItem>> GetChargeTypeList()
    {
      List<EnumViewItem> result = _utilityService.GetChargeTypeList();
      return Ok(result);
    }
  }
}