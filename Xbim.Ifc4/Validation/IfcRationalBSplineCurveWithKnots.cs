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
namespace Xbim.Ifc4.GeometryResource
{
	public partial class IfcRationalBSplineCurveWithKnots : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRationalBSplineCurveWithKnots clause) {
			var retVal = false;
			if (clause == Where.IfcRationalBSplineCurveWithKnots.SameNumOfWeightsAndPoints) {
				try {
					retVal = SIZEOF(WeightsData) == SIZEOF(this/* as IfcBSplineCurve*/.ControlPointsList);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometryResource.IfcRationalBSplineCurveWithKnots");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRationalBSplineCurveWithKnots.SameNumOfWeightsAndPoints' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcRationalBSplineCurveWithKnots.WeightsGreaterZero) {
				try {
					retVal = IfcCurveWeightsPositive(this);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometryResource.IfcRationalBSplineCurveWithKnots");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRationalBSplineCurveWithKnots.WeightsGreaterZero' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcBSplineCurveWithKnots)clause);
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcRationalBSplineCurveWithKnots.SameNumOfWeightsAndPoints))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBSplineCurveWithKnots.SameNumOfWeightsAndPoints", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcRationalBSplineCurveWithKnots.WeightsGreaterZero))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBSplineCurveWithKnots.WeightsGreaterZero", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots
	{
		public static readonly IfcRationalBSplineCurveWithKnots SameNumOfWeightsAndPoints = new IfcRationalBSplineCurveWithKnots();
		public static readonly IfcRationalBSplineCurveWithKnots WeightsGreaterZero = new IfcRationalBSplineCurveWithKnots();
		protected IfcRationalBSplineCurveWithKnots() {}
	}
}
