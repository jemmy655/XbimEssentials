// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedMgmtElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcActionRequest
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcActionRequest : IIfcControl
	{
		IfcActionRequestTypeEnum? @PredefinedType { get; }
		IfcLabel? @Status { get; }
		IfcText? @LongDescription { get; }
	
	}
}

namespace Xbim.Ifc4.SharedMgmtElements
{
	[ExpressType("IfcActionRequest", 397)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcActionRequest : IfcControl, IInstantiableEntity, IIfcActionRequest, IEqualityComparer<@IfcActionRequest>, IEquatable<@IfcActionRequest>
	{
		#region IIfcActionRequest explicit implementation
		IfcActionRequestTypeEnum? IIfcActionRequest.PredefinedType { get { return @PredefinedType; } }	
		IfcLabel? IIfcActionRequest.Status { get { return @Status; } }	
		IfcText? IIfcActionRequest.LongDescription { get { return @LongDescription; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcActionRequest(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActionRequestTypeEnum? _predefinedType;
		private IfcLabel? _status;
		private IfcText? _longDescription;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcActionRequestTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _status;
				((IPersistEntity)this).Activate(false);
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcText? @LongDescription 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longDescription;
				((IPersistEntity)this).Activate(false);
				return _longDescription;
			} 
			set
			{
				SetValue( v =>  _longDescription = v, _longDescription, value,  "LongDescription");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _predefinedType = (IfcActionRequestTypeEnum) System.Enum.Parse(typeof (IfcActionRequestTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_status = value.StringVal;
					return;
				case 8: 
					_longDescription = value.StringVal;
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
        public bool Equals(@IfcActionRequest other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcActionRequest
            var root = (@IfcActionRequest)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcActionRequest left, @IfcActionRequest right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcActionRequest left, @IfcActionRequest right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcActionRequest x, @IfcActionRequest y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcActionRequest obj)
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