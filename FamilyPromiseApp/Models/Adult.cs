
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyPromiseApp.Data;
namespace FamilyPromiseApp.Models;
public class Adult {
    public int ID { get; set; }
    public int CaseID { get; set; }
    public int PersonID { get; set; }

    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Display(Name = "First Name")]
    public string FirstMidName { get; set; }
    public int Age { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date of Birth")]
    public DateTime DateOfBirth { get; set; }
    [Display(Name = "Cell Number")]
    public string CellPhone { get; set; }
    [Display(Name = "Work Number")]
    public string WorkPhone { get; set; }
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    public int AdultNumber { get; set; }
    


}