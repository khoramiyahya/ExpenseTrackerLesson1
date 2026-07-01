using ExpenseTrackerLesson1;

Expense myExpense = new Expense() {
    Title= "Coffee",
    IsBusiness=false,
    Amount = 5.6m,
    CategoryId=1,
    Date=DateTime.Now,
};

Console.WriteLine("Exspense Title: " + myExpense.Title);
Console.WriteLine("Exspense Amount: " +  myExpense.Amount);
Console.WriteLine("Exspense Category Id: " + myExpense.CategoryId);
Console.WriteLine("Is Business Exspense: " + myExpense.IsBusiness);
Console.WriteLine("Exspense Tax : " + myExpense.Amount * 0.15m );
Console.WriteLine("Exspense Total With Tax : " + myExpense.Amount * 1.15m);
