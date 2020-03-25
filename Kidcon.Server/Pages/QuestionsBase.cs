using System;
using System.Threading.Tasks;
using Kidcon.Server.Services;
using Kidcon.Shared;
using Microsoft.AspNetCore.Components;

namespace Kidcon.Server.Pages
{
    public class QuestionsBase : ComponentBase
    {
        [Inject]
        public IEquationService EquationService { get; set; }

        public string RandomName = "";

        protected override async Task OnInitializedAsync()
        {
            RandomName = await EquationService.GetRandomName();
        }

        //  onClickedSide(creditRef: MatButton, debitRef: MatButton, sideChosen: string)
        //  {
        //      this.sideChosen = sideChosen;
        //      if (this.accountIncreasingOn === sideChosen)
        //      {
        //          this.correct = true;
        //          this.score += 1;
        //      }
        //      else
        //      {
        //          this.correct = false;
        //      }
        //      this.questionCount += 1;
        //      creditRef.disabled = true;
        //      debitRef.disabled = true;
        //      setTimeout(() => {
        //          this.getClassificationAccount();
        //          this.sideChosen = null;
        //          debitRef.disabled = false;
        //          creditRef.disabled = false;
        //      }, 4500);

        //      if (this.questionCount >= 10)
        //      {
        //          this.openDialog();
        //      }
        //  }

        //  openDialog()
        //  {
        //      this.accountsAsked = [];
        //      const dialogRef = this.dialog.open(ScoreDialogComponent, {
        //      width: '70%',
        //data:
        //          {
        //          questionsAnswered: this.questionCount,
        //  scoreAchieved: this.score
        //}
        //      });

        //      dialogRef.afterClosed().subscribe(() => {
        //          this.questionCount = 0;
        //          this.score = 0;
        //      });
        //  }

        //  getClassificationAccount()
        //  {
        //      this.classificationsSub = this.accountingService.randomClassification
        //      .subscribe((classification: ClassificationData) => {
        //          if (this.accountsAsked.indexOf(classification.accountName) !== -1)
        //          {
        //              this.classification = getRandomItem(classification.valuesArray);
        //              // console.log('repeated item');
        //          }
        //          else
        //          {
        //              this.classification = classification.chosenAccount;
        //              // console.log('new item');
        //          }
        //          this.accountName = this.classification.name;
        //          this.accountType = this.classification.type;
        //          this.accountIncreasingOn = this.classification.increasingSide;
        //          this.accountsAsked.push(this.classification.name);
        //          // console.log(this.accountsAsked);
        //      });
        //  }

        //  setAOrAn()
        //  {
        //      const accounts = ['asset', 'expense', 'income'];
        //      return accounts.indexOf(this.accountType) !== -1 ? 'an' : 'a';
        //  }

        //  // openSnackBar() {
        //  //   this.snackBar.open(this.correct ? 'correct' : 'incorrect');
        //  // }
    }
}
