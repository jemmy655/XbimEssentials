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
namespace Xbim.Ifc4.PropertyResource
{
	public partial class IfcPropertyEnumeratedValue : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcPropertyEnumeratedValue clause) {
			var retVal = false;
			if (clause == Where.IfcPropertyEnumeratedValue.WR21) {
				try {
					retVal = !(EXISTS(EnumerationReference)) || !(EXISTS(EnumerationValues)) || (SIZEOF(EnumerationValues.Where(temp => EnumerationReference.EnumerationValues.Contains(temp))) == SIZEOF(EnumerationValues));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.PropertyResource.IfcPropertyEnumeratedValue");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPropertyEnumeratedValue.WR21' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcPropertyEnumeratedValue.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPropertyEnumeratedValue.WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcPropertyEnumeratedValue
	{
		public static readonly IfcPropertyEnumeratedValue WR21 = new IfcPropertyEnumeratedValue();
		protected IfcPropertyEnumeratedValue() {}
	}
}
