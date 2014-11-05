using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;


namespace WpcabAdministration.Models
{
    [Bind(Exclude = "Id,SomeOtherProperty")]
    public class Member
    {
        [Key]
        [Editable(false)]
        [Display(Name = "ID")]
        public int MemberId { get; private set; }

        [Display(Name = "Form Id")]
        public string FormId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string NameEn { get; set; }

        [Display(Name = "নাম")]
        public string NameBn { get; set; }

        [Display(Name = "Father's Name")]
        public string FatherNameEn { get; set; }

        [Display(Name = "বাবা'র নাম")]
        public string FatherNameBn { get; set; }

        [Display(Name = "Mother's Name")]
        public string MotherNameEn { get; set; }

        [Display(Name = "মা'র নাম")]
        public string MotherNameBn { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Marital Status")]
        [DisplayFormat(NullDisplayText = "Unknown")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Spouse's Name")]
        public string SpouseNameEn { get; set; }

        [Display(Name = "সহধর্মিণী'র নাম")]
        public string SpouseNameBn { get; set; }

        [Display(Name = "Blood Group")]
        [DisplayFormat(NullDisplayText = "Unknown")]
        public string BloodGroup { get; set; }

        public string Photo { get; set; }

        public string SignatureImage { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mobile Number")]
        [Phone(ErrorMessage = "Please enter a valid mobile number.")]
        public string MobileNumber { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Display(Name = "National ID")]
        public string NationalId { get; set; }

        [Display(Name = "Date of Birth")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Date of Membership")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfMembership { get; set; }

        [Display(Name = "Start date of Account")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDateOfAccount { get; set; }

        [NotMapped]
        [Editable(false)]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Educational Qualification")]
        public string EducationalQualification { get; set; }

        [Display(Name = "Profession")]
        public string Profession { get; set; }

        [Display(Name = "Experience")]
        public string Experience { get; set; }

        [Display(Name = "Monthly Income")]
        public int MonthlyIncome { get; set; }

        [Display(Name = "Monthly Expense")]
        public int MonthlyExpense { get; set; }

        [Display(Name = "Number of Family Member")]
        public int NoOfFamilyMember { get; set; }

        [Display(Name = "Financial Status")]
        public int FinancialStatus { get; set; }

        [Display(Name = "Relegion")]
        [DisplayFormat(NullDisplayText = "Unknown")]
        public string Relegion { get; set; }

        [Display(Name = "Passed")]
        public bool IsPassed { get; set; }

        [Display(Name = "Date of Passing")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfPassing { get; set; }

        [Display(Name = "Inactive")]
        public bool IsInactive { get; set; }

        [Display(Name = "Date from Inactive")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateFromInactive { get; set; }

        [Display(Name = "Referral")]
        public string ReferralId { get; set; }

        public virtual Member Referral { get; set; }

        [Display(Name = "Relatives")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public virtual ICollection<Member> Relatives { get; set; }

        public int VillageId { get; set; }

        public virtual Village Village { get; set; }

        [NotMapped]
        [Display(Name = "Village")]
        public string VillageEn { get; set; }

        [NotMapped]
        [Display(Name = "গ্রাম")]
        public string VillageBn { get; set; }

        public int PostOfficeId { get; set; }

        public virtual PostOffice PostOffice { get; set; }

        [NotMapped]
        [Display(Name = "Post Office")]
        public string PostOfficeEn { get; set; }

        [NotMapped]
        [Display(Name = "পোষ্ট অফিস")]
        public string PostOfficeBn { get; set; }

        public int PoliceStationId { get; set; }

        public virtual PoliceStation PoliceStation { get; set; }

        [NotMapped]
        [Display(Name = "Police Station")]
        public string PoliceStationEn { get; set; }

        [NotMapped]
        [Display(Name = "থানা")]
        public string PoliceStationBn { get; set; }

        public int DistrictId { get; set; }

        public virtual District District { get; set; }

        [NotMapped]
        [Display(Name = "District")]
        public string DistrictEn { get; set; }

        [NotMapped]
        [Display(Name = "জেলা")]
        public string DistrictBn { get; set; }

        [Display(Name = "Zone")]
        public int ZoneId { get; set; }

        public virtual Zone Zone { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "Nationality")]
        [DisplayFormat(NullDisplayText = "Unknown")]
        public string Nationality { get; set; }

        public virtual Country Country { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "required")]
        [MinLength(4, ErrorMessage = "Min: 4")]
        [MaxLength(8, ErrorMessage = "Max: 8")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "required")]
        [MinLength(4, ErrorMessage = "Min: 4")]
        [MaxLength(8, ErrorMessage = "Max: 8")]
        public string Password { get; set; }

        

        //[Editable(false)]
        //[NotMapped]
    }
}