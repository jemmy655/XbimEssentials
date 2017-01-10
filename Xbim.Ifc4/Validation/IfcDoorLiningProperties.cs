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
namespace Xbim.Ifc4.ArchitectureDomain
{
	public partial class IfcDoorLiningProperties : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcDoorLiningProperties clause) {
			var retVal = false;
			if (clause == Where.IfcDoorLiningProperties.WR31) {
				try {
					retVal = !(EXISTS(LiningDepth) && !(EXISTS(LiningThickness)));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.ArchitectureDomain.IfcDoorLiningProperties");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcDoorLiningProperties.WR31' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcDoorLiningProperties.WR32) {
				try {
					retVal = !(EXISTS(ThresholdDepth) && !(EXISTS(ThresholdThickness)));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.ArchitectureDomain.IfcDoorLiningProperties");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcDoorLiningProperties.WR32' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcDoorLiningProperties.WR33) {
				try {
					retVal = (EXISTS(TransomOffset) && EXISTS(TransomThickness)) ^ (!(EXISTS(TransomOffset)) && !(EXISTS(TransomThickness)));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.ArchitectureDomain.IfcDoorLiningProperties");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcDoorLiningProperties.WR33' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcDoorLiningProperties.WR34) {
				try {
					retVal = (EXISTS(CasingDepth) && EXISTS(CasingThickness)) ^ (!(EXISTS(CasingDepth)) && !(EXISTS(CasingThickness)));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.ArchitectureDomain.IfcDoorLiningProperties");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcDoorLiningProperties.WR34' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcDoorLiningProperties.WR35) {
				try {
					retVal = (EXISTS(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0))) && ((TYPEOF(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)).Contains("IFC4.IFCDOORTYPE")) || (TYPEOF(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)).Contains("IFC4.IFCDOORSTYLE")));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.ArchitectureDomain.IfcDoorLiningProperties");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcDoorLiningProperties.WR35' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			throw new ArgumentException(string.Format("Invalid clause specifier: '{0}'", clause));
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcDoorLiningProperties.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDoorLiningProperties.WR31", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcDoorLiningProperties.WR32))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDoorLiningProperties.WR32", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcDoorLiningProperties.WR33))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDoorLiningProperties.WR33", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcDoorLiningProperties.WR34))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDoorLiningProperties.WR34", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcDoorLiningProperties.WR35))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDoorLiningProperties.WR35", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcDoorLiningProperties
	{
		public static readonly IfcDoorLiningProperties WR31 = new IfcDoorLiningProperties();
		public static readonly IfcDoorLiningProperties WR32 = new IfcDoorLiningProperties();
		public static readonly IfcDoorLiningProperties WR33 = new IfcDoorLiningProperties();
		public static readonly IfcDoorLiningProperties WR34 = new IfcDoorLiningProperties();
		public static readonly IfcDoorLiningProperties WR35 = new IfcDoorLiningProperties();
		protected IfcDoorLiningProperties() {}
	}
}
