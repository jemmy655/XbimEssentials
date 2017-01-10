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
namespace Xbim.Ifc4.GeometricModelResource
{
	public partial class IfcGeometricSet : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcGeometricSet clause) {
			var retVal = false;
			if (clause == Where.IfcGeometricSet.ConsistentDim) {
				try {
					retVal = SIZEOF(Elements.Where(Temp => Temp.Dim != Elements.ItemAt(0).Dim)) == 0;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometricModelResource.IfcGeometricSet");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcGeometricSet.ConsistentDim' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcGeometricSet.ConsistentDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcGeometricSet.ConsistentDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcGeometricSet
	{
		public static readonly IfcGeometricSet ConsistentDim = new IfcGeometricSet();
		protected IfcGeometricSet() {}
	}
}
