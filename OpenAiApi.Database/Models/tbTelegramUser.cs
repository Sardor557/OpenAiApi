using OpenAiApi.Database.Models.BaseModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace OpenAiApi.Database.Models
{
    public class tbTelegramUser : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [IndexColumn(IsUnique = true)]
        public long TelegramId {  get; set; }

        [StringLength(255)]
        public string FullName { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }

        [StringLength(2)]
        public string Lang { get; set; }

        public virtual List<tbTelegramUserMessage> Messages { get; set; }
    }
}
