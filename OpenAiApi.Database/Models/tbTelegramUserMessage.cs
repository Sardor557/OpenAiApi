using OpenAiApi.Database.Models.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenAiApi.Database.Models
{
    public class tbTelegramUserMessage : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public int TelegramUserId { get; set; }
        public virtual tbTelegramUser TelegramUser { get; set; }

        [StringLength(2000)]
        public string Message {  get; set; }        
    }
}
