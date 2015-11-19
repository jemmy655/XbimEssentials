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
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSymbolStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSymbolStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IIfcSymbolStyleSelect @StyleOfSymbol { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcSymbolStyle", 729)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSymbolStyle : IfcPresentationStyle, IInstantiableEntity, IIfcSymbolStyle, IEqualityComparer<@IfcSymbolStyle>, IEquatable<@IfcSymbolStyle>
	{
		#region IIfcSymbolStyle explicit implementation
		IIfcSymbolStyleSelect IIfcSymbolStyle.StyleOfSymbol { get { return @StyleOfSymbol; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSymbolStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSymbolStyleSelect _styleOfSymbol;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcSymbolStyleSelect @StyleOfSymbol 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _styleOfSymbol;
				((IPersistEntity)this).Activate(false);
				return _styleOfSymbol;
			} 
			set
			{
				SetValue( v =>  _styleOfSymbol = v, _styleOfSymbol, value,  "StyleOfSymbol");
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
					_styleOfSymbol = (IfcSymbolStyleSelect)(value.EntityVal);
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
        public bool Equals(@IfcSymbolStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSymbolStyle
            var root = (@IfcSymbolStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSymbolStyle left, @IfcSymbolStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSymbolStyle left, @IfcSymbolStyle right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSymbolStyle x, @IfcSymbolStyle y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSymbolStyle obj)
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