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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAggregates
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAggregates : IIfcRelDecomposes
	{
		IIfcObjectDefinition @RelatingObject { get; }
		IEnumerable<IIfcObjectDefinition> @RelatedObjects { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelAggregates", 909)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAggregates : IfcRelDecomposes, IInstantiableEntity, IIfcRelAggregates, IEqualityComparer<@IfcRelAggregates>, IEquatable<@IfcRelAggregates>
	{
		#region IIfcRelAggregates explicit implementation
		IIfcObjectDefinition IIfcRelAggregates.RelatingObject { get { return @RelatingObject; } }	
		IEnumerable<IIfcObjectDefinition> IIfcRelAggregates.RelatedObjects { get { return @RelatedObjects; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAggregates(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcObjectDefinition _relatingObject;
		private ItemSet<IfcObjectDefinition> _relatedObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcObjectDefinition @RelatingObject 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingObject;
				((IPersistEntity)this).Activate(false);
				return _relatingObject;
			} 
			set
			{
				SetValue( v =>  _relatingObject = v, _relatingObject, value,  "RelatingObject");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 6)]
		public ItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedObjects;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingObject = (IfcObjectDefinition)(value.EntityVal);
					return;
				case 5: 
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObjectDefinition>( this );
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* RelatedObjects | RelatingObject :=: Temp)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAggregates other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAggregates
            var root = (@IfcRelAggregates)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAggregates left, @IfcRelAggregates right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAggregates left, @IfcRelAggregates right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAggregates x, @IfcRelAggregates y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAggregates obj)
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