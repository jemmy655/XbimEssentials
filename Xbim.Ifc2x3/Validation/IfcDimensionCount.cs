using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial struct IfcDimensionCount : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcDimensionCount clause) {
			var retVal = false;
			if (clause == Where.IfcDimensionCount.WR1) {
				try {
					retVal = ((0 < this) && (this <= 3) );
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.GeometryResource.IfcDimensionCount");
					Log.Error("Exception thrown evaluating where-clause 'IfcDimensionCount.WR1'.", ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public  IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcDimensionCount.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDimensionCount.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcDimensionCount
	{
		public static readonly IfcDimensionCount WR1 = new IfcDimensionCount();
		protected IfcDimensionCount() {}
	}
}
