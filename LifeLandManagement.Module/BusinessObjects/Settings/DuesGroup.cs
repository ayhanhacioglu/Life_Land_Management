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

namespace LifeLandManagement.Module.BusinessObjects.Settings
{
  [DefaultClassOptions]
  [DefaultProperty("GroupName")]
  
  public class DuesGroup : XPObject
  { 
    public DuesGroup(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
    }

    
    decimal _amount;
    string _groupName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string GroupName
    {
      get => _groupName;
      set => SetPropertyValue(nameof(GroupName), ref _groupName, value);
    }

    public decimal Amount
    {
      get => _amount;
      set => SetPropertyValue(nameof(Amount), ref _amount, value);
    }
    [Association]
    public XPCollection<Members> Members
    {
      get
      {
        return GetCollection<Members>(nameof(Members));
      }
    }
  }
}