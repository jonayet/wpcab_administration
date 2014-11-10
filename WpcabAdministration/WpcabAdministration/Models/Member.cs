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
        public int MemberId { get; set; }

        public string PhotoFileName { get; set; }

        #region Personal Information
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
        public string MaritalStatus { get; set; }

        [Display(Name = "Spouse's Name")]
        public string SpouseNameEn { get; set; }

        [Display(Name = "সহধর্মিণী'র নাম")]
        public string SpouseNameBn { get; set; }

        [Display(Name = "Care Of")]
        public string CareOfEn { get; set; }

        [Display(Name = "প্রযত্নে")]
        public string CareOfBn { get; set; }

        [Display(Name = "Blood Group")]
        //[DisplayFormat(NullDisplayText = "Unknown")]
        public string BloodGroup { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Editable(false)]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Passed")]
        public bool IsPassed { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Passing")]
        public DateTime DateOfPassing { get; set; }

        [Display(Name = "National ID")]
        public string NationalId { get; set; }

        [Display(Name = "Relatives")]
        public List<Relative> Relatives { get; set; }
        #endregion

        #region Contacts
        [Display(Name = "Present Address")]
        [DataType(DataType.MultilineText)]
        public string PresentAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }

        [Display(Name = "Mobile Number")]
        [Phone(ErrorMessage = "Please enter a valid mobile number.")]
        public string Mobile { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } 
        #endregion

        #region Present Address
        [Display(Name = "Village")]
        public string VillageEn { get; set; }

        [Display(Name = "গ্রাম")]
        public string VillageBn { get; set; }

        [Display(Name = "Post Office")]
        public string PostOfficeEn { get; set; }

        [Display(Name = "পোষ্ট অফিস")]
        public string PostOfficeBn { get; set; }

        [Display(Name = "Police Station")]
        public string PoliceStationEn { get; set; }

        [Display(Name = "থানা")]
        public string PoliceStationBn { get; set; }

        [Display(Name = "District")]
        public string DistrictEn { get; set; }

        [Display(Name = "জেলা")]
        public string DistrictBn { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } 
        #endregion

        #region Membership Information
        [Display(Name = "Form Id")]
        public string FormId { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Membership")]
        public DateTime DateOfMembership { get; set; }

        [Display(Name = "Inactive")]
        public bool IsInactive { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date from Inactive")]
        public DateTime DateFromInactive { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start date of Account")]
        public DateTime StartDateOfAccount { get; set; }

        [Display(Name = "Referral")]
        public string ReferralName { get; set; }
        public string ReferralId { get; set; }

        [Display(Name = "Zone")]
        public int ZoneId { get; set; }
        public virtual Zone Zone { get; set; }
        #endregion

        #region Misc Information
        [Display(Name = "Educational Qualification")]
        public string EducationalQualification { get; set; }

        [Display(Name = "Relegion")]
        public string Relegion { get; set; }

        [Display(Name = "Sub Relegion")]
        public string SubRelegion { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Profession")]
        public string Profession { get; set; }

        [Display(Name = "Experience")]
        public string Experience { get; set; }

        [Display(Name = "Monthly Income")]
        public int MonthlyIncome { get; set; }

        [Display(Name = "Monthly Expense")]
        public int MonthlyExpense { get; set; }

        [Display(Name = "Number of dependent Family Members")]
        public int NoOfFamilyMembers { get; set; }

        [Display(Name = "Financial Status")]
        public int FinancialStatus { get; set; } 
        #endregion

        #region Online Account Info
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "required")]
        [MinLength(4, ErrorMessage = "Min: 4")]
        [MaxLength(8, ErrorMessage = "Max: 8")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "required")]
        [MinLength(4, ErrorMessage = "Min: 4")]
        [MaxLength(8, ErrorMessage = "Max: 8")]
        public string PasswordHash { get; set; } 
        #endregion

        #region Application Internal Information
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastDateOfTransaction { get; set; }

        public string LastUpdateBy { get; set; }
        public int LastUpdateById { get; set; } 
        #endregion

        public string SignatureFileName { get; set; }

        //[NotMapped]
    }
}