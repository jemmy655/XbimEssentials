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
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveBoundedSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveBoundedSurface : IIfcBoundedSurface
	{
		IIfcSurface @BasisSurface { get; }
		IEnumerable<IIfcBoundaryCurve> @Boundaries { get; }
		IfcBoolean @ImplicitOuter { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCurveBoundedSurface", 559)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveBoundedSurface : IfcBoundedSurface, IInstantiableEntity, IIfcCurveBoundedSurface, IEqualityComparer<@IfcCurveBoundedSurface>, IEquatable<@IfcCurveBoundedSurface>
	{
		#region IIfcCurveBoundedSurface explicit implementation
		IIfcSurface IIfcCurveBoundedSurface.BasisSurface { get { return @BasisSurface; } }	
		IEnumerable<IIfcBoundaryCurve> IIfcCurveBoundedSurface.Boundaries { get { return @Boundaries; } }	
		IfcBoolean IIfcCurveBoundedSurface.ImplicitOuter { get { return @ImplicitOuter; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedSurface(IModel model) : base(model) 		{ 
			Model = model; 
			_boundaries = new ItemSet<IfcBoundaryCurve>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcSurface _basisSurface;
		private ItemSet<IfcBoundaryCurve> _boundaries;
		private IfcBoolean _implicitOuter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcSurface @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 4)]
		public ItemSet<IfcBoundaryCurve> @Boundaries 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boundaries;
				((IPersistEntity)this).Activate(false);
				return _boundaries;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcBoolean @ImplicitOuter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _implicitOuter;
				((IPersistEntity)this).Activate(false);
				return _implicitOuter;
			} 
			set
			{
				SetValue( v =>  _implicitOuter = v, _implicitOuter, value,  "ImplicitOuter");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					if (_boundaries == null) _boundaries = new ItemSet<IfcBoundaryCurve>( this );
					_boundaries.InternalAdd((IfcBoundaryCurve)value.EntityVal);
					return;
				case 2: 
					_implicitOuter = value.BooleanVal;
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
        public bool Equals(@IfcCurveBoundedSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurveBoundedSurface
            var root = (@IfcCurveBoundedSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurveBoundedSurface left, @IfcCurveBoundedSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveBoundedSurface left, @IfcCurveBoundedSurface right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCurveBoundedSurface x, @IfcCurveBoundedSurface y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCurveBoundedSurface obj)
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