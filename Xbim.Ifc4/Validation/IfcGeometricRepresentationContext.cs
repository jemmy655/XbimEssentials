using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.RepresentationResource
{
	public partial class IfcGeometricRepresentationContext : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcGeometricRepresentationContext clause) {
			var retVal = false;
			if (clause == Where.IfcGeometricRepresentationContext.North2D) {
				try {
					retVal = !(EXISTS(TrueNorth)) || (HIINDEX(TrueNorth.DirectionRatios) == 2);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.RepresentationResource.IfcGeometricRepresentationContext");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcGeometricRepresentationContext.North2D' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcGeometricRepresentationContext.North2D))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeometricRepresentationContext.North2D", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcGeometricRepresentationContext
	{
		public static readonly IfcGeometricRepresentationContext North2D = new IfcGeometricRepresentationContext();
		protected IfcGeometricRepresentationContext() {}
	}
}
