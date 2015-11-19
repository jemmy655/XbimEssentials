// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedComponentElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMechanicalFastener
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMechanicalFastener : IIfcElementComponent
	{
		IfcPositiveLengthMeasure? @NominalDiameter { get; }
		IfcPositiveLengthMeasure? @NominalLength { get; }
		IfcMechanicalFastenerTypeEnum? @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.SharedComponentElements
{
	[ExpressType("IfcMechanicalFastener", 769)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalFastener : IfcElementComponent, IInstantiableEntity, IIfcMechanicalFastener, IEqualityComparer<@IfcMechanicalFastener>, IEquatable<@IfcMechanicalFastener>
	{
		#region IIfcMechanicalFastener explicit implementation
		IfcPositiveLengthMeasure? IIfcMechanicalFastener.NominalDiameter { get { return @NominalDiameter; } }	
		IfcPositiveLengthMeasure? IIfcMechanicalFastener.NominalLength { get { return @NominalLength; } }	
		IfcMechanicalFastenerTypeEnum? IIfcMechanicalFastener.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalFastener(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcPositiveLengthMeasure? _nominalLength;
		private IfcMechanicalFastenerTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 33)]
		public IfcPositiveLengthMeasure? @NominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 34)]
		public IfcPositiveLengthMeasure? @NominalLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _nominalLength;
				((IPersistEntity)this).Activate(false);
				return _nominalLength;
			} 
			set
			{
				SetValue( v =>  _nominalLength = v, _nominalLength, value,  "NominalLength");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 35)]
		public IfcMechanicalFastenerTypeEnum? @PredefinedType 
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_nominalDiameter = value.RealVal;
					return;
				case 9: 
					_nominalLength = value.RealVal;
					return;
				case 10: 
                    _predefinedType = (IfcMechanicalFastenerTypeEnum) System.Enum.Parse(typeof (IfcMechanicalFastenerTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:((PredefinedType = IfcMechanicalFastenerTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:('IFC4.IFCMECHANICALFASTENERTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMechanicalFastener other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMechanicalFastener
            var root = (@IfcMechanicalFastener)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMechanicalFastener left, @IfcMechanicalFastener right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMechanicalFastener left, @IfcMechanicalFastener right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMechanicalFastener x, @IfcMechanicalFastener y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMechanicalFastener obj)
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