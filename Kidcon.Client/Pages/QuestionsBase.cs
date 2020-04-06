using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Kidcon.Client.Services;
using Kidcon.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Kidcon.Client.Pages
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
        public int Time { get; set; } = 3;
        public int Score { get; set; }
        public int QuestionCount { get; set; }

        public bool DialogIsOpen { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            await GetNewAccount();
        }

        protected async Task GetNewAccount()
        {
            Account = await AccountService.GetRandomAccount();
            Answer = null;
            DidAnswer = false;
            Time = 3;
            StateHasChanged();
        }

        protected void Answered(string answer)
        {
            DidAnswer = true;
            Answer = answer;
            Correct = Answer == Account.IncreasingSide;

            if (Correct)
            {
                Score++;
            }
            QuestionCount++;

            StartTimerAsync();
        }

        public async void StartTimerAsync()
        {
            while (Time > 0)
            {
                Time--;
                StateHasChanged();
                await Task.Delay(1000);
            }
            await GetNewAccount();
        }
    }
}
