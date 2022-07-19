﻿namespace Hello.Ildar.Bot.Domain.Entities;

/// <summary>
/// Запись о расходах/доходах.
/// </summary>
public class Record : EntityBase
{
    public int TelegramUserId { get; set; }
    public TelegramUser TelegramUser { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public decimal Value { get; set; }
}