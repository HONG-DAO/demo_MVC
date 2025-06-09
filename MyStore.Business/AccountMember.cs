using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyStore.Business;

public partial class AccountMember
{
    [Key] // Đánh dấu đây là primary key
    public int MemberId { get; set; }

    public string MemberPassword { get; set; } = null!;

    public string? FullName { get; set; }

    public string? EmailAddress { get; set; }

    public string? MemberRole { get; set; }
}