namespace KidCon.WebApp.Components.Pages;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using KidCon.Database.Entities;
using KidCon.WebApp.Services;
using Microsoft.AspNetCore.Components;

public partial class Questions : ComponentBase, IDisposable
{
    private readonly Timer timer = new()
    {
        Interval = 600,
    };

    [Inject]
    public AccountService AccountService { get; set; } = null!;

    private List<Account> Accounts { get; set; } = null!;

    public Account Account { get; set; } = null!;

    public bool Correct { get; set; } = false;

    private string Answer { get; set; } = null!;

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

    private void TimerOnElapsed(object? sender, ElapsedEventArgs e)
    {
        this.Time -= 0.1;
        this.StateHasChanged();
        if (this.Time <= 0)
        {
            this.timer.Stop();
            this.GetAccount();
        }
    }

    private async Task GetAccounts()
    {
        this.Accounts = await this.AccountService.GetRandomAccounts();
    }

    private void GetAccount()
    {
        this.Account = this.Accounts[this.QuestionCount];
        this.Answer = string.Empty;
        this.DidAnswer = false;
        this.Time = 1.0;
        this.StateHasChanged();
    }

    private void Answered(string answer)
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
        this.timer.Dispose();
    }
}