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

namespace LifeLandManagement.Module.BusinessObjects.Enums
{
  [DefaultClassOptions]
  [DefaultProperty("Types")]
  
  public class SalaryTypes : XPObject
  { 
    public SalaryTypes(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    string _types;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Types
    {
      get => _types;
      set => SetPropertyValue(nameof(Types), ref _types, value);
    }
  }
}