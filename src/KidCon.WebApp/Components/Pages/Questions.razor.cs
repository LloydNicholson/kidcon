namespace KidCon.WebApp.Components.Pages;

using System.Collections.Generic;
using System.Threading.Tasks;
using KidCon.Database.Entities;
using KidCon.WebApp.Services;
using Microsoft.AspNetCore.Components;

public partial class Questions : ComponentBase
{
    [Inject]
    public AccountService AccountService { get; set; } = null!;

    private List<Account> Accounts { get; set; } = null!;

    public Account Account { get; set; } = null!;

    public bool Correct { get; set; }

    private string Answer { get; set; } = null!;

    public bool DidAnswer => !string.IsNullOrWhiteSpace(this.Answer);

    public double TimeRemaining { get; set; } = 4;

    public int Score { get; set; }

    public int QuestionCount { get; set; }

    public bool DialogIsOpen { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await this.GetAccounts();
        this.GetAccount();
    }

    private async Task GetAccounts()
    {
        this.Accounts = await this.AccountService.GetRandomAccounts();
    }

    private void GetAccount()
    {
        this.Account = this.Accounts[this.QuestionCount];
        this.Answer = string.Empty;
        this.TimeRemaining = 4;
        this.StateHasChanged();
    }

    private void Answered(string answer)
    {
        this.Answer = answer;
        this.Correct = this.Answer == this.Account.IncreasingSide;

        if (this.Correct)
        {
            this.Score++;
        }

        this.QuestionCount++;
    }

    public async Task RestartGame()
    {
        this.Score = 0;
        this.QuestionCount = 0;
        await this.GetAccounts();
        this.GetAccount();
    }
}