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
  [DefaultProperty("SupplierName")]
  
  public class Suppliers : XPObject
  { 
    public Suppliers(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
     
    }


    Counties _counties;
    Provinces _provinces;
    SupplierTypes _supplierTypes;
    string _address;
    string _email;
    string _phoneOther;
    string _phoneGsm;
    string _duty;
    string _responsible;
    string _supplierName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string SupplierName
    {
      get => _supplierName;
      set => SetPropertyValue(nameof(SupplierName), ref _supplierName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Responsible
    {
      get => _responsible;
      set => SetPropertyValue(nameof(Responsible), ref _responsible, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Duty
    {
      get => _duty;
      set => SetPropertyValue(nameof(Duty), ref _duty, value);
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

    public SupplierTypes SupplierTypes
    {
      get => _supplierTypes;
      set => SetPropertyValue(nameof(SupplierTypes), ref _supplierTypes, value);
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
  }
}