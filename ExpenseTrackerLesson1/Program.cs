using ExpenseTrackerLesson1;

Expense myExpense = new Expense() {
    Title= "Coffee",
    IsBusiness=false,
    Amount = 5.6m,
    CategoryId=1,
    Date=new DateTime(2026,06,01),
};

decimal taxRate = 0.15m;
decimal tax = myExpense.Amount * taxRate;
decimal total = myExpense.Amount + tax;


Console.WriteLine($"Expense Title: {myExpense.Title}");
Console.WriteLine($"Expense Amount: {myExpense.Amount}");
Console.WriteLine($"Expense Category Id: { myExpense.CategoryId}");
Console.WriteLine($"Is Business Exspense: { myExpense.IsBusiness}");
Console.WriteLine($"Expense Tax : {tax}");
Console.WriteLine($"Expense Total With Tax : {total}");