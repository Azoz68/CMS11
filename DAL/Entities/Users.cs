using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Users : _base
    {
        [Required]
        public int Role { get; set; }

        [Required(ErrorMessage ="اسم المستخدم")]
        [MaxLength(15)]
        [MinLength(6,ErrorMessage ="من فضلك ادخل اسم مستخدم صحيح")]
        [DisplayName("اسم المستخدم")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9]{6,15}$")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="كلمة المرور")]
        [DisplayName("كلمة المرور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "إعادة كلمة المرور")]
        [DisplayName("كلمة المرور")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public virtual string RePassword { get; set; }

        [DisplayName("الاسم")]
        //  [Display(Name = "Password")]
        [RegularExpression(@"^[a-zA-Z'-\s]{1,40}$")]
        public string Name { get; set; }
        public bool IsAdmin { get; set; }

    }
}
