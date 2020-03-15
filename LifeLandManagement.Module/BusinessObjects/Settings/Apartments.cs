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
  [DefaultProperty("ApartmentName")]
  
  public class Apartments : XPObject
  { 
    public Apartments(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    ApartmentTypes _apartmentTypes;
    Buildings _buildingName;
    int _radiators;
    int _parkingLot;
    decimal _landShare;
    decimal _netSquareMeters;
    decimal _grossSquareMeters;
    int _apartmentNo;

    
    public ApartmentTypes ApartmentTypes
    {
      get => _apartmentTypes;
      set => SetPropertyValue(nameof(ApartmentTypes), ref _apartmentTypes, value);
    }
    
    public Buildings BuildingName
    {
      get => _buildingName;
      set => SetPropertyValue(nameof(BuildingName), ref _buildingName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public int ApartmentNo
    {
      get => _apartmentNo;
      set => SetPropertyValue(nameof(ApartmentNo), ref _apartmentNo, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public decimal GrossSquareMeters
    {
      get => _grossSquareMeters;
      set => SetPropertyValue(nameof(GrossSquareMeters), ref _grossSquareMeters, value);
    }


    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public decimal NetSquareMeters
    {
      get => _netSquareMeters;
      set => SetPropertyValue(nameof(NetSquareMeters), ref _netSquareMeters, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public decimal LandShare
    {
      get => _landShare;
      set => SetPropertyValue(nameof(LandShare), ref _landShare, value);
    }

    public int ParkingLot
    {
      get => _parkingLot;
      set => SetPropertyValue(nameof(ParkingLot), ref _parkingLot, value);
    }

    public int Radiators
    {
      get => _radiators;
      set => SetPropertyValue(nameof(Radiators), ref _radiators, value);
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