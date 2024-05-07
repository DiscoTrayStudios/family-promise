using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;


namespace FamilyPromiseApp.Models
{
    
    public enum YorN
    {
        Yes, No
    }
     public enum HouseType
    {
        [Display(Name = "Apartment")]
        Apartment, 
        [Display(Name = "House")]
        House,
        [Display(Name = "Mobile Home")]
        MobileHome
    }
    public enum RecentHousing
    {
        Renting, Purchased, Outside, Shelter, Car, Hotel
    }
    public enum Reason1
    {
        Eviction, 
        [Display(Name = "Kicked Out")]
        KickedOut, 
        Diasaster, 
        Moved, 
        Other
    }
    public enum Reason2
    {
        [Display(Name = "Lost Job")]
        LostJob, 
        [Display(Name = "Dissolution of Family")]
        FamilyDissolution, 
        [Display(Name = "Loss of Benefits")]
        BenefitsStopped, 
        [Display(Name = "Medical Problems")]
        MedicalProblems, 
        Other
    }

    public enum MaritalStatus
    {
        MarriedLocationKnown,
        MarriedLocationUnknown,
        Single
    }

    public enum GradeLevel
    {
        None,
        Kindergarten,
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth,
        Seventh,
        Eighth,
        Ninth,
        Tenth,
        Eleventh,
        Twelfth,
        College
    }

    public class IntakeModel
    {
        [Display(Name = "Client ID")]
        public int ID { get; set; }
        // [Key]
        // public int CaseID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Substance Issues")]
        public string SubstanceIss { get; set; }


        [Display(Name = "Referral taken by:")]
        public string TakenByNow { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Current Time")]
        public DateTime TimeNow { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Display(Name = "Current Date")]
        public DateTime DateToday { get; set;}

        [Display(Name = "Highest Form of Education")]
        public string Education { get; set; }

        [Display(Name = "Transportation Method")]
        public string TransportMethod { get; set; }

        [Display(Name = "Referring Agency / Source:")]
        public Referral ReferralAgency { get; set;}

        [Display(Name = "Employment")]
        public string IsEmployed { get; set; }

        [Display(Name = "Income")]
        public string Income { get; set; }

        [Display(Name = "Monthly Rent, if applicable.")]
        public string IsHoused { get; set; }

        [Display(Name = "Relationship")]
        public string Relationships { get; set; }


        [Display(Name = "Were/Are you part of the Work Study Program?")]
        public string WorkStudy { get; set; }

        [Display(Name = "# of Adults")]
        public string AdultNum { get; set; }

        
        [Display(Name = "SSN")]
        public string SSN { get; set; }

        [Display(Name = "Primary Reason of Homelessness")]
        public Reason1 Reason { get; set; }

        [Display(Name = "Primary Reason of Homelessness")]
        public Reason2? Reason2 { get; set; }

        [Display(Name = "ID Number")]
        public string IDNum { get; set; }
        
        [Display(Name = "Race")]
        public string Race { get; set; }

        [Display(Name = "Gender Identity")]
        public string Gender { get; set; }

        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        [Display(Name = "Where is your spouse located?")]
        public string SpouseLocation { get; set; }

        [Display(Name = "# of Children")]
        public int ChildSchool { get; set; }

        [Display(Name = "Grade of Child")]
        public int ChildGrade { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        
        [Display(Name = "Date Admitted")]
        public DateTime? DateAdmitted { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        
        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        
        [Display(Name = "Cell Number")]
        public string CellPhoneNum { get; set; }

        [Display(Name = "Work Number")]
        public string WorkPhoneNum { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAdd { get; set;}

        [Display(Name = "Address")]
        public string HomeAddress { get; set;}
        
        [Display(Name = "Are there any additional adults in the household?")]
        public AnyHouseHold? HouseHoldMemberExists { get; set; }

        [Display(Name = "Name")]
        public string AdultName { get; set; }

        [Display(Name = "Age")]
        public int AdultAge { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime AdultDateOfBirth { get; set; }

        [Display(Name = "Cell Phone")]
        public string AdultCellPhone { get; set; }

        [Display(Name = "Work Phone")]
        public string AdultWorkPhone { get; set; }
        [Display(Name = "Email")]
        public string AdultEmail { get; set; }
        
        [Display(Name = "Are there any additional children in the household?")]
        public AnyChildren? HouseHoldChildrenExists { get; set; }

        [Display(Name = "Most Recent Housing")]
        public RecentHousing? RecentHousing { get; set; }

        [Display(Name = "Type of Housing")]
        public HouseType? HouseType { get; set; }

        [Display(Name = "Number of children in household")]
        public int ChildNum { get; set; }

        [Display(Name = "Name")]
        public string ChildName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime ChildDateOfBirth { get; set; }
        [Display(Name = "Age")]
        public int ChildAge { get; set; }

    }
}
