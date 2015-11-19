// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieComponent
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieComponent : ICobieAsset
	{
		string @SerialNumber { get; }
		DateTimeValue @InstallationDate { get; }
		DateTimeValue @WarrantyStartDate { get; }
		string @TagNumber { get; }
		string @BarCode { get; }
		string @AssetIdentifier { get; }
		ICobieType @Type { get; }
		ICobieSpace @Space { get; }
		IEnumerable<ICobieComponent> @AssemblyOf { get; }
		IEnumerable<ICobieSystem> @Systems {  get; }
		IEnumerable<ICobieConnection> @ConnectedBefore {  get; }
		IEnumerable<ICobieConnection> @ConnectedAfter {  get; }
		IEnumerable<ICobieConnection> @Connecting {  get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("Component", 24)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieComponent : CobieAsset, IInstantiableEntity, ICobieComponent, IEqualityComparer<@CobieComponent>, IEquatable<@CobieComponent>
	{
		#region ICobieComponent explicit implementation
		string ICobieComponent.SerialNumber { get { return @SerialNumber; } }	
		DateTimeValue ICobieComponent.InstallationDate { get { return @InstallationDate; } }	
		DateTimeValue ICobieComponent.WarrantyStartDate { get { return @WarrantyStartDate; } }	
		string ICobieComponent.TagNumber { get { return @TagNumber; } }	
		string ICobieComponent.BarCode { get { return @BarCode; } }	
		string ICobieComponent.AssetIdentifier { get { return @AssetIdentifier; } }	
		ICobieType ICobieComponent.Type { get { return @Type; } }	
		ICobieSpace ICobieComponent.Space { get { return @Space; } }	
		IEnumerable<ICobieComponent> ICobieComponent.AssemblyOf { get { return @AssemblyOf; } }	
		 
		IEnumerable<ICobieSystem> ICobieComponent.Systems {  get { return @Systems; } }
		IEnumerable<ICobieConnection> ICobieComponent.ConnectedBefore {  get { return @ConnectedBefore; } }
		IEnumerable<ICobieConnection> ICobieComponent.ConnectedAfter {  get { return @ConnectedAfter; } }
		IEnumerable<ICobieConnection> ICobieComponent.Connecting {  get { return @Connecting; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieComponent(IModel model) : base(model) 		{ 
			Model = model; 
			_assemblyOf = new ItemSet<CobieComponent>( this, 0 );
		}

		#region Explicit attribute fields
		private string _serialNumber;
		private DateTimeValue _installationDate;
		private DateTimeValue _warrantyStartDate;
		private string _tagNumber;
		private string _barCode;
		private string _assetIdentifier;
		private CobieType _type;
		private CobieSpace _space;
		private ItemSet<CobieComponent> _assemblyOf;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public string @SerialNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _serialNumber;
				((IPersistEntity)this).Activate(false);
				return _serialNumber;
			} 
			set
			{
				SetValue( v =>  _serialNumber = v, _serialNumber, value,  "SerialNumber");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public DateTimeValue @InstallationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _installationDate;
				((IPersistEntity)this).Activate(false);
				return _installationDate;
			} 
			set
			{
				SetValue( v =>  _installationDate = v, _installationDate, value,  "InstallationDate");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public DateTimeValue @WarrantyStartDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _warrantyStartDate;
				((IPersistEntity)this).Activate(false);
				return _warrantyStartDate;
			} 
			set
			{
				SetValue( v =>  _warrantyStartDate = v, _warrantyStartDate, value,  "WarrantyStartDate");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public string @TagNumber 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tagNumber;
				((IPersistEntity)this).Activate(false);
				return _tagNumber;
			} 
			set
			{
				SetValue( v =>  _tagNumber = v, _tagNumber, value,  "TagNumber");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public string @BarCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _barCode;
				((IPersistEntity)this).Activate(false);
				return _barCode;
			} 
			set
			{
				SetValue( v =>  _barCode = v, _barCode, value,  "BarCode");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 18)]
		public string @AssetIdentifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _assetIdentifier;
				((IPersistEntity)this).Activate(false);
				return _assetIdentifier;
			} 
			set
			{
				SetValue( v =>  _assetIdentifier = v, _assetIdentifier, value,  "AssetIdentifier");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(17, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public CobieType @Type 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _type;
				((IPersistEntity)this).Activate(false);
				return _type;
			} 
			set
			{
				SetValue( v =>  _type = v, _type, value,  "Type");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(18, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public CobieSpace @Space 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _space;
				((IPersistEntity)this).Activate(false);
				return _space;
			} 
			set
			{
				SetValue( v =>  _space = v, _space, value,  "Space");
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 21)]
		public ItemSet<CobieComponent> @AssemblyOf 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _assemblyOf;
				((IPersistEntity)this).Activate(false);
				return _assemblyOf;
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 22)]
		public IEnumerable<CobieSystem> @Systems 
		{ 
			get 
			{
				return Model.Instances.Where<CobieSystem>(e => e.Components != null &&  e.Components.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 23)]
		public IEnumerable<CobieConnection> @ConnectedBefore 
		{ 
			get 
			{
				return Model.Instances.Where<CobieConnection>(e => (e.ComponentA as CobieComponent) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 24)]
		public IEnumerable<CobieConnection> @ConnectedAfter 
		{ 
			get 
			{
				return Model.Instances.Where<CobieConnection>(e => (e.ComponentB as CobieComponent) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 25)]
		public IEnumerable<CobieConnection> @Connecting 
		{ 
			get 
			{
				return Model.Instances.Where<CobieConnection>(e => (e.RealizingComponent as CobieComponent) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					_serialNumber = value.StringVal;
					return;
				case 11: 
					_installationDate = value.StringVal;
					return;
				case 12: 
					_warrantyStartDate = value.StringVal;
					return;
				case 13: 
					_tagNumber = value.StringVal;
					return;
				case 14: 
					_barCode = value.StringVal;
					return;
				case 15: 
					_assetIdentifier = value.StringVal;
					return;
				case 16: 
					_type = (CobieType)(value.EntityVal);
					return;
				case 17: 
					_space = (CobieSpace)(value.EntityVal);
					return;
				case 18: 
					if (_assemblyOf == null) _assemblyOf = new ItemSet<CobieComponent>( this );
					_assemblyOf.InternalAdd((CobieComponent)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieComponent other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieComponent
            var root = (@CobieComponent)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieComponent left, @CobieComponent right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieComponent left, @CobieComponent right)
        {
            return !(left == right);
        }


        public bool Equals(@CobieComponent x, @CobieComponent y)
        {
            return x == y;
        }

        public int GetHashCode(@CobieComponent obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}