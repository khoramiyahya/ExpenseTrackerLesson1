using ExpenseTrackerLesson;

decimal[] expensisAmount= { 50m, 120m, 250m, 80m, 1500m }; ;
List<Expense> expenses =new List<Expense>();

decimal totalExpenses = 0;

for (int i=0 ;i < expensisAmount.Count() ; i++)
{
    expenses.Add(
    new Expense
    {
        Amount = expensisAmount[i],
        CategoryId = 1,
        Date = new DateTime(2026, 07, 02),
        Title = "Rice"
    });
}

foreach (Expense expense in expenses)
{
    if (expense.Amount == 80)
    { continue;}
    else if (expense.Amount > 1000)
    { Console.WriteLine("High-value expense found."); break; }
    expense.PrintExpenseSummary(expense);
    totalExpenses += expense.Amount;
}

Console.WriteLine("Result-----------------------------");
Console.WriteLine($"Total Expenses : {totalExpenses}");

