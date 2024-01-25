namespace CardPayment.Domain;

using System.ComponentModel.DataAnnotations;

public sealed record Transaction
{
    [Key]
    public Guid Id { get; set; }
    public decimal Amount { get; set; } = 0;
    public string AccountName { get; set; }
    public DateTime DateTimeCreated { get; } = DateTime.Now;
}