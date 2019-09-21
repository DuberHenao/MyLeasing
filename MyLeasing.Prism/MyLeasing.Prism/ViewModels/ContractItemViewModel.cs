using System;
using MyLeasing.Common.Models;
using Prism.Commands;
using Prism.Navigation;

namespace MyLeasing.Prism.ViewModels
{
    public class ContractItemViewModel : ContractResponse
    {
        private DelegateCommand _selectContractCommand;
        private readonly INavigationService _navigationService;

        public ContractItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public DelegateCommand SelectContractCommand => _selectContractCommand ?? (_selectContractCommand = new DelegateCommand(SelectContract));

        private async void SelectContract()
        {
            var parameters = new NavigationParameters
            {
                { "Contract", this }
            };

            await _navigationService.NavigateAsync("ContractPage", parameters);
        }
    }
}
