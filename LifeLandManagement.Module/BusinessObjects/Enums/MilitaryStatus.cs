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
  [DefaultProperty("Status")]
  
  public class MilitaryStatus : XPObject
  { 
    public MilitaryStatus(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();  
    }

    string _status;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Status
    {
      get => _status;
      set => SetPropertyValue(nameof(Status), ref _status, value);
    }
  }
}