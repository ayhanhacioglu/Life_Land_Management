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
  [DefaultProperty("ProvinceName")]
  
  public class Provinces : XPObject
  { 
    public Provinces(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    string _provinceName;
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ProvinceName
    {
      get => _provinceName;
      set => SetPropertyValue(nameof(ProvinceName), ref _provinceName, value);
    }

  }
}