﻿using System;
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
  [DefaultProperty("CountyName")]
 
  public class Counties : XPObject
  { 
    public Counties(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    string _countyName;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CountyName
    {
      get => _countyName;
      set => SetPropertyValue(nameof(CountyName), ref _countyName, value);
    }
  }
}