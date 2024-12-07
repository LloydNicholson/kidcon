namespace KidCon.WebApp.Components.Pages;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using ClientApp.Shared.Models;
using KidCon.WebApp.Services;
using Microsoft.AspNetCore.Components;

public partial class Questions : ComponentBase, IDisposable
{
    private readonly Timer timer = new()
    {
        Interval = 600,
    };

    [Inject]
    public IAccountService AccountService { get; set; }

    private List<Account> Accounts { get; set; } = null!;

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
        this.timer.Elapsed += this.TimerOnElapsed;

        await this.GetAccounts();
        this.GetAccount();
    }

    private void TimerOnElapsed(object sender, ElapsedEventArgs e)
    {
        this.Time -= 0.1;
        this.StateHasChanged();
        if (this.Time <= 0)
        {
            this.timer.Stop();
            this.GetAccount();
        }
    }

    protected async Task GetAccounts()
    {
        this.Accounts = await this.AccountService.GetRandomAccounts();
    }

    protected void GetAccount()
    {
        this.Account = this.Accounts[this.QuestionCount];
        this.Answer = null;
        this.DidAnswer = false;
        this.Time = 1.0;
        this.StateHasChanged();
    }

    protected void Answered(string answer)
    {
        this.DidAnswer = true;
        this.Answer = answer;
        this.Correct = this.Answer == this.Account.IncreasingSide;

        if (this.Correct)
        {
            this.Score++;
        }

        this.QuestionCount++;

        this.timer.Start();
    }

    public async Task RestartGame()
    {
        this.Score = 0;
        this.QuestionCount = 0;
        await this.GetAccounts();
        this.GetAccount();
    }

    public void Dispose()
    {
        if (this.timer != null)
        {
            this.timer.Dispose();
        }
    }
}