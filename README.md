# 🚚 Codac Logistics — Fuel & Delivery Auditor

A console-based C# application that tracks fuel expenses and delivery performance for a single vehicle over a 5-day work week.

> Built as part of an **Introduction to C#** course project.

---

## 📋 Features

- **Driver Profile Setup** — Enter driver name, weekly fuel budget, and total distance traveled
- **Input Validation** — Distance input is validated within an accepted range (1.0 – 5,000.0 km)
- **Daily Fuel Tracking** — Log fuel expenses for each of the 5 working days
- **Performance Analysis** — Calculates efficiency ratio (km per PHP), efficiency rating, and budget status
- **Audit Report** — Displays a clean, formatted summary of the week's logistics data

---

## 🖥️ Sample Output

```
========================================
  CODAC LOGISTICS - Fuel & Delivery Audit
========================================

Enter Driver's Full Name: Juan Dela Cruz
Enter Weekly Fuel Budget (PHP): 5000
Enter Total Distance Traveled this week (km, 1.0 - 5000.0): 850

--- Daily Fuel Expense Entry ---
Enter fuel cost for Day 1 (PHP): 900
Enter fuel cost for Day 2 (PHP): 850
Enter fuel cost for Day 3 (PHP): 920
Enter fuel cost for Day 4 (PHP): 870
Enter fuel cost for Day 5 (PHP): 810

========================================
       CODAC LOGISTICS - AUDIT REPORT
========================================
  Driver Name       : Juan Dela Cruz
  Total Distance    : 850.00 km
  Weekly Budget     : PHP 5000.00
----------------------------------------
  5-Day Fuel Expense Breakdown:
    Day 1           : PHP 900.00
    Day 2           : PHP 850.00
    Day 3           : PHP 920.00
    Day 4           : PHP 870.00
    Day 5           : PHP 810.00
----------------------------------------
  Total Fuel Spent  : PHP 4350.00
  Avg Daily Expense : PHP 870.00
  Efficiency Ratio  : 0.20 km/PHP
  Efficiency Rating : Low Efficiency / Maintenance Required
----------------------------------------
  Budget Status     : UNDER BUDGET ✓ (Saved PHP 650.00)
  Under Budget?     : True
========================================
  End of Audit Report
========================================
```

---

## 🛠️ Tech Stack

| | |
|---|---|
| **Language** | C# |
| **Framework** | .NET 10.0 |
| **Type** | Console Application |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/en-us/download) or later

### Run the App

```bash
# Clone the repository
git clone https://github.com/your-username/CodacLogistics.git
cd CodacLogistics

# Build and run
dotnet run
```

---

## 📁 Project Structure

```
CodacLogistics/
├── Program.cs              # Main application logic
├── CodacLogistics.csproj   # Project configuration
└── README.md
```

---

## 📐 Concepts Demonstrated

This project was built to practice core C# fundamentals:

| Concept | Usage |
|---|---|
| **Data Types** | `string`, `decimal`, `double`, `bool` used intentionally for appropriate contexts |
| **Arrays** | 1D `decimal[]` array to store 5 days of fuel expenses |
| **Loops** | `for` loop for fixed iterations; `while` loop for input validation |
| **Conditionals** | `if/else` for efficiency rating and budget status logic |
| **Input Parsing** | `decimal.Parse`, `double.TryParse` for safe user input handling |
| **String Formatting** | Interpolated strings with `F2` format specifiers for currency/distance display |

---

## 📝 License

This project is for educational purposes. Feel free to use or adapt it for your own learning.
