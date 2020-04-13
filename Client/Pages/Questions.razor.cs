using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using ClientApp.Client.Services;
using ClientApp.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace ClientApp.Client.Pages
{
    public partial class Questions : ComponentBase, IDisposable
    {
        Timer timer = new Timer()
        {
            Interval = 600
        };

        [Inject]
        public IAccountService AccountService { get; set; }

        public List<Account> Accounts { get; set; }
        public Account Account { get; set; }

        public bool Correct { get; set; } = false;
        public string Answer { get; set; }
        public bool DidAnswer { get; set; }
        public double Time { get; set; } = 1.0;
        public int Score { get; set; }
        public int QuestionCount { get; set; } = 0;

        public bool DialogIsOpen { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            timer.Elapsed += TimerOnElapsed;

            await GetAccounts();
            GetAccount();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            Time -= 0.1;
            StateHasChanged();
            if (Time <= 0)
            {
                timer.Stop();
                GetAccount();
            }
        }

        protected async Task GetAccounts()
        {
            Accounts = await AccountService.GetRandomAccounts();
        }

        protected void GetAccount()
        {
            Account = Accounts[QuestionCount];
            Answer = null;
            DidAnswer = false;
            Time = 1.0;
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

            timer.Start();
        }

        public async Task RestartGame()
        {
            Score = 0;
            QuestionCount = 0;
            await GetAccounts();
        }

        public void Dispose()
        {
            if (timer != null)
            {
                timer.Dispose();
            }
        }
    }
}
