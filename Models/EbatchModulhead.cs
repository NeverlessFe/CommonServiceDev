using System;
using System.Collections.Generic;

namespace CommonServiceCore.Models;

public partial class EbatchModulhead
{
    public long RecordId { get; set; }

    public string? Idapps { get; set; }

    public string? Modulid { get; set; }

    public string? Description { get; set; }

    public string? Lob { get; set; }

    public string? Kategori1 { get; set; }

    public string? Kategori2 { get; set; }

    public string? Kategori3 { get; set; }

    public string? Kategori4 { get; set; }

    public string? Kategori5 { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public string? Modulname { get; set; }

    public DateTime? Applydate { get; set; }

    public string? Urlmodul { get; set; }

    public string? Urlwebhook { get; set; }

    public string? ServerName { get; set; }

    public string? DatabaseName { get; set; }

    public string? SpName { get; set; }

    public string? PkField { get; set; }
}
