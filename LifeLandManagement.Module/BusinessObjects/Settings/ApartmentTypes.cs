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

namespace LifeLandManagement.Module.BusinessObjects
{
  [DefaultClassOptions]
  [DefaultProperty("ApartmentType")]

  public class ApartmentTypes : XPObject
  { 
    public ApartmentTypes(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    string _apartmentType;
    


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ApartmentType
    {
      get => _apartmentType;
      set => SetPropertyValue(nameof(ApartmentType), ref _apartmentType, value);
    }

  }
}