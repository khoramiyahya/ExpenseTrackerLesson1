using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTrackerLesson1
{
    public class Expense
    {
        public string Title { get; set; }=string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsBusiness { get; set; }
        public int CategoryId { get; set; }

    }
}
