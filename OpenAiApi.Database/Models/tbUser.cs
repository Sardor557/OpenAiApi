using OpenAiApi.Database.Models.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenAiApi.Database.Models
{
    public sealed class tbUser : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Login {  get; set; }

        [Required, StringLength(100)]
        public string Password {  get; set; }
    }
}
