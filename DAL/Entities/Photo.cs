using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Photo :_base
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string MimeType { get; set; }
        public long Size { get; set; }
        [ForeignKey("News")]
        public int News_Id { get; set; }
        public virtual News News { get; set; }  
    }
}