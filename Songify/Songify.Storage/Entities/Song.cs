using Songify.Common.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songify.Storage.Entities
{
    [Table("Songs", Schema = "Songify")]
    public class Song : BaseEntity
    {
        public string Title { get; set; }
        public string FileName { get; set; }
    }
}
