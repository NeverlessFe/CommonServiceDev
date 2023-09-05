using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchApprvdetailM
{
    public long RecordId { get; set; }

    public string? IdappsFk { get; set; }

    public string? IdsectionFk { get; set; }

    public string? Modulid { get; set; }

    public string? Apprvlevel { get; set; }

    public string? Apprvroleid { get; set; }

    public string? Apprvtype { get; set; }

    public bool? IsAmountLimit { get; set; }

    public decimal? AmountLimit { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }
}
