using System;
using System.Collections.Generic;

namespace API.Models;

public partial class CountryList
{
    public int Id { get; set; }

    public string? CountryName { get; set; }

    public string? CountryCode { get; set; }

    public string? Nationality { get; set; }

    public string? ImageUrl { get; set; }
}
