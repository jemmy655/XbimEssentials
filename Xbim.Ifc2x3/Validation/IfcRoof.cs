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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class IfcRoof : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcRoof clause) {
			var retVal = false;
			if (clause == Where.IfcRoof.WR1) {
				try {
					retVal = (HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) == 0) || ((HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) == 1) && (!(EXISTS(this/* as IfcProduct*/.Representation))));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.SharedBldgElements.IfcRoof");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcRoof.WR1' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			return base.ValidateClause((Where.IfcProduct)clause);
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(Where.IfcRoof.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRoof.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcRoof : IfcProduct
	{
		public new static readonly IfcRoof WR1 = new IfcRoof();
		protected IfcRoof() {}
	}
}
