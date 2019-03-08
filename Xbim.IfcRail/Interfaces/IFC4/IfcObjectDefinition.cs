// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.IfcRail.Kernel
{
	public partial class @IfcObjectDefinition : IIfcObjectDefinition
	{
		IEnumerable<IIfcRelAssigns> IIfcObjectDefinition.HasAssignments 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssigns>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelNests> IIfcObjectDefinition.Nests 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelNests>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelNests> IIfcObjectDefinition.IsNestedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelNests>(e => (e.RelatingObject as IfcObjectDefinition) == this, "RelatingObject", this);
			} 
		}
		IEnumerable<IIfcRelDeclares> IIfcObjectDefinition.HasContext 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDeclares>(e => e.RelatedDefinitions != null &&  e.RelatedDefinitions.Contains(this), "RelatedDefinitions", this);
			} 
		}
		IEnumerable<IIfcRelAggregates> IIfcObjectDefinition.IsDecomposedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAggregates>(e => (e.RelatingObject as IfcObjectDefinition) == this, "RelatingObject", this);
			} 
		}
		IEnumerable<IIfcRelAggregates> IIfcObjectDefinition.Decomposes 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAggregates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelAssociates> IIfcObjectDefinition.HasAssociations 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
	//## Custom code
	//##
	}
}