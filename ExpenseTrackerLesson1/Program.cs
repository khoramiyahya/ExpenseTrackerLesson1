using ExpenseTrackerLesson1;

Console.WriteLine("Start");




Expense expense = new(){
    Title= "Coffee",
    IsBusiness=true,
    Amount = 250.75m,
    CategoryId=1,
    Date=new DateTime(2026,06,01),
};

Console.WriteLine("Processing expense");
decimal monthlyBudget = 500;

decimal taxRate = 0.15m;
decimal tax = expense.Amount * taxRate;
decimal totalBeforeDiscount = expense.Amount + tax;
decimal discountRate = 0.1m;
decimal discountAmount = totalBeforeDiscount * discountRate;
decimal finalTotal = totalBeforeDiscount - discountAmount;
bool hasExceededBudget = finalTotal > monthlyBudget;
bool requiresApproval =
    expense.Amount > 100 && expense.IsBusiness;

Console.WriteLine("Expense Summary");
Console.WriteLine("--------------------------------------------");
Console.WriteLine($"Monthly Budget Is : {monthlyBudget}");
Console.WriteLine($"Title                   : {expense.Title}");
Console.WriteLine($"Amount                  : {expense.Amount}");
Console.WriteLine($"Date                    : {expense.Date:yyyy-MM-dd}");
Console.WriteLine($"Business Expense        : {expense.IsBusiness}");
Console.WriteLine($"Category Id             : {expense.CategoryId}");
Console.WriteLine($"Tax                     : {tax}");
Console.WriteLine($"Total before discount   : {totalBeforeDiscount}");
Console.WriteLine($"DiscountAmount          : {discountAmount}");
Console.WriteLine($"Final Total             : {finalTotal}");
Console.WriteLine($"Exceeded Budget         : {hasExceededBudget}");



//A company has these business rules:
//Tax Rate: 15 %
//Discount: 10 %
//Monthly Budget: 500


if (requiresApproval)
{
    Console.WriteLine("Expense is waiting for manager approval.");
}
else
{
    Console.WriteLine("Expense has been approved.");
}


Console.WriteLine("End");


