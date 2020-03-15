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

namespace LifeLandManagement.Module.BusinessObjects
{
  [DefaultClassOptions]
  [DefaultProperty("BuildingName")]
 
  public class Buildings : XPObject
  { 
    public Buildings(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

   
    string _actualStatus;
    string _status;
    string _buildingName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string BuildingName
    {
      get => _buildingName;
      set => SetPropertyValue(nameof(BuildingName), ref _buildingName, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ActualStatus
    {
      get => _actualStatus;
      set => SetPropertyValue(nameof(ActualStatus), ref _actualStatus, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Status
    {
      get => _status;
      set => SetPropertyValue(nameof(Status), ref _status, value);
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