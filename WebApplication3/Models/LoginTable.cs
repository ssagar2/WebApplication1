namespace WebApplication3.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LoginTable")]
    public partial class LoginTable
    {
        public int Id { get; set; }

        [StringLength(50)]
        [System.ComponentModel.DisplayName("User Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[System.ComponentModel.DisplayName("Confirm Password")]
        //[DataType(DataType.Password)]
        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }
    }
}
