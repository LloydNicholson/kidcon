using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Kidcon.Server.Services;
using Kidcon.Shared;
using Kidcon.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Kidcon.Server.Pages
{
    public class QuestionsBase : ComponentBase
    {
        [Inject]
        public IEquationService EquationService { get; set; }

        [Inject]
        public IAccountService AccountService { get; set; }

        public Account Account { get; set; }

        public bool Correct { get; set; } = false;

        public string Answer { get; set; }

        public bool DidAnswer { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetNewAccount();
        }

        protected async Task GetNewAccount()
        {
            Account = await AccountService.GetRandomAccount();
            Answer = null;
            DidAnswer = false;
            StateHasChanged();
        }

        protected void Answered(string answer)
        {
            DidAnswer = true;
            Answer = answer;
            Correct = Answer == Account.IncreasingSide;
            StateHasChanged();
            Task.Delay(3000).ContinueWith(async t =>
            {
                await GetNewAccount();
            });
        }
    }
}
