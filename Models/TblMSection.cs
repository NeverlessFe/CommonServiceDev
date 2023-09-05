using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class TblMSection
{
    public long RecordId { get; set; }

    public string? Idapps { get; set; }

    public long? MenuId { get; set; }

    public string? Lob { get; set; }

    public string? SectionName { get; set; }

    public string? SectionDescription { get; set; }

    public string? Category1 { get; set; }

    public string? Atribut1 { get; set; }

    public string? Category2 { get; set; }

    public string? Atribut2 { get; set; }

    public string? Category3 { get; set; }

    public string? Atribut3 { get; set; }

    public string? Category4 { get; set; }

    public string? Atribut4 { get; set; }

    public string? Category5 { get; set; }

    public string? Atribut5 { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }
}
