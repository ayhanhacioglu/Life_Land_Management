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
  [DefaultProperty("AssetName")]
 
  public class Assets : XPObject
  { 
    public Assets(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
    }


    Staffs _debtTo;
    Suppliers _supplierName;
    decimal _price;
    string _purchaserName;
    DateTime _purchasingDate;
    string _description;
    string _assetName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string AssetName
    {
      get => _assetName;
      set => SetPropertyValue(nameof(AssetName), ref _assetName, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string Description
    {
      get => _description;
      set => SetPropertyValue(nameof(Description), ref _description, value);
    }

    public Suppliers SupplierName
    {
      get => _supplierName;
      set => SetPropertyValue(nameof(SupplierName), ref _supplierName, value);
    }

    public DateTime PurchasingDate
    {
      get => _purchasingDate;
      set => SetPropertyValue(nameof(PurchasingDate), ref _purchasingDate, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string PurchaserName
    {
      get => _purchaserName;
      set => SetPropertyValue(nameof(PurchaserName), ref _purchaserName, value);
    }

    public decimal Price
    {
      get => _price;
      set => SetPropertyValue(nameof(Price), ref _price, value);
    }

    
    public Staffs DebtTo
    {
      get => _debtTo;
      set => SetPropertyValue(nameof(DebtTo), ref _debtTo, value);
    }

  }
}