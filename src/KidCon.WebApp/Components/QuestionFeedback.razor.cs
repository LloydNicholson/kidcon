namespace KidCon.WebApp.Components;

using System.Timers;
using KidCon.Database.Entities;
using Microsoft.AspNetCore.Components;

public partial class QuestionFeedback : ComponentBase, IDisposable
{
    private readonly Timer timer = new()
    {
        Interval = TimeSpan.FromSeconds(1).TotalMilliseconds,
    };

    public double TimeRatio => 1 - 1 / this.TimeRemainingSeconds;

    [Parameter]
    public Account Account { get; set; } = null!;

    [Parameter]
    public bool Correct { get; set; }

    [Parameter]
    public int Score { get; set; }

    [Parameter]
    public int QuestionCount { get; set; }

    [Parameter]
    public double TimeRemainingSeconds { get; set; }

    [Parameter]
    public required Action TimerFinished { get; set; }

    protected override Task OnInitializedAsync()
    {
        this.timer.Elapsed += async (sender, e) =>
        {
            this.TimeRemainingSeconds -= 1;
            await this.InvokeAsync(this.StateHasChanged);
            if (this.TimeRemainingSeconds < 0)
            {
                this.TimeRemainingSeconds = 0;
                this.timer.Stop();
                await this.InvokeAsync(this.TimerFinished);
            }
        };
        this.timer.Start();

        return Task.CompletedTask;
    }

    protected virtual string AOrAn()
    {
        return this.Account.Classification.Type is "Asset" or "Expense" or "Income"
            ? "an"
            : "a";
    }

    public void Dispose()
    {
        this.timer.Dispose();
    }
}