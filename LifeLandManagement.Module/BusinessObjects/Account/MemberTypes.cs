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

namespace LifeLandManagement.Module.BusinessObjects.Account
{
  [DefaultClassOptions]
  [DefaultProperty("MemberType")]
  
  public class MemberTypes : XPObject
  { 
    public MemberTypes(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }


    string _memberType;
    
    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string MemberType
    {
      get => _memberType;
      set => SetPropertyValue(nameof(MemberType), ref _memberType, value);
    }


  }
}