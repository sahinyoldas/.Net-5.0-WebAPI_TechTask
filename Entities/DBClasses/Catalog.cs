﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DBClasses
{
    public class Catalog : IBaseEntity
    {
        public long Id { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public long UserId { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public ICollection<CatalogAlbum> CatalogAlbums { get; set; }
    }
}
