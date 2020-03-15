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
using LifeLandManagement.Module.BusinessObjects.Settings;
using LifeLandManagement.Module.BusinessObjects.Enums;

namespace LifeLandManagement.Module.BusinessObjects.Account
{
  [DefaultClassOptions]
  [DefaultProperty("MemberName")]
  
  public class Members : XPObject
  { 
    public Members(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }


    DuesGroup _duesGroup;
    Buildings _buildingName;
    Apartments _apartments;
    MemberTypes _memberTypes;
    Genders _genders;
    MaritalStatus _maritalStatus;
    EducationStatus _educationStatus;
    BloodTypes _bloodType;
    int _floor;
    DateTime _movingDate;
    string _profession;
    string _email;
    string _phoneOther;
    string _phoneGsm;
    DateTime _memberBirthDate;
    int _memberPersonalId;
    string _memberSurname;
    string _memberName;


    public MemberTypes MemberTypes
    {
      get => _memberTypes;
      set => SetPropertyValue(nameof(MemberTypes), ref _memberTypes, value);
    }

    [Association]
    public Apartments Apartments
    {
      get => _apartments;
      set => SetPropertyValue(nameof(Apartments), ref _apartments, value);
    }

    [Association]
    public Buildings BuildingName
    {
      get => _buildingName;
      set => SetPropertyValue(nameof(BuildingName), ref _buildingName, value);
    }

    [Association]
    public DuesGroup DuesGroup
    {
      get => _duesGroup;
      set => SetPropertyValue(nameof(DuesGroup), ref _duesGroup, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string MemberName
    {
      get => _memberName;
      set => SetPropertyValue(nameof(MemberName), ref _memberName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string MemberSurname
    {
      get => _memberSurname;
      set => SetPropertyValue(nameof(MemberSurname), ref _memberSurname, value);
    }

    public Genders Genders
    {
      get => _genders;
      set => SetPropertyValue(nameof(Genders), ref _genders, value);
    }

    public int MemberPersonalId
    {
      get => _memberPersonalId;
      set => SetPropertyValue(nameof(MemberPersonalId), ref _memberPersonalId, value);
    }

    public DateTime MemberBirthDate
    {
      get => _memberBirthDate;
      set => SetPropertyValue(nameof(MemberBirthDate), ref _memberBirthDate, value);
    }

    public BloodTypes BloodType
    {
      get => _bloodType;
      set => SetPropertyValue(nameof(BloodType), ref _bloodType, value);
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
    public string Profession
    {
      get => _profession;
      set => SetPropertyValue(nameof(Profession), ref _profession, value);
    }

    public int Floor
    {
      get => _floor;
      set => SetPropertyValue(nameof(Floor), ref _floor, value);
    }

    public DateTime MovingDate
    {
      get => _movingDate;
      set => SetPropertyValue(nameof(MovingDate), ref _movingDate, value);
    }
  }
}