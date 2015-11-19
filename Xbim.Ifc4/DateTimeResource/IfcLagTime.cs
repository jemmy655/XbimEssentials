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
using Xbim.Ifc4.DateTimeResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLagTime
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLagTime : IIfcSchedulingTime
	{
		IIfcTimeOrRatioSelect @LagValue { get; }
		IfcTaskDurationEnum @DurationType { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcLagTime", 728)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLagTime : IfcSchedulingTime, IInstantiableEntity, IIfcLagTime, IEqualityComparer<@IfcLagTime>, IEquatable<@IfcLagTime>
	{
		#region IIfcLagTime explicit implementation
		IIfcTimeOrRatioSelect IIfcLagTime.LagValue { get { return @LagValue; } }	
		IfcTaskDurationEnum IIfcLagTime.DurationType { get { return @DurationType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLagTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTimeOrRatioSelect _lagValue;
		private IfcTaskDurationEnum _durationType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcTimeOrRatioSelect @LagValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lagValue;
				((IPersistEntity)this).Activate(false);
				return _lagValue;
			} 
			set
			{
				SetValue( v =>  _lagValue = v, _lagValue, value,  "LagValue");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 5)]
		public IfcTaskDurationEnum @DurationType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _durationType;
				((IPersistEntity)this).Activate(false);
				return _durationType;
			} 
			set
			{
				SetValue( v =>  _durationType = v, _durationType, value,  "DurationType");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_lagValue = (IfcTimeOrRatioSelect)(value.EntityVal);
					return;
				case 4: 
                    _durationType = (IfcTaskDurationEnum) System.Enum.Parse(typeof (IfcTaskDurationEnum), value.EnumVal, true);
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
        public bool Equals(@IfcLagTime other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLagTime
            var root = (@IfcLagTime)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLagTime left, @IfcLagTime right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLagTime left, @IfcLagTime right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLagTime x, @IfcLagTime y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLagTime obj)
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