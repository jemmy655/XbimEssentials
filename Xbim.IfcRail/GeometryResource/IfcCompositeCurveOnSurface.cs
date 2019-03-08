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
using Xbim.IfcRail.GeometryResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.GeometryResource
{
	[ExpressType("IfcCompositeCurveOnSurface", 1130)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurveOnSurface : IfcCompositeCurve, IInstantiableEntity, IfcCurveOnSurface, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcCompositeCurveOnSurface>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurveOnSurface(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}



		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 0)]
		public List<IfcSurface> @BasisSurface 
		{
			get 
			{
				//## Getter for BasisSurface
			    return IfcGetBasisSurface(this).ToList();
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeCurveOnSurface other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Segments)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Segments)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
        private static IEnumerable<IfcSurface> IfcGetBasisSurface(IfcCurveOnSurface curveOnSurface)
        {
            var pc = curveOnSurface as IfcPcurve;
            if (pc != null)
            {
                yield return pc.BasisSurface;
                yield break;
            }

            var ccos = curveOnSurface as IfcCompositeCurveOnSurface;
            if (ccos == null)
                yield break;

            foreach (var segment in ccos.Segments)
            {
                var curve = segment.ParentCurve as IfcCurveOnSurface;
                if (curve == null) continue;
                foreach (var surface in IfcGetBasisSurface(curve))
                {
                    yield return surface;
                }
            }
        }
  
		//##
		#endregion
	}
}