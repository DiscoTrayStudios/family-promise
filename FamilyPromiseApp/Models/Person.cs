using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FamilyPromiseApp.Models
{

    public enum AnyHouseHold
    {
        No, Yes
    }

    public enum AnyChildren
    {
        No, Yes
    }

    public class Person
    {
        
        [Display(Name = "Client ID")]
        public int ID { get; set; }
        // [Key]
        // public int CaseID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Column("First Name")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Cell Number")]
        public string CellPhone { get; set; }
        [Display(Name = "Work Number")]
        public string WorkPhone { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set;}
        [Display(Name = "Are there any additional adults in the household?")]
        public AnyHouseHold? HouseHoldMemberExist { get; set; }
        [Display(Name = "Number of additional adults in the household")]
        public int HouseHoldNum { get; set; }
        [Display(Name = "Adult Name(s)")]
        public string AdultName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Adult Date of Birth")]
        public DateTime AdultDateOfBirth { get; set; }
        [Display(Name = "Adult Cell Phone")]
        public string AdultCellPhone { get; set; }
        [Display(Name = "Adult Work Phone")]
        public string AdultWorkPhone { get; set; }
        [Display(Name = "Adult Email")]
        public string AdultEmail { get; set; }
        [Display(Name = "Are there any children in the household?")]
        public AnyChildren? HouseHoldChildrenExist { get; set; }
        [Display(Name = "How many children are in the household?")]
        public int ChildNum { get; set; }
        [Display(Name = "Child Name(s)")]
        public string ChildName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Child Date of Birth")]
        public DateTime ChildDateOfBirth { get; set; }
        [Display(Name = "Child Age")]
        public int ChildAge { get; set; }
        public Case Case{ get; set; }
        [Display(Name = "Referrals Available")]
        public ICollection<Referral> Referral { get; set; }
        [NotMapped]
        public List<int> SelectedReferralIds { get; set; }
        [NotMapped]
        public List<SelectListItem> AvailableReferrals { get; set; }

        // public Case Case { get; set; }

    }
}