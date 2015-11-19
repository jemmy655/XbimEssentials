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
using Xbim.Ifc4.TopologyResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOrientedEdge
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOrientedEdge : IIfcEdge
	{
		IIfcEdge @EdgeElement { get; }
		IfcBoolean @Orientation { get; }
	
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IfcOrientedEdge", 794)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrientedEdge : IfcEdge, IInstantiableEntity, IIfcOrientedEdge, IEqualityComparer<@IfcOrientedEdge>, IEquatable<@IfcOrientedEdge>
	{
		#region IIfcOrientedEdge explicit implementation
		IIfcEdge IIfcOrientedEdge.EdgeElement { get { return @EdgeElement; } }	
		IfcBoolean IIfcOrientedEdge.Orientation { get { return @Orientation; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrientedEdge(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEdge _edgeElement;
		private IfcBoolean _orientation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcEdge @EdgeElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edgeElement;
				((IPersistEntity)this).Activate(false);
				return _edgeElement;
			} 
			set
			{
				SetValue( v =>  _edgeElement = v, _edgeElement, value,  "EdgeElement");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcBoolean @Orientation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _orientation;
				((IPersistEntity)this).Activate(false);
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation");
			} 
		}	
		#endregion

		#region Overriding attributes
		[EntityAttribute(1, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public override IfcVertex @EdgeStart 
		{
			get 
			{
				//## Overriding derived attribute EdgeStart getter
			    return Orientation
			        ? EdgeElement.EdgeStart
			        : EdgeElement.EdgeEnd;

			    //##
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property EdgeStart in IfcOrientedEdge"); 
			}
		}
		[EntityAttribute(2, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public override IfcVertex @EdgeEnd 
		{
			get 
			{
				//## Overriding derived attribute EdgeEnd getter
                return Orientation
                    ? EdgeElement.EdgeEnd
                    : EdgeElement.EdgeStart;
				//##
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property EdgeEnd in IfcOrientedEdge"); 
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_edgeElement = (IfcEdge)(value.EntityVal);
					return;
				case 3: 
					_orientation = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*EdgeElementNotOriented:	EdgeElementNotOriented : NOT('IFC4.IFCORIENTEDEDGE' IN TYPEOF(EdgeElement));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOrientedEdge other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOrientedEdge
            var root = (@IfcOrientedEdge)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOrientedEdge left, @IfcOrientedEdge right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOrientedEdge left, @IfcOrientedEdge right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcOrientedEdge x, @IfcOrientedEdge y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcOrientedEdge obj)
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