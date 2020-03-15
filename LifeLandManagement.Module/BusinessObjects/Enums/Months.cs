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
  [DefaultProperty("MonthName")]
  
  public class Months : XPObject
  { 
    public Months(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }


    string _monthName;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string MonthName
    {
      get => _monthName;
      set => SetPropertyValue(nameof(MonthName), ref _monthName, value);
    }
  }
}