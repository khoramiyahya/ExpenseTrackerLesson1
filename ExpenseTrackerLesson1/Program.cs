using ExpenseTrackerLesson1;

Expense expense = new(){
    Title= "Coffee",
    IsBusiness=false,
    Amount = 5.6m,
    CategoryId=1,
    Date=new DateTime(2026,06,01),
};

decimal taxRate = 0.15m;
decimal tax = expense.Amount * taxRate;
decimal total = expense.Amount + tax;


//Console.WriteLine($"Expense Title: {myExpense.Title}");
//Console.WriteLine($"Expense Amount: {myExpense.Amount}");
//Console.WriteLine($"Expense Category Id: { myExpense.CategoryId}");
//Console.WriteLine($"Is Business Exspense: { myExpense.IsBusiness}");
//Console.WriteLine($"Expense Tax : {tax}");
//Console.WriteLine($"Expense Total With Tax : {total}");

Console.WriteLine("Expense Summary");
Console.WriteLine("-------------------------");
Console.WriteLine($"Title              : {expense.Title}");
Console.WriteLine($"Amount             : {expense.Amount}");
Console.WriteLine($"Date               : {expense.Date:yyyy-MM-dd}");
Console.WriteLine($"Business Expense   : {expense.IsBusiness}");
Console.WriteLine($"Category Id        : {expense.CategoryId}");
Console.WriteLine($"Tax                : {tax}");
Console.WriteLine($"Total With Tax     : {total}");