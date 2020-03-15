using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using LifeLandManagement.Module.BusinessObjects.Enums;

namespace LifeLandManagement.Module.BusinessObjects.Account
{
  [DefaultClassOptions]
  [DefaultProperty("StaffName")]
  
  public class Staffs : XPObject
  { 
    public Staffs(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    SalaryTypes _salaryTypes;
    StaffTypes _staffTypes;
    MilitaryStatus _militaryStatus;
    MaritalStatus _maritalStatus;
    EducationStatus _educationStatus;
    Counties _counties;
    Provinces _provinces;
    int _socialInsurance;
    int _children;
    decimal _staffSalary;
    string _emergencyContactPhone;
    string _emergencyContactRelation;
    string _emergencyCallContactName;
    string _address;
    string _email;
    string _phoneOther;
    int _staffIdentity;
    string _phoneGsm;
    string _staffDuty;
    string _staffSurname;
    string _staffName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string StaffName
    {
      get => _staffName;
      set => SetPropertyValue(nameof(StaffName), ref _staffName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string StaffSurname
    {
      get => _staffSurname;
      set => SetPropertyValue(nameof(StaffSurname), ref _staffSurname, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string StaffDuty
    {
      get => _staffDuty;
      set => SetPropertyValue(nameof(StaffDuty), ref _staffDuty, value);
    }

    public int StaffIdentity
    {
      get => _staffIdentity;
      set => SetPropertyValue(nameof(StaffIdentity), ref _staffIdentity, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string PhoneGsm
    {
      get => _phoneGsm;
      set => SetPropertyValue(nameof(PhoneGsm), ref _phoneGsm, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string PhoneOther
    {
      get => _phoneOther;
      set => SetPropertyValue(nameof(PhoneOther), ref _phoneOther, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Email
    {
      get => _email;
      set => SetPropertyValue(nameof(Email), ref _email, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Address
    {
      get => _address;
      set => SetPropertyValue(nameof(Address), ref _address, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string EmergencyCallContactName
    {
      get => _emergencyCallContactName;
      set => SetPropertyValue(nameof(EmergencyCallContactName), ref _emergencyCallContactName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string EmergencyContactRelation
    {
      get => _emergencyContactRelation;
      set => SetPropertyValue(nameof(EmergencyContactRelation), ref _emergencyContactRelation, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string EmergencyContactPhone
    {
      get => _emergencyContactPhone;
      set => SetPropertyValue(nameof(EmergencyContactPhone), ref _emergencyContactPhone, value);
    }

    public decimal StaffSalary
    {
      get => _staffSalary;
      set => SetPropertyValue(nameof(StaffSalary), ref _staffSalary, value);
    }

    public int Children
    {
      get => _children;
      set => SetPropertyValue(nameof(Children), ref _children, value);
    }

    public int SocialInsurance
    {
      get => _socialInsurance;
      set => SetPropertyValue(nameof(SocialInsurance), ref _socialInsurance, value);
    }


    public Provinces Provinces
    {
      get => _provinces;
      set => SetPropertyValue(nameof(Provinces), ref _provinces, value);
    }

    public Counties Counties
    {
      get => _counties;
      set => SetPropertyValue(nameof(Counties), ref _counties, value);
    }

    public EducationStatus EducationStatus
    {
      get => _educationStatus;
      set => SetPropertyValue(nameof(EducationStatus), ref _educationStatus, value);
    }

    public MaritalStatus MaritalStatus
    {
      get => _maritalStatus;
      set => SetPropertyValue(nameof(MaritalStatus), ref _maritalStatus, value);
    }

    public MilitaryStatus MilitaryStatus
    {
      get => _militaryStatus;
      set => SetPropertyValue(nameof(MilitaryStatus), ref _militaryStatus, value);
    }

    public StaffTypes StaffTypes
    {
      get => _staffTypes;
      set => SetPropertyValue(nameof(StaffTypes), ref _staffTypes, value);
    }
    
    public SalaryTypes SalaryTypes
    {
      get => _salaryTypes;
      set => SetPropertyValue(nameof(SalaryTypes), ref _salaryTypes, value);
    }
   
  }
}