using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class TblTErrorLog
{
    public long RecordId { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public string? Error { get; set; }

    public string? Username { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
