using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerLesson;
    public class Expense
    {
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int CategoryId { get; set; }

    public decimal CalculateTax(decimal amount)
    {
        return amount * 0.15m;
    }
    public decimal CalculateTax(decimal amount,decimal taxRate)
    {
        return amount * taxRate;
    }

    public decimal CalculateDiscount(decimal amount, decimal discountRate) 
    {
        return amount * discountRate;
    }

    public string GetCategoryName(int categoryId) { 

        return categoryId switch
        {
            1 => "Food",
            2 => "Transport",
            3 => "Shopping",
            4 => "Utilities",
            _ => "Other"
        };
    }

    public string GetApprovalStatus(decimal amount) {
        string statusMessage="Director Approval Required";

        if (amount <= 100)
        {statusMessage = "Automatically Approved";}
        else if (amount > 100 && amount <= 1000)
        {statusMessage = "Manager Approval Required";}
        //else if (amount > 1000)
        //{statusMessage="Director Approval Required";}
        return statusMessage;
    }

    public void PrintExpenseSummary(Expense expense) 
    {
        decimal taxAmount = expense.CalculateTax(expense.Amount);
        decimal amountWithTax = expense.Amount + taxAmount;
        decimal discountAmount = expense.CalculateDiscount(expense.Amount, 0.10m);
        decimal totalAmount = amountWithTax - discountAmount;
        string categoryName = expense.GetCategoryName(expense.CategoryId);

        Console.WriteLine($"Expense Summry {expense.Title} {expense.Amount} ");
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
        Console.WriteLine(expense.GetApprovalStatus(expense.Amount));
        Console.WriteLine($"");

    }




}

