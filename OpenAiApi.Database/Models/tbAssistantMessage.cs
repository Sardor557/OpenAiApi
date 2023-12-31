﻿using OpenAiApi.Database.Models.BaseModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OpenAiApi.Database.Models
{
    public class tbAssistantMessage : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long TelegramUserMessageId {  get; set; }
        public virtual tbTelegramUserMessage TelegramUserMessage { get; set; }

        [StringLength(10000)]
        public string Message { get; set; }
    }
}
