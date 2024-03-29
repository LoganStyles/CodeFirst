﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Entities
{
    public class Tag
    {
        public Tag()
        {
            Albums = new HashSet<Album>();
        }

        [Key]
        public long Id { get; set; }
        public string Title { get; set; } = null!;

        [ForeignKey("TagId")]
        [InverseProperty(nameof(Album.Tags))]
        public virtual ICollection<Album> Albums { get; set; }
    }
}



