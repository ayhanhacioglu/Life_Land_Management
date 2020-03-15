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
  [DefaultProperty("Gender")]
  
  public class Genders : XPObject
  { 
    public Genders(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }
    string _gender;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Gender
    {
      get => _gender;
      set => SetPropertyValue(nameof(Gender), ref _gender, value);
    }
  }
}