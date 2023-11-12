using System;
using System.ComponentModel;

namespace OpenAiApi.Database.Models.BaseModels
{
    public class BaseModel
    {
        [DefaultValue(1)]
        public int Status { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
