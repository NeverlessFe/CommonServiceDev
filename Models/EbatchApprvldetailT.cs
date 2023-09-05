using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchApprvldetailT
{
    public long RecordId { get; set; }

    public string? IdappsFk { get; set; }

    public string? ModulidFk { get; set; }

    public string? Idtransc { get; set; }

    public DateTime? Applydate { get; set; }

    public string? Description { get; set; }

    public int? Apprvlevel { get; set; }

    public string? Apprvlroleid { get; set; }

    public string? Lob { get; set; }

    public string? Nik { get; set; }

    public bool? IsAmountLimit { get; set; }

    public decimal? AmountLimit { get; set; }

    public int? Amount { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public string? Attribute3 { get; set; }

    public string? Attribute4 { get; set; }

    public string? Attribute5 { get; set; }

    public bool? Isactive { get; set; }

    public bool? IsDelegate { get; set; }

    public string? Rejectreason { get; set; }

    public string? Status { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public string? Remarks { get; set; }
}
