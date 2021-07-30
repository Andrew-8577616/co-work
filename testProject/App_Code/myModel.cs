﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class asset
{
    public int AssetId { get; set; }
    public int UserId { get; set; }
    public string AssetClass { get; set; }
    public string BankName { get; set; }
    public string Currency { get; set; }
    public int money { get; set; }
    public string note { get; set; }
}

public partial class creditCard
{
    public int CardId { get; set; }
    public string Company { get; set; }
    public string Product { get; set; }
    public string Advantage1 { get; set; }
    public string Advantage2 { get; set; }
    public string Advantage3 { get; set; }
    public string Advantage4 { get; set; }
    public string Advantage5 { get; set; }
    public string Advantage6 { get; set; }
    public string fee { get; set; }
}

public partial class Employee
{
    public int EmployeeID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public System.DateTime BirthDate { get; set; }
    public System.DateTime HireDate { get; set; }
    public Nullable<bool> Supervisor { get; set; }
}

public partial class Member
{
    public int UserID { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Nullable<System.DateTime> BirthDate { get; set; }
    public System.DateTime RegisterDate { get; set; }
    public string Gender { get; set; }
    public Nullable<int> Age { get; set; }
    public Nullable<int> Income { get; set; }
}

public partial class Note
{
    public int NoteID { get; set; }
    public int UserID { get; set; }
    public string Category { get; set; }
    public string Details { get; set; }
    public Nullable<int> Price { get; set; }
    public Nullable<System.DateTime> Date { get; set; }
}

public partial class Stock
{
    public int StockID { get; set; }
    public int UserID { get; set; }
    public string StockNumber { get; set; }
    public string CompanyName { get; set; }
    public Nullable<int> Price { get; set; }
    public Nullable<int> Amount { get; set; }
    public Nullable<System.DateTime> Date { get; set; }
}

public partial class Stock1
{
    public string StockID { get; set; }
    public string company { get; set; }
    public string profit { get; set; }
    public string date { get; set; }
    public string payDate { get; set; }
}

public partial class UserCredit
{
    public int CreditId { get; set; }
    public int UserID { get; set; }
    public int CardId { get; set; }
}
