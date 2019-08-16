using AutoMapper;
using MoneyDiary.BusinessLogic.Interfaces;
using MoneyDiary.DataAccess.Interfaces;
using MoneyDiary.Entities;
using MoneyDiary.ViewModels.Account;
using System.Collections.Generic;
using System.Linq;

namespace MoneyDiary.BusinessLogic.Services
{
  public class AccountService : IAccountService
  {
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public AccountService(IAccountRepository accountRepository, IMapper mapper)
    {
      _accountRepository = accountRepository;
      _mapper = mapper;
    }

    public GetAllAccountViewModel GetAll()
    {
      GetAllAccountViewModel viewModel = new GetAllAccountViewModel();

      List<Account> accounts = _accountRepository.GetAll();
      viewModel.Accounts = _mapper.Map<List<AccountViewItem>>(accounts);
      viewModel.TotalBalance = accounts.Sum(x => x.Balance);

      return viewModel;
    }

    public void Insert(InsertAccountViewModel insertedAccount)
    {
      Account account = _mapper.Map<Account>(insertedAccount);
      _accountRepository.Insert(account);
    }
  }
}
