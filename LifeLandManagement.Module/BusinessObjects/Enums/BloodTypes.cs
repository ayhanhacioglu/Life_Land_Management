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
using LifeLandManagement.Module.BusinessObjects.Account;

namespace LifeLandManagement.Module.BusinessObjects.Enums
{
  [DefaultClassOptions]
  [DefaultProperty("BloodType")]
  
  public class BloodTypes : XPObject
  { 
    public BloodTypes(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    string _bloodType;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string BloodType
    {
      get => _bloodType;
      set => SetPropertyValue(nameof(BloodType), ref _bloodType, value);
    }
  }
}