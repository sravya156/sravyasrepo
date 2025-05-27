using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace NatureHub2.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int? UserId { get; set; }

    public int? OrderId { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Status { get; set; }

    public virtual Order? Order { get; set; }

    public virtual User? User { get; set; }
}
