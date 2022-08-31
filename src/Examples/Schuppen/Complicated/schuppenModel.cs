// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "schuppen.grg" on Wed Aug 31 15:46:43 CEST 2022

using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Diagnostics;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;
using GRGEN_EXPR = de.unika.ipd.grGen.expression;
using GRGEN_MODEL = de.unika.ipd.grGen.Model_schuppen;

namespace de.unika.ipd.grGen.Model_schuppen
{

	//
	// Enums
	//

	public enum ENUM_Size { @TALL = 0, @SMALL = 1, };

	public enum ENUM_Overhang { @BOTH = 0, @INSIDE = 1, @OUTSIDE = 2, };

	public enum ENUM_Filling { @BOX = 0, @WINDOW = 1, };

	public class Enums
	{
		public static GRGEN_LIBGR.EnumAttributeType @Size = new GRGEN_LIBGR.EnumAttributeType("Size", null, "Size", typeof(GRGEN_MODEL.ENUM_Size), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "TALL"),
			new GRGEN_LIBGR.EnumMember(1, "SMALL"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @Overhang = new GRGEN_LIBGR.EnumAttributeType("Overhang", null, "Overhang", typeof(GRGEN_MODEL.ENUM_Overhang), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "BOTH"),
			new GRGEN_LIBGR.EnumMember(1, "INSIDE"),
			new GRGEN_LIBGR.EnumMember(2, "OUTSIDE"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @Filling = new GRGEN_LIBGR.EnumAttributeType("Filling", null, "Filling", typeof(GRGEN_MODEL.ENUM_Filling), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "BOX"),
			new GRGEN_LIBGR.EnumMember(1, "WINDOW"),
		});
	}

	//
	// Node types
	//

	public enum NodeTypes { @Node=0, @DesignNode=1, @Design=2, @Roof=3, @MainPart=4, @Base=5, @RingBar=6, @Middle=7, @Post=8, @Infill=9, @Door=10, @Wall=11, @WallFrame=12, @Module=13, @FrameModule=14, @LModule=15 };

	// *** Node Node ***


	public sealed partial class @Node : GRGEN_LGSP.LGSPNode, GRGEN_LIBGR.INode
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Node[] pool;

		static @Node() {
		}

		public @Node() : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
			// implicit initialization, container creation of Node
		}

		public static GRGEN_MODEL.NodeType_Node TypeInstance { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Node(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Node(this, graph, oldToNewObjectMap);
		}

		private @Node(GRGEN_MODEL.@Node oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Node))
				return false;
			@Node that_ = (@Node)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Node[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Node
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Node[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Node
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Node[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Node type \"Node\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Node type \"Node\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Node
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Node does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Node does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Node : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Node typeVar = new GRGEN_MODEL.NodeType_Node();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Node() : base((int) NodeTypes.@Node)
		{
		}
		public override string Name { get { return "Node"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Node"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.libGr.INode"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Node"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Node();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Node();
		}

	}

	// *** Node DesignNode ***

	public interface IDesignNode : GRGEN_LIBGR.INode
	{
		bool @isAlignmentNode { get; set; }
		bool @filled { get; set; }
	}

	public sealed partial class NodeType_DesignNode : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_DesignNode typeVar = new GRGEN_MODEL.NodeType_DesignNode();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public static GRGEN_LIBGR.AttributeType AttributeType_isAlignmentNode;
		public static GRGEN_LIBGR.AttributeType AttributeType_filled;
		public NodeType_DesignNode() : base((int) NodeTypes.@DesignNode)
		{
			AttributeType_isAlignmentNode = new GRGEN_LIBGR.AttributeType("isAlignmentNode", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null, null, null, typeof(bool));
			AttributeType_filled = new GRGEN_LIBGR.AttributeType("filled", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null, null, null, typeof(bool));
		}
		public override string Name { get { return "DesignNode"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "DesignNode"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IDesignNode"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type DesignNode cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_isAlignmentNode;
				yield return AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return AttributeType_isAlignmentNode;
				case "filled" : return AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type DesignNode!");
		}
	}

	public class Comparer_DesignNode_isAlignmentNode : Comparer<GRGEN_MODEL.IDesignNode>
	{
		public static Comparer_DesignNode_isAlignmentNode thisComparer = new Comparer_DesignNode_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IDesignNode a, GRGEN_MODEL.IDesignNode b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_DesignNode_isAlignmentNode : Comparer<GRGEN_MODEL.IDesignNode>
	{
		public static ReverseComparer_DesignNode_isAlignmentNode thisComparer = new ReverseComparer_DesignNode_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IDesignNode b, GRGEN_MODEL.IDesignNode a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_DesignNode_isAlignmentNode
	{
		private static GRGEN_MODEL.IDesignNode instanceBearingAttributeForSearch = new GRGEN_MODEL.@Design();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IDesignNode> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_DesignNode_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayOrderAscendingBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>(list);
			newList.Sort(Comparer_DesignNode_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayOrderDescendingBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>(list);
			newList.Sort(ReverseComparer_DesignNode_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayGroupBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IDesignNode>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IDesignNode>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IDesignNode> tempList = new List<GRGEN_MODEL.IDesignNode>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>();
			foreach(List<GRGEN_MODEL.IDesignNode> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IDesignNode element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IDesignNode entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_DesignNode_filled : Comparer<GRGEN_MODEL.IDesignNode>
	{
		public static Comparer_DesignNode_filled thisComparer = new Comparer_DesignNode_filled();
		public override int Compare(GRGEN_MODEL.IDesignNode a, GRGEN_MODEL.IDesignNode b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_DesignNode_filled : Comparer<GRGEN_MODEL.IDesignNode>
	{
		public static ReverseComparer_DesignNode_filled thisComparer = new ReverseComparer_DesignNode_filled();
		public override int Compare(GRGEN_MODEL.IDesignNode b, GRGEN_MODEL.IDesignNode a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_DesignNode_filled
	{
		private static GRGEN_MODEL.IDesignNode instanceBearingAttributeForSearch = new GRGEN_MODEL.@Design();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesignNode> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IDesignNode> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_DesignNode_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayOrderAscendingBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>(list);
			newList.Sort(Comparer_DesignNode_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayOrderDescendingBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>(list);
			newList.Sort(ReverseComparer_DesignNode_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayGroupBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IDesignNode>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IDesignNode>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IDesignNode> tempList = new List<GRGEN_MODEL.IDesignNode>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>();
			foreach(List<GRGEN_MODEL.IDesignNode> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IDesignNode> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<GRGEN_MODEL.IDesignNode> newList = new List<GRGEN_MODEL.IDesignNode>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IDesignNode element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IDesignNode> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IDesignNode entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Design ***

	public interface IDesign : IDesignNode
	{
	}

	public sealed partial class @Design : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IDesign
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Design[] pool;

		// explicit initializations of DesignNode for target Design
		// implicit initializations of DesignNode for target Design
		// explicit initializations of Design for target Design
		// implicit initializations of Design for target Design
		static @Design() {
		}

		public @Design() : base(GRGEN_MODEL.NodeType_Design.typeVar)
		{
			// implicit initialization, container creation of Design
			// explicit initializations of DesignNode for target Design
			// explicit initializations of Design for target Design
		}

		public static GRGEN_MODEL.NodeType_Design TypeInstance { get { return GRGEN_MODEL.NodeType_Design.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Design(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Design(this, graph, oldToNewObjectMap);
		}

		private @Design(GRGEN_MODEL.@Design oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Design.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Design))
				return false;
			@Design that_ = (@Design)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Design CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Design node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Design();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Design[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Design
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Design
				// explicit initializations of Design for target Design
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Design CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Design node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Design();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Design[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Design
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Design
				// explicit initializations of Design for target Design
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Design[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Design\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Design\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Design
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Design
			// explicit initializations of Design for target Design
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Design does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Design does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Design : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Design typeVar = new GRGEN_MODEL.NodeType_Design();
		public static bool[] isA = new bool[] { true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Design() : base((int) NodeTypes.@Design)
		{
		}
		public override string Name { get { return "Design"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Design"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IDesign"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Design"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Design();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Design newNode = new GRGEN_MODEL.@Design();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
					// copy attributes for: Design
					{
						GRGEN_MODEL.IDesign old = (GRGEN_MODEL.IDesign) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Design_isAlignmentNode : Comparer<GRGEN_MODEL.IDesign>
	{
		public static Comparer_Design_isAlignmentNode thisComparer = new Comparer_Design_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IDesign a, GRGEN_MODEL.IDesign b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Design_isAlignmentNode : Comparer<GRGEN_MODEL.IDesign>
	{
		public static ReverseComparer_Design_isAlignmentNode thisComparer = new ReverseComparer_Design_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IDesign b, GRGEN_MODEL.IDesign a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Design_isAlignmentNode
	{
		private static GRGEN_MODEL.IDesign instanceBearingAttributeForSearch = new GRGEN_MODEL.@Design();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IDesign> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Design_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IDesign> ArrayOrderAscendingBy(List<GRGEN_MODEL.IDesign> list)
		{
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>(list);
			newList.Sort(Comparer_Design_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesign> ArrayOrderDescendingBy(List<GRGEN_MODEL.IDesign> list)
		{
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>(list);
			newList.Sort(ReverseComparer_Design_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesign> ArrayGroupBy(List<GRGEN_MODEL.IDesign> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IDesign>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IDesign>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IDesign> tempList = new List<GRGEN_MODEL.IDesign>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>();
			foreach(List<GRGEN_MODEL.IDesign> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IDesign> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IDesign> list)
		{
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IDesign element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IDesign> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IDesign entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Design_filled : Comparer<GRGEN_MODEL.IDesign>
	{
		public static Comparer_Design_filled thisComparer = new Comparer_Design_filled();
		public override int Compare(GRGEN_MODEL.IDesign a, GRGEN_MODEL.IDesign b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Design_filled : Comparer<GRGEN_MODEL.IDesign>
	{
		public static ReverseComparer_Design_filled thisComparer = new ReverseComparer_Design_filled();
		public override int Compare(GRGEN_MODEL.IDesign b, GRGEN_MODEL.IDesign a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Design_filled
	{
		private static GRGEN_MODEL.IDesign instanceBearingAttributeForSearch = new GRGEN_MODEL.@Design();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDesign> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IDesign> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Design_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IDesign> ArrayOrderAscendingBy(List<GRGEN_MODEL.IDesign> list)
		{
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>(list);
			newList.Sort(Comparer_Design_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesign> ArrayOrderDescendingBy(List<GRGEN_MODEL.IDesign> list)
		{
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>(list);
			newList.Sort(ReverseComparer_Design_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDesign> ArrayGroupBy(List<GRGEN_MODEL.IDesign> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IDesign>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IDesign>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IDesign> tempList = new List<GRGEN_MODEL.IDesign>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>();
			foreach(List<GRGEN_MODEL.IDesign> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IDesign> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IDesign> list)
		{
			List<GRGEN_MODEL.IDesign> newList = new List<GRGEN_MODEL.IDesign>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IDesign element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IDesign> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IDesign entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Roof ***

	public interface IRoof : IDesignNode
	{
	}

	public sealed partial class @Roof : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IRoof
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Roof[] pool;

		// explicit initializations of DesignNode for target Roof
		// implicit initializations of DesignNode for target Roof
		// explicit initializations of Roof for target Roof
		// implicit initializations of Roof for target Roof
		static @Roof() {
		}

		public @Roof() : base(GRGEN_MODEL.NodeType_Roof.typeVar)
		{
			// implicit initialization, container creation of Roof
			// explicit initializations of DesignNode for target Roof
			// explicit initializations of Roof for target Roof
		}

		public static GRGEN_MODEL.NodeType_Roof TypeInstance { get { return GRGEN_MODEL.NodeType_Roof.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Roof(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Roof(this, graph, oldToNewObjectMap);
		}

		private @Roof(GRGEN_MODEL.@Roof oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Roof.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Roof))
				return false;
			@Roof that_ = (@Roof)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Roof CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Roof node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Roof();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Roof[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Roof
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Roof
				// explicit initializations of Roof for target Roof
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Roof CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Roof node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Roof();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Roof[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Roof
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Roof
				// explicit initializations of Roof for target Roof
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Roof[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Roof\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Roof\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Roof
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Roof
			// explicit initializations of Roof for target Roof
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Roof does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Roof does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Roof : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Roof typeVar = new GRGEN_MODEL.NodeType_Roof();
		public static bool[] isA = new bool[] { true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Roof() : base((int) NodeTypes.@Roof)
		{
		}
		public override string Name { get { return "Roof"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Roof"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IRoof"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Roof"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Roof();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Roof newNode = new GRGEN_MODEL.@Roof();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
					// copy attributes for: Roof
					{
						GRGEN_MODEL.IRoof old = (GRGEN_MODEL.IRoof) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Roof_isAlignmentNode : Comparer<GRGEN_MODEL.IRoof>
	{
		public static Comparer_Roof_isAlignmentNode thisComparer = new Comparer_Roof_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IRoof a, GRGEN_MODEL.IRoof b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Roof_isAlignmentNode : Comparer<GRGEN_MODEL.IRoof>
	{
		public static ReverseComparer_Roof_isAlignmentNode thisComparer = new ReverseComparer_Roof_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IRoof b, GRGEN_MODEL.IRoof a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Roof_isAlignmentNode
	{
		private static GRGEN_MODEL.IRoof instanceBearingAttributeForSearch = new GRGEN_MODEL.@Roof();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IRoof> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Roof_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IRoof> ArrayOrderAscendingBy(List<GRGEN_MODEL.IRoof> list)
		{
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>(list);
			newList.Sort(Comparer_Roof_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRoof> ArrayOrderDescendingBy(List<GRGEN_MODEL.IRoof> list)
		{
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>(list);
			newList.Sort(ReverseComparer_Roof_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRoof> ArrayGroupBy(List<GRGEN_MODEL.IRoof> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IRoof>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IRoof>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IRoof> tempList = new List<GRGEN_MODEL.IRoof>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>();
			foreach(List<GRGEN_MODEL.IRoof> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IRoof> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IRoof> list)
		{
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IRoof element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IRoof> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IRoof entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Roof_filled : Comparer<GRGEN_MODEL.IRoof>
	{
		public static Comparer_Roof_filled thisComparer = new Comparer_Roof_filled();
		public override int Compare(GRGEN_MODEL.IRoof a, GRGEN_MODEL.IRoof b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Roof_filled : Comparer<GRGEN_MODEL.IRoof>
	{
		public static ReverseComparer_Roof_filled thisComparer = new ReverseComparer_Roof_filled();
		public override int Compare(GRGEN_MODEL.IRoof b, GRGEN_MODEL.IRoof a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Roof_filled
	{
		private static GRGEN_MODEL.IRoof instanceBearingAttributeForSearch = new GRGEN_MODEL.@Roof();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRoof> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IRoof> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Roof_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IRoof> ArrayOrderAscendingBy(List<GRGEN_MODEL.IRoof> list)
		{
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>(list);
			newList.Sort(Comparer_Roof_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRoof> ArrayOrderDescendingBy(List<GRGEN_MODEL.IRoof> list)
		{
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>(list);
			newList.Sort(ReverseComparer_Roof_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRoof> ArrayGroupBy(List<GRGEN_MODEL.IRoof> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IRoof>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IRoof>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IRoof> tempList = new List<GRGEN_MODEL.IRoof>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>();
			foreach(List<GRGEN_MODEL.IRoof> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IRoof> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IRoof> list)
		{
			List<GRGEN_MODEL.IRoof> newList = new List<GRGEN_MODEL.IRoof>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IRoof element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IRoof> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IRoof entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node MainPart ***

	public interface IMainPart : IDesignNode
	{
	}

	public sealed partial class @MainPart : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMainPart
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@MainPart[] pool;

		// explicit initializations of DesignNode for target MainPart
		// implicit initializations of DesignNode for target MainPart
		// explicit initializations of MainPart for target MainPart
		// implicit initializations of MainPart for target MainPart
		static @MainPart() {
		}

		public @MainPart() : base(GRGEN_MODEL.NodeType_MainPart.typeVar)
		{
			// implicit initialization, container creation of MainPart
			// explicit initializations of DesignNode for target MainPart
			// explicit initializations of MainPart for target MainPart
		}

		public static GRGEN_MODEL.NodeType_MainPart TypeInstance { get { return GRGEN_MODEL.NodeType_MainPart.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@MainPart(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@MainPart(this, graph, oldToNewObjectMap);
		}

		private @MainPart(GRGEN_MODEL.@MainPart oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_MainPart.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @MainPart))
				return false;
			@MainPart that_ = (@MainPart)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@MainPart CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@MainPart node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MainPart();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@MainPart[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of MainPart
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target MainPart
				// explicit initializations of MainPart for target MainPart
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@MainPart CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@MainPart node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MainPart();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@MainPart[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of MainPart
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target MainPart
				// explicit initializations of MainPart for target MainPart
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@MainPart[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"MainPart\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"MainPart\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of MainPart
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target MainPart
			// explicit initializations of MainPart for target MainPart
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("MainPart does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("MainPart does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_MainPart : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_MainPart typeVar = new GRGEN_MODEL.NodeType_MainPart();
		public static bool[] isA = new bool[] { true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_MainPart() : base((int) NodeTypes.@MainPart)
		{
		}
		public override string Name { get { return "MainPart"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "MainPart"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IMainPart"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@MainPart"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@MainPart();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@MainPart newNode = new GRGEN_MODEL.@MainPart();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
					// copy attributes for: MainPart
					{
						GRGEN_MODEL.IMainPart old = (GRGEN_MODEL.IMainPart) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_MainPart_isAlignmentNode : Comparer<GRGEN_MODEL.IMainPart>
	{
		public static Comparer_MainPart_isAlignmentNode thisComparer = new Comparer_MainPart_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IMainPart a, GRGEN_MODEL.IMainPart b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_MainPart_isAlignmentNode : Comparer<GRGEN_MODEL.IMainPart>
	{
		public static ReverseComparer_MainPart_isAlignmentNode thisComparer = new ReverseComparer_MainPart_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IMainPart b, GRGEN_MODEL.IMainPart a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_MainPart_isAlignmentNode
	{
		private static GRGEN_MODEL.IMainPart instanceBearingAttributeForSearch = new GRGEN_MODEL.@MainPart();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IMainPart> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_MainPart_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayOrderAscendingBy(List<GRGEN_MODEL.IMainPart> list)
		{
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>(list);
			newList.Sort(Comparer_MainPart_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayOrderDescendingBy(List<GRGEN_MODEL.IMainPart> list)
		{
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>(list);
			newList.Sort(ReverseComparer_MainPart_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayGroupBy(List<GRGEN_MODEL.IMainPart> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IMainPart>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IMainPart>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IMainPart> tempList = new List<GRGEN_MODEL.IMainPart>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>();
			foreach(List<GRGEN_MODEL.IMainPart> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IMainPart> list)
		{
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IMainPart element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IMainPart> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IMainPart entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_MainPart_filled : Comparer<GRGEN_MODEL.IMainPart>
	{
		public static Comparer_MainPart_filled thisComparer = new Comparer_MainPart_filled();
		public override int Compare(GRGEN_MODEL.IMainPart a, GRGEN_MODEL.IMainPart b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_MainPart_filled : Comparer<GRGEN_MODEL.IMainPart>
	{
		public static ReverseComparer_MainPart_filled thisComparer = new ReverseComparer_MainPart_filled();
		public override int Compare(GRGEN_MODEL.IMainPart b, GRGEN_MODEL.IMainPart a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_MainPart_filled
	{
		private static GRGEN_MODEL.IMainPart instanceBearingAttributeForSearch = new GRGEN_MODEL.@MainPart();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMainPart> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IMainPart> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_MainPart_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayOrderAscendingBy(List<GRGEN_MODEL.IMainPart> list)
		{
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>(list);
			newList.Sort(Comparer_MainPart_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayOrderDescendingBy(List<GRGEN_MODEL.IMainPart> list)
		{
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>(list);
			newList.Sort(ReverseComparer_MainPart_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayGroupBy(List<GRGEN_MODEL.IMainPart> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IMainPart>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IMainPart>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IMainPart> tempList = new List<GRGEN_MODEL.IMainPart>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>();
			foreach(List<GRGEN_MODEL.IMainPart> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IMainPart> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IMainPart> list)
		{
			List<GRGEN_MODEL.IMainPart> newList = new List<GRGEN_MODEL.IMainPart>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IMainPart element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IMainPart> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IMainPart entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Base ***

	public interface IBase : IDesignNode
	{
	}

	public sealed partial class @Base : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBase
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Base[] pool;

		// explicit initializations of DesignNode for target Base
		// implicit initializations of DesignNode for target Base
		// explicit initializations of Base for target Base
		// implicit initializations of Base for target Base
		static @Base() {
		}

		public @Base() : base(GRGEN_MODEL.NodeType_Base.typeVar)
		{
			// implicit initialization, container creation of Base
			// explicit initializations of DesignNode for target Base
			// explicit initializations of Base for target Base
		}

		public static GRGEN_MODEL.NodeType_Base TypeInstance { get { return GRGEN_MODEL.NodeType_Base.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Base(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Base(this, graph, oldToNewObjectMap);
		}

		private @Base(GRGEN_MODEL.@Base oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Base.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Base))
				return false;
			@Base that_ = (@Base)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Base CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Base node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Base();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Base[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Base
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Base
				// explicit initializations of Base for target Base
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Base CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Base node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Base();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Base[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Base
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Base
				// explicit initializations of Base for target Base
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Base[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Base\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Base\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Base
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Base
			// explicit initializations of Base for target Base
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Base does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Base does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Base : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Base typeVar = new GRGEN_MODEL.NodeType_Base();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Base() : base((int) NodeTypes.@Base)
		{
		}
		public override string Name { get { return "Base"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Base"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IBase"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Base"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Base();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Base newNode = new GRGEN_MODEL.@Base();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Base:
					// copy attributes for: Base
					{
						GRGEN_MODEL.IBase old = (GRGEN_MODEL.IBase) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Base_isAlignmentNode : Comparer<GRGEN_MODEL.IBase>
	{
		public static Comparer_Base_isAlignmentNode thisComparer = new Comparer_Base_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IBase a, GRGEN_MODEL.IBase b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Base_isAlignmentNode : Comparer<GRGEN_MODEL.IBase>
	{
		public static ReverseComparer_Base_isAlignmentNode thisComparer = new ReverseComparer_Base_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IBase b, GRGEN_MODEL.IBase a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Base_isAlignmentNode
	{
		private static GRGEN_MODEL.IBase instanceBearingAttributeForSearch = new GRGEN_MODEL.@Base();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IBase> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Base_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IBase> ArrayOrderAscendingBy(List<GRGEN_MODEL.IBase> list)
		{
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>(list);
			newList.Sort(Comparer_Base_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBase> ArrayOrderDescendingBy(List<GRGEN_MODEL.IBase> list)
		{
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>(list);
			newList.Sort(ReverseComparer_Base_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBase> ArrayGroupBy(List<GRGEN_MODEL.IBase> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IBase>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IBase>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IBase> tempList = new List<GRGEN_MODEL.IBase>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>();
			foreach(List<GRGEN_MODEL.IBase> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IBase> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IBase> list)
		{
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IBase element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IBase> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IBase entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Base_filled : Comparer<GRGEN_MODEL.IBase>
	{
		public static Comparer_Base_filled thisComparer = new Comparer_Base_filled();
		public override int Compare(GRGEN_MODEL.IBase a, GRGEN_MODEL.IBase b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Base_filled : Comparer<GRGEN_MODEL.IBase>
	{
		public static ReverseComparer_Base_filled thisComparer = new ReverseComparer_Base_filled();
		public override int Compare(GRGEN_MODEL.IBase b, GRGEN_MODEL.IBase a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Base_filled
	{
		private static GRGEN_MODEL.IBase instanceBearingAttributeForSearch = new GRGEN_MODEL.@Base();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IBase> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IBase> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Base_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IBase> ArrayOrderAscendingBy(List<GRGEN_MODEL.IBase> list)
		{
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>(list);
			newList.Sort(Comparer_Base_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBase> ArrayOrderDescendingBy(List<GRGEN_MODEL.IBase> list)
		{
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>(list);
			newList.Sort(ReverseComparer_Base_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IBase> ArrayGroupBy(List<GRGEN_MODEL.IBase> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IBase>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IBase>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IBase> tempList = new List<GRGEN_MODEL.IBase>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>();
			foreach(List<GRGEN_MODEL.IBase> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IBase> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IBase> list)
		{
			List<GRGEN_MODEL.IBase> newList = new List<GRGEN_MODEL.IBase>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IBase element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IBase> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IBase entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node RingBar ***

	public interface IRingBar : IDesignNode
	{
	}

	public sealed partial class @RingBar : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IRingBar
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@RingBar[] pool;

		// explicit initializations of DesignNode for target RingBar
		// implicit initializations of DesignNode for target RingBar
		// explicit initializations of RingBar for target RingBar
		// implicit initializations of RingBar for target RingBar
		static @RingBar() {
		}

		public @RingBar() : base(GRGEN_MODEL.NodeType_RingBar.typeVar)
		{
			// implicit initialization, container creation of RingBar
			// explicit initializations of DesignNode for target RingBar
			// explicit initializations of RingBar for target RingBar
		}

		public static GRGEN_MODEL.NodeType_RingBar TypeInstance { get { return GRGEN_MODEL.NodeType_RingBar.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@RingBar(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@RingBar(this, graph, oldToNewObjectMap);
		}

		private @RingBar(GRGEN_MODEL.@RingBar oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_RingBar.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @RingBar))
				return false;
			@RingBar that_ = (@RingBar)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@RingBar CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@RingBar node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@RingBar();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@RingBar[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of RingBar
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target RingBar
				// explicit initializations of RingBar for target RingBar
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@RingBar CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@RingBar node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@RingBar();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@RingBar[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of RingBar
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target RingBar
				// explicit initializations of RingBar for target RingBar
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@RingBar[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"RingBar\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"RingBar\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of RingBar
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target RingBar
			// explicit initializations of RingBar for target RingBar
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("RingBar does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("RingBar does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_RingBar : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_RingBar typeVar = new GRGEN_MODEL.NodeType_RingBar();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_RingBar() : base((int) NodeTypes.@RingBar)
		{
		}
		public override string Name { get { return "RingBar"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "RingBar"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IRingBar"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@RingBar"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@RingBar();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@RingBar newNode = new GRGEN_MODEL.@RingBar();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
					// copy attributes for: RingBar
					{
						GRGEN_MODEL.IRingBar old = (GRGEN_MODEL.IRingBar) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_RingBar_isAlignmentNode : Comparer<GRGEN_MODEL.IRingBar>
	{
		public static Comparer_RingBar_isAlignmentNode thisComparer = new Comparer_RingBar_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IRingBar a, GRGEN_MODEL.IRingBar b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_RingBar_isAlignmentNode : Comparer<GRGEN_MODEL.IRingBar>
	{
		public static ReverseComparer_RingBar_isAlignmentNode thisComparer = new ReverseComparer_RingBar_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IRingBar b, GRGEN_MODEL.IRingBar a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_RingBar_isAlignmentNode
	{
		private static GRGEN_MODEL.IRingBar instanceBearingAttributeForSearch = new GRGEN_MODEL.@RingBar();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IRingBar> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_RingBar_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayOrderAscendingBy(List<GRGEN_MODEL.IRingBar> list)
		{
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>(list);
			newList.Sort(Comparer_RingBar_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayOrderDescendingBy(List<GRGEN_MODEL.IRingBar> list)
		{
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>(list);
			newList.Sort(ReverseComparer_RingBar_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayGroupBy(List<GRGEN_MODEL.IRingBar> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IRingBar>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IRingBar>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IRingBar> tempList = new List<GRGEN_MODEL.IRingBar>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>();
			foreach(List<GRGEN_MODEL.IRingBar> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IRingBar> list)
		{
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IRingBar element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IRingBar> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IRingBar entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_RingBar_filled : Comparer<GRGEN_MODEL.IRingBar>
	{
		public static Comparer_RingBar_filled thisComparer = new Comparer_RingBar_filled();
		public override int Compare(GRGEN_MODEL.IRingBar a, GRGEN_MODEL.IRingBar b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_RingBar_filled : Comparer<GRGEN_MODEL.IRingBar>
	{
		public static ReverseComparer_RingBar_filled thisComparer = new ReverseComparer_RingBar_filled();
		public override int Compare(GRGEN_MODEL.IRingBar b, GRGEN_MODEL.IRingBar a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_RingBar_filled
	{
		private static GRGEN_MODEL.IRingBar instanceBearingAttributeForSearch = new GRGEN_MODEL.@RingBar();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IRingBar> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IRingBar> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_RingBar_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayOrderAscendingBy(List<GRGEN_MODEL.IRingBar> list)
		{
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>(list);
			newList.Sort(Comparer_RingBar_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayOrderDescendingBy(List<GRGEN_MODEL.IRingBar> list)
		{
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>(list);
			newList.Sort(ReverseComparer_RingBar_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayGroupBy(List<GRGEN_MODEL.IRingBar> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IRingBar>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IRingBar>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IRingBar> tempList = new List<GRGEN_MODEL.IRingBar>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>();
			foreach(List<GRGEN_MODEL.IRingBar> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IRingBar> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IRingBar> list)
		{
			List<GRGEN_MODEL.IRingBar> newList = new List<GRGEN_MODEL.IRingBar>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IRingBar element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IRingBar> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IRingBar entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Middle ***

	public interface IMiddle : IDesignNode
	{
	}

	public sealed partial class @Middle : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMiddle
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Middle[] pool;

		// explicit initializations of DesignNode for target Middle
		// implicit initializations of DesignNode for target Middle
		// explicit initializations of Middle for target Middle
		// implicit initializations of Middle for target Middle
		static @Middle() {
		}

		public @Middle() : base(GRGEN_MODEL.NodeType_Middle.typeVar)
		{
			// implicit initialization, container creation of Middle
			// explicit initializations of DesignNode for target Middle
			// explicit initializations of Middle for target Middle
		}

		public static GRGEN_MODEL.NodeType_Middle TypeInstance { get { return GRGEN_MODEL.NodeType_Middle.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Middle(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Middle(this, graph, oldToNewObjectMap);
		}

		private @Middle(GRGEN_MODEL.@Middle oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Middle.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Middle))
				return false;
			@Middle that_ = (@Middle)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Middle CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Middle node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Middle();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Middle[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Middle
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Middle
				// explicit initializations of Middle for target Middle
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Middle CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Middle node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Middle();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Middle[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Middle
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Middle
				// explicit initializations of Middle for target Middle
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Middle[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Middle\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Middle\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Middle
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Middle
			// explicit initializations of Middle for target Middle
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Middle does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Middle does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Middle : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Middle typeVar = new GRGEN_MODEL.NodeType_Middle();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Middle() : base((int) NodeTypes.@Middle)
		{
		}
		public override string Name { get { return "Middle"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Middle"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IMiddle"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Middle"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Middle();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Middle newNode = new GRGEN_MODEL.@Middle();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
					// copy attributes for: Middle
					{
						GRGEN_MODEL.IMiddle old = (GRGEN_MODEL.IMiddle) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Middle_isAlignmentNode : Comparer<GRGEN_MODEL.IMiddle>
	{
		public static Comparer_Middle_isAlignmentNode thisComparer = new Comparer_Middle_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IMiddle a, GRGEN_MODEL.IMiddle b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Middle_isAlignmentNode : Comparer<GRGEN_MODEL.IMiddle>
	{
		public static ReverseComparer_Middle_isAlignmentNode thisComparer = new ReverseComparer_Middle_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IMiddle b, GRGEN_MODEL.IMiddle a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Middle_isAlignmentNode
	{
		private static GRGEN_MODEL.IMiddle instanceBearingAttributeForSearch = new GRGEN_MODEL.@Middle();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IMiddle> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Middle_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayOrderAscendingBy(List<GRGEN_MODEL.IMiddle> list)
		{
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>(list);
			newList.Sort(Comparer_Middle_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayOrderDescendingBy(List<GRGEN_MODEL.IMiddle> list)
		{
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>(list);
			newList.Sort(ReverseComparer_Middle_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayGroupBy(List<GRGEN_MODEL.IMiddle> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IMiddle>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IMiddle>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IMiddle> tempList = new List<GRGEN_MODEL.IMiddle>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>();
			foreach(List<GRGEN_MODEL.IMiddle> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IMiddle> list)
		{
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IMiddle element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IMiddle> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IMiddle entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Middle_filled : Comparer<GRGEN_MODEL.IMiddle>
	{
		public static Comparer_Middle_filled thisComparer = new Comparer_Middle_filled();
		public override int Compare(GRGEN_MODEL.IMiddle a, GRGEN_MODEL.IMiddle b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Middle_filled : Comparer<GRGEN_MODEL.IMiddle>
	{
		public static ReverseComparer_Middle_filled thisComparer = new ReverseComparer_Middle_filled();
		public override int Compare(GRGEN_MODEL.IMiddle b, GRGEN_MODEL.IMiddle a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Middle_filled
	{
		private static GRGEN_MODEL.IMiddle instanceBearingAttributeForSearch = new GRGEN_MODEL.@Middle();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IMiddle> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IMiddle> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Middle_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayOrderAscendingBy(List<GRGEN_MODEL.IMiddle> list)
		{
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>(list);
			newList.Sort(Comparer_Middle_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayOrderDescendingBy(List<GRGEN_MODEL.IMiddle> list)
		{
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>(list);
			newList.Sort(ReverseComparer_Middle_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayGroupBy(List<GRGEN_MODEL.IMiddle> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IMiddle>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IMiddle>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IMiddle> tempList = new List<GRGEN_MODEL.IMiddle>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>();
			foreach(List<GRGEN_MODEL.IMiddle> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IMiddle> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IMiddle> list)
		{
			List<GRGEN_MODEL.IMiddle> newList = new List<GRGEN_MODEL.IMiddle>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IMiddle element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IMiddle> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IMiddle entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Post ***

	public interface IPost : IDesignNode
	{
	}

	public sealed partial class @Post : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IPost
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Post[] pool;

		// explicit initializations of DesignNode for target Post
		// implicit initializations of DesignNode for target Post
		// explicit initializations of Post for target Post
		// implicit initializations of Post for target Post
		static @Post() {
		}

		public @Post() : base(GRGEN_MODEL.NodeType_Post.typeVar)
		{
			// implicit initialization, container creation of Post
			// explicit initializations of DesignNode for target Post
			// explicit initializations of Post for target Post
		}

		public static GRGEN_MODEL.NodeType_Post TypeInstance { get { return GRGEN_MODEL.NodeType_Post.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Post(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Post(this, graph, oldToNewObjectMap);
		}

		private @Post(GRGEN_MODEL.@Post oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Post.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Post))
				return false;
			@Post that_ = (@Post)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Post CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Post node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Post();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Post[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Post
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Post
				// explicit initializations of Post for target Post
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Post CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Post node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Post();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Post[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Post
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Post
				// explicit initializations of Post for target Post
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Post[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Post\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Post\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Post
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Post
			// explicit initializations of Post for target Post
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Post does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Post does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Post : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Post typeVar = new GRGEN_MODEL.NodeType_Post();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Post() : base((int) NodeTypes.@Post)
		{
		}
		public override string Name { get { return "Post"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Post"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IPost"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Post"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Post();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Post newNode = new GRGEN_MODEL.@Post();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Post:
					// copy attributes for: Post
					{
						GRGEN_MODEL.IPost old = (GRGEN_MODEL.IPost) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Post_isAlignmentNode : Comparer<GRGEN_MODEL.IPost>
	{
		public static Comparer_Post_isAlignmentNode thisComparer = new Comparer_Post_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IPost a, GRGEN_MODEL.IPost b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Post_isAlignmentNode : Comparer<GRGEN_MODEL.IPost>
	{
		public static ReverseComparer_Post_isAlignmentNode thisComparer = new ReverseComparer_Post_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IPost b, GRGEN_MODEL.IPost a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Post_isAlignmentNode
	{
		private static GRGEN_MODEL.IPost instanceBearingAttributeForSearch = new GRGEN_MODEL.@Post();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IPost> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Post_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IPost> ArrayOrderAscendingBy(List<GRGEN_MODEL.IPost> list)
		{
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>(list);
			newList.Sort(Comparer_Post_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IPost> ArrayOrderDescendingBy(List<GRGEN_MODEL.IPost> list)
		{
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>(list);
			newList.Sort(ReverseComparer_Post_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IPost> ArrayGroupBy(List<GRGEN_MODEL.IPost> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IPost>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IPost>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IPost> tempList = new List<GRGEN_MODEL.IPost>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>();
			foreach(List<GRGEN_MODEL.IPost> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IPost> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IPost> list)
		{
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IPost element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IPost> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IPost entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Post_filled : Comparer<GRGEN_MODEL.IPost>
	{
		public static Comparer_Post_filled thisComparer = new Comparer_Post_filled();
		public override int Compare(GRGEN_MODEL.IPost a, GRGEN_MODEL.IPost b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Post_filled : Comparer<GRGEN_MODEL.IPost>
	{
		public static ReverseComparer_Post_filled thisComparer = new ReverseComparer_Post_filled();
		public override int Compare(GRGEN_MODEL.IPost b, GRGEN_MODEL.IPost a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Post_filled
	{
		private static GRGEN_MODEL.IPost instanceBearingAttributeForSearch = new GRGEN_MODEL.@Post();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IPost> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IPost> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Post_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IPost> ArrayOrderAscendingBy(List<GRGEN_MODEL.IPost> list)
		{
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>(list);
			newList.Sort(Comparer_Post_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IPost> ArrayOrderDescendingBy(List<GRGEN_MODEL.IPost> list)
		{
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>(list);
			newList.Sort(ReverseComparer_Post_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IPost> ArrayGroupBy(List<GRGEN_MODEL.IPost> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IPost>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IPost>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IPost> tempList = new List<GRGEN_MODEL.IPost>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>();
			foreach(List<GRGEN_MODEL.IPost> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IPost> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IPost> list)
		{
			List<GRGEN_MODEL.IPost> newList = new List<GRGEN_MODEL.IPost>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IPost element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IPost> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IPost entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Infill ***

	public interface IInfill : IDesignNode
	{
	}

	public sealed partial class @Infill : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IInfill
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Infill[] pool;

		// explicit initializations of DesignNode for target Infill
		// implicit initializations of DesignNode for target Infill
		// explicit initializations of Infill for target Infill
		// implicit initializations of Infill for target Infill
		static @Infill() {
		}

		public @Infill() : base(GRGEN_MODEL.NodeType_Infill.typeVar)
		{
			// implicit initialization, container creation of Infill
			// explicit initializations of DesignNode for target Infill
			// explicit initializations of Infill for target Infill
		}

		public static GRGEN_MODEL.NodeType_Infill TypeInstance { get { return GRGEN_MODEL.NodeType_Infill.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Infill(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Infill(this, graph, oldToNewObjectMap);
		}

		private @Infill(GRGEN_MODEL.@Infill oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Infill.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Infill))
				return false;
			@Infill that_ = (@Infill)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Infill CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Infill node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Infill();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Infill[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Infill
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Infill
				// explicit initializations of Infill for target Infill
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Infill CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Infill node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Infill();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Infill[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Infill
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Infill
				// explicit initializations of Infill for target Infill
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Infill[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Infill\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Infill\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Infill
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Infill
			// explicit initializations of Infill for target Infill
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Infill does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Infill does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Infill : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Infill typeVar = new GRGEN_MODEL.NodeType_Infill();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Infill() : base((int) NodeTypes.@Infill)
		{
		}
		public override string Name { get { return "Infill"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Infill"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IInfill"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Infill"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Infill();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Infill newNode = new GRGEN_MODEL.@Infill();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
					// copy attributes for: Infill
					{
						GRGEN_MODEL.IInfill old = (GRGEN_MODEL.IInfill) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Infill_isAlignmentNode : Comparer<GRGEN_MODEL.IInfill>
	{
		public static Comparer_Infill_isAlignmentNode thisComparer = new Comparer_Infill_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IInfill a, GRGEN_MODEL.IInfill b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Infill_isAlignmentNode : Comparer<GRGEN_MODEL.IInfill>
	{
		public static ReverseComparer_Infill_isAlignmentNode thisComparer = new ReverseComparer_Infill_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IInfill b, GRGEN_MODEL.IInfill a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Infill_isAlignmentNode
	{
		private static GRGEN_MODEL.IInfill instanceBearingAttributeForSearch = new GRGEN_MODEL.@Infill();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IInfill> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Infill_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IInfill> ArrayOrderAscendingBy(List<GRGEN_MODEL.IInfill> list)
		{
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>(list);
			newList.Sort(Comparer_Infill_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IInfill> ArrayOrderDescendingBy(List<GRGEN_MODEL.IInfill> list)
		{
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>(list);
			newList.Sort(ReverseComparer_Infill_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IInfill> ArrayGroupBy(List<GRGEN_MODEL.IInfill> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IInfill>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IInfill>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IInfill> tempList = new List<GRGEN_MODEL.IInfill>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>();
			foreach(List<GRGEN_MODEL.IInfill> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IInfill> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IInfill> list)
		{
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IInfill element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IInfill> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IInfill entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Infill_filled : Comparer<GRGEN_MODEL.IInfill>
	{
		public static Comparer_Infill_filled thisComparer = new Comparer_Infill_filled();
		public override int Compare(GRGEN_MODEL.IInfill a, GRGEN_MODEL.IInfill b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Infill_filled : Comparer<GRGEN_MODEL.IInfill>
	{
		public static ReverseComparer_Infill_filled thisComparer = new ReverseComparer_Infill_filled();
		public override int Compare(GRGEN_MODEL.IInfill b, GRGEN_MODEL.IInfill a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Infill_filled
	{
		private static GRGEN_MODEL.IInfill instanceBearingAttributeForSearch = new GRGEN_MODEL.@Infill();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IInfill> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IInfill> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Infill_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IInfill> ArrayOrderAscendingBy(List<GRGEN_MODEL.IInfill> list)
		{
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>(list);
			newList.Sort(Comparer_Infill_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IInfill> ArrayOrderDescendingBy(List<GRGEN_MODEL.IInfill> list)
		{
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>(list);
			newList.Sort(ReverseComparer_Infill_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IInfill> ArrayGroupBy(List<GRGEN_MODEL.IInfill> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IInfill>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IInfill>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IInfill> tempList = new List<GRGEN_MODEL.IInfill>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>();
			foreach(List<GRGEN_MODEL.IInfill> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IInfill> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IInfill> list)
		{
			List<GRGEN_MODEL.IInfill> newList = new List<GRGEN_MODEL.IInfill>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IInfill element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IInfill> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IInfill entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Door ***

	public interface IDoor : IDesignNode
	{
	}

	public sealed partial class @Door : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IDoor
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Door[] pool;

		// explicit initializations of DesignNode for target Door
		// implicit initializations of DesignNode for target Door
		// explicit initializations of Door for target Door
		// implicit initializations of Door for target Door
		static @Door() {
		}

		public @Door() : base(GRGEN_MODEL.NodeType_Door.typeVar)
		{
			// implicit initialization, container creation of Door
			// explicit initializations of DesignNode for target Door
			// explicit initializations of Door for target Door
		}

		public static GRGEN_MODEL.NodeType_Door TypeInstance { get { return GRGEN_MODEL.NodeType_Door.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Door(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Door(this, graph, oldToNewObjectMap);
		}

		private @Door(GRGEN_MODEL.@Door oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Door.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Door))
				return false;
			@Door that_ = (@Door)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Door CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Door node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Door();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Door[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Door
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Door
				// explicit initializations of Door for target Door
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Door CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Door node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Door();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Door[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Door
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Door
				// explicit initializations of Door for target Door
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Door[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Door\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Door\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Door
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Door
			// explicit initializations of Door for target Door
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Door does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Door does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Door : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Door typeVar = new GRGEN_MODEL.NodeType_Door();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Door() : base((int) NodeTypes.@Door)
		{
		}
		public override string Name { get { return "Door"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Door"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IDoor"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Door"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Door();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Door newNode = new GRGEN_MODEL.@Door();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Door:
					// copy attributes for: Door
					{
						GRGEN_MODEL.IDoor old = (GRGEN_MODEL.IDoor) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Door_isAlignmentNode : Comparer<GRGEN_MODEL.IDoor>
	{
		public static Comparer_Door_isAlignmentNode thisComparer = new Comparer_Door_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IDoor a, GRGEN_MODEL.IDoor b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Door_isAlignmentNode : Comparer<GRGEN_MODEL.IDoor>
	{
		public static ReverseComparer_Door_isAlignmentNode thisComparer = new ReverseComparer_Door_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IDoor b, GRGEN_MODEL.IDoor a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Door_isAlignmentNode
	{
		private static GRGEN_MODEL.IDoor instanceBearingAttributeForSearch = new GRGEN_MODEL.@Door();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IDoor> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Door_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IDoor> ArrayOrderAscendingBy(List<GRGEN_MODEL.IDoor> list)
		{
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>(list);
			newList.Sort(Comparer_Door_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDoor> ArrayOrderDescendingBy(List<GRGEN_MODEL.IDoor> list)
		{
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>(list);
			newList.Sort(ReverseComparer_Door_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDoor> ArrayGroupBy(List<GRGEN_MODEL.IDoor> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IDoor>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IDoor>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IDoor> tempList = new List<GRGEN_MODEL.IDoor>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>();
			foreach(List<GRGEN_MODEL.IDoor> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IDoor> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IDoor> list)
		{
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IDoor element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IDoor> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IDoor entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Door_filled : Comparer<GRGEN_MODEL.IDoor>
	{
		public static Comparer_Door_filled thisComparer = new Comparer_Door_filled();
		public override int Compare(GRGEN_MODEL.IDoor a, GRGEN_MODEL.IDoor b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Door_filled : Comparer<GRGEN_MODEL.IDoor>
	{
		public static ReverseComparer_Door_filled thisComparer = new ReverseComparer_Door_filled();
		public override int Compare(GRGEN_MODEL.IDoor b, GRGEN_MODEL.IDoor a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Door_filled
	{
		private static GRGEN_MODEL.IDoor instanceBearingAttributeForSearch = new GRGEN_MODEL.@Door();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IDoor> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IDoor> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Door_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IDoor> ArrayOrderAscendingBy(List<GRGEN_MODEL.IDoor> list)
		{
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>(list);
			newList.Sort(Comparer_Door_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDoor> ArrayOrderDescendingBy(List<GRGEN_MODEL.IDoor> list)
		{
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>(list);
			newList.Sort(ReverseComparer_Door_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IDoor> ArrayGroupBy(List<GRGEN_MODEL.IDoor> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IDoor>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IDoor>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IDoor> tempList = new List<GRGEN_MODEL.IDoor>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>();
			foreach(List<GRGEN_MODEL.IDoor> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IDoor> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IDoor> list)
		{
			List<GRGEN_MODEL.IDoor> newList = new List<GRGEN_MODEL.IDoor>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IDoor element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IDoor> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IDoor entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Wall ***

	public interface IWall : IDesignNode
	{
	}

	public sealed partial class @Wall : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IWall
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Wall[] pool;

		// explicit initializations of DesignNode for target Wall
		// implicit initializations of DesignNode for target Wall
		// explicit initializations of Wall for target Wall
		// implicit initializations of Wall for target Wall
		static @Wall() {
		}

		public @Wall() : base(GRGEN_MODEL.NodeType_Wall.typeVar)
		{
			// implicit initialization, container creation of Wall
			// explicit initializations of DesignNode for target Wall
			// explicit initializations of Wall for target Wall
		}

		public static GRGEN_MODEL.NodeType_Wall TypeInstance { get { return GRGEN_MODEL.NodeType_Wall.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Wall(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Wall(this, graph, oldToNewObjectMap);
		}

		private @Wall(GRGEN_MODEL.@Wall oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Wall.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Wall))
				return false;
			@Wall that_ = (@Wall)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Wall CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Wall node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Wall();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Wall[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Wall
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Wall
				// explicit initializations of Wall for target Wall
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Wall CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Wall node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Wall();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Wall[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Wall
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Wall
				// explicit initializations of Wall for target Wall
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Wall[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Wall\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Wall\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Wall
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Wall
			// explicit initializations of Wall for target Wall
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Wall does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Wall does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Wall : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Wall typeVar = new GRGEN_MODEL.NodeType_Wall();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Wall() : base((int) NodeTypes.@Wall)
		{
		}
		public override string Name { get { return "Wall"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Wall"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IWall"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Wall"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Wall();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Wall newNode = new GRGEN_MODEL.@Wall();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
					// copy attributes for: Wall
					{
						GRGEN_MODEL.IWall old = (GRGEN_MODEL.IWall) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Wall_isAlignmentNode : Comparer<GRGEN_MODEL.IWall>
	{
		public static Comparer_Wall_isAlignmentNode thisComparer = new Comparer_Wall_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IWall a, GRGEN_MODEL.IWall b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Wall_isAlignmentNode : Comparer<GRGEN_MODEL.IWall>
	{
		public static ReverseComparer_Wall_isAlignmentNode thisComparer = new ReverseComparer_Wall_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IWall b, GRGEN_MODEL.IWall a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Wall_isAlignmentNode
	{
		private static GRGEN_MODEL.IWall instanceBearingAttributeForSearch = new GRGEN_MODEL.@Wall();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IWall> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Wall_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IWall> ArrayOrderAscendingBy(List<GRGEN_MODEL.IWall> list)
		{
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>(list);
			newList.Sort(Comparer_Wall_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWall> ArrayOrderDescendingBy(List<GRGEN_MODEL.IWall> list)
		{
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>(list);
			newList.Sort(ReverseComparer_Wall_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWall> ArrayGroupBy(List<GRGEN_MODEL.IWall> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IWall>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IWall>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IWall> tempList = new List<GRGEN_MODEL.IWall>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>();
			foreach(List<GRGEN_MODEL.IWall> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IWall> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IWall> list)
		{
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IWall element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IWall> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IWall entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Wall_filled : Comparer<GRGEN_MODEL.IWall>
	{
		public static Comparer_Wall_filled thisComparer = new Comparer_Wall_filled();
		public override int Compare(GRGEN_MODEL.IWall a, GRGEN_MODEL.IWall b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Wall_filled : Comparer<GRGEN_MODEL.IWall>
	{
		public static ReverseComparer_Wall_filled thisComparer = new ReverseComparer_Wall_filled();
		public override int Compare(GRGEN_MODEL.IWall b, GRGEN_MODEL.IWall a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Wall_filled
	{
		private static GRGEN_MODEL.IWall instanceBearingAttributeForSearch = new GRGEN_MODEL.@Wall();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWall> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IWall> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Wall_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IWall> ArrayOrderAscendingBy(List<GRGEN_MODEL.IWall> list)
		{
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>(list);
			newList.Sort(Comparer_Wall_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWall> ArrayOrderDescendingBy(List<GRGEN_MODEL.IWall> list)
		{
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>(list);
			newList.Sort(ReverseComparer_Wall_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWall> ArrayGroupBy(List<GRGEN_MODEL.IWall> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IWall>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IWall>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IWall> tempList = new List<GRGEN_MODEL.IWall>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>();
			foreach(List<GRGEN_MODEL.IWall> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IWall> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IWall> list)
		{
			List<GRGEN_MODEL.IWall> newList = new List<GRGEN_MODEL.IWall>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IWall element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IWall> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IWall entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node WallFrame ***

	public interface IWallFrame : IDesignNode
	{
	}

	public sealed partial class @WallFrame : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IWallFrame
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@WallFrame[] pool;

		// explicit initializations of DesignNode for target WallFrame
		// implicit initializations of DesignNode for target WallFrame
		// explicit initializations of WallFrame for target WallFrame
		// implicit initializations of WallFrame for target WallFrame
		static @WallFrame() {
		}

		public @WallFrame() : base(GRGEN_MODEL.NodeType_WallFrame.typeVar)
		{
			// implicit initialization, container creation of WallFrame
			// explicit initializations of DesignNode for target WallFrame
			// explicit initializations of WallFrame for target WallFrame
		}

		public static GRGEN_MODEL.NodeType_WallFrame TypeInstance { get { return GRGEN_MODEL.NodeType_WallFrame.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@WallFrame(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@WallFrame(this, graph, oldToNewObjectMap);
		}

		private @WallFrame(GRGEN_MODEL.@WallFrame oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_WallFrame.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @WallFrame))
				return false;
			@WallFrame that_ = (@WallFrame)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@WallFrame CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@WallFrame node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@WallFrame();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@WallFrame[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of WallFrame
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target WallFrame
				// explicit initializations of WallFrame for target WallFrame
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@WallFrame CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@WallFrame node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@WallFrame();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@WallFrame[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of WallFrame
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target WallFrame
				// explicit initializations of WallFrame for target WallFrame
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@WallFrame[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"WallFrame\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"WallFrame\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of WallFrame
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target WallFrame
			// explicit initializations of WallFrame for target WallFrame
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("WallFrame does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("WallFrame does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_WallFrame : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_WallFrame typeVar = new GRGEN_MODEL.NodeType_WallFrame();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_WallFrame() : base((int) NodeTypes.@WallFrame)
		{
		}
		public override string Name { get { return "WallFrame"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "WallFrame"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IWallFrame"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@WallFrame"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@WallFrame();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@WallFrame newNode = new GRGEN_MODEL.@WallFrame();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
					// copy attributes for: WallFrame
					{
						GRGEN_MODEL.IWallFrame old = (GRGEN_MODEL.IWallFrame) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_WallFrame_isAlignmentNode : Comparer<GRGEN_MODEL.IWallFrame>
	{
		public static Comparer_WallFrame_isAlignmentNode thisComparer = new Comparer_WallFrame_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IWallFrame a, GRGEN_MODEL.IWallFrame b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_WallFrame_isAlignmentNode : Comparer<GRGEN_MODEL.IWallFrame>
	{
		public static ReverseComparer_WallFrame_isAlignmentNode thisComparer = new ReverseComparer_WallFrame_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IWallFrame b, GRGEN_MODEL.IWallFrame a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_WallFrame_isAlignmentNode
	{
		private static GRGEN_MODEL.IWallFrame instanceBearingAttributeForSearch = new GRGEN_MODEL.@WallFrame();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IWallFrame> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_WallFrame_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayOrderAscendingBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>(list);
			newList.Sort(Comparer_WallFrame_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayOrderDescendingBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>(list);
			newList.Sort(ReverseComparer_WallFrame_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayGroupBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IWallFrame>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IWallFrame>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IWallFrame> tempList = new List<GRGEN_MODEL.IWallFrame>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>();
			foreach(List<GRGEN_MODEL.IWallFrame> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IWallFrame element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IWallFrame entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_WallFrame_filled : Comparer<GRGEN_MODEL.IWallFrame>
	{
		public static Comparer_WallFrame_filled thisComparer = new Comparer_WallFrame_filled();
		public override int Compare(GRGEN_MODEL.IWallFrame a, GRGEN_MODEL.IWallFrame b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_WallFrame_filled : Comparer<GRGEN_MODEL.IWallFrame>
	{
		public static ReverseComparer_WallFrame_filled thisComparer = new ReverseComparer_WallFrame_filled();
		public override int Compare(GRGEN_MODEL.IWallFrame b, GRGEN_MODEL.IWallFrame a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_WallFrame_filled
	{
		private static GRGEN_MODEL.IWallFrame instanceBearingAttributeForSearch = new GRGEN_MODEL.@WallFrame();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IWallFrame> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IWallFrame> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_WallFrame_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayOrderAscendingBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>(list);
			newList.Sort(Comparer_WallFrame_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayOrderDescendingBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>(list);
			newList.Sort(ReverseComparer_WallFrame_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayGroupBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IWallFrame>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IWallFrame>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IWallFrame> tempList = new List<GRGEN_MODEL.IWallFrame>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>();
			foreach(List<GRGEN_MODEL.IWallFrame> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IWallFrame> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<GRGEN_MODEL.IWallFrame> newList = new List<GRGEN_MODEL.IWallFrame>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IWallFrame element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IWallFrame> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IWallFrame entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node Module ***

	public interface IModule : IDesignNode
	{
	}

	public sealed partial class @Module : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IModule
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Module[] pool;

		// explicit initializations of DesignNode for target Module
		// implicit initializations of DesignNode for target Module
		// explicit initializations of Module for target Module
		// implicit initializations of Module for target Module
		static @Module() {
		}

		public @Module() : base(GRGEN_MODEL.NodeType_Module.typeVar)
		{
			// implicit initialization, container creation of Module
			// explicit initializations of DesignNode for target Module
			// explicit initializations of Module for target Module
		}

		public static GRGEN_MODEL.NodeType_Module TypeInstance { get { return GRGEN_MODEL.NodeType_Module.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@Module(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Module(this, graph, oldToNewObjectMap);
		}

		private @Module(GRGEN_MODEL.@Module oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_Module.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Module))
				return false;
			@Module that_ = (@Module)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Module CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Module node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Module();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Module[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Module
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Module
				// explicit initializations of Module for target Module
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Module CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@Module node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Module();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Module[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of Module
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target Module
				// explicit initializations of Module for target Module
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Module[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"Module\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"Module\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Module
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target Module
			// explicit initializations of Module for target Module
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Module does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Module does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_Module : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Module typeVar = new GRGEN_MODEL.NodeType_Module();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_Module() : base((int) NodeTypes.@Module)
		{
		}
		public override string Name { get { return "Module"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Module"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IModule"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Module"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Module();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Module newNode = new GRGEN_MODEL.@Module();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: Module
					{
						GRGEN_MODEL.IModule old = (GRGEN_MODEL.IModule) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_Module_isAlignmentNode : Comparer<GRGEN_MODEL.IModule>
	{
		public static Comparer_Module_isAlignmentNode thisComparer = new Comparer_Module_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IModule a, GRGEN_MODEL.IModule b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_Module_isAlignmentNode : Comparer<GRGEN_MODEL.IModule>
	{
		public static ReverseComparer_Module_isAlignmentNode thisComparer = new ReverseComparer_Module_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IModule b, GRGEN_MODEL.IModule a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_Module_isAlignmentNode
	{
		private static GRGEN_MODEL.IModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@Module();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IModule> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Module_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IModule> list)
		{
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>(list);
			newList.Sort(Comparer_Module_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IModule> list)
		{
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>(list);
			newList.Sort(ReverseComparer_Module_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IModule> ArrayGroupBy(List<GRGEN_MODEL.IModule> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IModule>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IModule> tempList = new List<GRGEN_MODEL.IModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>();
			foreach(List<GRGEN_MODEL.IModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IModule> list)
		{
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IModule> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IModule entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_Module_filled : Comparer<GRGEN_MODEL.IModule>
	{
		public static Comparer_Module_filled thisComparer = new Comparer_Module_filled();
		public override int Compare(GRGEN_MODEL.IModule a, GRGEN_MODEL.IModule b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_Module_filled : Comparer<GRGEN_MODEL.IModule>
	{
		public static ReverseComparer_Module_filled thisComparer = new ReverseComparer_Module_filled();
		public override int Compare(GRGEN_MODEL.IModule b, GRGEN_MODEL.IModule a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_Module_filled
	{
		private static GRGEN_MODEL.IModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@Module();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IModule> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_Module_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IModule> list)
		{
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>(list);
			newList.Sort(Comparer_Module_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IModule> list)
		{
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>(list);
			newList.Sort(ReverseComparer_Module_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IModule> ArrayGroupBy(List<GRGEN_MODEL.IModule> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IModule>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IModule> tempList = new List<GRGEN_MODEL.IModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>();
			foreach(List<GRGEN_MODEL.IModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IModule> list)
		{
			List<GRGEN_MODEL.IModule> newList = new List<GRGEN_MODEL.IModule>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IModule> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IModule entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	// *** Node FrameModule ***

	public interface IFrameModule : IModule
	{
		GRGEN_MODEL.ENUM_Size @size { get; set; }
		GRGEN_MODEL.ENUM_Overhang @overhang { get; set; }
		GRGEN_MODEL.ENUM_Filling @filling { get; set; }
	}

	public sealed partial class @FrameModule : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IFrameModule
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@FrameModule[] pool;

		// explicit initializations of DesignNode for target FrameModule
		// implicit initializations of DesignNode for target FrameModule
		// explicit initializations of Module for target FrameModule
		// implicit initializations of Module for target FrameModule
		// explicit initializations of FrameModule for target FrameModule
		// implicit initializations of FrameModule for target FrameModule
		static @FrameModule() {
		}

		public @FrameModule() : base(GRGEN_MODEL.NodeType_FrameModule.typeVar)
		{
			// implicit initialization, container creation of FrameModule
			// explicit initializations of DesignNode for target FrameModule
			// explicit initializations of Module for target FrameModule
			// explicit initializations of FrameModule for target FrameModule
		}

		public static GRGEN_MODEL.NodeType_FrameModule TypeInstance { get { return GRGEN_MODEL.NodeType_FrameModule.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@FrameModule(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@FrameModule(this, graph, oldToNewObjectMap);
		}

		private @FrameModule(GRGEN_MODEL.@FrameModule oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_FrameModule.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
			size_M0no_suXx_h4rD = oldElem.size_M0no_suXx_h4rD;
			overhang_M0no_suXx_h4rD = oldElem.overhang_M0no_suXx_h4rD;
			filling_M0no_suXx_h4rD = oldElem.filling_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @FrameModule))
				return false;
			@FrameModule that_ = (@FrameModule)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				&& size_M0no_suXx_h4rD == that_.size_M0no_suXx_h4rD
				&& overhang_M0no_suXx_h4rD == that_.overhang_M0no_suXx_h4rD
				&& filling_M0no_suXx_h4rD == that_.filling_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@FrameModule CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@FrameModule node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@FrameModule();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@FrameModule[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of FrameModule
				node.@isAlignmentNode = false;
				node.@filled = false;
				node.@size = 0;
				node.@overhang = 0;
				node.@filling = 0;
				// explicit initializations of DesignNode for target FrameModule
				// explicit initializations of Module for target FrameModule
				// explicit initializations of FrameModule for target FrameModule
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@FrameModule CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@FrameModule node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@FrameModule();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@FrameModule[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of FrameModule
				node.@isAlignmentNode = false;
				node.@filled = false;
				node.@size = 0;
				node.@overhang = 0;
				node.@filling = 0;
				// explicit initializations of DesignNode for target FrameModule
				// explicit initializations of Module for target FrameModule
				// explicit initializations of FrameModule for target FrameModule
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@FrameModule[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}

		private GRGEN_MODEL.ENUM_Size size_M0no_suXx_h4rD;
		public GRGEN_MODEL.ENUM_Size @size
		{
			get { return size_M0no_suXx_h4rD; }
			set { size_M0no_suXx_h4rD = value; }
		}

		private GRGEN_MODEL.ENUM_Overhang overhang_M0no_suXx_h4rD;
		public GRGEN_MODEL.ENUM_Overhang @overhang
		{
			get { return overhang_M0no_suXx_h4rD; }
			set { overhang_M0no_suXx_h4rD = value; }
		}

		private GRGEN_MODEL.ENUM_Filling filling_M0no_suXx_h4rD;
		public GRGEN_MODEL.ENUM_Filling @filling
		{
			get { return filling_M0no_suXx_h4rD; }
			set { filling_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
				case "size": return this.@size;
				case "overhang": return this.@overhang;
				case "filling": return this.@filling;
			}
			throw new NullReferenceException(
				"The Node type \"FrameModule\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
				case "size": this.@size = (GRGEN_MODEL.ENUM_Size) value; return;
				case "overhang": this.@overhang = (GRGEN_MODEL.ENUM_Overhang) value; return;
				case "filling": this.@filling = (GRGEN_MODEL.ENUM_Filling) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"FrameModule\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of FrameModule
			this.@isAlignmentNode = false;
			this.@filled = false;
			this.@size = 0;
			this.@overhang = 0;
			this.@filling = 0;
			// explicit initializations of DesignNode for target FrameModule
			// explicit initializations of Module for target FrameModule
			// explicit initializations of FrameModule for target FrameModule
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("FrameModule does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("FrameModule does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_FrameModule : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_FrameModule typeVar = new GRGEN_MODEL.NodeType_FrameModule();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public static GRGEN_LIBGR.AttributeType AttributeType_size;
		public static GRGEN_LIBGR.AttributeType AttributeType_overhang;
		public static GRGEN_LIBGR.AttributeType AttributeType_filling;
		public NodeType_FrameModule() : base((int) NodeTypes.@FrameModule)
		{
			AttributeType_size = new GRGEN_LIBGR.AttributeType("size", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@Size, null, null, null, null, null, typeof(GRGEN_MODEL.ENUM_Size));
			AttributeType_overhang = new GRGEN_LIBGR.AttributeType("overhang", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@Overhang, null, null, null, null, null, typeof(GRGEN_MODEL.ENUM_Overhang));
			AttributeType_filling = new GRGEN_LIBGR.AttributeType("filling", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@Filling, null, null, null, null, null, typeof(GRGEN_MODEL.ENUM_Filling));
		}
		public override string Name { get { return "FrameModule"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "FrameModule"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IFrameModule"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@FrameModule"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@FrameModule();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 5; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
				yield return AttributeType_size;
				yield return AttributeType_overhang;
				yield return AttributeType_filling;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
				case "size" : return AttributeType_size;
				case "overhang" : return AttributeType_overhang;
				case "filling" : return AttributeType_filling;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@FrameModule newNode = new GRGEN_MODEL.@FrameModule();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: Module
					{
						GRGEN_MODEL.IModule old = (GRGEN_MODEL.IModule) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
					// copy attributes for: FrameModule
					{
						GRGEN_MODEL.IFrameModule old = (GRGEN_MODEL.IFrameModule) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
						newNode.@size = old.@size;
						newNode.@overhang = old.@overhang;
						newNode.@filling = old.@filling;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_FrameModule_isAlignmentNode : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static Comparer_FrameModule_isAlignmentNode thisComparer = new Comparer_FrameModule_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IFrameModule a, GRGEN_MODEL.IFrameModule b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_FrameModule_isAlignmentNode : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static ReverseComparer_FrameModule_isAlignmentNode thisComparer = new ReverseComparer_FrameModule_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.IFrameModule b, GRGEN_MODEL.IFrameModule a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_FrameModule_isAlignmentNode
	{
		private static GRGEN_MODEL.IFrameModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@FrameModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IFrameModule> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_FrameModule_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(Comparer_FrameModule_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(ReverseComparer_FrameModule_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayGroupBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IFrameModule>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IFrameModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IFrameModule> tempList = new List<GRGEN_MODEL.IFrameModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			foreach(List<GRGEN_MODEL.IFrameModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IFrameModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IFrameModule entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_FrameModule_filled : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static Comparer_FrameModule_filled thisComparer = new Comparer_FrameModule_filled();
		public override int Compare(GRGEN_MODEL.IFrameModule a, GRGEN_MODEL.IFrameModule b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_FrameModule_filled : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static ReverseComparer_FrameModule_filled thisComparer = new ReverseComparer_FrameModule_filled();
		public override int Compare(GRGEN_MODEL.IFrameModule b, GRGEN_MODEL.IFrameModule a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_FrameModule_filled
	{
		private static GRGEN_MODEL.IFrameModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@FrameModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IFrameModule> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_FrameModule_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(Comparer_FrameModule_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(ReverseComparer_FrameModule_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayGroupBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.IFrameModule>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.IFrameModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IFrameModule> tempList = new List<GRGEN_MODEL.IFrameModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			foreach(List<GRGEN_MODEL.IFrameModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IFrameModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.IFrameModule entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	public class Comparer_FrameModule_size : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static Comparer_FrameModule_size thisComparer = new Comparer_FrameModule_size();
		public override int Compare(GRGEN_MODEL.IFrameModule a, GRGEN_MODEL.IFrameModule b)
		{
			return a.@size.CompareTo(b.@size);
		}
	}

	public class ReverseComparer_FrameModule_size : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static ReverseComparer_FrameModule_size thisComparer = new ReverseComparer_FrameModule_size();
		public override int Compare(GRGEN_MODEL.IFrameModule b, GRGEN_MODEL.IFrameModule a)
		{
			return a.@size.CompareTo(b.@size);
		}
	}

	public class ArrayHelper_FrameModule_size
	{
		private static GRGEN_MODEL.IFrameModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@FrameModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Size entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@size.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Size entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@size.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Size entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@size.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Size entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@size.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Size entry)
		{
			instanceBearingAttributeForSearch.@size = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_FrameModule_size.thisComparer);
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(Comparer_FrameModule_size.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(ReverseComparer_FrameModule_size.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayGroupBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			Dictionary<GRGEN_MODEL.ENUM_Size, List<GRGEN_MODEL.IFrameModule>> seenValues = new Dictionary<GRGEN_MODEL.ENUM_Size, List<GRGEN_MODEL.IFrameModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@size)) {
					seenValues[list[pos].@size].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IFrameModule> tempList = new List<GRGEN_MODEL.IFrameModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@size, tempList);
				}
			}
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			foreach(List<GRGEN_MODEL.IFrameModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			Dictionary<GRGEN_MODEL.ENUM_Size, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.ENUM_Size, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IFrameModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@size)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@size, null);
				}
			}
			return newList;
		}
		public static List<GRGEN_MODEL.ENUM_Size> Extract(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.ENUM_Size> resultList = new List<GRGEN_MODEL.ENUM_Size>(list.Count);
			foreach(GRGEN_MODEL.IFrameModule entry in list)
				resultList.Add(entry.@size);
			return resultList;
		}
	}


	public class Comparer_FrameModule_overhang : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static Comparer_FrameModule_overhang thisComparer = new Comparer_FrameModule_overhang();
		public override int Compare(GRGEN_MODEL.IFrameModule a, GRGEN_MODEL.IFrameModule b)
		{
			return a.@overhang.CompareTo(b.@overhang);
		}
	}

	public class ReverseComparer_FrameModule_overhang : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static ReverseComparer_FrameModule_overhang thisComparer = new ReverseComparer_FrameModule_overhang();
		public override int Compare(GRGEN_MODEL.IFrameModule b, GRGEN_MODEL.IFrameModule a)
		{
			return a.@overhang.CompareTo(b.@overhang);
		}
	}

	public class ArrayHelper_FrameModule_overhang
	{
		private static GRGEN_MODEL.IFrameModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@FrameModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Overhang entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@overhang.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Overhang entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@overhang.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Overhang entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@overhang.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Overhang entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@overhang.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Overhang entry)
		{
			instanceBearingAttributeForSearch.@overhang = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_FrameModule_overhang.thisComparer);
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(Comparer_FrameModule_overhang.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(ReverseComparer_FrameModule_overhang.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayGroupBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			Dictionary<GRGEN_MODEL.ENUM_Overhang, List<GRGEN_MODEL.IFrameModule>> seenValues = new Dictionary<GRGEN_MODEL.ENUM_Overhang, List<GRGEN_MODEL.IFrameModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@overhang)) {
					seenValues[list[pos].@overhang].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IFrameModule> tempList = new List<GRGEN_MODEL.IFrameModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@overhang, tempList);
				}
			}
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			foreach(List<GRGEN_MODEL.IFrameModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			Dictionary<GRGEN_MODEL.ENUM_Overhang, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.ENUM_Overhang, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IFrameModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@overhang)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@overhang, null);
				}
			}
			return newList;
		}
		public static List<GRGEN_MODEL.ENUM_Overhang> Extract(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.ENUM_Overhang> resultList = new List<GRGEN_MODEL.ENUM_Overhang>(list.Count);
			foreach(GRGEN_MODEL.IFrameModule entry in list)
				resultList.Add(entry.@overhang);
			return resultList;
		}
	}


	public class Comparer_FrameModule_filling : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static Comparer_FrameModule_filling thisComparer = new Comparer_FrameModule_filling();
		public override int Compare(GRGEN_MODEL.IFrameModule a, GRGEN_MODEL.IFrameModule b)
		{
			return a.@filling.CompareTo(b.@filling);
		}
	}

	public class ReverseComparer_FrameModule_filling : Comparer<GRGEN_MODEL.IFrameModule>
	{
		public static ReverseComparer_FrameModule_filling thisComparer = new ReverseComparer_FrameModule_filling();
		public override int Compare(GRGEN_MODEL.IFrameModule b, GRGEN_MODEL.IFrameModule a)
		{
			return a.@filling.CompareTo(b.@filling);
		}
	}

	public class ArrayHelper_FrameModule_filling
	{
		private static GRGEN_MODEL.IFrameModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@FrameModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Filling entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filling.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Filling entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filling.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Filling entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filling.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Filling entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filling.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IFrameModule> list, GRGEN_MODEL.ENUM_Filling entry)
		{
			instanceBearingAttributeForSearch.@filling = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_FrameModule_filling.thisComparer);
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(Comparer_FrameModule_filling.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>(list);
			newList.Sort(ReverseComparer_FrameModule_filling.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayGroupBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			Dictionary<GRGEN_MODEL.ENUM_Filling, List<GRGEN_MODEL.IFrameModule>> seenValues = new Dictionary<GRGEN_MODEL.ENUM_Filling, List<GRGEN_MODEL.IFrameModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filling)) {
					seenValues[list[pos].@filling].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IFrameModule> tempList = new List<GRGEN_MODEL.IFrameModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filling, tempList);
				}
			}
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			foreach(List<GRGEN_MODEL.IFrameModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IFrameModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.IFrameModule> newList = new List<GRGEN_MODEL.IFrameModule>();
			Dictionary<GRGEN_MODEL.ENUM_Filling, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.ENUM_Filling, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IFrameModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filling)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filling, null);
				}
			}
			return newList;
		}
		public static List<GRGEN_MODEL.ENUM_Filling> Extract(List<GRGEN_MODEL.IFrameModule> list)
		{
			List<GRGEN_MODEL.ENUM_Filling> resultList = new List<GRGEN_MODEL.ENUM_Filling>(list.Count);
			foreach(GRGEN_MODEL.IFrameModule entry in list)
				resultList.Add(entry.@filling);
			return resultList;
		}
	}


	// *** Node LModule ***

	public interface ILModule : IModule
	{
	}

	public sealed partial class @LModule : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ILModule
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@LModule[] pool;

		// explicit initializations of DesignNode for target LModule
		// implicit initializations of DesignNode for target LModule
		// explicit initializations of Module for target LModule
		// implicit initializations of Module for target LModule
		// explicit initializations of LModule for target LModule
		// implicit initializations of LModule for target LModule
		static @LModule() {
		}

		public @LModule() : base(GRGEN_MODEL.NodeType_LModule.typeVar)
		{
			// implicit initialization, container creation of LModule
			// explicit initializations of DesignNode for target LModule
			// explicit initializations of Module for target LModule
			// explicit initializations of LModule for target LModule
		}

		public static GRGEN_MODEL.NodeType_LModule TypeInstance { get { return GRGEN_MODEL.NodeType_LModule.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() {
			return new GRGEN_MODEL.@LModule(this, null, null);
		}

		public override GRGEN_LIBGR.INode Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@LModule(this, graph, oldToNewObjectMap);
		}

		private @LModule(GRGEN_MODEL.@LModule oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.NodeType_LModule.typeVar)
		{
			isAlignmentNode_M0no_suXx_h4rD = oldElem.isAlignmentNode_M0no_suXx_h4rD;
			filled_M0no_suXx_h4rD = oldElem.filled_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @LModule))
				return false;
			@LModule that_ = (@LModule)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& isAlignmentNode_M0no_suXx_h4rD == that_.isAlignmentNode_M0no_suXx_h4rD
				&& filled_M0no_suXx_h4rD == that_.filled_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@LModule CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@LModule node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@LModule();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@LModule[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of LModule
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target LModule
				// explicit initializations of Module for target LModule
				// explicit initializations of LModule for target LModule
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@LModule CreateNode(GRGEN_LGSP.LGSPNamedGraph graph, string nodeName)
		{
			GRGEN_MODEL.@LModule node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@LModule();
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@LModule[GRGEN_LGSP.LGSPGraph.poolSize];
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, container creation of LModule
				node.@isAlignmentNode = false;
				node.@filled = false;
				// explicit initializations of DesignNode for target LModule
				// explicit initializations of Module for target LModule
				// explicit initializations of LModule for target LModule
			}
			graph.AddNode(node, nodeName);
			return node;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@LModule[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}


		private bool isAlignmentNode_M0no_suXx_h4rD;
		public bool @isAlignmentNode
		{
			get { return isAlignmentNode_M0no_suXx_h4rD; }
			set { isAlignmentNode_M0no_suXx_h4rD = value; }
		}

		private bool filled_M0no_suXx_h4rD;
		public bool @filled
		{
			get { return filled_M0no_suXx_h4rD; }
			set { filled_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isAlignmentNode": return this.@isAlignmentNode;
				case "filled": return this.@filled;
			}
			throw new NullReferenceException(
				"The Node type \"LModule\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isAlignmentNode": this.@isAlignmentNode = (bool) value; return;
				case "filled": this.@filled = (bool) value; return;
			}
			throw new NullReferenceException(
				"The Node type \"LModule\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of LModule
			this.@isAlignmentNode = false;
			this.@filled = false;
			// explicit initializations of DesignNode for target LModule
			// explicit initializations of Module for target LModule
			// explicit initializations of LModule for target LModule
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("LModule does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("LModule does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class NodeType_LModule : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_LModule typeVar = new GRGEN_MODEL.NodeType_LModule();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, true, false, true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public NodeType_LModule() : base((int) NodeTypes.@LModule)
		{
		}
		public override string Name { get { return "LModule"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "LModule"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.ILModule"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@LModule"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@LModule();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				yield return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isAlignmentNode" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode;
				case "filled" : return GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@LModule newNode = new GRGEN_MODEL.@LModule();
			switch(oldNode.Type.TypeID)
			{
				case (int) GRGEN_MODEL.NodeTypes.@Design:
				case (int) GRGEN_MODEL.NodeTypes.@Roof:
				case (int) GRGEN_MODEL.NodeTypes.@MainPart:
				case (int) GRGEN_MODEL.NodeTypes.@Base:
				case (int) GRGEN_MODEL.NodeTypes.@RingBar:
				case (int) GRGEN_MODEL.NodeTypes.@Middle:
				case (int) GRGEN_MODEL.NodeTypes.@Post:
				case (int) GRGEN_MODEL.NodeTypes.@Infill:
				case (int) GRGEN_MODEL.NodeTypes.@Door:
				case (int) GRGEN_MODEL.NodeTypes.@Wall:
				case (int) GRGEN_MODEL.NodeTypes.@WallFrame:
					// copy attributes for: DesignNode
					{
						GRGEN_MODEL.IDesignNode old = (GRGEN_MODEL.IDesignNode) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@Module:
				case (int) GRGEN_MODEL.NodeTypes.@FrameModule:
					// copy attributes for: Module
					{
						GRGEN_MODEL.IModule old = (GRGEN_MODEL.IModule) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
				case (int) GRGEN_MODEL.NodeTypes.@LModule:
					// copy attributes for: LModule
					{
						GRGEN_MODEL.ILModule old = (GRGEN_MODEL.ILModule) oldNode;
						newNode.@isAlignmentNode = old.@isAlignmentNode;
						newNode.@filled = old.@filled;
					}
					break;
			}
			return newNode;
		}

	}

	public class Comparer_LModule_isAlignmentNode : Comparer<GRGEN_MODEL.ILModule>
	{
		public static Comparer_LModule_isAlignmentNode thisComparer = new Comparer_LModule_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.ILModule a, GRGEN_MODEL.ILModule b)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ReverseComparer_LModule_isAlignmentNode : Comparer<GRGEN_MODEL.ILModule>
	{
		public static ReverseComparer_LModule_isAlignmentNode thisComparer = new ReverseComparer_LModule_isAlignmentNode();
		public override int Compare(GRGEN_MODEL.ILModule b, GRGEN_MODEL.ILModule a)
		{
			return a.@isAlignmentNode.CompareTo(b.@isAlignmentNode);
		}
	}

	public class ArrayHelper_LModule_isAlignmentNode
	{
		private static GRGEN_MODEL.ILModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@LModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@isAlignmentNode.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.ILModule> list, bool entry)
		{
			instanceBearingAttributeForSearch.@isAlignmentNode = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_LModule_isAlignmentNode.thisComparer);
		}
		public static List<GRGEN_MODEL.ILModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.ILModule> list)
		{
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>(list);
			newList.Sort(Comparer_LModule_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.ILModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.ILModule> list)
		{
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>(list);
			newList.Sort(ReverseComparer_LModule_isAlignmentNode.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.ILModule> ArrayGroupBy(List<GRGEN_MODEL.ILModule> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.ILModule>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.ILModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@isAlignmentNode)) {
					seenValues[list[pos].@isAlignmentNode].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.ILModule> tempList = new List<GRGEN_MODEL.ILModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@isAlignmentNode, tempList);
				}
			}
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>();
			foreach(List<GRGEN_MODEL.ILModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.ILModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.ILModule> list)
		{
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.ILModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@isAlignmentNode)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@isAlignmentNode, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.ILModule> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.ILModule entry in list)
				resultList.Add(entry.@isAlignmentNode);
			return resultList;
		}
	}


	public class Comparer_LModule_filled : Comparer<GRGEN_MODEL.ILModule>
	{
		public static Comparer_LModule_filled thisComparer = new Comparer_LModule_filled();
		public override int Compare(GRGEN_MODEL.ILModule a, GRGEN_MODEL.ILModule b)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ReverseComparer_LModule_filled : Comparer<GRGEN_MODEL.ILModule>
	{
		public static ReverseComparer_LModule_filled thisComparer = new ReverseComparer_LModule_filled();
		public override int Compare(GRGEN_MODEL.ILModule b, GRGEN_MODEL.ILModule a)
		{
			return a.@filled.CompareTo(b.@filled);
		}
	}

	public class ArrayHelper_LModule_filled
	{
		private static GRGEN_MODEL.ILModule instanceBearingAttributeForSearch = new GRGEN_MODEL.@LModule();
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.ILModule> list, bool entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@filled.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.ILModule> list, bool entry)
		{
			instanceBearingAttributeForSearch.@filled = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_LModule_filled.thisComparer);
		}
		public static List<GRGEN_MODEL.ILModule> ArrayOrderAscendingBy(List<GRGEN_MODEL.ILModule> list)
		{
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>(list);
			newList.Sort(Comparer_LModule_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.ILModule> ArrayOrderDescendingBy(List<GRGEN_MODEL.ILModule> list)
		{
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>(list);
			newList.Sort(ReverseComparer_LModule_filled.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.ILModule> ArrayGroupBy(List<GRGEN_MODEL.ILModule> list)
		{
			Dictionary<bool, List<GRGEN_MODEL.ILModule>> seenValues = new Dictionary<bool, List<GRGEN_MODEL.ILModule>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@filled)) {
					seenValues[list[pos].@filled].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.ILModule> tempList = new List<GRGEN_MODEL.ILModule>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@filled, tempList);
				}
			}
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>();
			foreach(List<GRGEN_MODEL.ILModule> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.ILModule> ArrayKeepOneForEachBy(List<GRGEN_MODEL.ILModule> list)
		{
			List<GRGEN_MODEL.ILModule> newList = new List<GRGEN_MODEL.ILModule>();
			Dictionary<bool, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<bool, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.ILModule element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@filled)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@filled, null);
				}
			}
			return newList;
		}
		public static List<bool> Extract(List<GRGEN_MODEL.ILModule> list)
		{
			List<bool> resultList = new List<bool>(list.Count);
			foreach(GRGEN_MODEL.ILModule entry in list)
				resultList.Add(entry.@filled);
			return resultList;
		}
	}


	//
	// Edge types
	//

	public enum EdgeTypes { @AEdge=0, @Edge=1, @UEdge=2, @contains=3, @connected=4, @next=5, @locatedNext=6, @right=7, @infront=8, @above=9 };

	// *** Edge AEdge ***


	public sealed partial class EdgeType_AEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_AEdge typeVar = new GRGEN_MODEL.EdgeType_AEdge();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_AEdge() : base((int) EdgeTypes.@AEdge)
		{
		}
		public override string Name { get { return "AEdge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "AEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return null; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Arbitrary; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type AEdge cannot be instantiated!");
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type AEdge does not support source and target setting!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			throw new Exception("Cannot retype to the abstract type AEdge!");
		}
	}

	// *** Edge Edge ***


	public sealed partial class @Edge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IDEdge
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@Edge[] pool;

		static @Edge() {
		}

		public @Edge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, source, target)
		{
			// implicit initialization, container creation of Edge
		}

		public static GRGEN_MODEL.EdgeType_Edge TypeInstance { get { return GRGEN_MODEL.EdgeType_Edge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@Edge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@Edge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @Edge(GRGEN_MODEL.@Edge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Edge))
				return false;
			@Edge that_ = (@Edge)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Edge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of Edge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@Edge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of Edge
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@Edge[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"Edge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"Edge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Edge
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Edge does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Edge does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_Edge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Edge typeVar = new GRGEN_MODEL.EdgeType_Edge();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, true, false, true, false, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_Edge() : base((int) EdgeTypes.@Edge)
		{
		}
		public override string Name { get { return "Edge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Edge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IDEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Edge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge UEdge ***


	public sealed partial class @UEdge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IUEdge
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@UEdge[] pool;

		static @UEdge() {
		}

		public @UEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, source, target)
		{
			// implicit initialization, container creation of UEdge
		}

		public static GRGEN_MODEL.EdgeType_UEdge TypeInstance { get { return GRGEN_MODEL.EdgeType_UEdge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@UEdge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@UEdge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @UEdge(GRGEN_MODEL.@UEdge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @UEdge))
				return false;
			@UEdge that_ = (@UEdge)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@UEdge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of UEdge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@UEdge[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of UEdge
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@UEdge[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"UEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"UEdge\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of UEdge
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("UEdge does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("UEdge does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_UEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_UEdge typeVar = new GRGEN_MODEL.EdgeType_UEdge();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, true, false, true, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_UEdge() : base((int) EdgeTypes.@UEdge)
		{
		}
		public override string Name { get { return "UEdge"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "UEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IUEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@UEdge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Undirected; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge contains ***

	public interface Icontains : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class @contains : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Icontains
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@contains[] pool;

		// explicit initializations of contains for target contains
		// implicit initializations of contains for target contains
		static @contains() {
		}

		public @contains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_contains.typeVar, source, target)
		{
			// implicit initialization, container creation of contains
			// explicit initializations of contains for target contains
		}

		public static GRGEN_MODEL.EdgeType_contains TypeInstance { get { return GRGEN_MODEL.EdgeType_contains.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@contains(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@contains(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @contains(GRGEN_MODEL.@contains oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_contains.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @contains))
				return false;
			@contains that_ = (@contains)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@contains CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@contains edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@contains(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@contains[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of contains
				// explicit initializations of contains for target contains
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@contains CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@contains edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@contains(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@contains[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of contains
				// explicit initializations of contains for target contains
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@contains[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"contains\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"contains\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of contains
			// explicit initializations of contains for target contains
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("contains does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("contains does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_contains : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_contains typeVar = new GRGEN_MODEL.EdgeType_contains();
		public static bool[] isA = new bool[] { true, true, false, true, false, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_contains() : base((int) EdgeTypes.@contains)
		{
		}
		public override string Name { get { return "contains"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "contains"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.Icontains"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@contains"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@contains((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@contains((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge connected ***

	public interface Iconnected : GRGEN_LIBGR.IUEdge
	{
	}

	public sealed partial class @connected : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iconnected
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@connected[] pool;

		// explicit initializations of connected for target connected
		// implicit initializations of connected for target connected
		static @connected() {
		}

		public @connected(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_connected.typeVar, source, target)
		{
			// implicit initialization, container creation of connected
			// explicit initializations of connected for target connected
		}

		public static GRGEN_MODEL.EdgeType_connected TypeInstance { get { return GRGEN_MODEL.EdgeType_connected.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@connected(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@connected(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @connected(GRGEN_MODEL.@connected oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_connected.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @connected))
				return false;
			@connected that_ = (@connected)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@connected CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@connected edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@connected(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@connected[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of connected
				// explicit initializations of connected for target connected
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@connected CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@connected edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@connected(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@connected[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of connected
				// explicit initializations of connected for target connected
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@connected[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"connected\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"connected\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of connected
			// explicit initializations of connected for target connected
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("connected does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("connected does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_connected : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_connected typeVar = new GRGEN_MODEL.EdgeType_connected();
		public static bool[] isA = new bool[] { true, false, true, false, true, false, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_connected() : base((int) EdgeTypes.@connected)
		{
		}
		public override string Name { get { return "connected"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "connected"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.Iconnected"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@connected"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Undirected; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@connected((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@connected((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge next ***

	public interface Inext : GRGEN_LIBGR.IDEdge
	{
	}

	public sealed partial class EdgeType_next : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_next typeVar = new GRGEN_MODEL.EdgeType_next();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, true, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_next() : base((int) EdgeTypes.@next)
		{
		}
		public override string Name { get { return "next"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "next"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.Inext"; } }
		public override string EdgeClassName { get { return null; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type next cannot be instantiated!");
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type next does not support source and target setting!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			throw new Exception("Cannot retype to the abstract type next!");
		}
	}

	// *** Edge locatedNext ***

	public interface IlocatedNext : Inext
	{
	}

	public sealed partial class EdgeType_locatedNext : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_locatedNext typeVar = new GRGEN_MODEL.EdgeType_locatedNext();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, true, false, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, true, true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_locatedNext() : base((int) EdgeTypes.@locatedNext)
		{
		}
		public override string Name { get { return "locatedNext"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "locatedNext"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IlocatedNext"; } }
		public override string EdgeClassName { get { return null; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type locatedNext cannot be instantiated!");
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type locatedNext does not support source and target setting!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			throw new Exception("Cannot retype to the abstract type locatedNext!");
		}
	}

	// *** Edge right ***

	public interface Iright : IlocatedNext
	{
	}

	public sealed partial class @right : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iright
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@right[] pool;

		// explicit initializations of next for target right
		// implicit initializations of next for target right
		// explicit initializations of locatedNext for target right
		// implicit initializations of locatedNext for target right
		// explicit initializations of right for target right
		// implicit initializations of right for target right
		static @right() {
		}

		public @right(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_right.typeVar, source, target)
		{
			// implicit initialization, container creation of right
			// explicit initializations of next for target right
			// explicit initializations of locatedNext for target right
			// explicit initializations of right for target right
		}

		public static GRGEN_MODEL.EdgeType_right TypeInstance { get { return GRGEN_MODEL.EdgeType_right.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@right(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@right(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @right(GRGEN_MODEL.@right oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_right.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @right))
				return false;
			@right that_ = (@right)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@right CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@right edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@right(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@right[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of right
				// explicit initializations of next for target right
				// explicit initializations of locatedNext for target right
				// explicit initializations of right for target right
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@right CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@right edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@right(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@right[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of right
				// explicit initializations of next for target right
				// explicit initializations of locatedNext for target right
				// explicit initializations of right for target right
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@right[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"right\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"right\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of right
			// explicit initializations of next for target right
			// explicit initializations of locatedNext for target right
			// explicit initializations of right for target right
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("right does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("right does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_right : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_right typeVar = new GRGEN_MODEL.EdgeType_right();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, true, true, false, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, true, false, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_right() : base((int) EdgeTypes.@right)
		{
		}
		public override string Name { get { return "right"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "right"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.Iright"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@right"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@right((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@right((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge infront ***

	public interface Iinfront : IlocatedNext
	{
	}

	public sealed partial class @infront : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iinfront
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@infront[] pool;

		// explicit initializations of next for target infront
		// implicit initializations of next for target infront
		// explicit initializations of locatedNext for target infront
		// implicit initializations of locatedNext for target infront
		// explicit initializations of infront for target infront
		// implicit initializations of infront for target infront
		static @infront() {
		}

		public @infront(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_infront.typeVar, source, target)
		{
			// implicit initialization, container creation of infront
			// explicit initializations of next for target infront
			// explicit initializations of locatedNext for target infront
			// explicit initializations of infront for target infront
		}

		public static GRGEN_MODEL.EdgeType_infront TypeInstance { get { return GRGEN_MODEL.EdgeType_infront.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@infront(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@infront(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @infront(GRGEN_MODEL.@infront oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_infront.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @infront))
				return false;
			@infront that_ = (@infront)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@infront CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@infront edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@infront(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@infront[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of infront
				// explicit initializations of next for target infront
				// explicit initializations of locatedNext for target infront
				// explicit initializations of infront for target infront
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@infront CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@infront edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@infront(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@infront[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of infront
				// explicit initializations of next for target infront
				// explicit initializations of locatedNext for target infront
				// explicit initializations of infront for target infront
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@infront[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"infront\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"infront\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of infront
			// explicit initializations of next for target infront
			// explicit initializations of locatedNext for target infront
			// explicit initializations of infront for target infront
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("infront does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("infront does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_infront : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_infront typeVar = new GRGEN_MODEL.EdgeType_infront();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, true, false, true, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, false, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_infront() : base((int) EdgeTypes.@infront)
		{
		}
		public override string Name { get { return "infront"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "infront"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.Iinfront"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@infront"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@infront((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@infront((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge above ***

	public interface Iabove : IlocatedNext
	{
	}

	public sealed partial class @above : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iabove
	{
		[ThreadStatic] private static int poolLevel;
		[ThreadStatic] private static GRGEN_MODEL.@above[] pool;

		// explicit initializations of next for target above
		// implicit initializations of next for target above
		// explicit initializations of locatedNext for target above
		// implicit initializations of locatedNext for target above
		// explicit initializations of above for target above
		// implicit initializations of above for target above
		static @above() {
		}

		public @above(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_above.typeVar, source, target)
		{
			// implicit initialization, container creation of above
			// explicit initializations of next for target above
			// explicit initializations of locatedNext for target above
			// explicit initializations of above for target above
		}

		public static GRGEN_MODEL.EdgeType_above TypeInstance { get { return GRGEN_MODEL.EdgeType_above.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget) {
			return new GRGEN_MODEL.@above(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, null, null);
		}

		public override GRGEN_LIBGR.IEdge Copy(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@above(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget, graph, oldToNewObjectMap);
		}

		private @above(GRGEN_MODEL.@above oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
			: base(GRGEN_MODEL.EdgeType_above.typeVar, newSource, newTarget)
		{
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @above))
				return false;
			@above that_ = (@above)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public static GRGEN_MODEL.@above CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@above edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@above(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@above[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of above
				// explicit initializations of next for target above
				// explicit initializations of locatedNext for target above
				// explicit initializations of above for target above
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@above CreateEdge(GRGEN_LGSP.LGSPNamedGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			GRGEN_MODEL.@above edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@above(source, target);
			else
			{
				if(pool == null)
					pool = new GRGEN_MODEL.@above[GRGEN_LGSP.LGSPGraph.poolSize];
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, container creation of above
				// explicit initializations of next for target above
				// explicit initializations of locatedNext for target above
				// explicit initializations of above for target above
			}
			graph.AddEdge(edge, edgeName);
			return edge;
		}

		public override void Recycle()
		{
			if(pool == null)
				pool = new GRGEN_MODEL.@above[GRGEN_LGSP.LGSPGraph.poolSize];
			if(poolLevel < pool.Length)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Edge type \"above\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Edge type \"above\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of above
			// explicit initializations of next for target above
			// explicit initializations of locatedNext for target above
			// explicit initializations of above for target above
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("above does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("above does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class EdgeType_above : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_above typeVar = new GRGEN_MODEL.EdgeType_above();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, true, false, false, true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public EdgeType_above() : base((int) EdgeTypes.@above)
		{
		}
		public override string Name { get { return "above"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "above"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.Iabove"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@above"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@above((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}


		public override void SetSourceAndTarget(GRGEN_LIBGR.IEdge edge, GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			((GRGEN_LGSP.LGSPEdge)edge).SetSourceAndTarget((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@above((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	//
	// Object types
	//

	public enum ObjectTypes { @Object=0, @QuasiPlane=1 };

	// *** Object Object ***


	public sealed partial class @Object : GRGEN_LGSP.LGSPObject, GRGEN_LIBGR.IObject
	{

		static @Object() {
		}

		//create object by CreateObject of the type class, not this internal-use constructor
		public @Object(long uniqueId) : base(GRGEN_MODEL.ObjectType_Object.typeVar, uniqueId)
		{
			// implicit initialization, container creation of Object
		}

		public static GRGEN_MODEL.ObjectType_Object TypeInstance { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }

		public override GRGEN_LIBGR.IObject Clone(GRGEN_LIBGR.IGraph graph) {
			GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(this, graph, null);
			((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
			return newObject;
		}

		public override GRGEN_LIBGR.IObject Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(this, graph, oldToNewObjectMap);
			((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
			return newObject;
		}

		private @Object(GRGEN_MODEL.@Object oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.ObjectType_Object.typeVar, graph.GlobalVariables.FetchObjectUniqueId())
		{
			if(oldToNewObjectMap != null)
				oldToNewObjectMap.Add(oldElem, this);
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @Object))
				return false;
			@Object that_ = (@Object)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The Object type \"Object\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The Object type \"Object\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of Object
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Object does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("Object does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class ObjectType_Object : GRGEN_LIBGR.ObjectType
	{
		public static GRGEN_MODEL.ObjectType_Object typeVar = new GRGEN_MODEL.ObjectType_Object();
		public static bool[] isA = new bool[] { true, false, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public ObjectType_Object() : base((int) ObjectTypes.@Object)
		{
		}
		public override string Name { get { return "Object"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "Object"; } }
		public override string ObjectInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IObject"; } }
		public override string ObjectClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@Object"; } }
		public override GRGEN_LIBGR.IObject CreateObject(GRGEN_LIBGR.IGraph graph, long uniqueId)
		{
			if(uniqueId != -1) {
				GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(graph.GlobalVariables.FetchObjectUniqueId(uniqueId));
				((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
				return newObject;
			} else {
				GRGEN_MODEL.@Object newObject = new GRGEN_MODEL.@Object(graph.GlobalVariables.FetchObjectUniqueId());
				((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
				return newObject;
			}
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
	}

	// *** Object QuasiPlane ***

	public interface IQuasiPlane : GRGEN_LIBGR.IObject
	{
		double @xyRotation { get; set; }
		double @xzRotation { get; set; }
		double @yzRotation { get; set; }
	}

	public sealed partial class @QuasiPlane : GRGEN_LGSP.LGSPObject, GRGEN_MODEL.IQuasiPlane
	{

		// explicit initializations of QuasiPlane for target QuasiPlane
		// implicit initializations of QuasiPlane for target QuasiPlane
		static @QuasiPlane() {
		}

		//create object by CreateObject of the type class, not this internal-use constructor
		public @QuasiPlane(long uniqueId) : base(GRGEN_MODEL.ObjectType_QuasiPlane.typeVar, uniqueId)
		{
			// implicit initialization, container creation of QuasiPlane
			// explicit initializations of QuasiPlane for target QuasiPlane
		}

		public static GRGEN_MODEL.ObjectType_QuasiPlane TypeInstance { get { return GRGEN_MODEL.ObjectType_QuasiPlane.typeVar; } }

		public override GRGEN_LIBGR.IObject Clone(GRGEN_LIBGR.IGraph graph) {
			GRGEN_MODEL.@QuasiPlane newObject = new GRGEN_MODEL.@QuasiPlane(this, graph, null);
			((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
			return newObject;
		}

		public override GRGEN_LIBGR.IObject Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			GRGEN_MODEL.@QuasiPlane newObject = new GRGEN_MODEL.@QuasiPlane(this, graph, oldToNewObjectMap);
			((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
			return newObject;
		}

		private @QuasiPlane(GRGEN_MODEL.@QuasiPlane oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.ObjectType_QuasiPlane.typeVar, graph.GlobalVariables.FetchObjectUniqueId())
		{
			if(oldToNewObjectMap != null)
				oldToNewObjectMap.Add(oldElem, this);
			xyRotation_M0no_suXx_h4rD = oldElem.xyRotation_M0no_suXx_h4rD;
			xzRotation_M0no_suXx_h4rD = oldElem.xzRotation_M0no_suXx_h4rD;
			yzRotation_M0no_suXx_h4rD = oldElem.yzRotation_M0no_suXx_h4rD;
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @QuasiPlane))
				return false;
			@QuasiPlane that_ = (@QuasiPlane)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				&& xyRotation_M0no_suXx_h4rD == that_.xyRotation_M0no_suXx_h4rD
				&& xzRotation_M0no_suXx_h4rD == that_.xzRotation_M0no_suXx_h4rD
				&& yzRotation_M0no_suXx_h4rD == that_.yzRotation_M0no_suXx_h4rD
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}


		private double xyRotation_M0no_suXx_h4rD;
		public double @xyRotation
		{
			get { return xyRotation_M0no_suXx_h4rD; }
			set { xyRotation_M0no_suXx_h4rD = value; }
		}

		private double xzRotation_M0no_suXx_h4rD;
		public double @xzRotation
		{
			get { return xzRotation_M0no_suXx_h4rD; }
			set { xzRotation_M0no_suXx_h4rD = value; }
		}

		private double yzRotation_M0no_suXx_h4rD;
		public double @yzRotation
		{
			get { return yzRotation_M0no_suXx_h4rD; }
			set { yzRotation_M0no_suXx_h4rD = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "xyRotation": return this.@xyRotation;
				case "xzRotation": return this.@xzRotation;
				case "yzRotation": return this.@yzRotation;
			}
			throw new NullReferenceException(
				"The Object type \"QuasiPlane\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "xyRotation": this.@xyRotation = (double) value; return;
				case "xzRotation": this.@xzRotation = (double) value; return;
				case "yzRotation": this.@yzRotation = (double) value; return;
			}
			throw new NullReferenceException(
				"The Object type \"QuasiPlane\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of QuasiPlane
			this.@xyRotation = 0;
			this.@xzRotation = 0;
			this.@yzRotation = 0;
			// explicit initializations of QuasiPlane for target QuasiPlane
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("QuasiPlane does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("QuasiPlane does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class ObjectType_QuasiPlane : GRGEN_LIBGR.ObjectType
	{
		public static GRGEN_MODEL.ObjectType_QuasiPlane typeVar = new GRGEN_MODEL.ObjectType_QuasiPlane();
		public static bool[] isA = new bool[] { true, true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { false, true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public static GRGEN_LIBGR.AttributeType AttributeType_xyRotation;
		public static GRGEN_LIBGR.AttributeType AttributeType_xzRotation;
		public static GRGEN_LIBGR.AttributeType AttributeType_yzRotation;
		public ObjectType_QuasiPlane() : base((int) ObjectTypes.@QuasiPlane)
		{
			AttributeType_xyRotation = new GRGEN_LIBGR.AttributeType("xyRotation", this, GRGEN_LIBGR.AttributeKind.DoubleAttr, null, null, null, null, null, null, typeof(double));
			AttributeType_xzRotation = new GRGEN_LIBGR.AttributeType("xzRotation", this, GRGEN_LIBGR.AttributeKind.DoubleAttr, null, null, null, null, null, null, typeof(double));
			AttributeType_yzRotation = new GRGEN_LIBGR.AttributeType("yzRotation", this, GRGEN_LIBGR.AttributeKind.DoubleAttr, null, null, null, null, null, null, typeof(double));
		}
		public override string Name { get { return "QuasiPlane"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "QuasiPlane"; } }
		public override string ObjectInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.IQuasiPlane"; } }
		public override string ObjectClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@QuasiPlane"; } }
		public override GRGEN_LIBGR.IObject CreateObject(GRGEN_LIBGR.IGraph graph, long uniqueId)
		{
			if(uniqueId != -1) {
				GRGEN_MODEL.@QuasiPlane newObject = new GRGEN_MODEL.@QuasiPlane(graph.GlobalVariables.FetchObjectUniqueId(uniqueId));
				((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
				return newObject;
			} else {
				GRGEN_MODEL.@QuasiPlane newObject = new GRGEN_MODEL.@QuasiPlane(graph.GlobalVariables.FetchObjectUniqueId());
				((GRGEN_LIBGR.BaseGraph)graph).ObjectCreated(newObject);
				return newObject;
			}
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 3; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_xyRotation;
				yield return AttributeType_xzRotation;
				yield return AttributeType_yzRotation;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "xyRotation" : return AttributeType_xyRotation;
				case "xzRotation" : return AttributeType_xzRotation;
				case "yzRotation" : return AttributeType_yzRotation;
			}
			return null;
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
	}

	public class Comparer_QuasiPlane_xyRotation : Comparer<GRGEN_MODEL.IQuasiPlane>
	{
		public static Comparer_QuasiPlane_xyRotation thisComparer = new Comparer_QuasiPlane_xyRotation();
		public override int Compare(GRGEN_MODEL.IQuasiPlane a, GRGEN_MODEL.IQuasiPlane b)
		{
			return a.@xyRotation.CompareTo(b.@xyRotation);
		}
	}

	public class ReverseComparer_QuasiPlane_xyRotation : Comparer<GRGEN_MODEL.IQuasiPlane>
	{
		public static ReverseComparer_QuasiPlane_xyRotation thisComparer = new ReverseComparer_QuasiPlane_xyRotation();
		public override int Compare(GRGEN_MODEL.IQuasiPlane b, GRGEN_MODEL.IQuasiPlane a)
		{
			return a.@xyRotation.CompareTo(b.@xyRotation);
		}
	}

	public class ArrayHelper_QuasiPlane_xyRotation
	{
		private static GRGEN_MODEL.IQuasiPlane instanceBearingAttributeForSearch = new GRGEN_MODEL.@QuasiPlane(-1);
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@xyRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@xyRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@xyRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@xyRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			instanceBearingAttributeForSearch.@xyRotation = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_QuasiPlane_xyRotation.thisComparer);
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayOrderAscendingBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>(list);
			newList.Sort(Comparer_QuasiPlane_xyRotation.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayOrderDescendingBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>(list);
			newList.Sort(ReverseComparer_QuasiPlane_xyRotation.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayGroupBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			Dictionary<double, List<GRGEN_MODEL.IQuasiPlane>> seenValues = new Dictionary<double, List<GRGEN_MODEL.IQuasiPlane>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@xyRotation)) {
					seenValues[list[pos].@xyRotation].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IQuasiPlane> tempList = new List<GRGEN_MODEL.IQuasiPlane>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@xyRotation, tempList);
				}
			}
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>();
			foreach(List<GRGEN_MODEL.IQuasiPlane> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>();
			Dictionary<double, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<double, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IQuasiPlane element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@xyRotation)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@xyRotation, null);
				}
			}
			return newList;
		}
		public static List<double> Extract(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<double> resultList = new List<double>(list.Count);
			foreach(GRGEN_MODEL.IQuasiPlane entry in list)
				resultList.Add(entry.@xyRotation);
			return resultList;
		}
	}


	public class Comparer_QuasiPlane_xzRotation : Comparer<GRGEN_MODEL.IQuasiPlane>
	{
		public static Comparer_QuasiPlane_xzRotation thisComparer = new Comparer_QuasiPlane_xzRotation();
		public override int Compare(GRGEN_MODEL.IQuasiPlane a, GRGEN_MODEL.IQuasiPlane b)
		{
			return a.@xzRotation.CompareTo(b.@xzRotation);
		}
	}

	public class ReverseComparer_QuasiPlane_xzRotation : Comparer<GRGEN_MODEL.IQuasiPlane>
	{
		public static ReverseComparer_QuasiPlane_xzRotation thisComparer = new ReverseComparer_QuasiPlane_xzRotation();
		public override int Compare(GRGEN_MODEL.IQuasiPlane b, GRGEN_MODEL.IQuasiPlane a)
		{
			return a.@xzRotation.CompareTo(b.@xzRotation);
		}
	}

	public class ArrayHelper_QuasiPlane_xzRotation
	{
		private static GRGEN_MODEL.IQuasiPlane instanceBearingAttributeForSearch = new GRGEN_MODEL.@QuasiPlane(-1);
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@xzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@xzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@xzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@xzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			instanceBearingAttributeForSearch.@xzRotation = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_QuasiPlane_xzRotation.thisComparer);
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayOrderAscendingBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>(list);
			newList.Sort(Comparer_QuasiPlane_xzRotation.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayOrderDescendingBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>(list);
			newList.Sort(ReverseComparer_QuasiPlane_xzRotation.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayGroupBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			Dictionary<double, List<GRGEN_MODEL.IQuasiPlane>> seenValues = new Dictionary<double, List<GRGEN_MODEL.IQuasiPlane>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@xzRotation)) {
					seenValues[list[pos].@xzRotation].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IQuasiPlane> tempList = new List<GRGEN_MODEL.IQuasiPlane>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@xzRotation, tempList);
				}
			}
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>();
			foreach(List<GRGEN_MODEL.IQuasiPlane> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>();
			Dictionary<double, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<double, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IQuasiPlane element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@xzRotation)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@xzRotation, null);
				}
			}
			return newList;
		}
		public static List<double> Extract(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<double> resultList = new List<double>(list.Count);
			foreach(GRGEN_MODEL.IQuasiPlane entry in list)
				resultList.Add(entry.@xzRotation);
			return resultList;
		}
	}


	public class Comparer_QuasiPlane_yzRotation : Comparer<GRGEN_MODEL.IQuasiPlane>
	{
		public static Comparer_QuasiPlane_yzRotation thisComparer = new Comparer_QuasiPlane_yzRotation();
		public override int Compare(GRGEN_MODEL.IQuasiPlane a, GRGEN_MODEL.IQuasiPlane b)
		{
			return a.@yzRotation.CompareTo(b.@yzRotation);
		}
	}

	public class ReverseComparer_QuasiPlane_yzRotation : Comparer<GRGEN_MODEL.IQuasiPlane>
	{
		public static ReverseComparer_QuasiPlane_yzRotation thisComparer = new ReverseComparer_QuasiPlane_yzRotation();
		public override int Compare(GRGEN_MODEL.IQuasiPlane b, GRGEN_MODEL.IQuasiPlane a)
		{
			return a.@yzRotation.CompareTo(b.@yzRotation);
		}
	}

	public class ArrayHelper_QuasiPlane_yzRotation
	{
		private static GRGEN_MODEL.IQuasiPlane instanceBearingAttributeForSearch = new GRGEN_MODEL.@QuasiPlane(-1);
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@yzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@yzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@yzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayLastIndexOfBy(IList<GRGEN_MODEL.IQuasiPlane> list, double entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@yzRotation.Equals(entry))
					return i;
			return -1;
		}
		public static int ArrayIndexOfOrderedBy(List<GRGEN_MODEL.IQuasiPlane> list, double entry)
		{
			instanceBearingAttributeForSearch.@yzRotation = entry;
			return list.BinarySearch(instanceBearingAttributeForSearch, Comparer_QuasiPlane_yzRotation.thisComparer);
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayOrderAscendingBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>(list);
			newList.Sort(Comparer_QuasiPlane_yzRotation.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayOrderDescendingBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>(list);
			newList.Sort(ReverseComparer_QuasiPlane_yzRotation.thisComparer);
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayGroupBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			Dictionary<double, List<GRGEN_MODEL.IQuasiPlane>> seenValues = new Dictionary<double, List<GRGEN_MODEL.IQuasiPlane>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@yzRotation)) {
					seenValues[list[pos].@yzRotation].Add(list[pos]);
				} else {
					List<GRGEN_MODEL.IQuasiPlane> tempList = new List<GRGEN_MODEL.IQuasiPlane>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@yzRotation, tempList);
				}
			}
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>();
			foreach(List<GRGEN_MODEL.IQuasiPlane> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_MODEL.IQuasiPlane> ArrayKeepOneForEachBy(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<GRGEN_MODEL.IQuasiPlane> newList = new List<GRGEN_MODEL.IQuasiPlane>();
			Dictionary<double, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<double, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_MODEL.IQuasiPlane element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@yzRotation)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@yzRotation, null);
				}
			}
			return newList;
		}
		public static List<double> Extract(List<GRGEN_MODEL.IQuasiPlane> list)
		{
			List<double> resultList = new List<double>(list.Count);
			foreach(GRGEN_MODEL.IQuasiPlane entry in list)
				resultList.Add(entry.@yzRotation);
			return resultList;
		}
	}


	//
	// Transient object types
	//

	public enum TransientObjectTypes { @TransientObject=0 };

	// *** TransientObject TransientObject ***


	public sealed partial class @TransientObject : GRGEN_LGSP.LGSPTransientObject, GRGEN_LIBGR.ITransientObject
	{

		static @TransientObject() {
		}

		//create object by CreateTransientObject of the type class, not this internal-use constructor
		public @TransientObject() : base(GRGEN_MODEL.TransientObjectType_TransientObject.typeVar)
		{
			// implicit initialization, container creation of TransientObject
		}

		public static GRGEN_MODEL.TransientObjectType_TransientObject TypeInstance { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }

		public override GRGEN_LIBGR.ITransientObject Clone() {
			return new GRGEN_MODEL.@TransientObject(this, null, null);
		}

		public override GRGEN_LIBGR.ITransientObject Copy(GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) {
			return new GRGEN_MODEL.@TransientObject(this, graph, oldToNewObjectMap);
		}

		private @TransientObject(GRGEN_MODEL.@TransientObject oldElem, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap) : base(GRGEN_MODEL.TransientObjectType_TransientObject.typeVar)
		{
			if(oldToNewObjectMap != null)
				oldToNewObjectMap.Add(oldElem, this);
		}
		
		private GRGEN_LIBGR.IBaseObject Copy(GRGEN_LIBGR.IBaseObject oldObj, GRGEN_LIBGR.IGraph graph, IDictionary<object, object> oldToNewObjectMap)
		{
			if(oldObj == null)
				return null;
			if(oldToNewObjectMap.ContainsKey(oldObj))
				return (GRGEN_LIBGR.IBaseObject)oldToNewObjectMap[oldObj];
			else {
				if(oldObj is GRGEN_LIBGR.IObject) {
					GRGEN_LIBGR.IObject newObj = ((GRGEN_LIBGR.IObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				} else {
					GRGEN_LIBGR.ITransientObject newObj = ((GRGEN_LIBGR.ITransientObject)oldObj).Copy(graph, oldToNewObjectMap);
					return newObj;
				}
			}
		}

		public override bool IsDeeplyEqual(GRGEN_LIBGR.IDeepEqualityComparer that, IDictionary<object, object> visitedObjects) {
			if(visitedObjects.ContainsKey(this) || visitedObjects.ContainsKey(that))
				throw new Exception("Multiple appearances (and cycles) forbidden in deep equality comparison (only tree-like structures are supported)!");
			if(this == that)
				return true;
			if(!(that is @TransientObject))
				return false;
			@TransientObject that_ = (@TransientObject)that;
			visitedObjects.Add(this, null);
			if(that != this)
				visitedObjects.Add(that, null);
			bool result = true
				;
			visitedObjects.Remove(this);
			visitedObjects.Remove(that);
			return result;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The TransientObject type \"TransientObject\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The TransientObject type \"TransientObject\" does not have the attribute \"" + attrName + "\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, container creation of TransientObject
		}

		public override object ApplyFunctionMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("TransientObject does not have the function method " + name + "!");
			}
		}
		public override object[] ApplyProcedureMethod(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IGraph graph, string name, object[] arguments)
		{
			switch(name)
			{
				default: throw new NullReferenceException("TransientObject does not have the procedure method " + name + "!");
			}
		}
	}

	public sealed partial class TransientObjectType_TransientObject : GRGEN_LIBGR.TransientObjectType
	{
		public static GRGEN_MODEL.TransientObjectType_TransientObject typeVar = new GRGEN_MODEL.TransientObjectType_TransientObject();
		public static bool[] isA = new bool[] { true, };
		public override bool IsA(int typeID) { return isA[typeID]; }
		public static bool[] isMyType = new bool[] { true, };
		public override bool IsMyType(int typeID) { return isMyType[typeID]; }
		public TransientObjectType_TransientObject() : base((int) TransientObjectTypes.@TransientObject)
		{
		}
		public override string Name { get { return "TransientObject"; } }
		public override string Package { get { return null; } }
		public override string PackagePrefixedName { get { return "TransientObject"; } }
		public override string TransientObjectInterfaceName { get { return "de.unika.ipd.grGen.Model_schuppen.ITransientObject"; } }
		public override string TransientObjectClassName { get { return "de.unika.ipd.grGen.Model_schuppen.@TransientObject"; } }
		public override GRGEN_LIBGR.ITransientObject CreateTransientObject()
		{
			return new GRGEN_MODEL.@TransientObject();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override GRGEN_LIBGR.Annotations Annotations { get { return annotations; } }
		public GRGEN_LIBGR.Annotations annotations = new GRGEN_LIBGR.Annotations();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
	}

	public sealed class ExternalObjectType_object : GRGEN_LIBGR.ExternalObjectType
	{
		public ExternalObjectType_object()
			: base("object", typeof(object))
		{
		}
		public override int NumFunctionMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IFunctionDefinition> FunctionMethods { get { yield break; } }
		public override GRGEN_LIBGR.IFunctionDefinition GetFunctionMethod(string name) { return null; }
		public override int NumProcedureMethods { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.IProcedureDefinition> ProcedureMethods { get { yield break; } }
		public override GRGEN_LIBGR.IProcedureDefinition GetProcedureMethod(string name) { return null; }

		public static object ThrowCopyClassMissingException() { throw new Exception("Cannot copy/clone external object, copy class specification is missing in the model."); }
	}

	//
	// Indices
	//

	public class schuppenIndexSet : GRGEN_LIBGR.IIndexSet
	{
		public schuppenIndexSet(GRGEN_LGSP.LGSPGraph graph)
		{
		}


		public GRGEN_LIBGR.IIndex GetIndex(string indexName)
		{
			switch(indexName)
			{
				default: return null;
			}
		}

		public void FillAsClone(GRGEN_LGSP.LGSPGraph originalGraph, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
		{
		}
	}

	//
	// Node model
	//

	public sealed class schuppenNodeModel : GRGEN_LIBGR.INodeModel
	{
		public schuppenNodeModel()
		{
			GRGEN_MODEL.NodeType_Node.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
				GRGEN_MODEL.NodeType_Design.typeVar,
				GRGEN_MODEL.NodeType_Roof.typeVar,
				GRGEN_MODEL.NodeType_MainPart.typeVar,
				GRGEN_MODEL.NodeType_Base.typeVar,
				GRGEN_MODEL.NodeType_RingBar.typeVar,
				GRGEN_MODEL.NodeType_Middle.typeVar,
				GRGEN_MODEL.NodeType_Post.typeVar,
				GRGEN_MODEL.NodeType_Infill.typeVar,
				GRGEN_MODEL.NodeType_Door.typeVar,
				GRGEN_MODEL.NodeType_Wall.typeVar,
				GRGEN_MODEL.NodeType_WallFrame.typeVar,
				GRGEN_MODEL.NodeType_Module.typeVar,
				GRGEN_MODEL.NodeType_FrameModule.typeVar,
				GRGEN_MODEL.NodeType_LModule.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_DesignNode.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_DesignNode.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
				GRGEN_MODEL.NodeType_Design.typeVar,
				GRGEN_MODEL.NodeType_Roof.typeVar,
				GRGEN_MODEL.NodeType_MainPart.typeVar,
				GRGEN_MODEL.NodeType_Base.typeVar,
				GRGEN_MODEL.NodeType_RingBar.typeVar,
				GRGEN_MODEL.NodeType_Middle.typeVar,
				GRGEN_MODEL.NodeType_Post.typeVar,
				GRGEN_MODEL.NodeType_Infill.typeVar,
				GRGEN_MODEL.NodeType_Door.typeVar,
				GRGEN_MODEL.NodeType_Wall.typeVar,
				GRGEN_MODEL.NodeType_WallFrame.typeVar,
				GRGEN_MODEL.NodeType_Module.typeVar,
				GRGEN_MODEL.NodeType_FrameModule.typeVar,
				GRGEN_MODEL.NodeType_LModule.typeVar,
			};
			GRGEN_MODEL.NodeType_DesignNode.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_DesignNode.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Design.typeVar,
				GRGEN_MODEL.NodeType_Roof.typeVar,
				GRGEN_MODEL.NodeType_MainPart.typeVar,
				GRGEN_MODEL.NodeType_Base.typeVar,
				GRGEN_MODEL.NodeType_RingBar.typeVar,
				GRGEN_MODEL.NodeType_Middle.typeVar,
				GRGEN_MODEL.NodeType_Post.typeVar,
				GRGEN_MODEL.NodeType_Infill.typeVar,
				GRGEN_MODEL.NodeType_Door.typeVar,
				GRGEN_MODEL.NodeType_Wall.typeVar,
				GRGEN_MODEL.NodeType_WallFrame.typeVar,
				GRGEN_MODEL.NodeType_Module.typeVar,
			};
			GRGEN_MODEL.NodeType_DesignNode.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_DesignNode.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_DesignNode.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_DesignNode.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Design.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Design.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Design.typeVar,
			};
			GRGEN_MODEL.NodeType_Design.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Design.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Design.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Design.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Design.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Design.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Design.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Roof.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Roof.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Roof.typeVar,
			};
			GRGEN_MODEL.NodeType_Roof.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Roof.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Roof.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Roof.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Roof.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Roof.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Roof.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_MainPart.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_MainPart.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MainPart.typeVar,
			};
			GRGEN_MODEL.NodeType_MainPart.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_MainPart.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_MainPart.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_MainPart.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MainPart.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_MainPart.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_MainPart.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Base.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Base.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Base.typeVar,
			};
			GRGEN_MODEL.NodeType_Base.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Base.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Base.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Base.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Base.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Base.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Base.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_RingBar.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_RingBar.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_RingBar.typeVar,
			};
			GRGEN_MODEL.NodeType_RingBar.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_RingBar.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_RingBar.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_RingBar.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_RingBar.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_RingBar.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_RingBar.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Middle.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Middle.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Middle.typeVar,
			};
			GRGEN_MODEL.NodeType_Middle.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Middle.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Middle.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Middle.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Middle.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Middle.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Middle.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Post.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Post.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Post.typeVar,
			};
			GRGEN_MODEL.NodeType_Post.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Post.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Post.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Post.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Post.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Post.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Post.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Infill.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Infill.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Infill.typeVar,
			};
			GRGEN_MODEL.NodeType_Infill.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Infill.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Infill.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Infill.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Infill.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Infill.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Infill.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Door.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Door.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Door.typeVar,
			};
			GRGEN_MODEL.NodeType_Door.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Door.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Door.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Door.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Door.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Door.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Door.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Wall.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Wall.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Wall.typeVar,
			};
			GRGEN_MODEL.NodeType_Wall.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Wall.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Wall.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Wall.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Wall.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Wall.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Wall.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_WallFrame.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_WallFrame.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WallFrame.typeVar,
			};
			GRGEN_MODEL.NodeType_WallFrame.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_WallFrame.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_WallFrame.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_WallFrame.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WallFrame.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_WallFrame.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_WallFrame.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Module.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Module.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Module.typeVar,
				GRGEN_MODEL.NodeType_FrameModule.typeVar,
				GRGEN_MODEL.NodeType_LModule.typeVar,
			};
			GRGEN_MODEL.NodeType_Module.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Module.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FrameModule.typeVar,
				GRGEN_MODEL.NodeType_LModule.typeVar,
			};
			GRGEN_MODEL.NodeType_Module.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Module.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Module.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_Module.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Module.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
			};
			GRGEN_MODEL.NodeType_FrameModule.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_FrameModule.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FrameModule.typeVar,
			};
			GRGEN_MODEL.NodeType_FrameModule.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_FrameModule.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_FrameModule.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_FrameModule.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FrameModule.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
				GRGEN_MODEL.NodeType_Module.typeVar,
			};
			GRGEN_MODEL.NodeType_FrameModule.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_FrameModule.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Module.typeVar,
			};
			GRGEN_MODEL.NodeType_LModule.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_LModule.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_LModule.typeVar,
			};
			GRGEN_MODEL.NodeType_LModule.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_LModule.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_LModule.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_LModule.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_LModule.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_DesignNode.typeVar,
				GRGEN_MODEL.NodeType_Module.typeVar,
			};
			GRGEN_MODEL.NodeType_LModule.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_LModule.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Module.typeVar,
			};
		}
		public bool IsNodeModel { get { return true; } }
		public GRGEN_LIBGR.NodeType RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		public GRGEN_LIBGR.NodeType GetType(string name)
		{
			switch(name)
			{
				case "Node" : return GRGEN_MODEL.NodeType_Node.typeVar;
				case "DesignNode" : return GRGEN_MODEL.NodeType_DesignNode.typeVar;
				case "Design" : return GRGEN_MODEL.NodeType_Design.typeVar;
				case "Roof" : return GRGEN_MODEL.NodeType_Roof.typeVar;
				case "MainPart" : return GRGEN_MODEL.NodeType_MainPart.typeVar;
				case "Base" : return GRGEN_MODEL.NodeType_Base.typeVar;
				case "RingBar" : return GRGEN_MODEL.NodeType_RingBar.typeVar;
				case "Middle" : return GRGEN_MODEL.NodeType_Middle.typeVar;
				case "Post" : return GRGEN_MODEL.NodeType_Post.typeVar;
				case "Infill" : return GRGEN_MODEL.NodeType_Infill.typeVar;
				case "Door" : return GRGEN_MODEL.NodeType_Door.typeVar;
				case "Wall" : return GRGEN_MODEL.NodeType_Wall.typeVar;
				case "WallFrame" : return GRGEN_MODEL.NodeType_WallFrame.typeVar;
				case "Module" : return GRGEN_MODEL.NodeType_Module.typeVar;
				case "FrameModule" : return GRGEN_MODEL.NodeType_FrameModule.typeVar;
				case "LModule" : return GRGEN_MODEL.NodeType_LModule.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.NodeType[] types = {
			GRGEN_MODEL.NodeType_Node.typeVar,
			GRGEN_MODEL.NodeType_DesignNode.typeVar,
			GRGEN_MODEL.NodeType_Design.typeVar,
			GRGEN_MODEL.NodeType_Roof.typeVar,
			GRGEN_MODEL.NodeType_MainPart.typeVar,
			GRGEN_MODEL.NodeType_Base.typeVar,
			GRGEN_MODEL.NodeType_RingBar.typeVar,
			GRGEN_MODEL.NodeType_Middle.typeVar,
			GRGEN_MODEL.NodeType_Post.typeVar,
			GRGEN_MODEL.NodeType_Infill.typeVar,
			GRGEN_MODEL.NodeType_Door.typeVar,
			GRGEN_MODEL.NodeType_Wall.typeVar,
			GRGEN_MODEL.NodeType_WallFrame.typeVar,
			GRGEN_MODEL.NodeType_Module.typeVar,
			GRGEN_MODEL.NodeType_FrameModule.typeVar,
			GRGEN_MODEL.NodeType_LModule.typeVar,
		};
		public GRGEN_LIBGR.NodeType[] Types { get { return types; } }
		GRGEN_LIBGR.GraphElementType[] GRGEN_LIBGR.IGraphElementTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.NodeType_Node),
			typeof(GRGEN_MODEL.NodeType_DesignNode),
			typeof(GRGEN_MODEL.NodeType_Design),
			typeof(GRGEN_MODEL.NodeType_Roof),
			typeof(GRGEN_MODEL.NodeType_MainPart),
			typeof(GRGEN_MODEL.NodeType_Base),
			typeof(GRGEN_MODEL.NodeType_RingBar),
			typeof(GRGEN_MODEL.NodeType_Middle),
			typeof(GRGEN_MODEL.NodeType_Post),
			typeof(GRGEN_MODEL.NodeType_Infill),
			typeof(GRGEN_MODEL.NodeType_Door),
			typeof(GRGEN_MODEL.NodeType_Wall),
			typeof(GRGEN_MODEL.NodeType_WallFrame),
			typeof(GRGEN_MODEL.NodeType_Module),
			typeof(GRGEN_MODEL.NodeType_FrameModule),
			typeof(GRGEN_MODEL.NodeType_LModule),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.NodeType_DesignNode.AttributeType_isAlignmentNode,
			GRGEN_MODEL.NodeType_DesignNode.AttributeType_filled,
			GRGEN_MODEL.NodeType_FrameModule.AttributeType_size,
			GRGEN_MODEL.NodeType_FrameModule.AttributeType_overhang,
			GRGEN_MODEL.NodeType_FrameModule.AttributeType_filling,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// Edge model
	//

	public sealed class schuppenEdgeModel : GRGEN_LIBGR.IEdgeModel
	{
		public schuppenEdgeModel()
		{
			GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_contains.typeVar,
				GRGEN_MODEL.EdgeType_connected.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
				GRGEN_MODEL.EdgeType_right.typeVar,
				GRGEN_MODEL.EdgeType_infront.typeVar,
				GRGEN_MODEL.EdgeType_above.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_contains.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
				GRGEN_MODEL.EdgeType_right.typeVar,
				GRGEN_MODEL.EdgeType_infront.typeVar,
				GRGEN_MODEL.EdgeType_above.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_contains.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_connected.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_connected.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_contains.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_contains.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_contains.typeVar,
			};
			GRGEN_MODEL.EdgeType_contains.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_contains.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_contains.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_contains.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_contains.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_contains.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_contains.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_connected.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_connected.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_connected.typeVar,
			};
			GRGEN_MODEL.EdgeType_connected.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_connected.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_connected.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_connected.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_connected.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_connected.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_connected.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_next.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_next.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
				GRGEN_MODEL.EdgeType_right.typeVar,
				GRGEN_MODEL.EdgeType_infront.typeVar,
				GRGEN_MODEL.EdgeType_above.typeVar,
			};
			GRGEN_MODEL.EdgeType_next.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_next.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
			GRGEN_MODEL.EdgeType_next.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_next.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_next.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_next.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_locatedNext.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_locatedNext.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
				GRGEN_MODEL.EdgeType_right.typeVar,
				GRGEN_MODEL.EdgeType_infront.typeVar,
				GRGEN_MODEL.EdgeType_above.typeVar,
			};
			GRGEN_MODEL.EdgeType_locatedNext.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_locatedNext.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_right.typeVar,
				GRGEN_MODEL.EdgeType_infront.typeVar,
				GRGEN_MODEL.EdgeType_above.typeVar,
			};
			GRGEN_MODEL.EdgeType_locatedNext.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_locatedNext.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
			};
			GRGEN_MODEL.EdgeType_locatedNext.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_locatedNext.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_next.typeVar,
			};
			GRGEN_MODEL.EdgeType_right.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_right.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_right.typeVar,
			};
			GRGEN_MODEL.EdgeType_right.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_right.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_right.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_right.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_right.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
			GRGEN_MODEL.EdgeType_right.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_right.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
			GRGEN_MODEL.EdgeType_infront.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_infront.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_infront.typeVar,
			};
			GRGEN_MODEL.EdgeType_infront.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_infront.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_infront.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_infront.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_infront.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
			GRGEN_MODEL.EdgeType_infront.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_infront.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
			GRGEN_MODEL.EdgeType_above.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_above.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_above.typeVar,
			};
			GRGEN_MODEL.EdgeType_above.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_above.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_above.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_above.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_above.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_next.typeVar,
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
			GRGEN_MODEL.EdgeType_above.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_above.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			};
		}
		public bool IsNodeModel { get { return false; } }
		public GRGEN_LIBGR.EdgeType RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		public GRGEN_LIBGR.EdgeType GetType(string name)
		{
			switch(name)
			{
				case "AEdge" : return GRGEN_MODEL.EdgeType_AEdge.typeVar;
				case "Edge" : return GRGEN_MODEL.EdgeType_Edge.typeVar;
				case "UEdge" : return GRGEN_MODEL.EdgeType_UEdge.typeVar;
				case "contains" : return GRGEN_MODEL.EdgeType_contains.typeVar;
				case "connected" : return GRGEN_MODEL.EdgeType_connected.typeVar;
				case "next" : return GRGEN_MODEL.EdgeType_next.typeVar;
				case "locatedNext" : return GRGEN_MODEL.EdgeType_locatedNext.typeVar;
				case "right" : return GRGEN_MODEL.EdgeType_right.typeVar;
				case "infront" : return GRGEN_MODEL.EdgeType_infront.typeVar;
				case "above" : return GRGEN_MODEL.EdgeType_above.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GraphElementType GRGEN_LIBGR.IGraphElementTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.EdgeType[] types = {
			GRGEN_MODEL.EdgeType_AEdge.typeVar,
			GRGEN_MODEL.EdgeType_Edge.typeVar,
			GRGEN_MODEL.EdgeType_UEdge.typeVar,
			GRGEN_MODEL.EdgeType_contains.typeVar,
			GRGEN_MODEL.EdgeType_connected.typeVar,
			GRGEN_MODEL.EdgeType_next.typeVar,
			GRGEN_MODEL.EdgeType_locatedNext.typeVar,
			GRGEN_MODEL.EdgeType_right.typeVar,
			GRGEN_MODEL.EdgeType_infront.typeVar,
			GRGEN_MODEL.EdgeType_above.typeVar,
		};
		public GRGEN_LIBGR.EdgeType[] Types { get { return types; } }
		GRGEN_LIBGR.GraphElementType[] GRGEN_LIBGR.IGraphElementTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.EdgeType_AEdge),
			typeof(GRGEN_MODEL.EdgeType_Edge),
			typeof(GRGEN_MODEL.EdgeType_UEdge),
			typeof(GRGEN_MODEL.EdgeType_contains),
			typeof(GRGEN_MODEL.EdgeType_connected),
			typeof(GRGEN_MODEL.EdgeType_next),
			typeof(GRGEN_MODEL.EdgeType_locatedNext),
			typeof(GRGEN_MODEL.EdgeType_right),
			typeof(GRGEN_MODEL.EdgeType_infront),
			typeof(GRGEN_MODEL.EdgeType_above),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// Object model
	//

	public sealed class schuppenObjectModel : GRGEN_LIBGR.IObjectModel
	{
		public schuppenObjectModel()
		{
			GRGEN_MODEL.ObjectType_Object.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.subOrSameTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_Object.typeVar,
				GRGEN_MODEL.ObjectType_QuasiPlane.typeVar,
			};
			GRGEN_MODEL.ObjectType_Object.typeVar.directSubGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.directSubTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_QuasiPlane.typeVar,
			};
			GRGEN_MODEL.ObjectType_Object.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.superOrSameTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_Object.typeVar,
			};
			GRGEN_MODEL.ObjectType_Object.typeVar.directSuperGrGenTypes = GRGEN_MODEL.ObjectType_Object.typeVar.directSuperTypes = new GRGEN_LIBGR.ObjectType[] {
			};
			GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.subOrSameTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_QuasiPlane.typeVar,
			};
			GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.directSubGrGenTypes = GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.directSubTypes = new GRGEN_LIBGR.ObjectType[] {
			};
			GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.superOrSameTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_QuasiPlane.typeVar,
				GRGEN_MODEL.ObjectType_Object.typeVar,
			};
			GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.directSuperGrGenTypes = GRGEN_MODEL.ObjectType_QuasiPlane.typeVar.directSuperTypes = new GRGEN_LIBGR.ObjectType[] {
				GRGEN_MODEL.ObjectType_Object.typeVar,
			};
		}
		public bool IsTransientModel { get { return false; } }
		public GRGEN_LIBGR.ObjectType RootType { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.RootType { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.ObjectType_Object.typeVar; } }
		public GRGEN_LIBGR.ObjectType GetType(string name)
		{
			switch(name)
			{
				case "Object" : return GRGEN_MODEL.ObjectType_Object.typeVar;
				case "QuasiPlane" : return GRGEN_MODEL.ObjectType_QuasiPlane.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.ObjectType[] types = {
			GRGEN_MODEL.ObjectType_Object.typeVar,
			GRGEN_MODEL.ObjectType_QuasiPlane.typeVar,
		};
		public GRGEN_LIBGR.ObjectType[] Types { get { return types; } }
		GRGEN_LIBGR.BaseObjectType[] GRGEN_LIBGR.IBaseObjectTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.ObjectType_Object),
			typeof(GRGEN_MODEL.ObjectType_QuasiPlane),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.ObjectType_QuasiPlane.AttributeType_xyRotation,
			GRGEN_MODEL.ObjectType_QuasiPlane.AttributeType_xzRotation,
			GRGEN_MODEL.ObjectType_QuasiPlane.AttributeType_yzRotation,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// TransientObject model
	//

	public sealed class schuppenTransientObjectModel : GRGEN_LIBGR.ITransientObjectModel
	{
		public schuppenTransientObjectModel()
		{
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.subOrSameTypes = new GRGEN_LIBGR.TransientObjectType[] {
				GRGEN_MODEL.TransientObjectType_TransientObject.typeVar,
			};
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSubGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSubTypes = new GRGEN_LIBGR.TransientObjectType[] {
			};
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.superOrSameTypes = new GRGEN_LIBGR.TransientObjectType[] {
				GRGEN_MODEL.TransientObjectType_TransientObject.typeVar,
			};
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSuperGrGenTypes = GRGEN_MODEL.TransientObjectType_TransientObject.typeVar.directSuperTypes = new GRGEN_LIBGR.TransientObjectType[] {
			};
		}
		public bool IsTransientModel { get { return true; } }
		public GRGEN_LIBGR.TransientObjectType RootType { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.RootType { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar; } }
		public GRGEN_LIBGR.TransientObjectType GetType(string name)
		{
			switch(name)
			{
				case "TransientObject" : return GRGEN_MODEL.TransientObjectType_TransientObject.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.BaseObjectType GRGEN_LIBGR.IBaseObjectTypeModel.GetType(string name)
		{
			return GetType(name);
		}
		GRGEN_LIBGR.InheritanceType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.TransientObjectType[] types = {
			GRGEN_MODEL.TransientObjectType_TransientObject.typeVar,
		};
		public GRGEN_LIBGR.TransientObjectType[] Types { get { return types; } }
		GRGEN_LIBGR.BaseObjectType[] GRGEN_LIBGR.IBaseObjectTypeModel.Types { get { return types; } }
		GRGEN_LIBGR.InheritanceType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private global::System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.TransientObjectType_TransientObject),
		};
		public global::System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// IGraphModel (LGSPGraphModel) implementation
	//
	public sealed class schuppenGraphModel : GRGEN_LGSP.LGSPGraphModel
	{
		public schuppenGraphModel()
		{
			FullyInitializeExternalObjectTypes();
		}

		private schuppenNodeModel nodeModel = new schuppenNodeModel();
		private schuppenEdgeModel edgeModel = new schuppenEdgeModel();
		private schuppenObjectModel objectModel = new schuppenObjectModel();
		private schuppenTransientObjectModel transientObjectModel = new schuppenTransientObjectModel();
		private string[] packages = {
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
			GRGEN_MODEL.Enums.@Size,
			GRGEN_MODEL.Enums.@Overhang,
			GRGEN_MODEL.Enums.@Filling,
		};
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
		};
		private static GRGEN_LIBGR.IndexDescription[] indexDescriptions = {
		};
		public override GRGEN_LIBGR.IUniquenessHandler CreateUniquenessHandler(GRGEN_LIBGR.IGraph graph) {
			return null;
		}
		public override GRGEN_LIBGR.IIndexSet CreateIndexSet(GRGEN_LIBGR.IGraph graph) {
			return new schuppenIndexSet((GRGEN_LGSP.LGSPGraph)graph);
		}
		public override void FillIndexSetAsClone(GRGEN_LIBGR.IGraph graph, GRGEN_LIBGR.IGraph originalGraph, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) {
			((schuppenIndexSet)graph.Indices).FillAsClone((GRGEN_LGSP.LGSPGraph)originalGraph, oldToNewMap);
		}

		public override string ModelName { get { return "schuppen"; } }
		public override GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public override GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public override GRGEN_LIBGR.IObjectModel ObjectModel { get { return objectModel; } }
		public override GRGEN_LIBGR.ITransientObjectModel TransientObjectModel { get { return transientObjectModel; } }
		public override IEnumerable<string> Packages { get { return packages; } }
		public override IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public override IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public override IEnumerable<GRGEN_LIBGR.IndexDescription> IndexDescriptions { get { return indexDescriptions; } }
		public static GRGEN_LIBGR.IndexDescription GetIndexDescription(int i) { return indexDescriptions[i]; }
		public static GRGEN_LIBGR.IndexDescription GetIndexDescription(string indexName)
 		{
			for(int i=0; i<indexDescriptions.Length; ++i)
				if(indexDescriptions[i].Name==indexName)
					return indexDescriptions[i];
			return null;
		}
		public override bool GraphElementUniquenessIsEnsured { get { return false; } }
		public override bool GraphElementsAreAccessibleByUniqueId { get { return false; } }
		public override bool AreFunctionsParallelized { get { return false; } }
		public override int BranchingFactorForEqualsAny { get { return 0; } }
		public override int ThreadPoolSizeForSequencesParallelExecution { get { return 0; } }

		public static GRGEN_LIBGR.ExternalObjectType externalObjectType_object = new ExternalObjectType_object();
		private GRGEN_LIBGR.ExternalObjectType[] externalObjectTypes = { externalObjectType_object };
		public override GRGEN_LIBGR.ExternalObjectType[] ExternalObjectTypes { get { return externalObjectTypes; } }

		private void FullyInitializeExternalObjectTypes()
		{
			externalObjectType_object.InitDirectSupertypes( new GRGEN_LIBGR.ExternalObjectType[] { } );
		}

		public override global::System.Collections.IList ArrayOrderAscendingBy(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IDesignNode>)array);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IDesignNode>)array);
				default:
					return null;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IDesign>)array);
				case "filled":
					return ArrayHelper_Design_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IDesign>)array);
				default:
					return null;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IRoof>)array);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IRoof>)array);
				default:
					return null;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IMainPart>)array);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IMainPart>)array);
				default:
					return null;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IBase>)array);
				case "filled":
					return ArrayHelper_Base_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IBase>)array);
				default:
					return null;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IRingBar>)array);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IRingBar>)array);
				default:
					return null;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IMiddle>)array);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IMiddle>)array);
				default:
					return null;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IPost>)array);
				case "filled":
					return ArrayHelper_Post_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IPost>)array);
				default:
					return null;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IInfill>)array);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IInfill>)array);
				default:
					return null;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IDoor>)array);
				case "filled":
					return ArrayHelper_Door_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IDoor>)array);
				default:
					return null;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IWall>)array);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IWall>)array);
				default:
					return null;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IWallFrame>)array);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IWallFrame>)array);
				default:
					return null;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IModule>)array);
				case "filled":
					return ArrayHelper_Module_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IModule>)array);
				default:
					return null;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayOrderAscendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayOrderAscendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayOrderAscendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				default:
					return null;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayOrderAscendingBy((List<GRGEN_MODEL.ILModule>)array);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayOrderAscendingBy((List<GRGEN_MODEL.ILModule>)array);
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "contains":
				switch(member)
				{
				default:
					return null;
				}
			case "connected":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return null;
				}
			case "right":
				switch(member)
				{
				default:
					return null;
				}
			case "infront":
				switch(member)
				{
				default:
					return null;
				}
			case "above":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayOrderAscendingBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayOrderAscendingBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayOrderAscendingBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override global::System.Collections.IList ArrayOrderDescendingBy(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IDesignNode>)array);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IDesignNode>)array);
				default:
					return null;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IDesign>)array);
				case "filled":
					return ArrayHelper_Design_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IDesign>)array);
				default:
					return null;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IRoof>)array);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IRoof>)array);
				default:
					return null;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IMainPart>)array);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IMainPart>)array);
				default:
					return null;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IBase>)array);
				case "filled":
					return ArrayHelper_Base_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IBase>)array);
				default:
					return null;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IRingBar>)array);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IRingBar>)array);
				default:
					return null;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IMiddle>)array);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IMiddle>)array);
				default:
					return null;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IPost>)array);
				case "filled":
					return ArrayHelper_Post_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IPost>)array);
				default:
					return null;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IInfill>)array);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IInfill>)array);
				default:
					return null;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IDoor>)array);
				case "filled":
					return ArrayHelper_Door_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IDoor>)array);
				default:
					return null;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IWall>)array);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IWall>)array);
				default:
					return null;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IWallFrame>)array);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IWallFrame>)array);
				default:
					return null;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IModule>)array);
				case "filled":
					return ArrayHelper_Module_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IModule>)array);
				default:
					return null;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayOrderDescendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayOrderDescendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayOrderDescendingBy((List<GRGEN_MODEL.IFrameModule>)array);
				default:
					return null;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayOrderDescendingBy((List<GRGEN_MODEL.ILModule>)array);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayOrderDescendingBy((List<GRGEN_MODEL.ILModule>)array);
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "contains":
				switch(member)
				{
				default:
					return null;
				}
			case "connected":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return null;
				}
			case "right":
				switch(member)
				{
				default:
					return null;
				}
			case "infront":
				switch(member)
				{
				default:
					return null;
				}
			case "above":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayOrderDescendingBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayOrderDescendingBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayOrderDescendingBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override global::System.Collections.IList ArrayGroupBy(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IDesignNode>)array);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayGroupBy((List<GRGEN_MODEL.IDesignNode>)array);
				default:
					return null;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IDesign>)array);
				case "filled":
					return ArrayHelper_Design_filled.ArrayGroupBy((List<GRGEN_MODEL.IDesign>)array);
				default:
					return null;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IRoof>)array);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayGroupBy((List<GRGEN_MODEL.IRoof>)array);
				default:
					return null;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IMainPart>)array);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayGroupBy((List<GRGEN_MODEL.IMainPart>)array);
				default:
					return null;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IBase>)array);
				case "filled":
					return ArrayHelper_Base_filled.ArrayGroupBy((List<GRGEN_MODEL.IBase>)array);
				default:
					return null;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IRingBar>)array);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayGroupBy((List<GRGEN_MODEL.IRingBar>)array);
				default:
					return null;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IMiddle>)array);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayGroupBy((List<GRGEN_MODEL.IMiddle>)array);
				default:
					return null;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IPost>)array);
				case "filled":
					return ArrayHelper_Post_filled.ArrayGroupBy((List<GRGEN_MODEL.IPost>)array);
				default:
					return null;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IInfill>)array);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayGroupBy((List<GRGEN_MODEL.IInfill>)array);
				default:
					return null;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IDoor>)array);
				case "filled":
					return ArrayHelper_Door_filled.ArrayGroupBy((List<GRGEN_MODEL.IDoor>)array);
				default:
					return null;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IWall>)array);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayGroupBy((List<GRGEN_MODEL.IWall>)array);
				default:
					return null;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IWallFrame>)array);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayGroupBy((List<GRGEN_MODEL.IWallFrame>)array);
				default:
					return null;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IModule>)array);
				case "filled":
					return ArrayHelper_Module_filled.ArrayGroupBy((List<GRGEN_MODEL.IModule>)array);
				default:
					return null;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayGroupBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayGroupBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayGroupBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayGroupBy((List<GRGEN_MODEL.IFrameModule>)array);
				default:
					return null;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayGroupBy((List<GRGEN_MODEL.ILModule>)array);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayGroupBy((List<GRGEN_MODEL.ILModule>)array);
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "contains":
				switch(member)
				{
				default:
					return null;
				}
			case "connected":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return null;
				}
			case "right":
				switch(member)
				{
				default:
					return null;
				}
			case "infront":
				switch(member)
				{
				default:
					return null;
				}
			case "above":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayGroupBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayGroupBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayGroupBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override global::System.Collections.IList ArrayKeepOneForEach(global::System.Collections.IList array, string member)
		{
			if(array.Count == 0)
				return array;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return null;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return null;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IDesignNode>)array);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IDesignNode>)array);
				default:
					return null;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IDesign>)array);
				case "filled":
					return ArrayHelper_Design_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IDesign>)array);
				default:
					return null;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IRoof>)array);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IRoof>)array);
				default:
					return null;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IMainPart>)array);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IMainPart>)array);
				default:
					return null;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IBase>)array);
				case "filled":
					return ArrayHelper_Base_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IBase>)array);
				default:
					return null;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IRingBar>)array);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IRingBar>)array);
				default:
					return null;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IMiddle>)array);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IMiddle>)array);
				default:
					return null;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IPost>)array);
				case "filled":
					return ArrayHelper_Post_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IPost>)array);
				default:
					return null;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IInfill>)array);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IInfill>)array);
				default:
					return null;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IDoor>)array);
				case "filled":
					return ArrayHelper_Door_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IDoor>)array);
				default:
					return null;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IWall>)array);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IWall>)array);
				default:
					return null;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IWallFrame>)array);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IWallFrame>)array);
				default:
					return null;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IModule>)array);
				case "filled":
					return ArrayHelper_Module_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IModule>)array);
				default:
					return null;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IFrameModule>)array);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IFrameModule>)array);
				default:
					return null;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayKeepOneForEachBy((List<GRGEN_MODEL.ILModule>)array);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayKeepOneForEachBy((List<GRGEN_MODEL.ILModule>)array);
				default:
					return null;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "Edge":
				switch(member)
				{
				default:
					return null;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return null;
				}
			case "contains":
				switch(member)
				{
				default:
					return null;
				}
			case "connected":
				switch(member)
				{
				default:
					return null;
				}
			case "next":
				switch(member)
				{
				default:
					return null;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return null;
				}
			case "right":
				switch(member)
				{
				default:
					return null;
				}
			case "infront":
				switch(member)
				{
				default:
					return null;
				}
			case "above":
				switch(member)
				{
				default:
					return null;
				}
			case "Object":
				switch(member)
				{
				default:
					return null;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayKeepOneForEachBy((List<GRGEN_MODEL.IQuasiPlane>)array);
				default:
					return null;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return null;
				}
			default: return null;
			}
		}

		public override int ArrayIndexOfBy(global::System.Collections.IList array, string member, object value)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value);
				default:
					return -1;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value);
				case "filled":
					return ArrayHelper_Design_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value);
				default:
					return -1;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value);
				default:
					return -1;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value);
				default:
					return -1;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value);
				case "filled":
					return ArrayHelper_Base_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value);
				default:
					return -1;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value);
				default:
					return -1;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value);
				default:
					return -1;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value);
				case "filled":
					return ArrayHelper_Post_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value);
				default:
					return -1;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value);
				default:
					return -1;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value);
				case "filled":
					return ArrayHelper_Door_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value);
				default:
					return -1;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value);
				default:
					return -1;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value);
				default:
					return -1;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_Module_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value);
				default:
					return -1;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Size)value);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Overhang)value);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Filling)value);
				default:
					return -1;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value);
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "contains":
				switch(member)
				{
				default:
					return -1;
				}
			case "connected":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return -1;
				}
			case "right":
				switch(member)
				{
				default:
					return -1;
				}
			case "infront":
				switch(member)
				{
				default:
					return -1;
				}
			case "above":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayIndexOfBy(global::System.Collections.IList array, string member, object value, int startIndex)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Design_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Base_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Post_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Door_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Module_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value, startIndex);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Size)value, startIndex);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Overhang)value, startIndex);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Filling)value, startIndex);
				default:
					return -1;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "contains":
				switch(member)
				{
				default:
					return -1;
				}
			case "connected":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return -1;
				}
			case "right":
				switch(member)
				{
				default:
					return -1;
				}
			case "infront":
				switch(member)
				{
				default:
					return -1;
				}
			case "above":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value, startIndex);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value, startIndex);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value, startIndex);
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayLastIndexOfBy(global::System.Collections.IList array, string member, object value)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value);
				default:
					return -1;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value);
				case "filled":
					return ArrayHelper_Design_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value);
				default:
					return -1;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value);
				default:
					return -1;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value);
				default:
					return -1;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value);
				case "filled":
					return ArrayHelper_Base_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value);
				default:
					return -1;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value);
				default:
					return -1;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value);
				default:
					return -1;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value);
				case "filled":
					return ArrayHelper_Post_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value);
				default:
					return -1;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value);
				default:
					return -1;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value);
				case "filled":
					return ArrayHelper_Door_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value);
				default:
					return -1;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value);
				default:
					return -1;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value);
				default:
					return -1;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_Module_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value);
				default:
					return -1;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Size)value);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Overhang)value);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Filling)value);
				default:
					return -1;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value);
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "contains":
				switch(member)
				{
				default:
					return -1;
				}
			case "connected":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return -1;
				}
			case "right":
				switch(member)
				{
				default:
					return -1;
				}
			case "infront":
				switch(member)
				{
				default:
					return -1;
				}
			case "above":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayLastIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayLastIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayLastIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayLastIndexOfBy(global::System.Collections.IList array, string member, object value, int startIndex)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Design_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDesign>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRoof>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Base_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IBase>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Post_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IPost>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IInfill>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Door_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IDoor>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWall>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_Module_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IModule>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value, startIndex);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Size)value, startIndex);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Overhang)value, startIndex);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayLastIndexOfBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Filling)value, startIndex);
				default:
					return -1;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayLastIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value, startIndex);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayLastIndexOfBy((List<GRGEN_MODEL.ILModule>)array, (bool)value, startIndex);
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "contains":
				switch(member)
				{
				default:
					return -1;
				}
			case "connected":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return -1;
				}
			case "right":
				switch(member)
				{
				default:
					return -1;
				}
			case "infront":
				switch(member)
				{
				default:
					return -1;
				}
			case "above":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayLastIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value, startIndex);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayLastIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value, startIndex);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayLastIndexOfBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value, startIndex);
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}

		public override int ArrayIndexOfOrderedBy(global::System.Collections.IList array, string member, object value)
		{
			if(array.Count == 0)
				return -1;
			if(!(array[0] is GRGEN_LIBGR.IAttributeBearer))
				return -1;
			GRGEN_LIBGR.IAttributeBearer elem = (GRGEN_LIBGR.IAttributeBearer)array[0];
			switch(elem.Type.PackagePrefixedName)
			{
			case "Node":
				switch(member)
				{
				default:
					return -1;
				}
			case "DesignNode":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_DesignNode_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value);
				case "filled":
					return ArrayHelper_DesignNode_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IDesignNode>)array, (bool)value);
				default:
					return -1;
				}
			case "Design":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Design_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IDesign>)array, (bool)value);
				case "filled":
					return ArrayHelper_Design_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IDesign>)array, (bool)value);
				default:
					return -1;
				}
			case "Roof":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Roof_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IRoof>)array, (bool)value);
				case "filled":
					return ArrayHelper_Roof_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IRoof>)array, (bool)value);
				default:
					return -1;
				}
			case "MainPart":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_MainPart_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value);
				case "filled":
					return ArrayHelper_MainPart_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IMainPart>)array, (bool)value);
				default:
					return -1;
				}
			case "Base":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Base_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IBase>)array, (bool)value);
				case "filled":
					return ArrayHelper_Base_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IBase>)array, (bool)value);
				default:
					return -1;
				}
			case "RingBar":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_RingBar_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value);
				case "filled":
					return ArrayHelper_RingBar_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IRingBar>)array, (bool)value);
				default:
					return -1;
				}
			case "Middle":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Middle_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value);
				case "filled":
					return ArrayHelper_Middle_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IMiddle>)array, (bool)value);
				default:
					return -1;
				}
			case "Post":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Post_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IPost>)array, (bool)value);
				case "filled":
					return ArrayHelper_Post_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IPost>)array, (bool)value);
				default:
					return -1;
				}
			case "Infill":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Infill_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IInfill>)array, (bool)value);
				case "filled":
					return ArrayHelper_Infill_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IInfill>)array, (bool)value);
				default:
					return -1;
				}
			case "Door":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Door_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IDoor>)array, (bool)value);
				case "filled":
					return ArrayHelper_Door_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IDoor>)array, (bool)value);
				default:
					return -1;
				}
			case "Wall":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Wall_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IWall>)array, (bool)value);
				case "filled":
					return ArrayHelper_Wall_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IWall>)array, (bool)value);
				default:
					return -1;
				}
			case "WallFrame":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_WallFrame_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value);
				case "filled":
					return ArrayHelper_WallFrame_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IWallFrame>)array, (bool)value);
				default:
					return -1;
				}
			case "Module":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_Module_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_Module_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IModule>)array, (bool)value);
				default:
					return -1;
				}
			case "FrameModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_FrameModule_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_FrameModule_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IFrameModule>)array, (bool)value);
				case "size":
					return ArrayHelper_FrameModule_size.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Size)value);
				case "overhang":
					return ArrayHelper_FrameModule_overhang.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Overhang)value);
				case "filling":
					return ArrayHelper_FrameModule_filling.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IFrameModule>)array, (GRGEN_MODEL.ENUM_Filling)value);
				default:
					return -1;
				}
			case "LModule":
				switch(member)
				{
				case "isAlignmentNode":
					return ArrayHelper_LModule_isAlignmentNode.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.ILModule>)array, (bool)value);
				case "filled":
					return ArrayHelper_LModule_filled.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.ILModule>)array, (bool)value);
				default:
					return -1;
				}
			case "AEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "Edge":
				switch(member)
				{
				default:
					return -1;
				}
			case "UEdge":
				switch(member)
				{
				default:
					return -1;
				}
			case "contains":
				switch(member)
				{
				default:
					return -1;
				}
			case "connected":
				switch(member)
				{
				default:
					return -1;
				}
			case "next":
				switch(member)
				{
				default:
					return -1;
				}
			case "locatedNext":
				switch(member)
				{
				default:
					return -1;
				}
			case "right":
				switch(member)
				{
				default:
					return -1;
				}
			case "infront":
				switch(member)
				{
				default:
					return -1;
				}
			case "above":
				switch(member)
				{
				default:
					return -1;
				}
			case "Object":
				switch(member)
				{
				default:
					return -1;
				}
			case "QuasiPlane":
				switch(member)
				{
				case "xyRotation":
					return ArrayHelper_QuasiPlane_xyRotation.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				case "xzRotation":
					return ArrayHelper_QuasiPlane_xzRotation.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				case "yzRotation":
					return ArrayHelper_QuasiPlane_yzRotation.ArrayIndexOfOrderedBy((List<GRGEN_MODEL.IQuasiPlane>)array, (double)value);
				default:
					return -1;
				}
			case "TransientObject":
				switch(member)
				{
				default:
					return -1;
				}
			default: return -1;
			}
		}


		public override void FailAssertion() { Debug.Assert(false); }
		public override string MD5Hash { get { return "cd6f19a43cc6d3c0af2936c8cdb3716b"; } }
	}

	//
	// IGraph (LGSPGraph) implementation
	//
	public class schuppenGraph : GRGEN_LGSP.LGSPGraph
	{
		public schuppenGraph(GRGEN_LGSP.LGSPGlobalVariables globalVariables) : base(new schuppenGraphModel(), globalVariables, GetGraphName())
		{
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@Design CreateNodeDesign()
		{
			return GRGEN_MODEL.@Design.CreateNode(this);
		}

		public GRGEN_MODEL.@Roof CreateNodeRoof()
		{
			return GRGEN_MODEL.@Roof.CreateNode(this);
		}

		public GRGEN_MODEL.@MainPart CreateNodeMainPart()
		{
			return GRGEN_MODEL.@MainPart.CreateNode(this);
		}

		public GRGEN_MODEL.@Base CreateNodeBase()
		{
			return GRGEN_MODEL.@Base.CreateNode(this);
		}

		public GRGEN_MODEL.@RingBar CreateNodeRingBar()
		{
			return GRGEN_MODEL.@RingBar.CreateNode(this);
		}

		public GRGEN_MODEL.@Middle CreateNodeMiddle()
		{
			return GRGEN_MODEL.@Middle.CreateNode(this);
		}

		public GRGEN_MODEL.@Post CreateNodePost()
		{
			return GRGEN_MODEL.@Post.CreateNode(this);
		}

		public GRGEN_MODEL.@Infill CreateNodeInfill()
		{
			return GRGEN_MODEL.@Infill.CreateNode(this);
		}

		public GRGEN_MODEL.@Door CreateNodeDoor()
		{
			return GRGEN_MODEL.@Door.CreateNode(this);
		}

		public GRGEN_MODEL.@Wall CreateNodeWall()
		{
			return GRGEN_MODEL.@Wall.CreateNode(this);
		}

		public GRGEN_MODEL.@WallFrame CreateNodeWallFrame()
		{
			return GRGEN_MODEL.@WallFrame.CreateNode(this);
		}

		public GRGEN_MODEL.@Module CreateNodeModule()
		{
			return GRGEN_MODEL.@Module.CreateNode(this);
		}

		public GRGEN_MODEL.@FrameModule CreateNodeFrameModule()
		{
			return GRGEN_MODEL.@FrameModule.CreateNode(this);
		}

		public GRGEN_MODEL.@LModule CreateNodeLModule()
		{
			return GRGEN_MODEL.@LModule.CreateNode(this);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@contains CreateEdgecontains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@contains.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@connected CreateEdgeconnected(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@connected.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@right CreateEdgeright(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@right.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@infront CreateEdgeinfront(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@infront.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@above CreateEdgeabove(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@above.CreateEdge(this, source, target);
		}

	}

	//
	// INamedGraph (LGSPNamedGraph) implementation
	//
	public class schuppenNamedGraph : GRGEN_LGSP.LGSPNamedGraph
	{
		public schuppenNamedGraph(GRGEN_LGSP.LGSPGlobalVariables globalVariables) : base(new schuppenGraphModel(), globalVariables, GetGraphName(), 0)
		{
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode(string nodeName)
		{
			return GRGEN_MODEL.@Node.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Design CreateNodeDesign()
		{
			return GRGEN_MODEL.@Design.CreateNode(this);
		}

		public GRGEN_MODEL.@Design CreateNodeDesign(string nodeName)
		{
			return GRGEN_MODEL.@Design.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Roof CreateNodeRoof()
		{
			return GRGEN_MODEL.@Roof.CreateNode(this);
		}

		public GRGEN_MODEL.@Roof CreateNodeRoof(string nodeName)
		{
			return GRGEN_MODEL.@Roof.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@MainPart CreateNodeMainPart()
		{
			return GRGEN_MODEL.@MainPart.CreateNode(this);
		}

		public GRGEN_MODEL.@MainPart CreateNodeMainPart(string nodeName)
		{
			return GRGEN_MODEL.@MainPart.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Base CreateNodeBase()
		{
			return GRGEN_MODEL.@Base.CreateNode(this);
		}

		public GRGEN_MODEL.@Base CreateNodeBase(string nodeName)
		{
			return GRGEN_MODEL.@Base.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@RingBar CreateNodeRingBar()
		{
			return GRGEN_MODEL.@RingBar.CreateNode(this);
		}

		public GRGEN_MODEL.@RingBar CreateNodeRingBar(string nodeName)
		{
			return GRGEN_MODEL.@RingBar.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Middle CreateNodeMiddle()
		{
			return GRGEN_MODEL.@Middle.CreateNode(this);
		}

		public GRGEN_MODEL.@Middle CreateNodeMiddle(string nodeName)
		{
			return GRGEN_MODEL.@Middle.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Post CreateNodePost()
		{
			return GRGEN_MODEL.@Post.CreateNode(this);
		}

		public GRGEN_MODEL.@Post CreateNodePost(string nodeName)
		{
			return GRGEN_MODEL.@Post.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Infill CreateNodeInfill()
		{
			return GRGEN_MODEL.@Infill.CreateNode(this);
		}

		public GRGEN_MODEL.@Infill CreateNodeInfill(string nodeName)
		{
			return GRGEN_MODEL.@Infill.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Door CreateNodeDoor()
		{
			return GRGEN_MODEL.@Door.CreateNode(this);
		}

		public GRGEN_MODEL.@Door CreateNodeDoor(string nodeName)
		{
			return GRGEN_MODEL.@Door.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Wall CreateNodeWall()
		{
			return GRGEN_MODEL.@Wall.CreateNode(this);
		}

		public GRGEN_MODEL.@Wall CreateNodeWall(string nodeName)
		{
			return GRGEN_MODEL.@Wall.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@WallFrame CreateNodeWallFrame()
		{
			return GRGEN_MODEL.@WallFrame.CreateNode(this);
		}

		public GRGEN_MODEL.@WallFrame CreateNodeWallFrame(string nodeName)
		{
			return GRGEN_MODEL.@WallFrame.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@Module CreateNodeModule()
		{
			return GRGEN_MODEL.@Module.CreateNode(this);
		}

		public GRGEN_MODEL.@Module CreateNodeModule(string nodeName)
		{
			return GRGEN_MODEL.@Module.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@FrameModule CreateNodeFrameModule()
		{
			return GRGEN_MODEL.@FrameModule.CreateNode(this);
		}

		public GRGEN_MODEL.@FrameModule CreateNodeFrameModule(string nodeName)
		{
			return GRGEN_MODEL.@FrameModule.CreateNode(this, nodeName);
		}

		public GRGEN_MODEL.@LModule CreateNodeLModule()
		{
			return GRGEN_MODEL.@LModule.CreateNode(this);
		}

		public GRGEN_MODEL.@LModule CreateNodeLModule(string nodeName)
		{
			return GRGEN_MODEL.@LModule.CreateNode(this, nodeName);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@contains CreateEdgecontains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@contains.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@contains CreateEdgecontains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@contains.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@connected CreateEdgeconnected(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@connected.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@connected CreateEdgeconnected(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@connected.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@right CreateEdgeright(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@right.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@right CreateEdgeright(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@right.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@infront CreateEdgeinfront(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@infront.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@infront CreateEdgeinfront(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@infront.CreateEdge(this, source, target, edgeName);
		}

		public @GRGEN_MODEL.@above CreateEdgeabove(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@above.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@above CreateEdgeabove(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string edgeName)
		{
			return @GRGEN_MODEL.@above.CreateEdge(this, source, target, edgeName);
		}

	}
}
