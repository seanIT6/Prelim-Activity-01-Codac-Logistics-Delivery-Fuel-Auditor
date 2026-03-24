// ============================================================
// Codac Logistics Delivery & Fuel Auditor
// Author: [Your Name]
// Course: Introduction to C#
// Description: A console-based tool to track fuel expenses
//              and delivery performance for a single vehicle
//              over a 5-day work week.
// ============================================================

using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------------------------------------
        // TASK 1: Driver Profile & Distance Validation
        // -------------------------------------------------------

        Console.WriteLine("========================================");
        Console.WriteLine("  CODAC LOGISTICS - Fuel & Delivery Audit");
        Console.WriteLine("========================================\n");

        // string is used here because a driver's name is text data
        Console.Write("Enter Driver's Full Name: ");
        string driverName = Console.ReadLine();

        // decimal is used for financial values (fuel budget) to avoid
        // floating-point rounding errors common with double in monetary contexts
        Console.Write("Enter Weekly Fuel Budget (PHP): ");
        decimal weeklyFuelBudget = decimal.Parse(Console.ReadLine());

        // double is used for distance since it's a measurement (not currency)
        // and doesn't require the precision guarantees of decimal
        double totalDistance;

        // A while loop is used instead of if because validation may need to
        // repeat multiple times until the user provides a valid input.
        // An if statement only checks once — a loop keeps asking until valid.
        Console.Write("Enter Total Distance Traveled this week (km, 1.0 - 5000.0): ");
        while (!double.TryParse(Console.ReadLine(), out totalDistance) ||
               totalDistance < 1.0 || totalDistance > 5000.0)
        {
            Console.WriteLine("[ERROR] Distance must be between 1.0 and 5000.0 km. Please try again.");
            Console.Write("Enter Total Distance Traveled this week (km): ");
        }

        // -------------------------------------------------------
        // TASK 2: Fuel Expense Tracking
        // -------------------------------------------------------

        // A 1D array of decimal is declared to store 5 days of fuel costs.
        // decimal is chosen because fuel costs are financial values.
        decimal[] fuelExpenses = new decimal[5];
        decimal totalFuelSpent = 0m; // Accumulator for total fuel cost

        Console.WriteLine("\n--- Daily Fuel Expense Entry ---");

        // A for loop is used because we know exactly how many iterations
        // are needed (5 days). The (i + 1) expression converts the
        // zero-based index to a human-readable day number (Day 1, Day 2, etc.)
        for (int i = 0; i < fuelExpenses.Length; i++)
        {
            // (i + 1) maps index 0→Day 1, 1→Day 2, ..., 4→Day 5
            Console.Write($"Enter fuel cost for Day {i + 1} (PHP): ");
            fuelExpenses[i] = decimal.Parse(Console.ReadLine());

            // Accumulate total fuel spent across all days
            totalFuelSpent += fuelExpenses[i];
        }

        // -------------------------------------------------------
        // TASK 3: Performance Analysis
        // -------------------------------------------------------

        // Calculate average daily fuel expense
        decimal averageDailyExpense = totalFuelSpent / fuelExpenses.Length;

        // Fuel efficiency = km per PHP spent (distance / total fuel)
        // We cast to double for the division since distance is double
        double efficiencyRatio = totalDistance / (double)totalFuelSpent;

        // Determine efficiency rating using if/else control flow
        string efficiencyRating;
        if (efficiencyRatio > 15)
        {
            efficiencyRating = "High Efficiency";
        }
        else if (efficiencyRatio >= 10)
        {
            efficiencyRating = "Standard Efficiency";
        }
        else
        {
            efficiencyRating = "Low Efficiency / Maintenance Required";
        }

        // bool is used because budget status is a true/false (binary) condition
        bool isUnderBudget = totalFuelSpent <= weeklyFuelBudget;

        // -------------------------------------------------------
        // TASK 4: The Audit Report
        // -------------------------------------------------------

        Console.WriteLine("\n========================================");
        Console.WriteLine("       CODAC LOGISTICS - AUDIT REPORT");
        Console.WriteLine("========================================");
        Console.WriteLine($"  Driver Name       : {driverName}");
        Console.WriteLine($"  Total Distance    : {totalDistance:F2} km");
        Console.WriteLine($"  Weekly Budget     : PHP {weeklyFuelBudget:F2}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("  5-Day Fuel Expense Breakdown:");

        // Loop through array to display each day's expense
        for (int i = 0; i < fuelExpenses.Length; i++)
        {
            Console.WriteLine($"    Day {i + 1}           : PHP {fuelExpenses[i]:F2}");
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"  Total Fuel Spent  : PHP {totalFuelSpent:F2}");
        Console.WriteLine($"  Avg Daily Expense : PHP {averageDailyExpense:F2}");
        Console.WriteLine($"  Efficiency Ratio  : {efficiencyRatio:F2} km/PHP");
        Console.WriteLine($"  Efficiency Rating : {efficiencyRating}");
        Console.WriteLine("----------------------------------------");

        // Display budget status using the bool variable
        if (isUnderBudget)
        {
            decimal savings = weeklyFuelBudget - totalFuelSpent;
            Console.WriteLine($"  Budget Status     : UNDER BUDGET ✓ (Saved PHP {savings:F2})");
        }
        else
        {
            decimal overspend = totalFuelSpent - weeklyFuelBudget;
            Console.WriteLine($"  Budget Status     : OVER BUDGET ✗ (Exceeded by PHP {overspend:F2})");
        }

        Console.WriteLine($"  Under Budget?     : {isUnderBudget}");
        Console.WriteLine("========================================");
        Console.WriteLine("  End of Audit Report");
        Console.WriteLine("========================================");
    }
}