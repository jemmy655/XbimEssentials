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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class IfcFillAreaStyle : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcFillAreaStyle clause) {
			var retVal = false;
			if (clause == Where.IfcFillAreaStyle.WR11) {
				try {
					retVal = SIZEOF(this.FillStyles.Where(Style => TYPEOF(Style).Contains("IFC2X3.IFCCOLOUR"))) <= 1;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.PresentationAppearanceResource.IfcFillAreaStyle");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcFillAreaStyle.WR11' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcFillAreaStyle.WR12) {
				try {
					retVal = SIZEOF(this.FillStyles.Where(Style => TYPEOF(Style).Contains("IFC2X3.IFCEXTERNALLYDEFINEDHATCHSTYLE"))) <= 1;
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.PresentationAppearanceResource.IfcFillAreaStyle");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcFillAreaStyle.WR12' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcFillAreaStyle.WR13) {
				try {
					retVal = IfcCorrectFillAreaStyle(this.FillStyles);
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.PresentationAppearanceResource.IfcFillAreaStyle");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcFillAreaStyle.WR13' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcFillAreaStyle.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFillAreaStyle.WR11", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcFillAreaStyle.WR12))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFillAreaStyle.WR12", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcFillAreaStyle.WR13))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFillAreaStyle.WR13", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.Where
{
	public class IfcFillAreaStyle
	{
		public static readonly IfcFillAreaStyle WR11 = new IfcFillAreaStyle();
		public static readonly IfcFillAreaStyle WR12 = new IfcFillAreaStyle();
		public static readonly IfcFillAreaStyle WR13 = new IfcFillAreaStyle();
		protected IfcFillAreaStyle() {}
	}
}
