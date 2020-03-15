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
  [DefaultProperty("Education")]
  
  public class EducationStatus : XPObject
  { 
    public EducationStatus(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
    }

    string _education;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Education
    {
      get => _education;
      set => SetPropertyValue(nameof(Education), ref _education, value);
    }
  }
}