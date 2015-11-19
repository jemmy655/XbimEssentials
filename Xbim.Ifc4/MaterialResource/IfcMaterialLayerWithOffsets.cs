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
using Xbim.Ifc4.MaterialResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialLayerWithOffsets
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialLayerWithOffsets : IIfcMaterialLayer
	{
		IfcLayerSetDirectionEnum @OffsetDirection { get; }
		IEnumerable<IfcLengthMeasure> @OffsetValues { get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialLayerWithOffsets", 758)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayerWithOffsets : IfcMaterialLayer, IInstantiableEntity, IIfcMaterialLayerWithOffsets, IEqualityComparer<@IfcMaterialLayerWithOffsets>, IEquatable<@IfcMaterialLayerWithOffsets>
	{
		#region IIfcMaterialLayerWithOffsets explicit implementation
		IfcLayerSetDirectionEnum IIfcMaterialLayerWithOffsets.OffsetDirection { get { return @OffsetDirection; } }	
		IEnumerable<IfcLengthMeasure> IIfcMaterialLayerWithOffsets.OffsetValues { get { return @OffsetValues; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayerWithOffsets(IModel model) : base(model) 		{ 
			Model = model; 
			_offsetValues = new ItemSet<IfcLengthMeasure>( this, 2 );
		}

		#region Explicit attribute fields
		private IfcLayerSetDirectionEnum _offsetDirection;
		private ItemSet<IfcLengthMeasure> _offsetValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 12)]
		public IfcLayerSetDirectionEnum @OffsetDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _offsetDirection;
				((IPersistEntity)this).Activate(false);
				return _offsetDirection;
			} 
			set
			{
				SetValue( v =>  _offsetDirection = v, _offsetDirection, value,  "OffsetDirection");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Array, EntityAttributeType.None, 1, 2, 13)]
		public ItemSet<IfcLengthMeasure> @OffsetValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _offsetValues;
				((IPersistEntity)this).Activate(false);
				return _offsetValues;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
                    _offsetDirection = (IfcLayerSetDirectionEnum) System.Enum.Parse(typeof (IfcLayerSetDirectionEnum), value.EnumVal, true);
					return;
				case 8: 
					if (_offsetValues == null) _offsetValues = new ItemSet<IfcLengthMeasure>( this );
					_offsetValues.InternalAdd(value.RealVal);
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
        public bool Equals(@IfcMaterialLayerWithOffsets other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialLayerWithOffsets
            var root = (@IfcMaterialLayerWithOffsets)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialLayerWithOffsets left, @IfcMaterialLayerWithOffsets right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialLayerWithOffsets left, @IfcMaterialLayerWithOffsets right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialLayerWithOffsets x, @IfcMaterialLayerWithOffsets y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialLayerWithOffsets obj)
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