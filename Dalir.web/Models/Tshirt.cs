using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dalir.web.Models;

[Table("Tshirt")]
public partial class Tshirt
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? TshirtName { get; set; }

    [StringLength(200)]
    public string? Price { get; set; }

    [StringLength(200)]
    public string? Color { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [StringLength(200)]
    public string? Available { get; set; }

    [StringLength(200)]
    public string? Tittle { get; set; }

    [Column("Image Name")]
    [StringLength(200)]
    public string? ImageName { get; set; }
}
