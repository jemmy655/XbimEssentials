// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralLoadResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBoundaryEdgeCondition
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBoundaryEdgeCondition : IIfcBoundaryCondition
	{
		IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthX { get; }
		IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthY { get; }
		IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthZ { get; }
		IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthX { get; }
		IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthY { get; }
		IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthZ { get; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IfcBoundaryEdgeCondition", 319)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundaryEdgeCondition : IfcBoundaryCondition, IInstantiableEntity, IIfcBoundaryEdgeCondition, IEqualityComparer<@IfcBoundaryEdgeCondition>, IEquatable<@IfcBoundaryEdgeCondition>
	{
		#region IIfcBoundaryEdgeCondition explicit implementation
		IfcModulusOfLinearSubgradeReactionMeasure? IIfcBoundaryEdgeCondition.LinearStiffnessByLengthX { get { return @LinearStiffnessByLengthX; } }	
		IfcModulusOfLinearSubgradeReactionMeasure? IIfcBoundaryEdgeCondition.LinearStiffnessByLengthY { get { return @LinearStiffnessByLengthY; } }	
		IfcModulusOfLinearSubgradeReactionMeasure? IIfcBoundaryEdgeCondition.LinearStiffnessByLengthZ { get { return @LinearStiffnessByLengthZ; } }	
		IfcModulusOfRotationalSubgradeReactionMeasure? IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthX { get { return @RotationalStiffnessByLengthX; } }	
		IfcModulusOfRotationalSubgradeReactionMeasure? IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthY { get { return @RotationalStiffnessByLengthY; } }	
		IfcModulusOfRotationalSubgradeReactionMeasure? IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthZ { get { return @RotationalStiffnessByLengthZ; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundaryEdgeCondition(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcModulusOfLinearSubgradeReactionMeasure? _linearStiffnessByLengthX;
		private IfcModulusOfLinearSubgradeReactionMeasure? _linearStiffnessByLengthY;
		private IfcModulusOfLinearSubgradeReactionMeasure? _linearStiffnessByLengthZ;
		private IfcModulusOfRotationalSubgradeReactionMeasure? _rotationalStiffnessByLengthX;
		private IfcModulusOfRotationalSubgradeReactionMeasure? _rotationalStiffnessByLengthY;
		private IfcModulusOfRotationalSubgradeReactionMeasure? _rotationalStiffnessByLengthZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _linearStiffnessByLengthX;
				((IPersistEntity)this).Activate(false);
				return _linearStiffnessByLengthX;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByLengthX = v, _linearStiffnessByLengthX, value,  "LinearStiffnessByLengthX");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _linearStiffnessByLengthY;
				((IPersistEntity)this).Activate(false);
				return _linearStiffnessByLengthY;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByLengthY = v, _linearStiffnessByLengthY, value,  "LinearStiffnessByLengthY");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcModulusOfLinearSubgradeReactionMeasure? @LinearStiffnessByLengthZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _linearStiffnessByLengthZ;
				((IPersistEntity)this).Activate(false);
				return _linearStiffnessByLengthZ;
			} 
			set
			{
				SetValue( v =>  _linearStiffnessByLengthZ = v, _linearStiffnessByLengthZ, value,  "LinearStiffnessByLengthZ");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalStiffnessByLengthX;
				((IPersistEntity)this).Activate(false);
				return _rotationalStiffnessByLengthX;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthX = v, _rotationalStiffnessByLengthX, value,  "RotationalStiffnessByLengthX");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalStiffnessByLengthY;
				((IPersistEntity)this).Activate(false);
				return _rotationalStiffnessByLengthY;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthY = v, _rotationalStiffnessByLengthY, value,  "RotationalStiffnessByLengthY");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcModulusOfRotationalSubgradeReactionMeasure? @RotationalStiffnessByLengthZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalStiffnessByLengthZ;
				((IPersistEntity)this).Activate(false);
				return _rotationalStiffnessByLengthZ;
			} 
			set
			{
				SetValue( v =>  _rotationalStiffnessByLengthZ = v, _rotationalStiffnessByLengthZ, value,  "RotationalStiffnessByLengthZ");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_linearStiffnessByLengthX = value.RealVal;
					return;
				case 2: 
					_linearStiffnessByLengthY = value.RealVal;
					return;
				case 3: 
					_linearStiffnessByLengthZ = value.RealVal;
					return;
				case 4: 
					_rotationalStiffnessByLengthX = value.RealVal;
					return;
				case 5: 
					_rotationalStiffnessByLengthY = value.RealVal;
					return;
				case 6: 
					_rotationalStiffnessByLengthZ = value.RealVal;
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
        public bool Equals(@IfcBoundaryEdgeCondition other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBoundaryEdgeCondition
            var root = (@IfcBoundaryEdgeCondition)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBoundaryEdgeCondition left, @IfcBoundaryEdgeCondition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBoundaryEdgeCondition left, @IfcBoundaryEdgeCondition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBoundaryEdgeCondition x, @IfcBoundaryEdgeCondition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBoundaryEdgeCondition obj)
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