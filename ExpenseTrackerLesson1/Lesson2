using ExpenseTrackerLesson;

decimal[] expensisAmount= { 50m, 120m, 250m, 80m, 1500m }; ;
List<Expense> expenses =new List<Expense>();



 decimal taxRate = 0.15m;
 decimal discountRate = 0.10m;
 decimal totalExpenses=0;

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

    Expense expense = expenses[i];

    if (expense.Amount==80)
    {
        continue;
    } else if (expense.Amount>1000)
    {
        Console.WriteLine("High-value expense found.");
        break;
    }
        decimal taxAmount = expense.Amount * taxRate;
    decimal amountWithTax = expense.Amount + taxAmount;

    decimal discountAmount = expense.Amount * discountRate;
    decimal totalAmount = amountWithTax - discountAmount;
    string categoryName = expense.CategoryId switch
    {
        1 => "Food",
        2 => "Transport",
        3 => "Shopping",
        4 => "Utilities",
        _ => "Other"
    };

    totalExpenses += expense.Amount;
    Console.WriteLine($"Expense Summry {i + 1}");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine($"Title : {expense.Title}");
    Console.WriteLine($"Date : {expense.Date}");
    Console.WriteLine($"Amount : {expense.Amount}");
    Console.WriteLine(">>>>>>>>>>>>>>");
    Console.WriteLine($"Tax : {taxAmount}");
    Console.WriteLine($"Amount With Tax : {amountWithTax}");
    Console.WriteLine($"Discount : {discountAmount}");
    Console.WriteLine($"Total Amount : {totalAmount}");
    Console.WriteLine($"Category Name : {categoryName}");

    if (expense.Amount <= 100)
    {
        Console.Write("Automatically Approved");
    }
    else if (expense.Amount > 100 && expense.Amount <= 1000)
    {
        Console.WriteLine("Manager Approval Required");
    }
    else if (expense.Amount > 1000)
    {
        Console.WriteLine("Director Approval Required");

    }


    //End
}


Console.WriteLine("Result-----------------------------");
Console.WriteLine($"Total Expenses : {totalExpenses}");

