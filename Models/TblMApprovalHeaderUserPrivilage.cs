using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class TblMApprovalHeaderUserPrivilage
{
    public long RecordId { get; set; }

    public string Username { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
