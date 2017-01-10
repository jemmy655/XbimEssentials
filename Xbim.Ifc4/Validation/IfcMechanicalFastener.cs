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
namespace Xbim.Ifc4.SharedComponentElements
{
	public partial class IfcMechanicalFastener : IExpressValidatable
	{

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcMechanicalFastener clause) {
			var retVal = false;
			if (clause == Where.IfcMechanicalFastener.CorrectPredefinedType) {
				try {
					retVal = !(EXISTS(PredefinedType)) || (PredefinedType != IfcMechanicalFastenerTypeEnum.USERDEFINED) || ((PredefinedType == IfcMechanicalFastenerTypeEnum.USERDEFINED) && EXISTS(this/* as IfcObject*/.ObjectType));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.SharedComponentElements.IfcMechanicalFastener");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcMechanicalFastener.CorrectPredefinedType' for #{0}.",EntityLabel), ex);
				}
				return retVal;
			}
			if (clause == Where.IfcMechanicalFastener.CorrectTypeAssigned) {
				try {
					retVal = (SIZEOF(IsTypedBy) == 0) || (TYPEOF(this/* as IfcObject*/.IsTypedBy.ItemAt(0).RelatingType).Contains("IFC4.IFCMECHANICALFASTENERTYPE"));
				} catch (Exception ex) {
					ILog Log = LogManager.GetLogger("Xbim.Ifc4.SharedComponentElements.IfcMechanicalFastener");
					Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcMechanicalFastener.CorrectTypeAssigned' for #{0}.",EntityLabel), ex);
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
			if (!ValidateClause(Where.IfcMechanicalFastener.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcMechanicalFastener.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(Where.IfcMechanicalFastener.CorrectTypeAssigned))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcMechanicalFastener.CorrectTypeAssigned", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcMechanicalFastener : IfcProduct
	{
		public static readonly IfcMechanicalFastener CorrectPredefinedType = new IfcMechanicalFastener();
		public static readonly IfcMechanicalFastener CorrectTypeAssigned = new IfcMechanicalFastener();
		protected IfcMechanicalFastener() {}
	}
}
