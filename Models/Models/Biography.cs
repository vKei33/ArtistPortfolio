using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArtistPortfolio.Models.Models
{
	public class Biography
	{
        public long Id { get; set; }

        [Column(TypeName = "text")]
        public string? BiographyContentMK { get; set; }

        [Column(TypeName = "text")]
        public string? BiographyContentEN { get; set; }

        [Required]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string? ImageUrl { get; set; }
    }
}

