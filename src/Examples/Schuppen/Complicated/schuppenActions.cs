// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "schuppen.grg" on Wed Aug 31 15:46:43 CEST 2022

//#pragma warning disable CS0219, CS0162
#pragma warning disable 219, 162

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;
using System.Diagnostics;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;
using GRGEN_EXPR = de.unika.ipd.grGen.expression;
using GRGEN_MODEL = de.unika.ipd.grGen.Model_schuppen;
using GRGEN_ACTIONS = de.unika.ipd.grGen.Action_schuppen;

namespace de.unika.ipd.grGen.Action_schuppen
{
	public class Rule_init : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_init instance = null;
		public static Rule_init Instance { get { if(instance==null) { instance = new Rule_init(); instance.initialize(); } return instance; } }

		public enum init_NodeNums { };
		public enum init_EdgeNums { };
		public enum init_VariableNums { };
		public enum init_SubNums { };
		public enum init_AltNums { };
		public enum init_IterNums { };





		public GRGEN_LGSP.PatternGraph pat_init;


		private Rule_init()
			: base("init",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_init+IMatch_init",
				"de.unika.ipd.grGen.Action_schuppen.Rule_init+Match_init"
			)
		{
		}
		private void initialize()
		{
			bool[,] init_isNodeHomomorphicGlobal = new bool[0, 0];
			bool[,] init_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] init_isNodeTotallyHomomorphic = new bool[0];
			bool[] init_isEdgeTotallyHomomorphic = new bool[0];
			pat_init = new GRGEN_LGSP.PatternGraph(
				"init",
				"",
				null, "init",
				false, false,
				new GRGEN_LGSP.PatternNode[] {  }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[0, 0] ,
				new bool[0, 0] ,
				init_isNodeHomomorphicGlobal,
				init_isEdgeHomomorphicGlobal,
				init_isNodeTotallyHomomorphic,
				init_isEdgeTotallyHomomorphic
			);


			patternGraph = pat_init;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_init curMatch = (Match_init)_curMatch;
			GRGEN_MODEL.@Design node_d = GRGEN_MODEL.@Design.CreateNode(graph);
			return;
		}
		private static string[] init_addedNodeNames = new string[] { "d" };
		private static string[] init_addedEdgeNames = new string[] {  };

		static Rule_init() {
		}

		public interface IMatch_init : GRGEN_LIBGR.IMatch
		{
			//Nodes
			//Edges
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_init : GRGEN_LGSP.MatchListElement<Match_init>, IMatch_init
		{
			public enum init_NodeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 0; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum init_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum init_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum init_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum init_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum init_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum init_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_init.instance.pat_init; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_init(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_init(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_init nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_init cur = this;
				while(cur != null) {
					Match_init next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_init that)
			{
			}

			public Match_init(Match_init that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_init that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
			}

			public Match_init(Match_init that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_init()
			{
			}

			public bool IsEqual(Match_init that)
			{
				if(that==null) return false;
				return true;
			}
		}


		public class Extractor
		{
		}


		public static List<GRGEN_ACTIONS.Rule_init.IMatch_init> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_init.IMatch_init>)
				return ((List<GRGEN_ACTIONS.Rule_init.IMatch_init>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_init.IMatch_init>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_init.IMatch_init instanceBearingAttributeForSearch_init = new GRGEN_ACTIONS.Rule_init.Match_init();
	}

	public class Rule_DesignR : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_DesignR instance = null;
		public static Rule_DesignR Instance { get { if(instance==null) { instance = new Rule_DesignR(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] DesignR_node_d_AllowedTypes = null;
		public static bool[] DesignR_node_d_IsAllowedType = null;
		public enum DesignR_NodeNums { @d, };
		public enum DesignR_EdgeNums { };
		public enum DesignR_VariableNums { };
		public enum DesignR_SubNums { };
		public enum DesignR_AltNums { };
		public enum DesignR_IterNums { };






		public GRGEN_LGSP.PatternGraph pat_DesignR;


		private Rule_DesignR()
			: base("DesignR",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_DesignR+IMatch_DesignR",
				"de.unika.ipd.grGen.Action_schuppen.Rule_DesignR+Match_DesignR"
			)
		{
		}
		private void initialize()
		{
			bool[,] DesignR_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] DesignR_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] DesignR_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] DesignR_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternNode DesignR_node_d = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Design, GRGEN_MODEL.NodeType_Design.typeVar, "GRGEN_MODEL.IDesign", "DesignR_node_d", "d", DesignR_node_d_AllowedTypes, DesignR_node_d_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternCondition DesignR_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IDesign", true, "DesignR_node_d", "filled"), new GRGEN_EXPR.Constant("false")),
				new string[] { "DesignR_node_d" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { DesignR_node_d }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_DesignR = new GRGEN_LGSP.PatternGraph(
				"DesignR",
				"",
				null, "DesignR",
				false, false,
				new GRGEN_LGSP.PatternNode[] { DesignR_node_d }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { DesignR_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				DesignR_isNodeHomomorphicGlobal,
				DesignR_isEdgeHomomorphicGlobal,
				DesignR_isNodeTotallyHomomorphic,
				DesignR_isEdgeTotallyHomomorphic
			);

			DesignR_node_d.pointOfDefinition = pat_DesignR;

			patternGraph = pat_DesignR;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_DesignR curMatch = (Match_DesignR)_curMatch;
			GRGEN_LGSP.LGSPNode node_d = curMatch._node_d;
			GRGEN_MODEL.IDesign inode_d = curMatch.node_d;
			GRGEN_MODEL.@Roof node_r = GRGEN_MODEL.@Roof.CreateNode(graph);
			GRGEN_MODEL.@MainPart node_m = GRGEN_MODEL.@MainPart.CreateNode(graph);
			GRGEN_MODEL.@Base node_b = GRGEN_MODEL.@Base.CreateNode(graph);
			GRGEN_MODEL.@contains edge__edge0 = GRGEN_MODEL.@contains.CreateEdge(graph, node_d, node_r);
			GRGEN_MODEL.@contains edge__edge1 = GRGEN_MODEL.@contains.CreateEdge(graph, node_d, node_m);
			GRGEN_MODEL.@contains edge__edge2 = GRGEN_MODEL.@contains.CreateEdge(graph, node_d, node_b);
			GRGEN_MODEL.@connected edge__edge3 = GRGEN_MODEL.@connected.CreateEdge(graph, node_r, node_m);
			GRGEN_MODEL.@connected edge__edge4 = GRGEN_MODEL.@connected.CreateEdge(graph, node_m, node_b);
			GRGEN_MODEL.@above edge__edge5 = GRGEN_MODEL.@above.CreateEdge(graph, node_r, node_m);
			GRGEN_MODEL.@above edge__edge6 = GRGEN_MODEL.@above.CreateEdge(graph, node_m, node_b);
			{ // eval_0
				bool tempvar_0 = (bool )true;
				node_b.@isAlignmentNode = tempvar_0;
				bool tempvar_1 = (bool )true;
				inode_d.@filled = tempvar_1;
			}
			return;
		}
		private static string[] DesignR_addedNodeNames = new string[] { "r", "m", "b" };
		private static string[] DesignR_addedEdgeNames = new string[] { "_edge0", "_edge1", "_edge2", "_edge3", "_edge4", "_edge5", "_edge6" };

		static Rule_DesignR() {
		}

		public interface IMatch_DesignR : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IDesign node_d { get; set; }
			//Edges
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_DesignR : GRGEN_LGSP.MatchListElement<Match_DesignR>, IMatch_DesignR
		{
			public GRGEN_MODEL.IDesign node_d { get { return (GRGEN_MODEL.IDesign)_node_d; } set { _node_d = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_d;
			public enum DesignR_NodeNums { @d, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)DesignR_NodeNums.@d: return _node_d;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "d": return _node_d;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "d": _node_d = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum DesignR_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum DesignR_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum DesignR_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum DesignR_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum DesignR_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum DesignR_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_DesignR.instance.pat_DesignR; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_DesignR(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_DesignR(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_DesignR nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_DesignR cur = this;
				while(cur != null) {
					Match_DesignR next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_DesignR that)
			{
				_node_d = that._node_d;
			}

			public Match_DesignR(Match_DesignR that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_DesignR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_d = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_d];
			}

			public Match_DesignR(Match_DesignR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_DesignR()
			{
			}

			public bool IsEqual(Match_DesignR that)
			{
				if(that==null) return false;
				if(_node_d != that._node_d) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IDesign> Extract_d(List<IMatch_DesignR> matchList)
			{
				List<GRGEN_MODEL.IDesign> resultList = new List<GRGEN_MODEL.IDesign>(matchList.Count);
				foreach(IMatch_DesignR match in matchList)
					resultList.Add(match.node_d);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>)
				return ((List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR instanceBearingAttributeForSearch_DesignR = new GRGEN_ACTIONS.Rule_DesignR.Match_DesignR();
		public static List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> Array_DesignR_groupBy_d(List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> list)
		{
			Dictionary<GRGEN_MODEL.IDesign, List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>> seenValues = new Dictionary<GRGEN_MODEL.IDesign, List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_d)) {
					seenValues[list[pos].@node_d].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> tempList = new List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_d, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> newList = new List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>();
			foreach(List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> Array_DesignR_keepOneForEachBy_d(List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> list)
		{
			List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> newList = new List<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR>();
			Dictionary<GRGEN_MODEL.IDesign, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesign, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_d)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_d, null);
				}
			}
			return newList;
		}
		public static int Array_DesignR_indexOfBy_d(IList<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> list, GRGEN_MODEL.IDesign entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_d.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_DesignR_indexOfBy_d(IList<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> list, GRGEN_MODEL.IDesign entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_d.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_DesignR_lastIndexOfBy_d(IList<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> list, GRGEN_MODEL.IDesign entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_d.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_DesignR_lastIndexOfBy_d(IList<GRGEN_ACTIONS.Rule_DesignR.IMatch_DesignR> list, GRGEN_MODEL.IDesign entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_d.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_MainPartR : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_MainPartR instance = null;
		public static Rule_MainPartR Instance { get { if(instance==null) { instance = new Rule_MainPartR(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] MainPartR_node_m_AllowedTypes = null;
		public static bool[] MainPartR_node_m_IsAllowedType = null;
		public enum MainPartR_NodeNums { @m, };
		public enum MainPartR_EdgeNums { };
		public enum MainPartR_VariableNums { };
		public enum MainPartR_SubNums { };
		public enum MainPartR_AltNums { };
		public enum MainPartR_IterNums { };






		public GRGEN_LGSP.PatternGraph pat_MainPartR;


		private Rule_MainPartR()
			: base("MainPartR",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_MainPartR+IMatch_MainPartR",
				"de.unika.ipd.grGen.Action_schuppen.Rule_MainPartR+Match_MainPartR"
			)
		{
		}
		private void initialize()
		{
			bool[,] MainPartR_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] MainPartR_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] MainPartR_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] MainPartR_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternNode MainPartR_node_m = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@MainPart, GRGEN_MODEL.NodeType_MainPart.typeVar, "GRGEN_MODEL.IMainPart", "MainPartR_node_m", "m", MainPartR_node_m_AllowedTypes, MainPartR_node_m_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternCondition MainPartR_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IMainPart", true, "MainPartR_node_m", "filled"), new GRGEN_EXPR.Constant("false")),
				new string[] { "MainPartR_node_m" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { MainPartR_node_m }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_MainPartR = new GRGEN_LGSP.PatternGraph(
				"MainPartR",
				"",
				null, "MainPartR",
				false, false,
				new GRGEN_LGSP.PatternNode[] { MainPartR_node_m }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { MainPartR_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				MainPartR_isNodeHomomorphicGlobal,
				MainPartR_isEdgeHomomorphicGlobal,
				MainPartR_isNodeTotallyHomomorphic,
				MainPartR_isEdgeTotallyHomomorphic
			);

			MainPartR_node_m.pointOfDefinition = pat_MainPartR;

			patternGraph = pat_MainPartR;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_MainPartR curMatch = (Match_MainPartR)_curMatch;
			GRGEN_LGSP.LGSPNode node_m = curMatch._node_m;
			GRGEN_MODEL.IMainPart inode_m = curMatch.node_m;
			GRGEN_MODEL.@RingBar node_r_u = GRGEN_MODEL.@RingBar.CreateNode(graph);
			GRGEN_MODEL.@Middle node_mi = GRGEN_MODEL.@Middle.CreateNode(graph);
			GRGEN_MODEL.@RingBar node_r_d = GRGEN_MODEL.@RingBar.CreateNode(graph);
			GRGEN_MODEL.@contains edge__edge0 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_r_u);
			GRGEN_MODEL.@contains edge__edge1 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_mi);
			GRGEN_MODEL.@contains edge__edge2 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_r_d);
			GRGEN_MODEL.@connected edge__edge3 = GRGEN_MODEL.@connected.CreateEdge(graph, node_r_u, node_mi);
			GRGEN_MODEL.@connected edge__edge4 = GRGEN_MODEL.@connected.CreateEdge(graph, node_mi, node_r_d);
			GRGEN_MODEL.@above edge__edge5 = GRGEN_MODEL.@above.CreateEdge(graph, node_mi, node_r_d);
			GRGEN_MODEL.@above edge__edge6 = GRGEN_MODEL.@above.CreateEdge(graph, node_r_u, node_mi);
			{ // eval_0
				bool tempvar_0 = (bool )true;
				node_r_d.@isAlignmentNode = tempvar_0;
				bool tempvar_1 = (bool )true;
				inode_m.@filled = tempvar_1;
			}
			return;
		}
		private static string[] MainPartR_addedNodeNames = new string[] { "r_u", "mi", "r_d" };
		private static string[] MainPartR_addedEdgeNames = new string[] { "_edge0", "_edge1", "_edge2", "_edge3", "_edge4", "_edge5", "_edge6" };

		static Rule_MainPartR() {
		}

		public interface IMatch_MainPartR : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IMainPart node_m { get; set; }
			//Edges
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_MainPartR : GRGEN_LGSP.MatchListElement<Match_MainPartR>, IMatch_MainPartR
		{
			public GRGEN_MODEL.IMainPart node_m { get { return (GRGEN_MODEL.IMainPart)_node_m; } set { _node_m = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_m;
			public enum MainPartR_NodeNums { @m, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)MainPartR_NodeNums.@m: return _node_m;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "m": return _node_m;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "m": _node_m = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum MainPartR_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum MainPartR_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum MainPartR_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum MainPartR_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum MainPartR_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum MainPartR_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_MainPartR.instance.pat_MainPartR; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_MainPartR(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_MainPartR(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_MainPartR nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_MainPartR cur = this;
				while(cur != null) {
					Match_MainPartR next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_MainPartR that)
			{
				_node_m = that._node_m;
			}

			public Match_MainPartR(Match_MainPartR that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_MainPartR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_m = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_m];
			}

			public Match_MainPartR(Match_MainPartR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_MainPartR()
			{
			}

			public bool IsEqual(Match_MainPartR that)
			{
				if(that==null) return false;
				if(_node_m != that._node_m) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IMainPart> Extract_m(List<IMatch_MainPartR> matchList)
			{
				List<GRGEN_MODEL.IMainPart> resultList = new List<GRGEN_MODEL.IMainPart>(matchList.Count);
				foreach(IMatch_MainPartR match in matchList)
					resultList.Add(match.node_m);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>)
				return ((List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR instanceBearingAttributeForSearch_MainPartR = new GRGEN_ACTIONS.Rule_MainPartR.Match_MainPartR();
		public static List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> Array_MainPartR_groupBy_m(List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> list)
		{
			Dictionary<GRGEN_MODEL.IMainPart, List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>> seenValues = new Dictionary<GRGEN_MODEL.IMainPart, List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_m)) {
					seenValues[list[pos].@node_m].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> tempList = new List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_m, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> newList = new List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>();
			foreach(List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> Array_MainPartR_keepOneForEachBy_m(List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> list)
		{
			List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> newList = new List<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR>();
			Dictionary<GRGEN_MODEL.IMainPart, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IMainPart, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_m)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_m, null);
				}
			}
			return newList;
		}
		public static int Array_MainPartR_indexOfBy_m(IList<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> list, GRGEN_MODEL.IMainPart entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_MainPartR_indexOfBy_m(IList<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> list, GRGEN_MODEL.IMainPart entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_MainPartR_lastIndexOfBy_m(IList<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> list, GRGEN_MODEL.IMainPart entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_MainPartR_lastIndexOfBy_m(IList<GRGEN_ACTIONS.Rule_MainPartR.IMatch_MainPartR> list, GRGEN_MODEL.IMainPart entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_MiddleR : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_MiddleR instance = null;
		public static Rule_MiddleR Instance { get { if(instance==null) { instance = new Rule_MiddleR(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] MiddleR_node_m_AllowedTypes = null;
		public static bool[] MiddleR_node_m_IsAllowedType = null;
		public enum MiddleR_NodeNums { @m, };
		public enum MiddleR_EdgeNums { };
		public enum MiddleR_VariableNums { };
		public enum MiddleR_SubNums { };
		public enum MiddleR_AltNums { };
		public enum MiddleR_IterNums { };






		public GRGEN_LGSP.PatternGraph pat_MiddleR;


		private Rule_MiddleR()
			: base("MiddleR",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_MiddleR+IMatch_MiddleR",
				"de.unika.ipd.grGen.Action_schuppen.Rule_MiddleR+Match_MiddleR"
			)
		{
		}
		private void initialize()
		{
			bool[,] MiddleR_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] MiddleR_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] MiddleR_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] MiddleR_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternNode MiddleR_node_m = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Middle, GRGEN_MODEL.NodeType_Middle.typeVar, "GRGEN_MODEL.IMiddle", "MiddleR_node_m", "m", MiddleR_node_m_AllowedTypes, MiddleR_node_m_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternCondition MiddleR_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IMiddle", true, "MiddleR_node_m", "filled"), new GRGEN_EXPR.Constant("false")),
				new string[] { "MiddleR_node_m" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { MiddleR_node_m }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_MiddleR = new GRGEN_LGSP.PatternGraph(
				"MiddleR",
				"",
				null, "MiddleR",
				false, false,
				new GRGEN_LGSP.PatternNode[] { MiddleR_node_m }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { MiddleR_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				MiddleR_isNodeHomomorphicGlobal,
				MiddleR_isEdgeHomomorphicGlobal,
				MiddleR_isNodeTotallyHomomorphic,
				MiddleR_isEdgeTotallyHomomorphic
			);

			MiddleR_node_m.pointOfDefinition = pat_MiddleR;

			patternGraph = pat_MiddleR;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_MiddleR curMatch = (Match_MiddleR)_curMatch;
			GRGEN_LGSP.LGSPNode node_m = curMatch._node_m;
			GRGEN_MODEL.IMiddle inode_m = curMatch.node_m;
			GRGEN_MODEL.@Door node_d = GRGEN_MODEL.@Door.CreateNode(graph);
			GRGEN_MODEL.@Infill node_i_f_r = GRGEN_MODEL.@Infill.CreateNode(graph);
			GRGEN_MODEL.@Infill node_i_f_l = GRGEN_MODEL.@Infill.CreateNode(graph);
			GRGEN_MODEL.@Infill node_i_l = GRGEN_MODEL.@Infill.CreateNode(graph);
			GRGEN_MODEL.@Infill node_i_r = GRGEN_MODEL.@Infill.CreateNode(graph);
			GRGEN_MODEL.@Infill node_i_b = GRGEN_MODEL.@Infill.CreateNode(graph);
			GRGEN_MODEL.@Post node_p_f_r = GRGEN_MODEL.@Post.CreateNode(graph);
			GRGEN_MODEL.@Post node_p_f_r_l = GRGEN_MODEL.@Post.CreateNode(graph);
			GRGEN_MODEL.@Post node_p_f_l = GRGEN_MODEL.@Post.CreateNode(graph);
			GRGEN_MODEL.@Post node_p_f_l_r = GRGEN_MODEL.@Post.CreateNode(graph);
			GRGEN_MODEL.@Post node_p_b_r = GRGEN_MODEL.@Post.CreateNode(graph);
			GRGEN_MODEL.@Post node_p_b_l = GRGEN_MODEL.@Post.CreateNode(graph);
			GRGEN_MODEL.@contains edge__edge0 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_d);
			GRGEN_MODEL.@contains edge__edge1 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_i_f_r);
			GRGEN_MODEL.@contains edge__edge2 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_i_f_l);
			GRGEN_MODEL.@contains edge__edge3 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_i_l);
			GRGEN_MODEL.@contains edge__edge4 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_i_r);
			GRGEN_MODEL.@contains edge__edge5 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_i_b);
			GRGEN_MODEL.@contains edge__edge6 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_p_f_r);
			GRGEN_MODEL.@contains edge__edge7 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_p_f_r_l);
			GRGEN_MODEL.@contains edge__edge8 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_p_f_l);
			GRGEN_MODEL.@contains edge__edge9 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_p_f_l_r);
			GRGEN_MODEL.@contains edge__edge10 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_p_b_r);
			GRGEN_MODEL.@contains edge__edge11 = GRGEN_MODEL.@contains.CreateEdge(graph, node_m, node_p_b_l);
			GRGEN_MODEL.@connected edge__edge12 = GRGEN_MODEL.@connected.CreateEdge(graph, node_p_f_l, node_p_f_l_r);
			GRGEN_MODEL.@connected edge__edge13 = GRGEN_MODEL.@connected.CreateEdge(graph, node_p_f_l_r, node_d);
			GRGEN_MODEL.@connected edge__edge14 = GRGEN_MODEL.@connected.CreateEdge(graph, node_d, node_p_f_r_l);
			GRGEN_MODEL.@connected edge__edge15 = GRGEN_MODEL.@connected.CreateEdge(graph, node_p_f_r_l, node_p_f_r);
			GRGEN_MODEL.@right edge__edge16 = GRGEN_MODEL.@right.CreateEdge(graph, node_i_l, node_p_f_l);
			GRGEN_MODEL.@connected edge__edge17 = GRGEN_MODEL.@connected.CreateEdge(graph, node_i_l, node_p_b_l);
			GRGEN_MODEL.@right edge__edge18 = GRGEN_MODEL.@right.CreateEdge(graph, node_i_b, node_p_b_l);
			GRGEN_MODEL.@right edge__edge19 = GRGEN_MODEL.@right.CreateEdge(graph, node_p_b_r, node_i_b);
			GRGEN_MODEL.@right edge__edge20 = GRGEN_MODEL.@right.CreateEdge(graph, node_i_r, node_p_b_r);
			GRGEN_MODEL.@right edge__edge21 = GRGEN_MODEL.@right.CreateEdge(graph, node_p_f_r, node_i_r);
			GRGEN_MODEL.@connected edge__edge22 = GRGEN_MODEL.@connected.CreateEdge(graph, node_p_f_l, node_i_l);
			GRGEN_MODEL.@connected edge__edge23 = GRGEN_MODEL.@connected.CreateEdge(graph, node_i_l, node_p_b_l);
			GRGEN_MODEL.@connected edge__edge24 = GRGEN_MODEL.@connected.CreateEdge(graph, node_p_b_l, node_i_b);
			GRGEN_MODEL.@connected edge__edge25 = GRGEN_MODEL.@connected.CreateEdge(graph, node_i_b, node_p_b_r);
			GRGEN_MODEL.@connected edge__edge26 = GRGEN_MODEL.@connected.CreateEdge(graph, node_p_b_r, node_i_r);
			GRGEN_MODEL.@connected edge__edge27 = GRGEN_MODEL.@connected.CreateEdge(graph, node_i_r, node_p_f_r);
			GRGEN_MODEL.@infront edge__edge28 = GRGEN_MODEL.@infront.CreateEdge(graph, node_p_f_l, node_i_l);
			GRGEN_MODEL.@infront edge__edge29 = GRGEN_MODEL.@infront.CreateEdge(graph, node_i_l, node_p_b_l);
			GRGEN_MODEL.@right edge__edge30 = GRGEN_MODEL.@right.CreateEdge(graph, node_i_b, node_p_b_l);
			GRGEN_MODEL.@right edge__edge31 = GRGEN_MODEL.@right.CreateEdge(graph, node_p_b_r, node_i_b);
			GRGEN_MODEL.@infront edge__edge32 = GRGEN_MODEL.@infront.CreateEdge(graph, node_i_r, node_p_b_r);
			GRGEN_MODEL.@infront edge__edge33 = GRGEN_MODEL.@infront.CreateEdge(graph, node_p_f_r, node_i_r);
			GRGEN_MODEL.@right edge__edge34 = GRGEN_MODEL.@right.CreateEdge(graph, node_i_b, node_p_f_l);
			GRGEN_MODEL.@right edge__edge35 = GRGEN_MODEL.@right.CreateEdge(graph, node_p_f_r, node_i_b);
			{ // eval_0
				bool tempvar_0 = (bool )true;
				node_p_f_l.@isAlignmentNode = tempvar_0;
				bool tempvar_1 = (bool )true;
				inode_m.@filled = tempvar_1;
			}
			return;
		}
		private static string[] MiddleR_addedNodeNames = new string[] { "d", "i_f_r", "i_f_l", "i_l", "i_r", "i_b", "p_f_r", "p_f_r_l", "p_f_l", "p_f_l_r", "p_b_r", "p_b_l" };
		private static string[] MiddleR_addedEdgeNames = new string[] { "_edge0", "_edge1", "_edge2", "_edge3", "_edge4", "_edge5", "_edge6", "_edge7", "_edge8", "_edge9", "_edge10", "_edge11", "_edge12", "_edge13", "_edge14", "_edge15", "_edge16", "_edge17", "_edge18", "_edge19", "_edge20", "_edge21", "_edge22", "_edge23", "_edge24", "_edge25", "_edge26", "_edge27", "_edge28", "_edge29", "_edge30", "_edge31", "_edge32", "_edge33", "_edge34", "_edge35" };

		static Rule_MiddleR() {
		}

		public interface IMatch_MiddleR : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IMiddle node_m { get; set; }
			//Edges
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_MiddleR : GRGEN_LGSP.MatchListElement<Match_MiddleR>, IMatch_MiddleR
		{
			public GRGEN_MODEL.IMiddle node_m { get { return (GRGEN_MODEL.IMiddle)_node_m; } set { _node_m = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_m;
			public enum MiddleR_NodeNums { @m, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)MiddleR_NodeNums.@m: return _node_m;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "m": return _node_m;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "m": _node_m = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum MiddleR_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum MiddleR_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum MiddleR_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum MiddleR_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum MiddleR_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum MiddleR_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_MiddleR.instance.pat_MiddleR; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_MiddleR(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_MiddleR(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_MiddleR nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_MiddleR cur = this;
				while(cur != null) {
					Match_MiddleR next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_MiddleR that)
			{
				_node_m = that._node_m;
			}

			public Match_MiddleR(Match_MiddleR that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_MiddleR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_m = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_m];
			}

			public Match_MiddleR(Match_MiddleR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_MiddleR()
			{
			}

			public bool IsEqual(Match_MiddleR that)
			{
				if(that==null) return false;
				if(_node_m != that._node_m) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IMiddle> Extract_m(List<IMatch_MiddleR> matchList)
			{
				List<GRGEN_MODEL.IMiddle> resultList = new List<GRGEN_MODEL.IMiddle>(matchList.Count);
				foreach(IMatch_MiddleR match in matchList)
					resultList.Add(match.node_m);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>)
				return ((List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR instanceBearingAttributeForSearch_MiddleR = new GRGEN_ACTIONS.Rule_MiddleR.Match_MiddleR();
		public static List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> Array_MiddleR_groupBy_m(List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> list)
		{
			Dictionary<GRGEN_MODEL.IMiddle, List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>> seenValues = new Dictionary<GRGEN_MODEL.IMiddle, List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_m)) {
					seenValues[list[pos].@node_m].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> tempList = new List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_m, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> newList = new List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>();
			foreach(List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> Array_MiddleR_keepOneForEachBy_m(List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> list)
		{
			List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> newList = new List<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR>();
			Dictionary<GRGEN_MODEL.IMiddle, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IMiddle, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_m)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_m, null);
				}
			}
			return newList;
		}
		public static int Array_MiddleR_indexOfBy_m(IList<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> list, GRGEN_MODEL.IMiddle entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_MiddleR_indexOfBy_m(IList<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> list, GRGEN_MODEL.IMiddle entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_MiddleR_lastIndexOfBy_m(IList<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> list, GRGEN_MODEL.IMiddle entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_MiddleR_lastIndexOfBy_m(IList<GRGEN_ACTIONS.Rule_MiddleR.IMatch_MiddleR> list, GRGEN_MODEL.IMiddle entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_m.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_InfillR : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_InfillR instance = null;
		public static Rule_InfillR Instance { get { if(instance==null) { instance = new Rule_InfillR(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] InfillR_node_i_AllowedTypes = null;
		public static bool[] InfillR_node_i_IsAllowedType = null;
		public enum InfillR_NodeNums { @i, };
		public enum InfillR_EdgeNums { };
		public enum InfillR_VariableNums { };
		public enum InfillR_SubNums { };
		public enum InfillR_AltNums { };
		public enum InfillR_IterNums { };






		public GRGEN_LGSP.PatternGraph pat_InfillR;


		private Rule_InfillR()
			: base("InfillR",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_InfillR+IMatch_InfillR",
				"de.unika.ipd.grGen.Action_schuppen.Rule_InfillR+Match_InfillR"
			)
		{
		}
		private void initialize()
		{
			bool[,] InfillR_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] InfillR_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] InfillR_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] InfillR_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternNode InfillR_node_i = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Infill, GRGEN_MODEL.NodeType_Infill.typeVar, "GRGEN_MODEL.IInfill", "InfillR_node_i", "i", InfillR_node_i_AllowedTypes, InfillR_node_i_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternCondition InfillR_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IInfill", true, "InfillR_node_i", "filled"), new GRGEN_EXPR.Constant("false")),
				new string[] { "InfillR_node_i" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { InfillR_node_i }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_InfillR = new GRGEN_LGSP.PatternGraph(
				"InfillR",
				"",
				null, "InfillR",
				false, false,
				new GRGEN_LGSP.PatternNode[] { InfillR_node_i }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { InfillR_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				InfillR_isNodeHomomorphicGlobal,
				InfillR_isEdgeHomomorphicGlobal,
				InfillR_isNodeTotallyHomomorphic,
				InfillR_isEdgeTotallyHomomorphic
			);

			InfillR_node_i.pointOfDefinition = pat_InfillR;

			patternGraph = pat_InfillR;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_InfillR curMatch = (Match_InfillR)_curMatch;
			GRGEN_LGSP.LGSPNode node_i = curMatch._node_i;
			GRGEN_MODEL.IInfill inode_i = curMatch.node_i;
			GRGEN_MODEL.@WallFrame node_wf = GRGEN_MODEL.@WallFrame.CreateNode(graph);
			GRGEN_MODEL.@Wall node_w = GRGEN_MODEL.@Wall.CreateNode(graph);
			GRGEN_MODEL.@contains edge__edge0 = GRGEN_MODEL.@contains.CreateEdge(graph, node_i, node_wf);
			GRGEN_MODEL.@contains edge__edge1 = GRGEN_MODEL.@contains.CreateEdge(graph, node_i, node_w);
			GRGEN_MODEL.@connected edge__edge2 = GRGEN_MODEL.@connected.CreateEdge(graph, node_w, node_wf);
			GRGEN_MODEL.@infront edge__edge3 = GRGEN_MODEL.@infront.CreateEdge(graph, node_w, node_wf);
			{ // eval_0
				bool tempvar_0 = (bool )true;
				inode_i.@filled = tempvar_0;
			}
			return;
		}
		private static string[] InfillR_addedNodeNames = new string[] { "wf", "w" };
		private static string[] InfillR_addedEdgeNames = new string[] { "_edge0", "_edge1", "_edge2", "_edge3" };

		static Rule_InfillR() {
		}

		public interface IMatch_InfillR : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IInfill node_i { get; set; }
			//Edges
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_InfillR : GRGEN_LGSP.MatchListElement<Match_InfillR>, IMatch_InfillR
		{
			public GRGEN_MODEL.IInfill node_i { get { return (GRGEN_MODEL.IInfill)_node_i; } set { _node_i = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_i;
			public enum InfillR_NodeNums { @i, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)InfillR_NodeNums.@i: return _node_i;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "i": return _node_i;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "i": _node_i = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum InfillR_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum InfillR_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum InfillR_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum InfillR_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum InfillR_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum InfillR_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_InfillR.instance.pat_InfillR; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_InfillR(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_InfillR(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_InfillR nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_InfillR cur = this;
				while(cur != null) {
					Match_InfillR next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_InfillR that)
			{
				_node_i = that._node_i;
			}

			public Match_InfillR(Match_InfillR that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_InfillR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_i = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_i];
			}

			public Match_InfillR(Match_InfillR that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_InfillR()
			{
			}

			public bool IsEqual(Match_InfillR that)
			{
				if(that==null) return false;
				if(_node_i != that._node_i) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IInfill> Extract_i(List<IMatch_InfillR> matchList)
			{
				List<GRGEN_MODEL.IInfill> resultList = new List<GRGEN_MODEL.IInfill>(matchList.Count);
				foreach(IMatch_InfillR match in matchList)
					resultList.Add(match.node_i);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>)
				return ((List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR instanceBearingAttributeForSearch_InfillR = new GRGEN_ACTIONS.Rule_InfillR.Match_InfillR();
		public static List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> Array_InfillR_groupBy_i(List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> list)
		{
			Dictionary<GRGEN_MODEL.IInfill, List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>> seenValues = new Dictionary<GRGEN_MODEL.IInfill, List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_i)) {
					seenValues[list[pos].@node_i].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> tempList = new List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_i, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> newList = new List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>();
			foreach(List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> Array_InfillR_keepOneForEachBy_i(List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> list)
		{
			List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> newList = new List<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR>();
			Dictionary<GRGEN_MODEL.IInfill, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IInfill, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_i)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_i, null);
				}
			}
			return newList;
		}
		public static int Array_InfillR_indexOfBy_i(IList<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> list, GRGEN_MODEL.IInfill entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_InfillR_indexOfBy_i(IList<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> list, GRGEN_MODEL.IInfill entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_InfillR_lastIndexOfBy_i(IList<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> list, GRGEN_MODEL.IInfill entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_InfillR_lastIndexOfBy_i(IList<GRGEN_ACTIONS.Rule_InfillR.IMatch_InfillR> list, GRGEN_MODEL.IInfill entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_WallR_front : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_WallR_front instance = null;
		public static Rule_WallR_front Instance { get { if(instance==null) { instance = new Rule_WallR_front(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] WallR_front_node_i_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] WallR_front_node_w_AllowedTypes = null;
		public static bool[] WallR_front_node_i_IsAllowedType = null;
		public static bool[] WallR_front_node_w_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] WallR_front_edge__edge0_AllowedTypes = null;
		public static bool[] WallR_front_edge__edge0_IsAllowedType = null;
		public enum WallR_front_NodeNums { @i, @w, };
		public enum WallR_front_EdgeNums { @_edge0, };
		public enum WallR_front_VariableNums { };
		public enum WallR_front_SubNums { };
		public enum WallR_front_AltNums { };
		public enum WallR_front_IterNums { };






		public GRGEN_LGSP.PatternGraph pat_WallR_front;

		public static GRGEN_LIBGR.NodeType[] WallR_front_neg_0_node__node0_AllowedTypes = null;
		public static bool[] WallR_front_neg_0_node__node0_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] WallR_front_neg_0_edge__edge0_AllowedTypes = null;
		public static bool[] WallR_front_neg_0_edge__edge0_IsAllowedType = null;
		public enum WallR_front_neg_0_NodeNums { @_node0, @i, };
		public enum WallR_front_neg_0_EdgeNums { @_edge0, };
		public enum WallR_front_neg_0_VariableNums { };
		public enum WallR_front_neg_0_SubNums { };
		public enum WallR_front_neg_0_AltNums { };
		public enum WallR_front_neg_0_IterNums { };


		public GRGEN_LGSP.PatternGraph WallR_front_neg_0;


		private Rule_WallR_front()
			: base("WallR_front",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_WallR_front+IMatch_WallR_front",
				"de.unika.ipd.grGen.Action_schuppen.Rule_WallR_front+Match_WallR_front"
			)
		{
		}
		private void initialize()
		{
			bool[,] WallR_front_isNodeHomomorphicGlobal = new bool[2, 2] {
				{ false, false, },
				{ false, false, },
			};
			bool[,] WallR_front_isEdgeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[] WallR_front_isNodeTotallyHomomorphic = new bool[2] { false, false,  };
			bool[] WallR_front_isEdgeTotallyHomomorphic = new bool[1] { false,  };
			GRGEN_LGSP.PatternNode WallR_front_node_i = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Infill, GRGEN_MODEL.NodeType_Infill.typeVar, "GRGEN_MODEL.IInfill", "WallR_front_node_i", "i", WallR_front_node_i_AllowedTypes, WallR_front_node_i_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode WallR_front_node_w = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Wall, GRGEN_MODEL.NodeType_Wall.typeVar, "GRGEN_MODEL.IWall", "WallR_front_node_w", "w", WallR_front_node_w_AllowedTypes, WallR_front_node_w_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge WallR_front_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@contains, GRGEN_MODEL.EdgeType_contains.typeVar, "GRGEN_MODEL.Icontains", "WallR_front_edge__edge0", "_edge0", WallR_front_edge__edge0_AllowedTypes, WallR_front_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternCondition WallR_front_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IWall", true, "WallR_front_node_w", "filled"), new GRGEN_EXPR.Constant("false")),
				new string[] { "WallR_front_node_w" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { WallR_front_node_w }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			bool[,] WallR_front_neg_0_isNodeHomomorphicGlobal = new bool[2, 2] {
				{ false, false, },
				{ false, false, },
			};
			bool[,] WallR_front_neg_0_isEdgeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[] WallR_front_neg_0_isNodeTotallyHomomorphic = new bool[2] { false, false,  };
			bool[] WallR_front_neg_0_isEdgeTotallyHomomorphic = new bool[1] { false,  };
			GRGEN_LGSP.PatternNode WallR_front_neg_0_node__node0 = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Node, GRGEN_MODEL.NodeType_Node.typeVar, "GRGEN_LIBGR.INode", "WallR_front_neg_0_node__node0", "_node0", WallR_front_neg_0_node__node0_AllowedTypes, WallR_front_neg_0_node__node0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge WallR_front_neg_0_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@infront, GRGEN_MODEL.EdgeType_infront.typeVar, "GRGEN_MODEL.Iinfront", "WallR_front_neg_0_edge__edge0", "_edge0", WallR_front_neg_0_edge__edge0_AllowedTypes, WallR_front_neg_0_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			WallR_front_neg_0 = new GRGEN_LGSP.PatternGraph(
				"neg_0",
				"WallR_front_",
				null, "neg_0",
				false, false,
				new GRGEN_LGSP.PatternNode[] { WallR_front_neg_0_node__node0, WallR_front_node_i }, 
				new GRGEN_LGSP.PatternEdge[] { WallR_front_neg_0_edge__edge0 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[2, 2] {
					{ true, false, },
					{ false, true, },
				},
				new bool[1, 1] {
					{ true, },
				},
				WallR_front_neg_0_isNodeHomomorphicGlobal,
				WallR_front_neg_0_isEdgeHomomorphicGlobal,
				WallR_front_neg_0_isNodeTotallyHomomorphic,
				WallR_front_neg_0_isEdgeTotallyHomomorphic
			);
			WallR_front_neg_0.edgeToSourceNode.Add(WallR_front_neg_0_edge__edge0, WallR_front_neg_0_node__node0);
			WallR_front_neg_0.edgeToTargetNode.Add(WallR_front_neg_0_edge__edge0, WallR_front_node_i);

			pat_WallR_front = new GRGEN_LGSP.PatternGraph(
				"WallR_front",
				"",
				null, "WallR_front",
				false, false,
				new GRGEN_LGSP.PatternNode[] { WallR_front_node_i, WallR_front_node_w }, 
				new GRGEN_LGSP.PatternEdge[] { WallR_front_edge__edge0 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] { WallR_front_neg_0,  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { WallR_front_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[2, 2] {
					{ true, false, },
					{ false, true, },
				},
				new bool[1, 1] {
					{ true, },
				},
				WallR_front_isNodeHomomorphicGlobal,
				WallR_front_isEdgeHomomorphicGlobal,
				WallR_front_isNodeTotallyHomomorphic,
				WallR_front_isEdgeTotallyHomomorphic
			);
			pat_WallR_front.edgeToSourceNode.Add(WallR_front_edge__edge0, WallR_front_node_i);
			pat_WallR_front.edgeToTargetNode.Add(WallR_front_edge__edge0, WallR_front_node_w);
			WallR_front_neg_0.embeddingGraph = pat_WallR_front;

			WallR_front_node_i.pointOfDefinition = pat_WallR_front;
			WallR_front_node_w.pointOfDefinition = pat_WallR_front;
			WallR_front_edge__edge0.pointOfDefinition = pat_WallR_front;
			WallR_front_neg_0_node__node0.pointOfDefinition = WallR_front_neg_0;
			WallR_front_neg_0_edge__edge0.pointOfDefinition = WallR_front_neg_0;

			patternGraph = pat_WallR_front;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_WallR_front curMatch = (Match_WallR_front)_curMatch;
			GRGEN_LGSP.LGSPNode node_w = curMatch._node_w;
			GRGEN_MODEL.IWall inode_w = curMatch.node_w;
			GRGEN_MODEL.@FrameModule node_fm_b = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_t = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_t_b = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_b_t = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@contains edge__edge1 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_b);
			GRGEN_MODEL.@contains edge__edge2 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_t);
			GRGEN_MODEL.@contains edge__edge3 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_t_b);
			GRGEN_MODEL.@contains edge__edge4 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_b_t);
			GRGEN_MODEL.@connected edge__edge5 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_b, node_fm_b_t);
			GRGEN_MODEL.@connected edge__edge6 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_b_t, node_fm_t_b);
			GRGEN_MODEL.@connected edge__edge7 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_t_b, node_fm_t);
			GRGEN_MODEL.@above edge__edge8 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_b_t, node_fm_b);
			GRGEN_MODEL.@above edge__edge9 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_t_b, node_fm_b_t);
			GRGEN_MODEL.@above edge__edge10 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_t, node_fm_t_b);
			{ // eval_0
				bool tempvar_0 = (bool )true;
				inode_w.@filled = tempvar_0;
				int tempvar_1 = (int) GRGEN_MODEL.ENUM_Size.@SMALL;
				node_fm_b.@size = (GRGEN_MODEL.ENUM_Size) tempvar_1;
				int tempvar_2 = (int) GRGEN_MODEL.ENUM_Size.@SMALL;
				node_fm_b_t.@size = (GRGEN_MODEL.ENUM_Size) tempvar_2;
				int tempvar_3 = (int) GRGEN_MODEL.ENUM_Size.@SMALL;
				node_fm_t.@size = (GRGEN_MODEL.ENUM_Size) tempvar_3;
				int tempvar_4 = (int) GRGEN_MODEL.ENUM_Size.@SMALL;
				node_fm_t_b.@size = (GRGEN_MODEL.ENUM_Size) tempvar_4;
				int tempvar_5 = (int) GRGEN_MODEL.ENUM_Overhang.@OUTSIDE;
				node_fm_b.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_5;
				int tempvar_6 = (int) GRGEN_MODEL.ENUM_Overhang.@OUTSIDE;
				node_fm_b_t.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_6;
				int tempvar_7 = (int) GRGEN_MODEL.ENUM_Overhang.@OUTSIDE;
				node_fm_t.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_7;
				int tempvar_8 = (int) GRGEN_MODEL.ENUM_Overhang.@OUTSIDE;
				node_fm_t_b.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_8;
				int tempvar_9 = (int) GRGEN_MODEL.ENUM_Filling.@BOX;
				node_fm_b.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_9;
				int tempvar_10 = (int) GRGEN_MODEL.ENUM_Filling.@WINDOW;
				node_fm_b_t.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_10;
				int tempvar_11 = (int) GRGEN_MODEL.ENUM_Filling.@BOX;
				node_fm_t.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_11;
				int tempvar_12 = (int) GRGEN_MODEL.ENUM_Filling.@WINDOW;
				node_fm_t_b.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_12;
			}
			return;
		}
		private static string[] WallR_front_addedNodeNames = new string[] { "fm_b", "fm_t", "fm_t_b", "fm_b_t" };
		private static string[] WallR_front_addedEdgeNames = new string[] { "_edge1", "_edge2", "_edge3", "_edge4", "_edge5", "_edge6", "_edge7", "_edge8", "_edge9", "_edge10" };

		static Rule_WallR_front() {
		}

		public interface IMatch_WallR_front : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IInfill node_i { get; set; }
			GRGEN_MODEL.IWall node_w { get; set; }
			//Edges
			GRGEN_MODEL.Icontains edge__edge0 { get; set; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public interface IMatch_WallR_front_neg_0 : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_LIBGR.INode node__node0 { get; set; }
			GRGEN_MODEL.IInfill node_i { get; set; }
			//Edges
			GRGEN_MODEL.Iinfront edge__edge0 { get; set; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_WallR_front : GRGEN_LGSP.MatchListElement<Match_WallR_front>, IMatch_WallR_front
		{
			public GRGEN_MODEL.IInfill node_i { get { return (GRGEN_MODEL.IInfill)_node_i; } set { _node_i = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IWall node_w { get { return (GRGEN_MODEL.IWall)_node_w; } set { _node_w = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_i;
			public GRGEN_LGSP.LGSPNode _node_w;
			public enum WallR_front_NodeNums { @i, @w, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 2; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)WallR_front_NodeNums.@i: return _node_i;
				case (int)WallR_front_NodeNums.@w: return _node_w;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "i": return _node_i;
				case "w": return _node_w;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "i": _node_i = (GRGEN_LGSP.LGSPNode)value; break;
				case "w": _node_w = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.Icontains edge__edge0 { get { return (GRGEN_MODEL.Icontains)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public enum WallR_front_EdgeNums { @_edge0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 1; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)WallR_front_EdgeNums.@_edge0: return _edge__edge0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "_edge0": return _edge__edge0;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum WallR_front_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum WallR_front_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_front_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_front_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_front_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_WallR_front.instance.pat_WallR_front; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_WallR_front(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_WallR_front(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_WallR_front nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_WallR_front cur = this;
				while(cur != null) {
					Match_WallR_front next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_WallR_front that)
			{
				_node_i = that._node_i;
				_node_w = that._node_w;
				_edge__edge0 = that._edge__edge0;
			}

			public Match_WallR_front(Match_WallR_front that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_WallR_front that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_i = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_i];
				_node_w = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_w];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
			}

			public Match_WallR_front(Match_WallR_front that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_WallR_front()
			{
			}

			public bool IsEqual(Match_WallR_front that)
			{
				if(that==null) return false;
				if(_node_i != that._node_i) return false;
				if(_node_w != that._node_w) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				return true;
			}
		}

		public class Match_WallR_front_neg_0 : GRGEN_LGSP.MatchListElement<Match_WallR_front_neg_0>, IMatch_WallR_front_neg_0
		{
			public GRGEN_LIBGR.INode node__node0 { get { return (GRGEN_LIBGR.INode)_node__node0; } set { _node__node0 = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IInfill node_i { get { return (GRGEN_MODEL.IInfill)_node_i; } set { _node_i = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node__node0;
			public GRGEN_LGSP.LGSPNode _node_i;
			public enum WallR_front_neg_0_NodeNums { @_node0, @i, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 2; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)WallR_front_neg_0_NodeNums.@_node0: return _node__node0;
				case (int)WallR_front_neg_0_NodeNums.@i: return _node_i;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "_node0": return _node__node0;
				case "i": return _node_i;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "_node0": _node__node0 = (GRGEN_LGSP.LGSPNode)value; break;
				case "i": _node_i = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.Iinfront edge__edge0 { get { return (GRGEN_MODEL.Iinfront)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public enum WallR_front_neg_0_EdgeNums { @_edge0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 1; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)WallR_front_neg_0_EdgeNums.@_edge0: return _edge__edge0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "_edge0": return _edge__edge0;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum WallR_front_neg_0_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum WallR_front_neg_0_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_front_neg_0_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_front_neg_0_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_front_neg_0_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_WallR_front.instance.WallR_front_neg_0; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_WallR_front_neg_0(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_WallR_front_neg_0(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_WallR_front_neg_0 nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_WallR_front_neg_0 cur = this;
				while(cur != null) {
					Match_WallR_front_neg_0 next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_WallR_front_neg_0 that)
			{
				_node__node0 = that._node__node0;
				_node_i = that._node_i;
				_edge__edge0 = that._edge__edge0;
			}

			public Match_WallR_front_neg_0(Match_WallR_front_neg_0 that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_WallR_front_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node__node0 = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node__node0];
				_node_i = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_i];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
			}

			public Match_WallR_front_neg_0(Match_WallR_front_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_WallR_front_neg_0()
			{
			}

			public bool IsEqual(Match_WallR_front_neg_0 that)
			{
				if(that==null) return false;
				if(_node__node0 != that._node__node0) return false;
				if(_node_i != that._node_i) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IInfill> Extract_i(List<IMatch_WallR_front> matchList)
			{
				List<GRGEN_MODEL.IInfill> resultList = new List<GRGEN_MODEL.IInfill>(matchList.Count);
				foreach(IMatch_WallR_front match in matchList)
					resultList.Add(match.node_i);
				return resultList;
			}
			public static List<GRGEN_MODEL.IWall> Extract_w(List<IMatch_WallR_front> matchList)
			{
				List<GRGEN_MODEL.IWall> resultList = new List<GRGEN_MODEL.IWall>(matchList.Count);
				foreach(IMatch_WallR_front match in matchList)
					resultList.Add(match.node_w);
				return resultList;
			}
			public static List<GRGEN_MODEL.Icontains> Extract__edge0(List<IMatch_WallR_front> matchList)
			{
				List<GRGEN_MODEL.Icontains> resultList = new List<GRGEN_MODEL.Icontains>(matchList.Count);
				foreach(IMatch_WallR_front match in matchList)
					resultList.Add(match.edge__edge0);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>)
				return ((List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front instanceBearingAttributeForSearch_WallR_front = new GRGEN_ACTIONS.Rule_WallR_front.Match_WallR_front();
		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> Array_WallR_front_groupBy_i(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list)
		{
			Dictionary<GRGEN_MODEL.IInfill, List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>> seenValues = new Dictionary<GRGEN_MODEL.IInfill, List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_i)) {
					seenValues[list[pos].@node_i].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> tempList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_i, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> newList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
			foreach(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> Array_WallR_front_keepOneForEachBy_i(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list)
		{
			List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> newList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
			Dictionary<GRGEN_MODEL.IInfill, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IInfill, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_i)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_i, null);
				}
			}
			return newList;
		}
		public static int Array_WallR_front_indexOfBy_i(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IInfill entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_indexOfBy_i(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IInfill entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_lastIndexOfBy_i(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IInfill entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_lastIndexOfBy_i(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IInfill entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_i.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> Array_WallR_front_groupBy_w(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list)
		{
			Dictionary<GRGEN_MODEL.IWall, List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>> seenValues = new Dictionary<GRGEN_MODEL.IWall, List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_w)) {
					seenValues[list[pos].@node_w].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> tempList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_w, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> newList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
			foreach(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> Array_WallR_front_keepOneForEachBy_w(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list)
		{
			List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> newList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
			Dictionary<GRGEN_MODEL.IWall, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IWall, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_w)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_w, null);
				}
			}
			return newList;
		}
		public static int Array_WallR_front_indexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IWall entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_indexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IWall entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_lastIndexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IWall entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_lastIndexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.IWall entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> Array_WallR_front_groupBy__edge0(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list)
		{
			Dictionary<GRGEN_MODEL.Icontains, List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>> seenValues = new Dictionary<GRGEN_MODEL.Icontains, List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge0)) {
					seenValues[list[pos].@edge__edge0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> tempList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> newList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
			foreach(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> Array_WallR_front_keepOneForEachBy__edge0(List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list)
		{
			List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> newList = new List<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front>();
			Dictionary<GRGEN_MODEL.Icontains, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Icontains, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge0, null);
				}
			}
			return newList;
		}
		public static int Array_WallR_front_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.Icontains entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.Icontains entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.Icontains entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_front_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_WallR_front.IMatch_WallR_front> list, GRGEN_MODEL.Icontains entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_WallR_default : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_WallR_default instance = null;
		public static Rule_WallR_default Instance { get { if(instance==null) { instance = new Rule_WallR_default(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] WallR_default_node_w_AllowedTypes = null;
		public static bool[] WallR_default_node_w_IsAllowedType = null;
		public enum WallR_default_NodeNums { @w, };
		public enum WallR_default_EdgeNums { };
		public enum WallR_default_VariableNums { };
		public enum WallR_default_SubNums { };
		public enum WallR_default_AltNums { };
		public enum WallR_default_IterNums { };






		public GRGEN_LGSP.PatternGraph pat_WallR_default;


		private Rule_WallR_default()
			: base("WallR_default",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_WallR_default+IMatch_WallR_default",
				"de.unika.ipd.grGen.Action_schuppen.Rule_WallR_default+Match_WallR_default"
			)
		{
		}
		private void initialize()
		{
			bool[,] WallR_default_isNodeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[,] WallR_default_isEdgeHomomorphicGlobal = new bool[0, 0];
			bool[] WallR_default_isNodeTotallyHomomorphic = new bool[1] { false,  };
			bool[] WallR_default_isEdgeTotallyHomomorphic = new bool[0];
			GRGEN_LGSP.PatternNode WallR_default_node_w = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@Wall, GRGEN_MODEL.NodeType_Wall.typeVar, "GRGEN_MODEL.IWall", "WallR_default_node_w", "w", WallR_default_node_w_AllowedTypes, WallR_default_node_w_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternCondition WallR_default_cond_0 = new GRGEN_LGSP.PatternCondition(
				new GRGEN_EXPR.EQ(new GRGEN_EXPR.Qualification("GRGEN_MODEL.IWall", true, "WallR_default_node_w", "filled"), new GRGEN_EXPR.Constant("false")),
				new string[] { "WallR_default_node_w" }, new string[] {  }, new string[] {  },
				new GRGEN_LGSP.PatternNode[] { WallR_default_node_w }, new GRGEN_LGSP.PatternEdge[] {  }, new GRGEN_LGSP.PatternVariable[] {  });
			pat_WallR_default = new GRGEN_LGSP.PatternGraph(
				"WallR_default",
				"",
				null, "WallR_default",
				false, false,
				new GRGEN_LGSP.PatternNode[] { WallR_default_node_w }, 
				new GRGEN_LGSP.PatternEdge[] {  }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] { WallR_default_cond_0,  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[1, 1] {
					{ true, },
				},
				new bool[0, 0] ,
				WallR_default_isNodeHomomorphicGlobal,
				WallR_default_isEdgeHomomorphicGlobal,
				WallR_default_isNodeTotallyHomomorphic,
				WallR_default_isEdgeTotallyHomomorphic
			);

			WallR_default_node_w.pointOfDefinition = pat_WallR_default;

			patternGraph = pat_WallR_default;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_WallR_default curMatch = (Match_WallR_default)_curMatch;
			GRGEN_LGSP.LGSPNode node_w = curMatch._node_w;
			GRGEN_MODEL.IWall inode_w = curMatch.node_w;
			GRGEN_MODEL.@LModule node_lm_b_r = GRGEN_MODEL.@LModule.CreateNode(graph);
			GRGEN_MODEL.@LModule node_lm_b_l = GRGEN_MODEL.@LModule.CreateNode(graph);
			GRGEN_MODEL.@LModule node_lm_t_r = GRGEN_MODEL.@LModule.CreateNode(graph);
			GRGEN_MODEL.@LModule node_lm_t_l = GRGEN_MODEL.@LModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_b_r = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_b_l = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_t_r = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@FrameModule node_fm_t_l = GRGEN_MODEL.@FrameModule.CreateNode(graph);
			GRGEN_MODEL.@contains edge__edge0 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_lm_b_r);
			GRGEN_MODEL.@contains edge__edge1 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_lm_b_l);
			GRGEN_MODEL.@contains edge__edge2 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_lm_t_r);
			GRGEN_MODEL.@contains edge__edge3 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_lm_t_l);
			GRGEN_MODEL.@contains edge__edge4 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_b_r);
			GRGEN_MODEL.@contains edge__edge5 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_b_l);
			GRGEN_MODEL.@contains edge__edge6 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_t_r);
			GRGEN_MODEL.@contains edge__edge7 = GRGEN_MODEL.@contains.CreateEdge(graph, node_w, node_fm_t_l);
			GRGEN_MODEL.@connected edge__edge8 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_b_l, node_lm_b_r);
			GRGEN_MODEL.@connected edge__edge9 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_b_r, node_lm_t_r);
			GRGEN_MODEL.@connected edge__edge10 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_t_r, node_lm_t_l);
			GRGEN_MODEL.@connected edge__edge11 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_t_l, node_lm_b_l);
			GRGEN_MODEL.@right edge__edge12 = GRGEN_MODEL.@right.CreateEdge(graph, node_lm_b_r, node_lm_b_l);
			GRGEN_MODEL.@above edge__edge13 = GRGEN_MODEL.@above.CreateEdge(graph, node_lm_t_r, node_lm_b_r);
			GRGEN_MODEL.@right edge__edge14 = GRGEN_MODEL.@right.CreateEdge(graph, node_lm_t_r, node_lm_t_l);
			GRGEN_MODEL.@above edge__edge15 = GRGEN_MODEL.@above.CreateEdge(graph, node_lm_t_l, node_lm_b_l);
			GRGEN_MODEL.@connected edge__edge16 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_b_l, node_fm_b_r);
			GRGEN_MODEL.@connected edge__edge17 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_b_r, node_fm_t_r);
			GRGEN_MODEL.@connected edge__edge18 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_t_r, node_fm_t_l);
			GRGEN_MODEL.@connected edge__edge19 = GRGEN_MODEL.@connected.CreateEdge(graph, node_fm_t_l, node_fm_b_l);
			GRGEN_MODEL.@right edge__edge20 = GRGEN_MODEL.@right.CreateEdge(graph, node_fm_b_r, node_fm_b_l);
			GRGEN_MODEL.@above edge__edge21 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_t_r, node_fm_b_r);
			GRGEN_MODEL.@right edge__edge22 = GRGEN_MODEL.@right.CreateEdge(graph, node_fm_t_r, node_fm_t_l);
			GRGEN_MODEL.@above edge__edge23 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_t_l, node_fm_b_l);
			GRGEN_MODEL.@connected edge__edge24 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_b_l, node_fm_b_l);
			GRGEN_MODEL.@right edge__edge25 = GRGEN_MODEL.@right.CreateEdge(graph, node_fm_b_l, node_lm_b_l);
			GRGEN_MODEL.@above edge__edge26 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_b_l, node_lm_b_l);
			GRGEN_MODEL.@connected edge__edge27 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_b_r, node_fm_b_r);
			GRGEN_MODEL.@right edge__edge28 = GRGEN_MODEL.@right.CreateEdge(graph, node_lm_b_r, node_fm_b_r);
			GRGEN_MODEL.@above edge__edge29 = GRGEN_MODEL.@above.CreateEdge(graph, node_fm_b_r, node_lm_b_r);
			GRGEN_MODEL.@connected edge__edge30 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_t_l, node_fm_t_r);
			GRGEN_MODEL.@right edge__edge31 = GRGEN_MODEL.@right.CreateEdge(graph, node_lm_t_l, node_fm_t_r);
			GRGEN_MODEL.@above edge__edge32 = GRGEN_MODEL.@above.CreateEdge(graph, node_lm_t_l, node_fm_t_r);
			GRGEN_MODEL.@connected edge__edge33 = GRGEN_MODEL.@connected.CreateEdge(graph, node_lm_t_r, node_fm_t_r);
			GRGEN_MODEL.@right edge__edge34 = GRGEN_MODEL.@right.CreateEdge(graph, node_lm_t_r, node_fm_t_r);
			GRGEN_MODEL.@above edge__edge35 = GRGEN_MODEL.@above.CreateEdge(graph, node_lm_t_r, node_fm_t_r);
			{ // eval_0
				bool tempvar_0 = (bool )true;
				inode_w.@filled = tempvar_0;
				int tempvar_1 = (int) GRGEN_MODEL.ENUM_Size.@TALL;
				node_fm_b_l.@size = (GRGEN_MODEL.ENUM_Size) tempvar_1;
				int tempvar_2 = (int) GRGEN_MODEL.ENUM_Size.@TALL;
				node_fm_b_r.@size = (GRGEN_MODEL.ENUM_Size) tempvar_2;
				int tempvar_3 = (int) GRGEN_MODEL.ENUM_Size.@TALL;
				node_fm_t_l.@size = (GRGEN_MODEL.ENUM_Size) tempvar_3;
				int tempvar_4 = (int) GRGEN_MODEL.ENUM_Size.@TALL;
				node_fm_t_r.@size = (GRGEN_MODEL.ENUM_Size) tempvar_4;
				int tempvar_5 = (int) GRGEN_MODEL.ENUM_Overhang.@BOTH;
				node_fm_b_l.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_5;
				int tempvar_6 = (int) GRGEN_MODEL.ENUM_Overhang.@BOTH;
				node_fm_b_r.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_6;
				int tempvar_7 = (int) GRGEN_MODEL.ENUM_Overhang.@BOTH;
				node_fm_t_l.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_7;
				int tempvar_8 = (int) GRGEN_MODEL.ENUM_Overhang.@BOTH;
				node_fm_t_r.@overhang = (GRGEN_MODEL.ENUM_Overhang) tempvar_8;
				int tempvar_9 = (int) GRGEN_MODEL.ENUM_Filling.@BOX;
				node_fm_b_l.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_9;
				int tempvar_10 = (int) GRGEN_MODEL.ENUM_Filling.@BOX;
				node_fm_b_r.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_10;
				int tempvar_11 = (int) GRGEN_MODEL.ENUM_Filling.@BOX;
				node_fm_t_l.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_11;
				int tempvar_12 = (int) GRGEN_MODEL.ENUM_Filling.@BOX;
				node_fm_t_r.@filling = (GRGEN_MODEL.ENUM_Filling) tempvar_12;
			}
			return;
		}
		private static string[] WallR_default_addedNodeNames = new string[] { "lm_b_r", "lm_b_l", "lm_t_r", "lm_t_l", "fm_b_r", "fm_b_l", "fm_t_r", "fm_t_l" };
		private static string[] WallR_default_addedEdgeNames = new string[] { "_edge0", "_edge1", "_edge2", "_edge3", "_edge4", "_edge5", "_edge6", "_edge7", "_edge8", "_edge9", "_edge10", "_edge11", "_edge12", "_edge13", "_edge14", "_edge15", "_edge16", "_edge17", "_edge18", "_edge19", "_edge20", "_edge21", "_edge22", "_edge23", "_edge24", "_edge25", "_edge26", "_edge27", "_edge28", "_edge29", "_edge30", "_edge31", "_edge32", "_edge33", "_edge34", "_edge35" };

		static Rule_WallR_default() {
		}

		public interface IMatch_WallR_default : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IWall node_w { get; set; }
			//Edges
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_WallR_default : GRGEN_LGSP.MatchListElement<Match_WallR_default>, IMatch_WallR_default
		{
			public GRGEN_MODEL.IWall node_w { get { return (GRGEN_MODEL.IWall)_node_w; } set { _node_w = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_w;
			public enum WallR_default_NodeNums { @w, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 1; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)WallR_default_NodeNums.@w: return _node_w;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "w": return _node_w;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "w": _node_w = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public enum WallR_default_EdgeNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 0; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum WallR_default_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum WallR_default_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_default_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_default_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum WallR_default_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_WallR_default.instance.pat_WallR_default; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_WallR_default(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_WallR_default(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_WallR_default nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_WallR_default cur = this;
				while(cur != null) {
					Match_WallR_default next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_WallR_default that)
			{
				_node_w = that._node_w;
			}

			public Match_WallR_default(Match_WallR_default that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_WallR_default that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_w = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_w];
			}

			public Match_WallR_default(Match_WallR_default that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_WallR_default()
			{
			}

			public bool IsEqual(Match_WallR_default that)
			{
				if(that==null) return false;
				if(_node_w != that._node_w) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IWall> Extract_w(List<IMatch_WallR_default> matchList)
			{
				List<GRGEN_MODEL.IWall> resultList = new List<GRGEN_MODEL.IWall>(matchList.Count);
				foreach(IMatch_WallR_default match in matchList)
					resultList.Add(match.node_w);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>)
				return ((List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default instanceBearingAttributeForSearch_WallR_default = new GRGEN_ACTIONS.Rule_WallR_default.Match_WallR_default();
		public static List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> Array_WallR_default_groupBy_w(List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> list)
		{
			Dictionary<GRGEN_MODEL.IWall, List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>> seenValues = new Dictionary<GRGEN_MODEL.IWall, List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_w)) {
					seenValues[list[pos].@node_w].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> tempList = new List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_w, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> newList = new List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>();
			foreach(List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> Array_WallR_default_keepOneForEachBy_w(List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> list)
		{
			List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> newList = new List<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default>();
			Dictionary<GRGEN_MODEL.IWall, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IWall, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_w)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_w, null);
				}
			}
			return newList;
		}
		public static int Array_WallR_default_indexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> list, GRGEN_MODEL.IWall entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_default_indexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> list, GRGEN_MODEL.IWall entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_default_lastIndexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> list, GRGEN_MODEL.IWall entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_WallR_default_lastIndexOfBy_w(IList<GRGEN_ACTIONS.Rule_WallR_default.IMatch_WallR_default> list, GRGEN_MODEL.IWall entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_w.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_RightTransitive : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_RightTransitive instance = null;
		public static Rule_RightTransitive Instance { get { if(instance==null) { instance = new Rule_RightTransitive(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] RightTransitive_node_y_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] RightTransitive_node_x_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] RightTransitive_node_z_AllowedTypes = null;
		public static bool[] RightTransitive_node_y_IsAllowedType = null;
		public static bool[] RightTransitive_node_x_IsAllowedType = null;
		public static bool[] RightTransitive_node_z_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] RightTransitive_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] RightTransitive_edge__edge1_AllowedTypes = null;
		public static bool[] RightTransitive_edge__edge0_IsAllowedType = null;
		public static bool[] RightTransitive_edge__edge1_IsAllowedType = null;
		public enum RightTransitive_NodeNums { @y, @x, @z, };
		public enum RightTransitive_EdgeNums { @_edge0, @_edge1, };
		public enum RightTransitive_VariableNums { };
		public enum RightTransitive_SubNums { };
		public enum RightTransitive_AltNums { };
		public enum RightTransitive_IterNums { };





		public GRGEN_LGSP.PatternGraph pat_RightTransitive;

		public static GRGEN_LIBGR.EdgeType[] RightTransitive_neg_0_edge__edge0_AllowedTypes = null;
		public static bool[] RightTransitive_neg_0_edge__edge0_IsAllowedType = null;
		public enum RightTransitive_neg_0_NodeNums { @z, @x, };
		public enum RightTransitive_neg_0_EdgeNums { @_edge0, };
		public enum RightTransitive_neg_0_VariableNums { };
		public enum RightTransitive_neg_0_SubNums { };
		public enum RightTransitive_neg_0_AltNums { };
		public enum RightTransitive_neg_0_IterNums { };


		public GRGEN_LGSP.PatternGraph RightTransitive_neg_0;


		private Rule_RightTransitive()
			: base("RightTransitive",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_RightTransitive+IMatch_RightTransitive",
				"de.unika.ipd.grGen.Action_schuppen.Rule_RightTransitive+Match_RightTransitive"
			)
		{
		}
		private void initialize()
		{
			bool[,] RightTransitive_isNodeHomomorphicGlobal = new bool[3, 3] {
				{ false, false, false, },
				{ false, false, false, },
				{ false, false, false, },
			};
			bool[,] RightTransitive_isEdgeHomomorphicGlobal = new bool[2, 2] {
				{ false, false, },
				{ false, false, },
			};
			bool[] RightTransitive_isNodeTotallyHomomorphic = new bool[3] { false, false, false,  };
			bool[] RightTransitive_isEdgeTotallyHomomorphic = new bool[2] { false, false,  };
			GRGEN_LGSP.PatternNode RightTransitive_node_y = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@DesignNode, GRGEN_MODEL.NodeType_DesignNode.typeVar, "GRGEN_MODEL.IDesignNode", "RightTransitive_node_y", "y", RightTransitive_node_y_AllowedTypes, RightTransitive_node_y_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode RightTransitive_node_x = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@DesignNode, GRGEN_MODEL.NodeType_DesignNode.typeVar, "GRGEN_MODEL.IDesignNode", "RightTransitive_node_x", "x", RightTransitive_node_x_AllowedTypes, RightTransitive_node_x_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode RightTransitive_node_z = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@DesignNode, GRGEN_MODEL.NodeType_DesignNode.typeVar, "GRGEN_MODEL.IDesignNode", "RightTransitive_node_z", "z", RightTransitive_node_z_AllowedTypes, RightTransitive_node_z_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge RightTransitive_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@right, GRGEN_MODEL.EdgeType_right.typeVar, "GRGEN_MODEL.Iright", "RightTransitive_edge__edge0", "_edge0", RightTransitive_edge__edge0_AllowedTypes, RightTransitive_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge RightTransitive_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@right, GRGEN_MODEL.EdgeType_right.typeVar, "GRGEN_MODEL.Iright", "RightTransitive_edge__edge1", "_edge1", RightTransitive_edge__edge1_AllowedTypes, RightTransitive_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			bool[,] RightTransitive_neg_0_isNodeHomomorphicGlobal = new bool[2, 2] {
				{ false, false, },
				{ false, false, },
			};
			bool[,] RightTransitive_neg_0_isEdgeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[] RightTransitive_neg_0_isNodeTotallyHomomorphic = new bool[2] { false, false,  };
			bool[] RightTransitive_neg_0_isEdgeTotallyHomomorphic = new bool[1] { false,  };
			GRGEN_LGSP.PatternEdge RightTransitive_neg_0_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@right, GRGEN_MODEL.EdgeType_right.typeVar, "GRGEN_MODEL.Iright", "RightTransitive_neg_0_edge__edge0", "_edge0", RightTransitive_neg_0_edge__edge0_AllowedTypes, RightTransitive_neg_0_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			RightTransitive_neg_0 = new GRGEN_LGSP.PatternGraph(
				"neg_0",
				"RightTransitive_",
				null, "neg_0",
				false, false,
				new GRGEN_LGSP.PatternNode[] { RightTransitive_node_z, RightTransitive_node_x }, 
				new GRGEN_LGSP.PatternEdge[] { RightTransitive_neg_0_edge__edge0 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[2, 2] {
					{ true, false, },
					{ false, true, },
				},
				new bool[1, 1] {
					{ true, },
				},
				RightTransitive_neg_0_isNodeHomomorphicGlobal,
				RightTransitive_neg_0_isEdgeHomomorphicGlobal,
				RightTransitive_neg_0_isNodeTotallyHomomorphic,
				RightTransitive_neg_0_isEdgeTotallyHomomorphic
			);
			RightTransitive_neg_0.edgeToSourceNode.Add(RightTransitive_neg_0_edge__edge0, RightTransitive_node_z);
			RightTransitive_neg_0.edgeToTargetNode.Add(RightTransitive_neg_0_edge__edge0, RightTransitive_node_x);

			pat_RightTransitive = new GRGEN_LGSP.PatternGraph(
				"RightTransitive",
				"",
				null, "RightTransitive",
				false, false,
				new GRGEN_LGSP.PatternNode[] { RightTransitive_node_y, RightTransitive_node_x, RightTransitive_node_z }, 
				new GRGEN_LGSP.PatternEdge[] { RightTransitive_edge__edge0, RightTransitive_edge__edge1 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] { RightTransitive_neg_0,  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[3, 3] {
					{ true, false, false, },
					{ false, true, false, },
					{ false, false, true, },
				},
				new bool[2, 2] {
					{ true, false, },
					{ false, true, },
				},
				RightTransitive_isNodeHomomorphicGlobal,
				RightTransitive_isEdgeHomomorphicGlobal,
				RightTransitive_isNodeTotallyHomomorphic,
				RightTransitive_isEdgeTotallyHomomorphic
			);
			pat_RightTransitive.edgeToSourceNode.Add(RightTransitive_edge__edge0, RightTransitive_node_y);
			pat_RightTransitive.edgeToTargetNode.Add(RightTransitive_edge__edge0, RightTransitive_node_x);
			pat_RightTransitive.edgeToSourceNode.Add(RightTransitive_edge__edge1, RightTransitive_node_z);
			pat_RightTransitive.edgeToTargetNode.Add(RightTransitive_edge__edge1, RightTransitive_node_y);
			RightTransitive_neg_0.embeddingGraph = pat_RightTransitive;

			RightTransitive_node_y.pointOfDefinition = pat_RightTransitive;
			RightTransitive_node_x.pointOfDefinition = pat_RightTransitive;
			RightTransitive_node_z.pointOfDefinition = pat_RightTransitive;
			RightTransitive_edge__edge0.pointOfDefinition = pat_RightTransitive;
			RightTransitive_edge__edge1.pointOfDefinition = pat_RightTransitive;
			RightTransitive_neg_0_edge__edge0.pointOfDefinition = RightTransitive_neg_0;

			patternGraph = pat_RightTransitive;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_RightTransitive curMatch = (Match_RightTransitive)_curMatch;
			GRGEN_LGSP.LGSPNode node_z = curMatch._node_z;
			GRGEN_LGSP.LGSPNode node_x = curMatch._node_x;
			GRGEN_MODEL.@right edge__edge2 = GRGEN_MODEL.@right.CreateEdge(graph, node_z, node_x);
			return;
		}
		private static string[] RightTransitive_addedNodeNames = new string[] {  };
		private static string[] RightTransitive_addedEdgeNames = new string[] { "_edge2" };

		static Rule_RightTransitive() {
		}

		public interface IMatch_RightTransitive : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IDesignNode node_y { get; set; }
			GRGEN_MODEL.IDesignNode node_x { get; set; }
			GRGEN_MODEL.IDesignNode node_z { get; set; }
			//Edges
			GRGEN_MODEL.Iright edge__edge0 { get; set; }
			GRGEN_MODEL.Iright edge__edge1 { get; set; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public interface IMatch_RightTransitive_neg_0 : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IDesignNode node_z { get; set; }
			GRGEN_MODEL.IDesignNode node_x { get; set; }
			//Edges
			GRGEN_MODEL.Iright edge__edge0 { get; set; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_RightTransitive : GRGEN_LGSP.MatchListElement<Match_RightTransitive>, IMatch_RightTransitive
		{
			public GRGEN_MODEL.IDesignNode node_y { get { return (GRGEN_MODEL.IDesignNode)_node_y; } set { _node_y = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IDesignNode node_x { get { return (GRGEN_MODEL.IDesignNode)_node_x; } set { _node_x = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IDesignNode node_z { get { return (GRGEN_MODEL.IDesignNode)_node_z; } set { _node_z = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_y;
			public GRGEN_LGSP.LGSPNode _node_x;
			public GRGEN_LGSP.LGSPNode _node_z;
			public enum RightTransitive_NodeNums { @y, @x, @z, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 3; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)RightTransitive_NodeNums.@y: return _node_y;
				case (int)RightTransitive_NodeNums.@x: return _node_x;
				case (int)RightTransitive_NodeNums.@z: return _node_z;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "y": return _node_y;
				case "x": return _node_x;
				case "z": return _node_z;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "y": _node_y = (GRGEN_LGSP.LGSPNode)value; break;
				case "x": _node_x = (GRGEN_LGSP.LGSPNode)value; break;
				case "z": _node_z = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.Iright edge__edge0 { get { return (GRGEN_MODEL.Iright)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.Iright edge__edge1 { get { return (GRGEN_MODEL.Iright)_edge__edge1; } set { _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public enum RightTransitive_EdgeNums { @_edge0, @_edge1, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 2; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)RightTransitive_EdgeNums.@_edge0: return _edge__edge0;
				case (int)RightTransitive_EdgeNums.@_edge1: return _edge__edge1;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "_edge0": return _edge__edge0;
				case "_edge1": return _edge__edge1;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge1": _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum RightTransitive_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum RightTransitive_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum RightTransitive_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum RightTransitive_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum RightTransitive_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_RightTransitive.instance.pat_RightTransitive; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_RightTransitive(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_RightTransitive(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_RightTransitive nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_RightTransitive cur = this;
				while(cur != null) {
					Match_RightTransitive next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_RightTransitive that)
			{
				_node_y = that._node_y;
				_node_x = that._node_x;
				_node_z = that._node_z;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
			}

			public Match_RightTransitive(Match_RightTransitive that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_RightTransitive that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_y = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_y];
				_node_x = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_x];
				_node_z = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_z];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
				_edge__edge1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge1];
			}

			public Match_RightTransitive(Match_RightTransitive that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_RightTransitive()
			{
			}

			public bool IsEqual(Match_RightTransitive that)
			{
				if(that==null) return false;
				if(_node_y != that._node_y) return false;
				if(_node_x != that._node_x) return false;
				if(_node_z != that._node_z) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				if(_edge__edge1 != that._edge__edge1) return false;
				return true;
			}
		}

		public class Match_RightTransitive_neg_0 : GRGEN_LGSP.MatchListElement<Match_RightTransitive_neg_0>, IMatch_RightTransitive_neg_0
		{
			public GRGEN_MODEL.IDesignNode node_z { get { return (GRGEN_MODEL.IDesignNode)_node_z; } set { _node_z = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IDesignNode node_x { get { return (GRGEN_MODEL.IDesignNode)_node_x; } set { _node_x = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_z;
			public GRGEN_LGSP.LGSPNode _node_x;
			public enum RightTransitive_neg_0_NodeNums { @z, @x, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 2; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)RightTransitive_neg_0_NodeNums.@z: return _node_z;
				case (int)RightTransitive_neg_0_NodeNums.@x: return _node_x;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "z": return _node_z;
				case "x": return _node_x;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "z": _node_z = (GRGEN_LGSP.LGSPNode)value; break;
				case "x": _node_x = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.Iright edge__edge0 { get { return (GRGEN_MODEL.Iright)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public enum RightTransitive_neg_0_EdgeNums { @_edge0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 1; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)RightTransitive_neg_0_EdgeNums.@_edge0: return _edge__edge0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "_edge0": return _edge__edge0;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum RightTransitive_neg_0_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum RightTransitive_neg_0_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum RightTransitive_neg_0_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum RightTransitive_neg_0_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum RightTransitive_neg_0_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_RightTransitive.instance.RightTransitive_neg_0; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_RightTransitive_neg_0(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_RightTransitive_neg_0(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_RightTransitive_neg_0 nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_RightTransitive_neg_0 cur = this;
				while(cur != null) {
					Match_RightTransitive_neg_0 next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_RightTransitive_neg_0 that)
			{
				_node_z = that._node_z;
				_node_x = that._node_x;
				_edge__edge0 = that._edge__edge0;
			}

			public Match_RightTransitive_neg_0(Match_RightTransitive_neg_0 that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_RightTransitive_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_z = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_z];
				_node_x = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_x];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
			}

			public Match_RightTransitive_neg_0(Match_RightTransitive_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_RightTransitive_neg_0()
			{
			}

			public bool IsEqual(Match_RightTransitive_neg_0 that)
			{
				if(that==null) return false;
				if(_node_z != that._node_z) return false;
				if(_node_x != that._node_x) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IDesignNode> Extract_y(List<IMatch_RightTransitive> matchList)
			{
				List<GRGEN_MODEL.IDesignNode> resultList = new List<GRGEN_MODEL.IDesignNode>(matchList.Count);
				foreach(IMatch_RightTransitive match in matchList)
					resultList.Add(match.node_y);
				return resultList;
			}
			public static List<GRGEN_MODEL.IDesignNode> Extract_x(List<IMatch_RightTransitive> matchList)
			{
				List<GRGEN_MODEL.IDesignNode> resultList = new List<GRGEN_MODEL.IDesignNode>(matchList.Count);
				foreach(IMatch_RightTransitive match in matchList)
					resultList.Add(match.node_x);
				return resultList;
			}
			public static List<GRGEN_MODEL.IDesignNode> Extract_z(List<IMatch_RightTransitive> matchList)
			{
				List<GRGEN_MODEL.IDesignNode> resultList = new List<GRGEN_MODEL.IDesignNode>(matchList.Count);
				foreach(IMatch_RightTransitive match in matchList)
					resultList.Add(match.node_z);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iright> Extract__edge0(List<IMatch_RightTransitive> matchList)
			{
				List<GRGEN_MODEL.Iright> resultList = new List<GRGEN_MODEL.Iright>(matchList.Count);
				foreach(IMatch_RightTransitive match in matchList)
					resultList.Add(match.edge__edge0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iright> Extract__edge1(List<IMatch_RightTransitive> matchList)
			{
				List<GRGEN_MODEL.Iright> resultList = new List<GRGEN_MODEL.Iright>(matchList.Count);
				foreach(IMatch_RightTransitive match in matchList)
					resultList.Add(match.edge__edge1);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>)
				return ((List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive instanceBearingAttributeForSearch_RightTransitive = new GRGEN_ACTIONS.Rule_RightTransitive.Match_RightTransitive();
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_groupBy_y(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>> seenValues = new Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_y)) {
					seenValues[list[pos].@node_y].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> tempList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_y, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_keepOneForEachBy_y(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_y)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_y, null);
				}
			}
			return newList;
		}
		public static int Array_RightTransitive_indexOfBy_y(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_indexOfBy_y(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy_y(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy_y(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_groupBy_x(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>> seenValues = new Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_x)) {
					seenValues[list[pos].@node_x].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> tempList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_x, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_keepOneForEachBy_x(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_x)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_x, null);
				}
			}
			return newList;
		}
		public static int Array_RightTransitive_indexOfBy_x(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_indexOfBy_x(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy_x(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy_x(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_groupBy_z(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>> seenValues = new Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_z)) {
					seenValues[list[pos].@node_z].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> tempList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_z, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_keepOneForEachBy_z(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_z)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_z, null);
				}
			}
			return newList;
		}
		public static int Array_RightTransitive_indexOfBy_z(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_indexOfBy_z(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy_z(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy_z(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_groupBy__edge0(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			Dictionary<GRGEN_MODEL.Iright, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>> seenValues = new Dictionary<GRGEN_MODEL.Iright, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge0)) {
					seenValues[list[pos].@edge__edge0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> tempList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_keepOneForEachBy__edge0(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			Dictionary<GRGEN_MODEL.Iright, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iright, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge0, null);
				}
			}
			return newList;
		}
		public static int Array_RightTransitive_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_groupBy__edge1(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			Dictionary<GRGEN_MODEL.Iright, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>> seenValues = new Dictionary<GRGEN_MODEL.Iright, List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge1)) {
					seenValues[list[pos].@edge__edge1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> tempList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> Array_RightTransitive_keepOneForEachBy__edge1(List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> newList = new List<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive>();
			Dictionary<GRGEN_MODEL.Iright, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iright, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge1, null);
				}
			}
			return newList;
		}
		public static int Array_RightTransitive_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_RightTransitive_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_RightTransitive.IMatch_RightTransitive> list, GRGEN_MODEL.Iright entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Rule_AboveTransitive : GRGEN_LGSP.LGSPRulePattern
	{
		private static Rule_AboveTransitive instance = null;
		public static Rule_AboveTransitive Instance { get { if(instance==null) { instance = new Rule_AboveTransitive(); instance.initialize(); } return instance; } }

		public static GRGEN_LIBGR.NodeType[] AboveTransitive_node_y_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] AboveTransitive_node_x_AllowedTypes = null;
		public static GRGEN_LIBGR.NodeType[] AboveTransitive_node_z_AllowedTypes = null;
		public static bool[] AboveTransitive_node_y_IsAllowedType = null;
		public static bool[] AboveTransitive_node_x_IsAllowedType = null;
		public static bool[] AboveTransitive_node_z_IsAllowedType = null;
		public static GRGEN_LIBGR.EdgeType[] AboveTransitive_edge__edge0_AllowedTypes = null;
		public static GRGEN_LIBGR.EdgeType[] AboveTransitive_edge__edge1_AllowedTypes = null;
		public static bool[] AboveTransitive_edge__edge0_IsAllowedType = null;
		public static bool[] AboveTransitive_edge__edge1_IsAllowedType = null;
		public enum AboveTransitive_NodeNums { @y, @x, @z, };
		public enum AboveTransitive_EdgeNums { @_edge0, @_edge1, };
		public enum AboveTransitive_VariableNums { };
		public enum AboveTransitive_SubNums { };
		public enum AboveTransitive_AltNums { };
		public enum AboveTransitive_IterNums { };





		public GRGEN_LGSP.PatternGraph pat_AboveTransitive;

		public static GRGEN_LIBGR.EdgeType[] AboveTransitive_neg_0_edge__edge0_AllowedTypes = null;
		public static bool[] AboveTransitive_neg_0_edge__edge0_IsAllowedType = null;
		public enum AboveTransitive_neg_0_NodeNums { @z, @x, };
		public enum AboveTransitive_neg_0_EdgeNums { @_edge0, };
		public enum AboveTransitive_neg_0_VariableNums { };
		public enum AboveTransitive_neg_0_SubNums { };
		public enum AboveTransitive_neg_0_AltNums { };
		public enum AboveTransitive_neg_0_IterNums { };


		public GRGEN_LGSP.PatternGraph AboveTransitive_neg_0;


		private Rule_AboveTransitive()
			: base("AboveTransitive",
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new string[] { },
				new GRGEN_LIBGR.GrGenType[] { },
				new GRGEN_LGSP.LGSPFilter[] {
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirst", null, "keepFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLast", null, "keepLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepFirstFraction", null, "keepFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("keepLastFraction", null, "keepLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirst", null, "removeFirst", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLast", null, "removeLast", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(int)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeFirstFraction", null, "removeFirstFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
					new GRGEN_LGSP.LGSPFilterAutoSupplied("removeLastFraction", null, "removeLastFraction", null, new GRGEN_LIBGR.GrGenType[] {GRGEN_LIBGR.VarType.GetVarType(typeof(double)), }, new String[] {"param"}),
				},
				new GRGEN_LIBGR.MatchClassInfo[] { },
				"de.unika.ipd.grGen.Action_schuppen.Rule_AboveTransitive+IMatch_AboveTransitive",
				"de.unika.ipd.grGen.Action_schuppen.Rule_AboveTransitive+Match_AboveTransitive"
			)
		{
		}
		private void initialize()
		{
			bool[,] AboveTransitive_isNodeHomomorphicGlobal = new bool[3, 3] {
				{ false, false, false, },
				{ false, false, false, },
				{ false, false, false, },
			};
			bool[,] AboveTransitive_isEdgeHomomorphicGlobal = new bool[2, 2] {
				{ false, false, },
				{ false, false, },
			};
			bool[] AboveTransitive_isNodeTotallyHomomorphic = new bool[3] { false, false, false,  };
			bool[] AboveTransitive_isEdgeTotallyHomomorphic = new bool[2] { false, false,  };
			GRGEN_LGSP.PatternNode AboveTransitive_node_y = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@DesignNode, GRGEN_MODEL.NodeType_DesignNode.typeVar, "GRGEN_MODEL.IDesignNode", "AboveTransitive_node_y", "y", AboveTransitive_node_y_AllowedTypes, AboveTransitive_node_y_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode AboveTransitive_node_x = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@DesignNode, GRGEN_MODEL.NodeType_DesignNode.typeVar, "GRGEN_MODEL.IDesignNode", "AboveTransitive_node_x", "x", AboveTransitive_node_x_AllowedTypes, AboveTransitive_node_x_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternNode AboveTransitive_node_z = new GRGEN_LGSP.PatternNode((int) GRGEN_MODEL.NodeTypes.@DesignNode, GRGEN_MODEL.NodeType_DesignNode.typeVar, "GRGEN_MODEL.IDesignNode", "AboveTransitive_node_z", "z", AboveTransitive_node_z_AllowedTypes, AboveTransitive_node_z_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge AboveTransitive_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@above, GRGEN_MODEL.EdgeType_above.typeVar, "GRGEN_MODEL.Iabove", "AboveTransitive_edge__edge0", "_edge0", AboveTransitive_edge__edge0_AllowedTypes, AboveTransitive_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			GRGEN_LGSP.PatternEdge AboveTransitive_edge__edge1 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@above, GRGEN_MODEL.EdgeType_above.typeVar, "GRGEN_MODEL.Iabove", "AboveTransitive_edge__edge1", "_edge1", AboveTransitive_edge__edge1_AllowedTypes, AboveTransitive_edge__edge1_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			bool[,] AboveTransitive_neg_0_isNodeHomomorphicGlobal = new bool[2, 2] {
				{ false, false, },
				{ false, false, },
			};
			bool[,] AboveTransitive_neg_0_isEdgeHomomorphicGlobal = new bool[1, 1] {
				{ false, },
			};
			bool[] AboveTransitive_neg_0_isNodeTotallyHomomorphic = new bool[2] { false, false,  };
			bool[] AboveTransitive_neg_0_isEdgeTotallyHomomorphic = new bool[1] { false,  };
			GRGEN_LGSP.PatternEdge AboveTransitive_neg_0_edge__edge0 = new GRGEN_LGSP.PatternEdge(true, (int) GRGEN_MODEL.EdgeTypes.@above, GRGEN_MODEL.EdgeType_above.typeVar, "GRGEN_MODEL.Iabove", "AboveTransitive_neg_0_edge__edge0", "_edge0", AboveTransitive_neg_0_edge__edge0_AllowedTypes, AboveTransitive_neg_0_edge__edge0_IsAllowedType, 5.5F, -1, false, null, null, null, null, null, null, false, null);
			AboveTransitive_neg_0 = new GRGEN_LGSP.PatternGraph(
				"neg_0",
				"AboveTransitive_",
				null, "neg_0",
				false, false,
				new GRGEN_LGSP.PatternNode[] { AboveTransitive_node_z, AboveTransitive_node_x }, 
				new GRGEN_LGSP.PatternEdge[] { AboveTransitive_neg_0_edge__edge0 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[2, 2] {
					{ true, false, },
					{ false, true, },
				},
				new bool[1, 1] {
					{ true, },
				},
				AboveTransitive_neg_0_isNodeHomomorphicGlobal,
				AboveTransitive_neg_0_isEdgeHomomorphicGlobal,
				AboveTransitive_neg_0_isNodeTotallyHomomorphic,
				AboveTransitive_neg_0_isEdgeTotallyHomomorphic
			);
			AboveTransitive_neg_0.edgeToSourceNode.Add(AboveTransitive_neg_0_edge__edge0, AboveTransitive_node_z);
			AboveTransitive_neg_0.edgeToTargetNode.Add(AboveTransitive_neg_0_edge__edge0, AboveTransitive_node_x);

			pat_AboveTransitive = new GRGEN_LGSP.PatternGraph(
				"AboveTransitive",
				"",
				null, "AboveTransitive",
				false, false,
				new GRGEN_LGSP.PatternNode[] { AboveTransitive_node_y, AboveTransitive_node_x, AboveTransitive_node_z }, 
				new GRGEN_LGSP.PatternEdge[] { AboveTransitive_edge__edge0, AboveTransitive_edge__edge1 }, 
				new GRGEN_LGSP.PatternVariable[] {  }, 
				new GRGEN_LGSP.PatternGraphEmbedding[] {  }, 
				new GRGEN_LGSP.Alternative[] {  }, 
				new GRGEN_LGSP.Iterated[] {  }, 
				new GRGEN_LGSP.PatternGraph[] { AboveTransitive_neg_0,  }, 
				new GRGEN_LGSP.PatternGraph[] {  }, 
				new GRGEN_LGSP.PatternCondition[] {  }, 
				new GRGEN_LGSP.PatternYielding[] {  }, 
				new bool[3, 3] {
					{ true, false, false, },
					{ false, true, false, },
					{ false, false, true, },
				},
				new bool[2, 2] {
					{ true, false, },
					{ false, true, },
				},
				AboveTransitive_isNodeHomomorphicGlobal,
				AboveTransitive_isEdgeHomomorphicGlobal,
				AboveTransitive_isNodeTotallyHomomorphic,
				AboveTransitive_isEdgeTotallyHomomorphic
			);
			pat_AboveTransitive.edgeToSourceNode.Add(AboveTransitive_edge__edge0, AboveTransitive_node_y);
			pat_AboveTransitive.edgeToTargetNode.Add(AboveTransitive_edge__edge0, AboveTransitive_node_x);
			pat_AboveTransitive.edgeToSourceNode.Add(AboveTransitive_edge__edge1, AboveTransitive_node_z);
			pat_AboveTransitive.edgeToTargetNode.Add(AboveTransitive_edge__edge1, AboveTransitive_node_y);
			AboveTransitive_neg_0.embeddingGraph = pat_AboveTransitive;

			AboveTransitive_node_y.pointOfDefinition = pat_AboveTransitive;
			AboveTransitive_node_x.pointOfDefinition = pat_AboveTransitive;
			AboveTransitive_node_z.pointOfDefinition = pat_AboveTransitive;
			AboveTransitive_edge__edge0.pointOfDefinition = pat_AboveTransitive;
			AboveTransitive_edge__edge1.pointOfDefinition = pat_AboveTransitive;
			AboveTransitive_neg_0_edge__edge0.pointOfDefinition = AboveTransitive_neg_0;

			patternGraph = pat_AboveTransitive;
		}


		public void Modify(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch _curMatch)
		{
			GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
			Match_AboveTransitive curMatch = (Match_AboveTransitive)_curMatch;
			GRGEN_LGSP.LGSPNode node_z = curMatch._node_z;
			GRGEN_LGSP.LGSPNode node_x = curMatch._node_x;
			GRGEN_MODEL.@above edge__edge2 = GRGEN_MODEL.@above.CreateEdge(graph, node_z, node_x);
			return;
		}
		private static string[] AboveTransitive_addedNodeNames = new string[] {  };
		private static string[] AboveTransitive_addedEdgeNames = new string[] { "_edge2" };

		static Rule_AboveTransitive() {
		}

		public interface IMatch_AboveTransitive : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IDesignNode node_y { get; set; }
			GRGEN_MODEL.IDesignNode node_x { get; set; }
			GRGEN_MODEL.IDesignNode node_z { get; set; }
			//Edges
			GRGEN_MODEL.Iabove edge__edge0 { get; set; }
			GRGEN_MODEL.Iabove edge__edge1 { get; set; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public interface IMatch_AboveTransitive_neg_0 : GRGEN_LIBGR.IMatch
		{
			//Nodes
			GRGEN_MODEL.IDesignNode node_z { get; set; }
			GRGEN_MODEL.IDesignNode node_x { get; set; }
			//Edges
			GRGEN_MODEL.Iabove edge__edge0 { get; set; }
			//Variables
			//EmbeddedGraphs
			//Alternatives
			//Iterateds
			//Independents
			// further match object stuff
			void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern);
		}

		public class Match_AboveTransitive : GRGEN_LGSP.MatchListElement<Match_AboveTransitive>, IMatch_AboveTransitive
		{
			public GRGEN_MODEL.IDesignNode node_y { get { return (GRGEN_MODEL.IDesignNode)_node_y; } set { _node_y = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IDesignNode node_x { get { return (GRGEN_MODEL.IDesignNode)_node_x; } set { _node_x = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IDesignNode node_z { get { return (GRGEN_MODEL.IDesignNode)_node_z; } set { _node_z = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_y;
			public GRGEN_LGSP.LGSPNode _node_x;
			public GRGEN_LGSP.LGSPNode _node_z;
			public enum AboveTransitive_NodeNums { @y, @x, @z, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 3; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)AboveTransitive_NodeNums.@y: return _node_y;
				case (int)AboveTransitive_NodeNums.@x: return _node_x;
				case (int)AboveTransitive_NodeNums.@z: return _node_z;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "y": return _node_y;
				case "x": return _node_x;
				case "z": return _node_z;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "y": _node_y = (GRGEN_LGSP.LGSPNode)value; break;
				case "x": _node_x = (GRGEN_LGSP.LGSPNode)value; break;
				case "z": _node_z = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.Iabove edge__edge0 { get { return (GRGEN_MODEL.Iabove)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_MODEL.Iabove edge__edge1 { get { return (GRGEN_MODEL.Iabove)_edge__edge1; } set { _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public GRGEN_LGSP.LGSPEdge _edge__edge1;
			public enum AboveTransitive_EdgeNums { @_edge0, @_edge1, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 2; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)AboveTransitive_EdgeNums.@_edge0: return _edge__edge0;
				case (int)AboveTransitive_EdgeNums.@_edge1: return _edge__edge1;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "_edge0": return _edge__edge0;
				case "_edge1": return _edge__edge1;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				case "_edge1": _edge__edge1 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum AboveTransitive_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum AboveTransitive_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum AboveTransitive_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum AboveTransitive_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum AboveTransitive_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_AboveTransitive.instance.pat_AboveTransitive; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_AboveTransitive(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_AboveTransitive(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_AboveTransitive nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_AboveTransitive cur = this;
				while(cur != null) {
					Match_AboveTransitive next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_AboveTransitive that)
			{
				_node_y = that._node_y;
				_node_x = that._node_x;
				_node_z = that._node_z;
				_edge__edge0 = that._edge__edge0;
				_edge__edge1 = that._edge__edge1;
			}

			public Match_AboveTransitive(Match_AboveTransitive that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_AboveTransitive that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_y = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_y];
				_node_x = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_x];
				_node_z = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_z];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
				_edge__edge1 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge1];
			}

			public Match_AboveTransitive(Match_AboveTransitive that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_AboveTransitive()
			{
			}

			public bool IsEqual(Match_AboveTransitive that)
			{
				if(that==null) return false;
				if(_node_y != that._node_y) return false;
				if(_node_x != that._node_x) return false;
				if(_node_z != that._node_z) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				if(_edge__edge1 != that._edge__edge1) return false;
				return true;
			}
		}

		public class Match_AboveTransitive_neg_0 : GRGEN_LGSP.MatchListElement<Match_AboveTransitive_neg_0>, IMatch_AboveTransitive_neg_0
		{
			public GRGEN_MODEL.IDesignNode node_z { get { return (GRGEN_MODEL.IDesignNode)_node_z; } set { _node_z = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_MODEL.IDesignNode node_x { get { return (GRGEN_MODEL.IDesignNode)_node_x; } set { _node_x = (GRGEN_LGSP.LGSPNode)value; } }
			public GRGEN_LGSP.LGSPNode _node_z;
			public GRGEN_LGSP.LGSPNode _node_x;
			public enum AboveTransitive_neg_0_NodeNums { @z, @x, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.INode> Nodes { get { return new GRGEN_LGSP.Nodes_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.INode> NodesEnumerator { get { return new GRGEN_LGSP.Nodes_Enumerator(this); } }
			public override int NumberOfNodes { get { return 2; } }
			public override GRGEN_LIBGR.INode getNodeAt(int index)
			{
				switch(index) {
				case (int)AboveTransitive_neg_0_NodeNums.@z: return _node_z;
				case (int)AboveTransitive_neg_0_NodeNums.@x: return _node_x;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.INode getNode(string name)
			{
				switch(name) {
				case "z": return _node_z;
				case "x": return _node_x;
				default: return null;
				}
			}
			public override void SetNode(string name, GRGEN_LIBGR.INode value)
			{
				switch(name) {
				case "z": _node_z = (GRGEN_LGSP.LGSPNode)value; break;
				case "x": _node_x = (GRGEN_LGSP.LGSPNode)value; break;
				default: break;
				}
			}

			public GRGEN_MODEL.Iabove edge__edge0 { get { return (GRGEN_MODEL.Iabove)_edge__edge0; } set { _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; } }
			public GRGEN_LGSP.LGSPEdge _edge__edge0;
			public enum AboveTransitive_neg_0_EdgeNums { @_edge0, END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IEdge> Edges { get { return new GRGEN_LGSP.Edges_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IEdge> EdgesEnumerator { get { return new GRGEN_LGSP.Edges_Enumerator(this); } }
			public override int NumberOfEdges { get { return 1; } }
			public override GRGEN_LIBGR.IEdge getEdgeAt(int index)
			{
				switch(index) {
				case (int)AboveTransitive_neg_0_EdgeNums.@_edge0: return _edge__edge0;
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IEdge getEdge(string name)
			{
				switch(name) {
				case "_edge0": return _edge__edge0;
				default: return null;
				}
			}
			public override void SetEdge(string name, GRGEN_LIBGR.IEdge value)
			{
				switch(name) {
				case "_edge0": _edge__edge0 = (GRGEN_LGSP.LGSPEdge)value; break;
				default: break;
				}
			}

			public enum AboveTransitive_neg_0_VariableNums { END_OF_ENUM };
			public override IEnumerable<object> Variables { get { return new GRGEN_LGSP.Variables_Enumerable(this); } }
			public override IEnumerator<object> VariablesEnumerator { get { return new GRGEN_LGSP.Variables_Enumerator(this); } }
			public override int NumberOfVariables { get { return 0; } }
			public override object getVariableAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override object getVariable(string name)
			{
				switch(name) {
				default: return null;
				}
			}
			public override void SetVariable(string name, object value)
			{
				switch(name) {
				default: break;
				}
			}

			public enum AboveTransitive_neg_0_SubNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> EmbeddedGraphs { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> EmbeddedGraphsEnumerator { get { return new GRGEN_LGSP.EmbeddedGraphs_Enumerator(this); } }
			public override int NumberOfEmbeddedGraphs { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getEmbeddedGraphAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getEmbeddedGraph(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum AboveTransitive_neg_0_AltNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Alternatives { get { return new GRGEN_LGSP.Alternatives_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> AlternativesEnumerator { get { return new GRGEN_LGSP.Alternatives_Enumerator(this); } }
			public override int NumberOfAlternatives { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getAlternativeAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getAlternative(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum AboveTransitive_neg_0_IterNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatches> Iterateds { get { return new GRGEN_LGSP.Iterateds_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatches> IteratedsEnumerator { get { return new GRGEN_LGSP.Iterateds_Enumerator(this); } }
			public override int NumberOfIterateds { get { return 0; } }
			public override GRGEN_LIBGR.IMatches getIteratedAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatches getIterated(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public enum AboveTransitive_neg_0_IdptNums { END_OF_ENUM };
			public override IEnumerable<GRGEN_LIBGR.IMatch> Independents { get { return new GRGEN_LGSP.Independents_Enumerable(this); } }
			public override IEnumerator<GRGEN_LIBGR.IMatch> IndependentsEnumerator { get { return new GRGEN_LGSP.Independents_Enumerator(this); } }
			public override int NumberOfIndependents { get { return 0; } }
			public override GRGEN_LIBGR.IMatch getIndependentAt(int index)
			{
				switch(index) {
				default: return null;
				}
			}
			public override GRGEN_LIBGR.IMatch getIndependent(string name)
			{
				switch(name) {
				default: return null;
				}
			}

			public override GRGEN_LIBGR.IPatternGraph Pattern { get { return Rule_AboveTransitive.instance.AboveTransitive_neg_0; } }
			public override GRGEN_LIBGR.IMatchClass MatchClass { get { return null; } }
			public override GRGEN_LIBGR.IMatch Clone() { return new Match_AboveTransitive_neg_0(this); }
			public override GRGEN_LIBGR.IMatch Clone(IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap) { return new Match_AboveTransitive_neg_0(this, oldToNewMap); }
			public void SetMatchOfEnclosingPattern(GRGEN_LIBGR.IMatch matchOfEnclosingPattern) { _matchOfEnclosingPattern = matchOfEnclosingPattern; }
			public Match_AboveTransitive_neg_0 nextWithSameHash;
			public void CleanNextWithSameHash() {
				Match_AboveTransitive_neg_0 cur = this;
				while(cur != null) {
					Match_AboveTransitive_neg_0 next = cur.nextWithSameHash;
					cur.nextWithSameHash = null;
					cur = next;
				}
			}

			public void AssignContent(Match_AboveTransitive_neg_0 that)
			{
				_node_z = that._node_z;
				_node_x = that._node_x;
				_edge__edge0 = that._edge__edge0;
			}

			public Match_AboveTransitive_neg_0(Match_AboveTransitive_neg_0 that)
			{
				AssignContent(that);
			}
			public void AssignContent(Match_AboveTransitive_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				_node_z = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_z];
				_node_x = (GRGEN_LGSP.LGSPNode)oldToNewMap[that._node_x];
				_edge__edge0 = (GRGEN_LGSP.LGSPEdge)oldToNewMap[that._edge__edge0];
			}

			public Match_AboveTransitive_neg_0(Match_AboveTransitive_neg_0 that, IDictionary<GRGEN_LIBGR.IGraphElement, GRGEN_LIBGR.IGraphElement> oldToNewMap)
			{
				AssignContent(that, oldToNewMap);
			}
			public Match_AboveTransitive_neg_0()
			{
			}

			public bool IsEqual(Match_AboveTransitive_neg_0 that)
			{
				if(that==null) return false;
				if(_node_z != that._node_z) return false;
				if(_node_x != that._node_x) return false;
				if(_edge__edge0 != that._edge__edge0) return false;
				return true;
			}
		}


		public class Extractor
		{
			public static List<GRGEN_MODEL.IDesignNode> Extract_y(List<IMatch_AboveTransitive> matchList)
			{
				List<GRGEN_MODEL.IDesignNode> resultList = new List<GRGEN_MODEL.IDesignNode>(matchList.Count);
				foreach(IMatch_AboveTransitive match in matchList)
					resultList.Add(match.node_y);
				return resultList;
			}
			public static List<GRGEN_MODEL.IDesignNode> Extract_x(List<IMatch_AboveTransitive> matchList)
			{
				List<GRGEN_MODEL.IDesignNode> resultList = new List<GRGEN_MODEL.IDesignNode>(matchList.Count);
				foreach(IMatch_AboveTransitive match in matchList)
					resultList.Add(match.node_x);
				return resultList;
			}
			public static List<GRGEN_MODEL.IDesignNode> Extract_z(List<IMatch_AboveTransitive> matchList)
			{
				List<GRGEN_MODEL.IDesignNode> resultList = new List<GRGEN_MODEL.IDesignNode>(matchList.Count);
				foreach(IMatch_AboveTransitive match in matchList)
					resultList.Add(match.node_z);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iabove> Extract__edge0(List<IMatch_AboveTransitive> matchList)
			{
				List<GRGEN_MODEL.Iabove> resultList = new List<GRGEN_MODEL.Iabove>(matchList.Count);
				foreach(IMatch_AboveTransitive match in matchList)
					resultList.Add(match.edge__edge0);
				return resultList;
			}
			public static List<GRGEN_MODEL.Iabove> Extract__edge1(List<IMatch_AboveTransitive> matchList)
			{
				List<GRGEN_MODEL.Iabove> resultList = new List<GRGEN_MODEL.Iabove>(matchList.Count);
				foreach(IMatch_AboveTransitive match in matchList)
					resultList.Add(match.edge__edge1);
				return resultList;
			}
		}


		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> ConvertAsNeeded(object parameter)
		{
			if(parameter is List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>)
				return ((List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>)parameter);
			else
				return GRGEN_LIBGR.MatchListHelper.ToList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>((IList<GRGEN_LIBGR.IMatch>)parameter);
		}
	}

	
	public partial class ArrayHelper
	{
		private static GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive instanceBearingAttributeForSearch_AboveTransitive = new GRGEN_ACTIONS.Rule_AboveTransitive.Match_AboveTransitive();
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_groupBy_y(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>> seenValues = new Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_y)) {
					seenValues[list[pos].@node_y].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> tempList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_y, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_keepOneForEachBy_y(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_y)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_y, null);
				}
			}
			return newList;
		}
		public static int Array_AboveTransitive_indexOfBy_y(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_indexOfBy_y(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy_y(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy_y(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_y.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_groupBy_x(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>> seenValues = new Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_x)) {
					seenValues[list[pos].@node_x].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> tempList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_x, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_keepOneForEachBy_x(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_x)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_x, null);
				}
			}
			return newList;
		}
		public static int Array_AboveTransitive_indexOfBy_x(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_indexOfBy_x(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy_x(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy_x(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_x.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_groupBy_z(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>> seenValues = new Dictionary<GRGEN_MODEL.IDesignNode, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@node_z)) {
					seenValues[list[pos].@node_z].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> tempList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@node_z, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_keepOneForEachBy_z(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.IDesignNode, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@node_z)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@node_z, null);
				}
			}
			return newList;
		}
		public static int Array_AboveTransitive_indexOfBy_z(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_indexOfBy_z(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy_z(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy_z(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.IDesignNode entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@node_z.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_groupBy__edge0(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			Dictionary<GRGEN_MODEL.Iabove, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>> seenValues = new Dictionary<GRGEN_MODEL.Iabove, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge0)) {
					seenValues[list[pos].@edge__edge0].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> tempList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge0, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_keepOneForEachBy__edge0(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			Dictionary<GRGEN_MODEL.Iabove, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iabove, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge0)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge0, null);
				}
			}
			return newList;
		}
		public static int Array_AboveTransitive_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_indexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy__edge0(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge0.Equals(entry))
					return i;
			return -1;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_groupBy__edge1(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			Dictionary<GRGEN_MODEL.Iabove, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>> seenValues = new Dictionary<GRGEN_MODEL.Iabove, List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>>();
			for(int pos = 0; pos < list.Count; ++pos)
			{
				if(seenValues.ContainsKey(list[pos].@edge__edge1)) {
					seenValues[list[pos].@edge__edge1].Add(list[pos]);
				} else {
					List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> tempList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
					tempList.Add(list[pos]);
					seenValues.Add(list[pos].@edge__edge1, tempList);
				}
			}
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			foreach(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> entry in seenValues.Values)
			{
				newList.AddRange(entry);
			}
			return newList;
		}
		public static List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> Array_AboveTransitive_keepOneForEachBy__edge1(List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list)
		{
			List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> newList = new List<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive>();
			Dictionary<GRGEN_MODEL.Iabove, GRGEN_LIBGR.SetValueType> alreadySeenMembers = new Dictionary<GRGEN_MODEL.Iabove, GRGEN_LIBGR.SetValueType>();
			foreach(GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive element in list)
			{
				if(!alreadySeenMembers.ContainsKey(element.@edge__edge1)) {
					newList.Add(element);
					alreadySeenMembers.Add(element.@edge__edge1, null);
				}
			}
			return newList;
		}
		public static int Array_AboveTransitive_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry, int startIndex)
		{
			for(int i = startIndex; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_indexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry)
		{
			for(int i = 0; i < list.Count; ++i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry, int startIndex)
		{
			for(int i = startIndex; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
		public static int Array_AboveTransitive_lastIndexOfBy__edge1(IList<GRGEN_ACTIONS.Rule_AboveTransitive.IMatch_AboveTransitive> list, GRGEN_MODEL.Iabove entry)
		{
			for(int i = list.Count - 1; i >= 0; --i)
				if(list[i].@edge__edge1.Equals(entry))
					return i;
			return -1;
		}
	}

	public class Functions
	{

		static Functions() {
		}

	}

	public class Procedures
	{

		static Procedures() {
		}

	}

	public partial class MatchFilters
	{

		static MatchFilters() {
		}

	}

	public partial class MatchClassFilters
	{

		static MatchClassFilters() {
		}

	}



	//-----------------------------------------------------------

	public class schuppen_RuleAndMatchingPatterns : GRGEN_LGSP.LGSPRuleAndMatchingPatterns
	{
		public schuppen_RuleAndMatchingPatterns()
		{
			subpatterns = new GRGEN_LGSP.LGSPMatchingPattern[0];
			rules = new GRGEN_LGSP.LGSPRulePattern[9];
			rulesAndSubpatterns = new GRGEN_LGSP.LGSPMatchingPattern[0+9];
			definedSequences = new GRGEN_LIBGR.DefinedSequenceInfo[0];
			functions = new GRGEN_LIBGR.FunctionInfo[0+0];
			procedures = new GRGEN_LIBGR.ProcedureInfo[0+0];
			matchClasses = new GRGEN_LIBGR.MatchClassInfo[0];
			packages = new string[0];
			rules[0] = Rule_init.Instance;
			rulesAndSubpatterns[0+0] = Rule_init.Instance;
			rules[1] = Rule_DesignR.Instance;
			rulesAndSubpatterns[0+1] = Rule_DesignR.Instance;
			rules[2] = Rule_MainPartR.Instance;
			rulesAndSubpatterns[0+2] = Rule_MainPartR.Instance;
			rules[3] = Rule_MiddleR.Instance;
			rulesAndSubpatterns[0+3] = Rule_MiddleR.Instance;
			rules[4] = Rule_InfillR.Instance;
			rulesAndSubpatterns[0+4] = Rule_InfillR.Instance;
			rules[5] = Rule_WallR_front.Instance;
			rulesAndSubpatterns[0+5] = Rule_WallR_front.Instance;
			rules[6] = Rule_WallR_default.Instance;
			rulesAndSubpatterns[0+6] = Rule_WallR_default.Instance;
			rules[7] = Rule_RightTransitive.Instance;
			rulesAndSubpatterns[0+7] = Rule_RightTransitive.Instance;
			rules[8] = Rule_AboveTransitive.Instance;
			rulesAndSubpatterns[0+8] = Rule_AboveTransitive.Instance;
		}
		public override GRGEN_LGSP.LGSPRulePattern[] Rules { get { return rules; } }
		private GRGEN_LGSP.LGSPRulePattern[] rules;
		public override GRGEN_LGSP.LGSPMatchingPattern[] Subpatterns { get { return subpatterns; } }
		private GRGEN_LGSP.LGSPMatchingPattern[] subpatterns;
		public override GRGEN_LGSP.LGSPMatchingPattern[] RulesAndSubpatterns { get { return rulesAndSubpatterns; } }
		private GRGEN_LGSP.LGSPMatchingPattern[] rulesAndSubpatterns;
		public override GRGEN_LIBGR.DefinedSequenceInfo[] DefinedSequences { get { return definedSequences; } }
		private GRGEN_LIBGR.DefinedSequenceInfo[] definedSequences;
		public override GRGEN_LIBGR.FunctionInfo[] Functions { get { return functions; } }
		private GRGEN_LIBGR.FunctionInfo[] functions;
		public override GRGEN_LIBGR.ProcedureInfo[] Procedures { get { return procedures; } }
		private GRGEN_LIBGR.ProcedureInfo[] procedures;
		public override GRGEN_LIBGR.MatchClassInfo[] MatchClasses { get { return matchClasses; } }
		private GRGEN_LIBGR.MatchClassInfo[] matchClasses;
		public override string[] Packages { get { return packages; } }
		private string[] packages;
	}


    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_init
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_init.IMatch_init match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_init : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_init
    {
        public Action_init()
            : base(Rule_init.Instance.patternGraph)
        {
            _rulePattern = Rule_init.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_init _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "init"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_init.Match_init, Rule_init.IMatch_init> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_init Instance { get { return instance; } set { instance = value; } }
        private static Action_init instance = new Action_init();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_init.Match_init, Rule_init.IMatch_init>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            Rule_init.Match_init match = matches.GetNextUnfilledPosition();
            matches.PositionWasFilledFixIt();
            // if enough matches were found, we leave
            if(maxMatches > 0 && matches.Count >= maxMatches)
            {
                return matches;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_init.IMatch_init match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches)
        {
            foreach(Rule_init.IMatch_init match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_init.IMatch_init match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_init.IMatch_init)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_init.IMatch_init>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_DesignR
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_DesignR.IMatch_DesignR match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_DesignR : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_DesignR
    {
        public Action_DesignR()
            : base(Rule_DesignR.Instance.patternGraph)
        {
            _rulePattern = Rule_DesignR.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_DesignR _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "DesignR"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_DesignR.Match_DesignR, Rule_DesignR.IMatch_DesignR> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_DesignR Instance { get { return instance; } set { instance = value; } }
        private static Action_DesignR instance = new Action_DesignR();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_DesignR.Match_DesignR, Rule_DesignR.IMatch_DesignR>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup DesignR_node_d 
            int type_id_candidate_DesignR_node_d = 2;
            for(GRGEN_LGSP.LGSPNode head_candidate_DesignR_node_d = graph.nodesByTypeHeads[type_id_candidate_DesignR_node_d], candidate_DesignR_node_d = head_candidate_DesignR_node_d.lgspTypeNext; candidate_DesignR_node_d != head_candidate_DesignR_node_d; candidate_DesignR_node_d = candidate_DesignR_node_d.lgspTypeNext)
            {
                // Condition 
                if(!((((GRGEN_MODEL.IDesign)candidate_DesignR_node_d).@filled == false))) {
                    continue;
                }
                Rule_DesignR.Match_DesignR match = matches.GetNextUnfilledPosition();
                match._node_d = candidate_DesignR_node_d;
                matches.PositionWasFilledFixIt();
                // if enough matches were found, we leave
                if(maxMatches > 0 && matches.Count >= maxMatches)
                {
                    graph.MoveHeadAfter(candidate_DesignR_node_d);
                    return matches;
                }
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_DesignR.IMatch_DesignR match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches)
        {
            foreach(Rule_DesignR.IMatch_DesignR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_DesignR.IMatch_DesignR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_DesignR.IMatch_DesignR)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_DesignR.IMatch_DesignR>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_MainPartR
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_MainPartR.IMatch_MainPartR match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_MainPartR : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_MainPartR
    {
        public Action_MainPartR()
            : base(Rule_MainPartR.Instance.patternGraph)
        {
            _rulePattern = Rule_MainPartR.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_MainPartR _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "MainPartR"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_MainPartR.Match_MainPartR, Rule_MainPartR.IMatch_MainPartR> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_MainPartR Instance { get { return instance; } set { instance = value; } }
        private static Action_MainPartR instance = new Action_MainPartR();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_MainPartR.Match_MainPartR, Rule_MainPartR.IMatch_MainPartR>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup MainPartR_node_m 
            int type_id_candidate_MainPartR_node_m = 4;
            for(GRGEN_LGSP.LGSPNode head_candidate_MainPartR_node_m = graph.nodesByTypeHeads[type_id_candidate_MainPartR_node_m], candidate_MainPartR_node_m = head_candidate_MainPartR_node_m.lgspTypeNext; candidate_MainPartR_node_m != head_candidate_MainPartR_node_m; candidate_MainPartR_node_m = candidate_MainPartR_node_m.lgspTypeNext)
            {
                // Condition 
                if(!((((GRGEN_MODEL.IMainPart)candidate_MainPartR_node_m).@filled == false))) {
                    continue;
                }
                Rule_MainPartR.Match_MainPartR match = matches.GetNextUnfilledPosition();
                match._node_m = candidate_MainPartR_node_m;
                matches.PositionWasFilledFixIt();
                // if enough matches were found, we leave
                if(maxMatches > 0 && matches.Count >= maxMatches)
                {
                    graph.MoveHeadAfter(candidate_MainPartR_node_m);
                    return matches;
                }
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_MainPartR.IMatch_MainPartR match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches)
        {
            foreach(Rule_MainPartR.IMatch_MainPartR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_MainPartR.IMatch_MainPartR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_MainPartR.IMatch_MainPartR)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_MainPartR.IMatch_MainPartR>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_MiddleR
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_MiddleR.IMatch_MiddleR match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_MiddleR : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_MiddleR
    {
        public Action_MiddleR()
            : base(Rule_MiddleR.Instance.patternGraph)
        {
            _rulePattern = Rule_MiddleR.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_MiddleR _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "MiddleR"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_MiddleR.Match_MiddleR, Rule_MiddleR.IMatch_MiddleR> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_MiddleR Instance { get { return instance; } set { instance = value; } }
        private static Action_MiddleR instance = new Action_MiddleR();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_MiddleR.Match_MiddleR, Rule_MiddleR.IMatch_MiddleR>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup MiddleR_node_m 
            int type_id_candidate_MiddleR_node_m = 7;
            for(GRGEN_LGSP.LGSPNode head_candidate_MiddleR_node_m = graph.nodesByTypeHeads[type_id_candidate_MiddleR_node_m], candidate_MiddleR_node_m = head_candidate_MiddleR_node_m.lgspTypeNext; candidate_MiddleR_node_m != head_candidate_MiddleR_node_m; candidate_MiddleR_node_m = candidate_MiddleR_node_m.lgspTypeNext)
            {
                // Condition 
                if(!((((GRGEN_MODEL.IMiddle)candidate_MiddleR_node_m).@filled == false))) {
                    continue;
                }
                Rule_MiddleR.Match_MiddleR match = matches.GetNextUnfilledPosition();
                match._node_m = candidate_MiddleR_node_m;
                matches.PositionWasFilledFixIt();
                // if enough matches were found, we leave
                if(maxMatches > 0 && matches.Count >= maxMatches)
                {
                    graph.MoveHeadAfter(candidate_MiddleR_node_m);
                    return matches;
                }
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_MiddleR.IMatch_MiddleR match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches)
        {
            foreach(Rule_MiddleR.IMatch_MiddleR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_MiddleR.IMatch_MiddleR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_MiddleR.IMatch_MiddleR)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_MiddleR.IMatch_MiddleR>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_InfillR
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_InfillR.IMatch_InfillR match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_InfillR : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_InfillR
    {
        public Action_InfillR()
            : base(Rule_InfillR.Instance.patternGraph)
        {
            _rulePattern = Rule_InfillR.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_InfillR _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "InfillR"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_InfillR.Match_InfillR, Rule_InfillR.IMatch_InfillR> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_InfillR Instance { get { return instance; } set { instance = value; } }
        private static Action_InfillR instance = new Action_InfillR();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_InfillR.Match_InfillR, Rule_InfillR.IMatch_InfillR>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup InfillR_node_i 
            int type_id_candidate_InfillR_node_i = 9;
            for(GRGEN_LGSP.LGSPNode head_candidate_InfillR_node_i = graph.nodesByTypeHeads[type_id_candidate_InfillR_node_i], candidate_InfillR_node_i = head_candidate_InfillR_node_i.lgspTypeNext; candidate_InfillR_node_i != head_candidate_InfillR_node_i; candidate_InfillR_node_i = candidate_InfillR_node_i.lgspTypeNext)
            {
                // Condition 
                if(!((((GRGEN_MODEL.IInfill)candidate_InfillR_node_i).@filled == false))) {
                    continue;
                }
                Rule_InfillR.Match_InfillR match = matches.GetNextUnfilledPosition();
                match._node_i = candidate_InfillR_node_i;
                matches.PositionWasFilledFixIt();
                // if enough matches were found, we leave
                if(maxMatches > 0 && matches.Count >= maxMatches)
                {
                    graph.MoveHeadAfter(candidate_InfillR_node_i);
                    return matches;
                }
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_InfillR.IMatch_InfillR match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches)
        {
            foreach(Rule_InfillR.IMatch_InfillR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_InfillR.IMatch_InfillR match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_InfillR.IMatch_InfillR)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_InfillR.IMatch_InfillR>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_WallR_front
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_WallR_front.IMatch_WallR_front match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_WallR_front : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_WallR_front
    {
        public Action_WallR_front()
            : base(Rule_WallR_front.Instance.patternGraph)
        {
            _rulePattern = Rule_WallR_front.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_WallR_front _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "WallR_front"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_WallR_front.Match_WallR_front, Rule_WallR_front.IMatch_WallR_front> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_WallR_front Instance { get { return instance; } set { instance = value; } }
        private static Action_WallR_front instance = new Action_WallR_front();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_WallR_front.Match_WallR_front, Rule_WallR_front.IMatch_WallR_front>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup WallR_front_edge__edge0 
            int type_id_candidate_WallR_front_edge__edge0 = 3;
            for(GRGEN_LGSP.LGSPEdge head_candidate_WallR_front_edge__edge0 = graph.edgesByTypeHeads[type_id_candidate_WallR_front_edge__edge0], candidate_WallR_front_edge__edge0 = head_candidate_WallR_front_edge__edge0.lgspTypeNext; candidate_WallR_front_edge__edge0 != head_candidate_WallR_front_edge__edge0; candidate_WallR_front_edge__edge0 = candidate_WallR_front_edge__edge0.lgspTypeNext)
            {
                // Implicit Source WallR_front_node_i from WallR_front_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_WallR_front_node_i = candidate_WallR_front_edge__edge0.lgspSource;
                if(candidate_WallR_front_node_i.lgspType.TypeID!=9) {
                    continue;
                }
                // Implicit Target WallR_front_node_w from WallR_front_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_WallR_front_node_w = candidate_WallR_front_edge__edge0.lgspTarget;
                if(candidate_WallR_front_node_w.lgspType.TypeID!=11) {
                    continue;
                }
                // Condition 
                if(!((((GRGEN_MODEL.IWall)candidate_WallR_front_node_w).@filled == false))) {
                    continue;
                }
                // NegativePattern 
                {
                    ++isoSpace;
                    uint prev_neg_0__candidate_WallR_front_node_i;
                    prev_neg_0__candidate_WallR_front_node_i = candidate_WallR_front_node_i.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                    candidate_WallR_front_node_i.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                    // Extend Incoming WallR_front_neg_0_edge__edge0 from WallR_front_node_i 
                    GRGEN_LGSP.LGSPEdge head_candidate_WallR_front_neg_0_edge__edge0 = candidate_WallR_front_node_i.lgspInhead;
                    if(head_candidate_WallR_front_neg_0_edge__edge0 != null)
                    {
                        GRGEN_LGSP.LGSPEdge candidate_WallR_front_neg_0_edge__edge0 = head_candidate_WallR_front_neg_0_edge__edge0;
                        do
                        {
                            if(candidate_WallR_front_neg_0_edge__edge0.lgspType.TypeID!=8) {
                                continue;
                            }
                            // Implicit Source WallR_front_neg_0_node__node0 from WallR_front_neg_0_edge__edge0 
                            GRGEN_LGSP.LGSPNode candidate_WallR_front_neg_0_node__node0 = candidate_WallR_front_neg_0_edge__edge0.lgspSource;
                            if((candidate_WallR_front_neg_0_node__node0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                            {
                                continue;
                            }
                            // negative pattern found
                            candidate_WallR_front_node_i.lgspFlags = candidate_WallR_front_node_i.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_WallR_front_node_i;
                            --isoSpace;
                            goto label0;
                        }
                        while( (candidate_WallR_front_neg_0_edge__edge0 = candidate_WallR_front_neg_0_edge__edge0.lgspInNext) != head_candidate_WallR_front_neg_0_edge__edge0 );
                    }
                    candidate_WallR_front_node_i.lgspFlags = candidate_WallR_front_node_i.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_WallR_front_node_i;
                    --isoSpace;
                }
                Rule_WallR_front.Match_WallR_front match = matches.GetNextUnfilledPosition();
                match._node_i = candidate_WallR_front_node_i;
                match._node_w = candidate_WallR_front_node_w;
                match._edge__edge0 = candidate_WallR_front_edge__edge0;
                matches.PositionWasFilledFixIt();
                // if enough matches were found, we leave
                if(maxMatches > 0 && matches.Count >= maxMatches)
                {
                    graph.MoveHeadAfter(candidate_WallR_front_edge__edge0);
                    return matches;
                }
label0: ;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_WallR_front.IMatch_WallR_front match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches)
        {
            foreach(Rule_WallR_front.IMatch_WallR_front match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_WallR_front.IMatch_WallR_front match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_WallR_front.IMatch_WallR_front)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_WallR_front.IMatch_WallR_front>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_WallR_default
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_WallR_default.IMatch_WallR_default match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_WallR_default : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_WallR_default
    {
        public Action_WallR_default()
            : base(Rule_WallR_default.Instance.patternGraph)
        {
            _rulePattern = Rule_WallR_default.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_WallR_default _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "WallR_default"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_WallR_default.Match_WallR_default, Rule_WallR_default.IMatch_WallR_default> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_WallR_default Instance { get { return instance; } set { instance = value; } }
        private static Action_WallR_default instance = new Action_WallR_default();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_WallR_default.Match_WallR_default, Rule_WallR_default.IMatch_WallR_default>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup WallR_default_node_w 
            int type_id_candidate_WallR_default_node_w = 11;
            for(GRGEN_LGSP.LGSPNode head_candidate_WallR_default_node_w = graph.nodesByTypeHeads[type_id_candidate_WallR_default_node_w], candidate_WallR_default_node_w = head_candidate_WallR_default_node_w.lgspTypeNext; candidate_WallR_default_node_w != head_candidate_WallR_default_node_w; candidate_WallR_default_node_w = candidate_WallR_default_node_w.lgspTypeNext)
            {
                // Condition 
                if(!((((GRGEN_MODEL.IWall)candidate_WallR_default_node_w).@filled == false))) {
                    continue;
                }
                Rule_WallR_default.Match_WallR_default match = matches.GetNextUnfilledPosition();
                match._node_w = candidate_WallR_default_node_w;
                matches.PositionWasFilledFixIt();
                // if enough matches were found, we leave
                if(maxMatches > 0 && matches.Count >= maxMatches)
                {
                    graph.MoveHeadAfter(candidate_WallR_default_node_w);
                    return matches;
                }
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_WallR_default.IMatch_WallR_default match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches)
        {
            foreach(Rule_WallR_default.IMatch_WallR_default match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_WallR_default.IMatch_WallR_default match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_WallR_default.IMatch_WallR_default)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_WallR_default.IMatch_WallR_default>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_RightTransitive
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_RightTransitive.IMatch_RightTransitive match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_RightTransitive : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_RightTransitive
    {
        public Action_RightTransitive()
            : base(Rule_RightTransitive.Instance.patternGraph)
        {
            _rulePattern = Rule_RightTransitive.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_RightTransitive _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "RightTransitive"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_RightTransitive.Match_RightTransitive, Rule_RightTransitive.IMatch_RightTransitive> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_RightTransitive Instance { get { return instance; } set { instance = value; } }
        private static Action_RightTransitive instance = new Action_RightTransitive();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_RightTransitive.Match_RightTransitive, Rule_RightTransitive.IMatch_RightTransitive>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup RightTransitive_edge__edge0 
            int type_id_candidate_RightTransitive_edge__edge0 = 7;
            for(GRGEN_LGSP.LGSPEdge head_candidate_RightTransitive_edge__edge0 = graph.edgesByTypeHeads[type_id_candidate_RightTransitive_edge__edge0], candidate_RightTransitive_edge__edge0 = head_candidate_RightTransitive_edge__edge0.lgspTypeNext; candidate_RightTransitive_edge__edge0 != head_candidate_RightTransitive_edge__edge0; candidate_RightTransitive_edge__edge0 = candidate_RightTransitive_edge__edge0.lgspTypeNext)
            {
                uint prev__candidate_RightTransitive_edge__edge0;
                prev__candidate_RightTransitive_edge__edge0 = candidate_RightTransitive_edge__edge0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_RightTransitive_edge__edge0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Source RightTransitive_node_y from RightTransitive_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_RightTransitive_node_y = candidate_RightTransitive_edge__edge0.lgspSource;
                if(!GRGEN_MODEL.NodeType_DesignNode.isMyType[candidate_RightTransitive_node_y.lgspType.TypeID]) {
                    candidate_RightTransitive_edge__edge0.lgspFlags = candidate_RightTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_edge__edge0;
                    continue;
                }
                uint prev__candidate_RightTransitive_node_y;
                prev__candidate_RightTransitive_node_y = candidate_RightTransitive_node_y.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_RightTransitive_node_y.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Target RightTransitive_node_x from RightTransitive_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_RightTransitive_node_x = candidate_RightTransitive_edge__edge0.lgspTarget;
                if(!GRGEN_MODEL.NodeType_DesignNode.isMyType[candidate_RightTransitive_node_x.lgspType.TypeID]) {
                    candidate_RightTransitive_node_y.lgspFlags = candidate_RightTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_node_y;
                    candidate_RightTransitive_edge__edge0.lgspFlags = candidate_RightTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_edge__edge0;
                    continue;
                }
                if((candidate_RightTransitive_node_x.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                {
                    candidate_RightTransitive_node_y.lgspFlags = candidate_RightTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_node_y;
                    candidate_RightTransitive_edge__edge0.lgspFlags = candidate_RightTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_edge__edge0;
                    continue;
                }
                uint prev__candidate_RightTransitive_node_x;
                prev__candidate_RightTransitive_node_x = candidate_RightTransitive_node_x.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_RightTransitive_node_x.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Extend Incoming RightTransitive_edge__edge1 from RightTransitive_node_y 
                GRGEN_LGSP.LGSPEdge head_candidate_RightTransitive_edge__edge1 = candidate_RightTransitive_node_y.lgspInhead;
                if(head_candidate_RightTransitive_edge__edge1 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_RightTransitive_edge__edge1 = head_candidate_RightTransitive_edge__edge1;
                    do
                    {
                        if(candidate_RightTransitive_edge__edge1.lgspType.TypeID!=7) {
                            continue;
                        }
                        if((candidate_RightTransitive_edge__edge1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            continue;
                        }
                        // Implicit Source RightTransitive_node_z from RightTransitive_edge__edge1 
                        GRGEN_LGSP.LGSPNode candidate_RightTransitive_node_z = candidate_RightTransitive_edge__edge1.lgspSource;
                        if(!GRGEN_MODEL.NodeType_DesignNode.isMyType[candidate_RightTransitive_node_z.lgspType.TypeID]) {
                            continue;
                        }
                        if((candidate_RightTransitive_node_z.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            continue;
                        }
                        // NegativePattern 
                        {
                            ++isoSpace;
                            uint prev_neg_0__candidate_RightTransitive_node_z;
                            prev_neg_0__candidate_RightTransitive_node_z = candidate_RightTransitive_node_z.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                            candidate_RightTransitive_node_z.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                            if((candidate_RightTransitive_node_x.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                            {
                                candidate_RightTransitive_node_z.lgspFlags = candidate_RightTransitive_node_z.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_RightTransitive_node_z;
                                --isoSpace;
                                goto label1;
                            }
                            // Extend Outgoing RightTransitive_neg_0_edge__edge0 from RightTransitive_node_z 
                            GRGEN_LGSP.LGSPEdge head_candidate_RightTransitive_neg_0_edge__edge0 = candidate_RightTransitive_node_z.lgspOuthead;
                            if(head_candidate_RightTransitive_neg_0_edge__edge0 != null)
                            {
                                GRGEN_LGSP.LGSPEdge candidate_RightTransitive_neg_0_edge__edge0 = head_candidate_RightTransitive_neg_0_edge__edge0;
                                do
                                {
                                    if(candidate_RightTransitive_neg_0_edge__edge0.lgspType.TypeID!=7) {
                                        continue;
                                    }
                                    if(candidate_RightTransitive_neg_0_edge__edge0.lgspTarget != candidate_RightTransitive_node_x) {
                                        continue;
                                    }
                                    // negative pattern found
                                    candidate_RightTransitive_node_z.lgspFlags = candidate_RightTransitive_node_z.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_RightTransitive_node_z;
                                    --isoSpace;
                                    goto label2;
                                }
                                while( (candidate_RightTransitive_neg_0_edge__edge0 = candidate_RightTransitive_neg_0_edge__edge0.lgspOutNext) != head_candidate_RightTransitive_neg_0_edge__edge0 );
                            }
                            candidate_RightTransitive_node_z.lgspFlags = candidate_RightTransitive_node_z.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_RightTransitive_node_z;
                            --isoSpace;
                        }
label1: ;
                        Rule_RightTransitive.Match_RightTransitive match = matches.GetNextUnfilledPosition();
                        match._node_y = candidate_RightTransitive_node_y;
                        match._node_x = candidate_RightTransitive_node_x;
                        match._node_z = candidate_RightTransitive_node_z;
                        match._edge__edge0 = candidate_RightTransitive_edge__edge0;
                        match._edge__edge1 = candidate_RightTransitive_edge__edge1;
                        matches.PositionWasFilledFixIt();
                        // if enough matches were found, we leave
                        if(maxMatches > 0 && matches.Count >= maxMatches)
                        {
                            candidate_RightTransitive_node_y.MoveInHeadAfter(candidate_RightTransitive_edge__edge1);
                            graph.MoveHeadAfter(candidate_RightTransitive_edge__edge0);
                            candidate_RightTransitive_node_x.lgspFlags = candidate_RightTransitive_node_x.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_node_x;
                            candidate_RightTransitive_node_y.lgspFlags = candidate_RightTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_node_y;
                            candidate_RightTransitive_edge__edge0.lgspFlags = candidate_RightTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_edge__edge0;
                            return matches;
                        }
label2: ;
                    }
                    while( (candidate_RightTransitive_edge__edge1 = candidate_RightTransitive_edge__edge1.lgspInNext) != head_candidate_RightTransitive_edge__edge1 );
                }
                candidate_RightTransitive_node_x.lgspFlags = candidate_RightTransitive_node_x.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_node_x;
                candidate_RightTransitive_node_y.lgspFlags = candidate_RightTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_node_y;
                candidate_RightTransitive_edge__edge0.lgspFlags = candidate_RightTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_RightTransitive_edge__edge0;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_RightTransitive.IMatch_RightTransitive match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches)
        {
            foreach(Rule_RightTransitive.IMatch_RightTransitive match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_RightTransitive.IMatch_RightTransitive match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_RightTransitive.IMatch_RightTransitive)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_RightTransitive.IMatch_RightTransitive>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    
    /// <summary>
    /// An object representing an executable rule - same as IAction, but with exact types and distinct parameters.
    /// </summary>
    public interface IAction_AboveTransitive
    {
        /// <summary> same as IAction.Match, but with exact types and distinct parameters. </summary>
        GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> same as IAction.Modify, but with exact types and distinct parameters. </summary>
        void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_AboveTransitive.IMatch_AboveTransitive match);
        /// <summary> same as IAction.ModifyAll, but with exact types and distinct parameters. </summary>
        void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches);
        /// <summary> same as IAction.Apply, but with exact types and distinct parameters; returns true if applied </summary>
        bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyAll, but with exact types and distinct parameters; returns the number of matches found/applied. </summary>
        int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyStar, but with exact types and distinct parameters. </summary>
        bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyPlus, but with exact types and distinct parameters. </summary>
        bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv);
        /// <summary> same as IAction.ApplyMinMax, but with exact types and distinct parameters. </summary>
        bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max);
    }
    
    public class Action_AboveTransitive : GRGEN_LGSP.LGSPAction, GRGEN_LIBGR.IAction, IAction_AboveTransitive
    {
        public Action_AboveTransitive()
            : base(Rule_AboveTransitive.Instance.patternGraph)
        {
            _rulePattern = Rule_AboveTransitive.Instance;
            DynamicMatch = myMatch;
        }

        public Rule_AboveTransitive _rulePattern;
        public override GRGEN_LGSP.LGSPRulePattern rulePattern { get { return _rulePattern; } }
        public override string Name { get { return "AboveTransitive"; } }
        [ThreadStatic] private static GRGEN_LGSP.LGSPMatchesList<Rule_AboveTransitive.Match_AboveTransitive, Rule_AboveTransitive.IMatch_AboveTransitive> matches;

        // Performance optimization: saves us usage of new for the return array or the return arrays. In the object/string-style modify/apply methods of the action interface implementation.
        [ThreadStatic] public static object[] ReturnArray;
        [ThreadStatic] public static List<object[]> ReturnArrayListForAll;
        [ThreadStatic] public static List<object[]> AvailableReturnArrays;
        public static Action_AboveTransitive Instance { get { return instance; } set { instance = value; } }
        private static Action_AboveTransitive instance = new Action_AboveTransitive();
        
        public GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> myMatch(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches)
        {
            GRGEN_LGSP.LGSPGraph graph = actionEnv.graph;
            if(matches == null)
                matches = new GRGEN_LGSP.LGSPMatchesList<Rule_AboveTransitive.Match_AboveTransitive, Rule_AboveTransitive.IMatch_AboveTransitive>(this);
            matches.Clear();
            if(ReturnArray == null)
                ReturnArray = new object[0];
            int isoSpace = 0;
            // Lookup AboveTransitive_edge__edge0 
            int type_id_candidate_AboveTransitive_edge__edge0 = 9;
            for(GRGEN_LGSP.LGSPEdge head_candidate_AboveTransitive_edge__edge0 = graph.edgesByTypeHeads[type_id_candidate_AboveTransitive_edge__edge0], candidate_AboveTransitive_edge__edge0 = head_candidate_AboveTransitive_edge__edge0.lgspTypeNext; candidate_AboveTransitive_edge__edge0 != head_candidate_AboveTransitive_edge__edge0; candidate_AboveTransitive_edge__edge0 = candidate_AboveTransitive_edge__edge0.lgspTypeNext)
            {
                uint prev__candidate_AboveTransitive_edge__edge0;
                prev__candidate_AboveTransitive_edge__edge0 = candidate_AboveTransitive_edge__edge0.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_AboveTransitive_edge__edge0.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Source AboveTransitive_node_y from AboveTransitive_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_AboveTransitive_node_y = candidate_AboveTransitive_edge__edge0.lgspSource;
                if(!GRGEN_MODEL.NodeType_DesignNode.isMyType[candidate_AboveTransitive_node_y.lgspType.TypeID]) {
                    candidate_AboveTransitive_edge__edge0.lgspFlags = candidate_AboveTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_edge__edge0;
                    continue;
                }
                uint prev__candidate_AboveTransitive_node_y;
                prev__candidate_AboveTransitive_node_y = candidate_AboveTransitive_node_y.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_AboveTransitive_node_y.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Implicit Target AboveTransitive_node_x from AboveTransitive_edge__edge0 
                GRGEN_LGSP.LGSPNode candidate_AboveTransitive_node_x = candidate_AboveTransitive_edge__edge0.lgspTarget;
                if(!GRGEN_MODEL.NodeType_DesignNode.isMyType[candidate_AboveTransitive_node_x.lgspType.TypeID]) {
                    candidate_AboveTransitive_node_y.lgspFlags = candidate_AboveTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_node_y;
                    candidate_AboveTransitive_edge__edge0.lgspFlags = candidate_AboveTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_edge__edge0;
                    continue;
                }
                if((candidate_AboveTransitive_node_x.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                {
                    candidate_AboveTransitive_node_y.lgspFlags = candidate_AboveTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_node_y;
                    candidate_AboveTransitive_edge__edge0.lgspFlags = candidate_AboveTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_edge__edge0;
                    continue;
                }
                uint prev__candidate_AboveTransitive_node_x;
                prev__candidate_AboveTransitive_node_x = candidate_AboveTransitive_node_x.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                candidate_AboveTransitive_node_x.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                // Extend Incoming AboveTransitive_edge__edge1 from AboveTransitive_node_y 
                GRGEN_LGSP.LGSPEdge head_candidate_AboveTransitive_edge__edge1 = candidate_AboveTransitive_node_y.lgspInhead;
                if(head_candidate_AboveTransitive_edge__edge1 != null)
                {
                    GRGEN_LGSP.LGSPEdge candidate_AboveTransitive_edge__edge1 = head_candidate_AboveTransitive_edge__edge1;
                    do
                    {
                        if(candidate_AboveTransitive_edge__edge1.lgspType.TypeID!=9) {
                            continue;
                        }
                        if((candidate_AboveTransitive_edge__edge1.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            continue;
                        }
                        // Implicit Source AboveTransitive_node_z from AboveTransitive_edge__edge1 
                        GRGEN_LGSP.LGSPNode candidate_AboveTransitive_node_z = candidate_AboveTransitive_edge__edge1.lgspSource;
                        if(!GRGEN_MODEL.NodeType_DesignNode.isMyType[candidate_AboveTransitive_node_z.lgspType.TypeID]) {
                            continue;
                        }
                        if((candidate_AboveTransitive_node_z.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                        {
                            continue;
                        }
                        // NegativePattern 
                        {
                            ++isoSpace;
                            uint prev_neg_0__candidate_AboveTransitive_node_z;
                            prev_neg_0__candidate_AboveTransitive_node_z = candidate_AboveTransitive_node_z.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                            candidate_AboveTransitive_node_z.lgspFlags |= (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace;
                            if((candidate_AboveTransitive_node_x.lgspFlags & (uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) != 0)
                            {
                                candidate_AboveTransitive_node_z.lgspFlags = candidate_AboveTransitive_node_z.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_AboveTransitive_node_z;
                                --isoSpace;
                                goto label3;
                            }
                            // Extend Outgoing AboveTransitive_neg_0_edge__edge0 from AboveTransitive_node_z 
                            GRGEN_LGSP.LGSPEdge head_candidate_AboveTransitive_neg_0_edge__edge0 = candidate_AboveTransitive_node_z.lgspOuthead;
                            if(head_candidate_AboveTransitive_neg_0_edge__edge0 != null)
                            {
                                GRGEN_LGSP.LGSPEdge candidate_AboveTransitive_neg_0_edge__edge0 = head_candidate_AboveTransitive_neg_0_edge__edge0;
                                do
                                {
                                    if(candidate_AboveTransitive_neg_0_edge__edge0.lgspType.TypeID!=9) {
                                        continue;
                                    }
                                    if(candidate_AboveTransitive_neg_0_edge__edge0.lgspTarget != candidate_AboveTransitive_node_x) {
                                        continue;
                                    }
                                    // negative pattern found
                                    candidate_AboveTransitive_node_z.lgspFlags = candidate_AboveTransitive_node_z.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_AboveTransitive_node_z;
                                    --isoSpace;
                                    goto label4;
                                }
                                while( (candidate_AboveTransitive_neg_0_edge__edge0 = candidate_AboveTransitive_neg_0_edge__edge0.lgspOutNext) != head_candidate_AboveTransitive_neg_0_edge__edge0 );
                            }
                            candidate_AboveTransitive_node_z.lgspFlags = candidate_AboveTransitive_node_z.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev_neg_0__candidate_AboveTransitive_node_z;
                            --isoSpace;
                        }
label3: ;
                        Rule_AboveTransitive.Match_AboveTransitive match = matches.GetNextUnfilledPosition();
                        match._node_y = candidate_AboveTransitive_node_y;
                        match._node_x = candidate_AboveTransitive_node_x;
                        match._node_z = candidate_AboveTransitive_node_z;
                        match._edge__edge0 = candidate_AboveTransitive_edge__edge0;
                        match._edge__edge1 = candidate_AboveTransitive_edge__edge1;
                        matches.PositionWasFilledFixIt();
                        // if enough matches were found, we leave
                        if(maxMatches > 0 && matches.Count >= maxMatches)
                        {
                            candidate_AboveTransitive_node_y.MoveInHeadAfter(candidate_AboveTransitive_edge__edge1);
                            graph.MoveHeadAfter(candidate_AboveTransitive_edge__edge0);
                            candidate_AboveTransitive_node_x.lgspFlags = candidate_AboveTransitive_node_x.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_node_x;
                            candidate_AboveTransitive_node_y.lgspFlags = candidate_AboveTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_node_y;
                            candidate_AboveTransitive_edge__edge0.lgspFlags = candidate_AboveTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_edge__edge0;
                            return matches;
                        }
label4: ;
                    }
                    while( (candidate_AboveTransitive_edge__edge1 = candidate_AboveTransitive_edge__edge1.lgspInNext) != head_candidate_AboveTransitive_edge__edge1 );
                }
                candidate_AboveTransitive_node_x.lgspFlags = candidate_AboveTransitive_node_x.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_node_x;
                candidate_AboveTransitive_node_y.lgspFlags = candidate_AboveTransitive_node_y.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_node_y;
                candidate_AboveTransitive_edge__edge0.lgspFlags = candidate_AboveTransitive_edge__edge0.lgspFlags & ~((uint)GRGEN_LGSP.LGSPElemFlags.IS_MATCHED << isoSpace) | prev__candidate_AboveTransitive_edge__edge0;
            }
            return matches;
        }
        /// <summary> Type of the matcher method (with parameters processing environment containing host graph, maximum number of matches to search for (zero=unlimited), and rule parameters; returning found matches). </summary>
        public delegate GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> MatchInvoker(GRGEN_LGSP.LGSPActionExecutionEnvironment actionEnv, int maxMatches);
        /// <summary> A delegate pointing to the current matcher program for this rule. </summary>
        public MatchInvoker DynamicMatch;
        /// <summary> The RulePattern object from which this LGSPAction object has been created. </summary>
        public GRGEN_LIBGR.IRulePattern RulePattern { get { return _rulePattern; } }
        public GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches)
        {
            return DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
        }
        public void Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, Rule_AboveTransitive.IMatch_AboveTransitive match)
        {
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
        }
        public void ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches)
        {
            foreach(Rule_AboveTransitive.IMatch_AboveTransitive match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
        }
        public bool Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            return true;
        }
        public int ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, maxMatches);
            if(matches.Count <= 0) return 0;
            foreach(Rule_AboveTransitive.IMatch_AboveTransitive match in matches)
            {
                
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, match);
            }
            return matches.Count;
        }
        public bool ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches;
            
            while(true)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return true;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
        }
        public bool ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            if(matches.Count <= 0) return false;
            
            do
            {
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
            }
            while(matches.Count > 0) ;
            return true;
        }
        public bool ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive> matches;
            
            for(int i = 0; i < max; i++)
            {
                matches = DynamicMatch((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, 1);
                if(matches.Count <= 0) return i >= min;
                _rulePattern.Modify((GRGEN_LGSP.LGSPActionExecutionEnvironment)actionEnv, matches.First);
            }
            return true;
        }
        // implementation of inexact action interface by delegation to exact action interface
        public GRGEN_LIBGR.IMatches Match(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int maxMatches, object[] parameters)
        {
            return Match(actionEnv, maxMatches);
        }
        public object[] Modify(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatch match)
        {
            
            Modify(actionEnv, (Rule_AboveTransitive.IMatch_AboveTransitive)match);
            return ReturnArray;
        }
        public List<object[]> ModifyAll(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches)
        {
            ModifyAll(actionEnv, (GRGEN_LIBGR.IMatchesExact<Rule_AboveTransitive.IMatch_AboveTransitive>)matches);
            while(AvailableReturnArrays.Count < matches.Count) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matches.Count; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        object[] GRGEN_LIBGR.IAction.Apply(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            
            if(Apply(actionEnv)) {
                return ReturnArray;
            }
            else return null;
        }
        public List<object[]> Reserve(int numReturns)
        {
            if(AvailableReturnArrays == null)
                AvailableReturnArrays = new List<object[]>();
            while(AvailableReturnArrays.Count < numReturns) AvailableReturnArrays.Add(new object[0]);
            if(ReturnArrayListForAll == null)
                ReturnArrayListForAll = new List<object[]>();
            ReturnArrayListForAll.Clear();
            for(int i=0; i<numReturns; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        List<object[]> GRGEN_LIBGR.IAction.ApplyAll(int maxMatches, GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            int matchesCount = ApplyAll(maxMatches, actionEnv);
            while(AvailableReturnArrays.Count < matchesCount) AvailableReturnArrays.Add(new object[0]);
            ReturnArrayListForAll.Clear();
            for(int i=0; i<matchesCount; ++i)
            {
                ReturnArrayListForAll.Add(AvailableReturnArrays[i]);
            }
            return ReturnArrayListForAll;
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyStar(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyStar(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyPlus(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, params object[] parameters)
        {
            return ApplyPlus(actionEnv);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        bool GRGEN_LIBGR.IAction.ApplyMinMax(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, int min, int max, params object[] parameters)
        {
            return ApplyMinMax(actionEnv, min, max);
        }
        public void Filter(GRGEN_LIBGR.IActionExecutionEnvironment actionEnv, GRGEN_LIBGR.IMatches matches, GRGEN_LIBGR.FilterCallWithArguments filter)
        {
            switch(filter.PackagePrefixedName) {
                case "keepFirst": matches.Filter_keepFirst((System.Int32)(filter.Arguments[0])); break;
                case "keepLast": matches.Filter_keepLast((System.Int32)(filter.Arguments[0])); break;
                case "keepFirstFraction": matches.Filter_keepFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "keepLastFraction": matches.Filter_keepLastFraction((System.Double)(filter.Arguments[0])); break;
                case "removeFirst": matches.Filter_removeFirst((System.Int32)(filter.Arguments[0])); break;
                case "removeLast": matches.Filter_removeLast((System.Int32)(filter.Arguments[0])); break;
                case "removeFirstFraction": matches.Filter_removeFirstFraction((System.Double)(filter.Arguments[0])); break;
                case "removeLastFraction": matches.Filter_removeLastFraction((System.Double)(filter.Arguments[0])); break;
                default: throw new Exception("Unknown filter name " + filter.PackagePrefixedName + "!");
            }
        }
    }
    

    // class which instantiates and stores all the compiled actions of the module,
    // dynamic regeneration and compilation causes the old action to be overwritten by the new one
    // matching/rule patterns are analyzed at creation time here, once, so that later regeneration runs have all the information available
    public class schuppenActions : GRGEN_LGSP.LGSPActions
    {
        public schuppenActions(GRGEN_LGSP.LGSPGraph lgspgraph, string modelAsmName, string actionsAsmName)
            : base(lgspgraph, modelAsmName, actionsAsmName)
        {
            InitActions();
        }

        public schuppenActions(GRGEN_LGSP.LGSPGraph lgspgraph)
            : base(lgspgraph)
        {
            InitActions();
        }

        private void InitActions()
        {
            packages = new string[0];
            GRGEN_LGSP.PatternGraphAnalyzer analyzer = new GRGEN_LGSP.PatternGraphAnalyzer();
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_init.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_init.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_init.Instance);
            actions.Add("init", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_init.Instance);
            @init = GRGEN_ACTIONS.Action_init.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_DesignR.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_DesignR.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_DesignR.Instance);
            actions.Add("DesignR", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_DesignR.Instance);
            @DesignR = GRGEN_ACTIONS.Action_DesignR.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_MainPartR.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_MainPartR.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_MainPartR.Instance);
            actions.Add("MainPartR", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_MainPartR.Instance);
            @MainPartR = GRGEN_ACTIONS.Action_MainPartR.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_MiddleR.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_MiddleR.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_MiddleR.Instance);
            actions.Add("MiddleR", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_MiddleR.Instance);
            @MiddleR = GRGEN_ACTIONS.Action_MiddleR.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_InfillR.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_InfillR.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_InfillR.Instance);
            actions.Add("InfillR", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_InfillR.Instance);
            @InfillR = GRGEN_ACTIONS.Action_InfillR.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_WallR_front.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_WallR_front.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_WallR_front.Instance);
            actions.Add("WallR_front", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_WallR_front.Instance);
            @WallR_front = GRGEN_ACTIONS.Action_WallR_front.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_WallR_default.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_WallR_default.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_WallR_default.Instance);
            actions.Add("WallR_default", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_WallR_default.Instance);
            @WallR_default = GRGEN_ACTIONS.Action_WallR_default.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_RightTransitive.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_RightTransitive.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_RightTransitive.Instance);
            actions.Add("RightTransitive", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_RightTransitive.Instance);
            @RightTransitive = GRGEN_ACTIONS.Action_RightTransitive.Instance;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_AboveTransitive.Instance.patternGraph, false);
            GRGEN_LGSP.PatternGraphAnalyzer.PrepareInline(GRGEN_ACTIONS.Rule_AboveTransitive.Instance.patternGraph);
            analyzer.RememberMatchingPattern(GRGEN_ACTIONS.Rule_AboveTransitive.Instance);
            actions.Add("AboveTransitive", (GRGEN_LGSP.LGSPAction) GRGEN_ACTIONS.Action_AboveTransitive.Instance);
            @AboveTransitive = GRGEN_ACTIONS.Action_AboveTransitive.Instance;
            analyzer.ComputeInterPatternRelations(false);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_init.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_DesignR.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_MainPartR.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_MiddleR.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_InfillR.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_WallR_front.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_WallR_default.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_RightTransitive.Instance.patternGraph);
            analyzer.AnalyzeWithInterPatternRelationsKnown(GRGEN_ACTIONS.Rule_AboveTransitive.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_init.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_DesignR.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_MainPartR.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_MiddleR.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_InfillR.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_WallR_front.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_WallR_default.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_RightTransitive.Instance.patternGraph);
            analyzer.InlineSubpatternUsages(GRGEN_ACTIONS.Rule_AboveTransitive.Instance.patternGraph);
            GRGEN_ACTIONS.Rule_init.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_DesignR.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_MainPartR.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_MiddleR.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_InfillR.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_WallR_front.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_WallR_default.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_RightTransitive.Instance.patternGraph.maxIsoSpace = 0;
            GRGEN_ACTIONS.Rule_AboveTransitive.Instance.patternGraph.maxIsoSpace = 0;
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_init.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_DesignR.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_MainPartR.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_MiddleR.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_InfillR.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_WallR_front.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_WallR_default.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_RightTransitive.Instance.patternGraph, true);
            analyzer.AnalyzeNestingOfPatternGraph(GRGEN_ACTIONS.Rule_AboveTransitive.Instance.patternGraph, true);
            analyzer.ComputeInterPatternRelations(true);
        }
        
        public GRGEN_ACTIONS.IAction_init @init;
        public GRGEN_ACTIONS.IAction_DesignR @DesignR;
        public GRGEN_ACTIONS.IAction_MainPartR @MainPartR;
        public GRGEN_ACTIONS.IAction_MiddleR @MiddleR;
        public GRGEN_ACTIONS.IAction_InfillR @InfillR;
        public GRGEN_ACTIONS.IAction_WallR_front @WallR_front;
        public GRGEN_ACTIONS.IAction_WallR_default @WallR_default;
        public GRGEN_ACTIONS.IAction_RightTransitive @RightTransitive;
        public GRGEN_ACTIONS.IAction_AboveTransitive @AboveTransitive;
        
        
        public override string[] Packages { get { return packages; } }
        private string[] packages;
        
        public override string Name { get { return "schuppenActions"; } }
        public override string StatisticsPath { get { return null; } }
        public override bool LazyNIC { get { return false; } }
        public override bool InlineIndependents { get { return true; } }
        public override bool Profile { get { return false; } }

        public override IList ArrayOrderAscendingBy(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "DesignR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "InfillR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override IList ArrayOrderDescendingBy(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "DesignR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "InfillR":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override IList ArrayGroupBy(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "DesignR":
                    switch(member)
                    {
                    case "d":
                        return ArrayHelper.Array_DesignR_groupBy_d(GRGEN_ACTIONS.Rule_DesignR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MainPartR_groupBy_m(GRGEN_ACTIONS.Rule_MainPartR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MiddleR_groupBy_m(GRGEN_ACTIONS.Rule_MiddleR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "InfillR":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_InfillR_groupBy_i(GRGEN_ACTIONS.Rule_InfillR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_WallR_front_groupBy_i(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array));
                    case "w":
                        return ArrayHelper.Array_WallR_front_groupBy_w(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_WallR_front_groupBy__edge0(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    case "w":
                        return ArrayHelper.Array_WallR_default_groupBy_w(GRGEN_ACTIONS.Rule_WallR_default.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_RightTransitive_groupBy_y(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "x":
                        return ArrayHelper.Array_RightTransitive_groupBy_x(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "z":
                        return ArrayHelper.Array_RightTransitive_groupBy_z(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_RightTransitive_groupBy__edge0(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_RightTransitive_groupBy__edge1(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_AboveTransitive_groupBy_y(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "x":
                        return ArrayHelper.Array_AboveTransitive_groupBy_x(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "z":
                        return ArrayHelper.Array_AboveTransitive_groupBy_z(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_AboveTransitive_groupBy__edge0(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_AboveTransitive_groupBy__edge1(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override IList ArrayKeepOneForEach(IList array, string member)
        {
            if(array.Count == 0)
                return array;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return null;
            if(array[0] == null)
                return null;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return null;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return null;
                    }
                case "DesignR":
                    switch(member)
                    {
                    case "d":
                        return ArrayHelper.Array_DesignR_keepOneForEachBy_d(GRGEN_ACTIONS.Rule_DesignR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MainPartR_keepOneForEachBy_m(GRGEN_ACTIONS.Rule_MainPartR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MiddleR_keepOneForEachBy_m(GRGEN_ACTIONS.Rule_MiddleR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "InfillR":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_InfillR_keepOneForEachBy_i(GRGEN_ACTIONS.Rule_InfillR.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_WallR_front_keepOneForEachBy_i(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array));
                    case "w":
                        return ArrayHelper.Array_WallR_front_keepOneForEachBy_w(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_WallR_front_keepOneForEachBy__edge0(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    case "w":
                        return ArrayHelper.Array_WallR_default_keepOneForEachBy_w(GRGEN_ACTIONS.Rule_WallR_default.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_RightTransitive_keepOneForEachBy_y(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "x":
                        return ArrayHelper.Array_RightTransitive_keepOneForEachBy_x(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "z":
                        return ArrayHelper.Array_RightTransitive_keepOneForEachBy_z(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_RightTransitive_keepOneForEachBy__edge0(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_RightTransitive_keepOneForEachBy__edge1(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_AboveTransitive_keepOneForEachBy_y(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "x":
                        return ArrayHelper.Array_AboveTransitive_keepOneForEachBy_x(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "z":
                        return ArrayHelper.Array_AboveTransitive_keepOneForEachBy_z(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "_edge0":
                        return ArrayHelper.Array_AboveTransitive_keepOneForEachBy__edge0(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    case "_edge1":
                        return ArrayHelper.Array_AboveTransitive_keepOneForEachBy__edge1(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array));
                    default:
                        return null;
                    }
                default:
                    return null;
                }
            }
        }

        public override int ArrayIndexOfBy(IList array, string member, object value)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "DesignR":
                    switch(member)
                    {
                    case "d":
                        return ArrayHelper.Array_DesignR_indexOfBy_d(GRGEN_ACTIONS.Rule_DesignR.ConvertAsNeeded(array), (GRGEN_MODEL.IDesign)value);
                    default:
                        return -1;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MainPartR_indexOfBy_m(GRGEN_ACTIONS.Rule_MainPartR.ConvertAsNeeded(array), (GRGEN_MODEL.IMainPart)value);
                    default:
                        return -1;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MiddleR_indexOfBy_m(GRGEN_ACTIONS.Rule_MiddleR.ConvertAsNeeded(array), (GRGEN_MODEL.IMiddle)value);
                    default:
                        return -1;
                    }
                case "InfillR":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_InfillR_indexOfBy_i(GRGEN_ACTIONS.Rule_InfillR.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value);
                    default:
                        return -1;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_WallR_front_indexOfBy_i(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value);
                    case "w":
                        return ArrayHelper.Array_WallR_front_indexOfBy_w(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value);
                    case "_edge0":
                        return ArrayHelper.Array_WallR_front_indexOfBy__edge0(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.Icontains)value);
                    default:
                        return -1;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    case "w":
                        return ArrayHelper.Array_WallR_default_indexOfBy_w(GRGEN_ACTIONS.Rule_WallR_default.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value);
                    default:
                        return -1;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_RightTransitive_indexOfBy_y(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "x":
                        return ArrayHelper.Array_RightTransitive_indexOfBy_x(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "z":
                        return ArrayHelper.Array_RightTransitive_indexOfBy_z(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_RightTransitive_indexOfBy__edge0(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value);
                    case "_edge1":
                        return ArrayHelper.Array_RightTransitive_indexOfBy__edge1(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value);
                    default:
                        return -1;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy_y(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "x":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy_x(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "z":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy_z(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy__edge0(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value);
                    case "_edge1":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy__edge1(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayIndexOfBy(IList array, string member, object value, int startIndex)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "DesignR":
                    switch(member)
                    {
                    case "d":
                        return ArrayHelper.Array_DesignR_indexOfBy_d(GRGEN_ACTIONS.Rule_DesignR.ConvertAsNeeded(array), (GRGEN_MODEL.IDesign)value, startIndex);
                    default:
                        return -1;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MainPartR_indexOfBy_m(GRGEN_ACTIONS.Rule_MainPartR.ConvertAsNeeded(array), (GRGEN_MODEL.IMainPart)value, startIndex);
                    default:
                        return -1;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MiddleR_indexOfBy_m(GRGEN_ACTIONS.Rule_MiddleR.ConvertAsNeeded(array), (GRGEN_MODEL.IMiddle)value, startIndex);
                    default:
                        return -1;
                    }
                case "InfillR":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_InfillR_indexOfBy_i(GRGEN_ACTIONS.Rule_InfillR.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value, startIndex);
                    default:
                        return -1;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_WallR_front_indexOfBy_i(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value, startIndex);
                    case "w":
                        return ArrayHelper.Array_WallR_front_indexOfBy_w(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_WallR_front_indexOfBy__edge0(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.Icontains)value, startIndex);
                    default:
                        return -1;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    case "w":
                        return ArrayHelper.Array_WallR_default_indexOfBy_w(GRGEN_ACTIONS.Rule_WallR_default.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value, startIndex);
                    default:
                        return -1;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_RightTransitive_indexOfBy_y(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "x":
                        return ArrayHelper.Array_RightTransitive_indexOfBy_x(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "z":
                        return ArrayHelper.Array_RightTransitive_indexOfBy_z(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_RightTransitive_indexOfBy__edge0(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_RightTransitive_indexOfBy__edge1(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value, startIndex);
                    default:
                        return -1;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy_y(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "x":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy_x(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "z":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy_z(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy__edge0(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_AboveTransitive_indexOfBy__edge1(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value, startIndex);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayLastIndexOfBy(IList array, string member, object value)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "DesignR":
                    switch(member)
                    {
                    case "d":
                        return ArrayHelper.Array_DesignR_lastIndexOfBy_d(GRGEN_ACTIONS.Rule_DesignR.ConvertAsNeeded(array), (GRGEN_MODEL.IDesign)value);
                    default:
                        return -1;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MainPartR_lastIndexOfBy_m(GRGEN_ACTIONS.Rule_MainPartR.ConvertAsNeeded(array), (GRGEN_MODEL.IMainPart)value);
                    default:
                        return -1;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MiddleR_lastIndexOfBy_m(GRGEN_ACTIONS.Rule_MiddleR.ConvertAsNeeded(array), (GRGEN_MODEL.IMiddle)value);
                    default:
                        return -1;
                    }
                case "InfillR":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_InfillR_lastIndexOfBy_i(GRGEN_ACTIONS.Rule_InfillR.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value);
                    default:
                        return -1;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_WallR_front_lastIndexOfBy_i(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value);
                    case "w":
                        return ArrayHelper.Array_WallR_front_lastIndexOfBy_w(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value);
                    case "_edge0":
                        return ArrayHelper.Array_WallR_front_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.Icontains)value);
                    default:
                        return -1;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    case "w":
                        return ArrayHelper.Array_WallR_default_lastIndexOfBy_w(GRGEN_ACTIONS.Rule_WallR_default.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value);
                    default:
                        return -1;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy_y(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "x":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy_x(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "z":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy_z(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value);
                    case "_edge1":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value);
                    default:
                        return -1;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy_y(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "x":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy_x(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "z":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy_z(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value);
                    case "_edge0":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value);
                    case "_edge1":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayLastIndexOfBy(IList array, string member, object value, int startIndex)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "DesignR":
                    switch(member)
                    {
                    case "d":
                        return ArrayHelper.Array_DesignR_lastIndexOfBy_d(GRGEN_ACTIONS.Rule_DesignR.ConvertAsNeeded(array), (GRGEN_MODEL.IDesign)value, startIndex);
                    default:
                        return -1;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MainPartR_lastIndexOfBy_m(GRGEN_ACTIONS.Rule_MainPartR.ConvertAsNeeded(array), (GRGEN_MODEL.IMainPart)value, startIndex);
                    default:
                        return -1;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    case "m":
                        return ArrayHelper.Array_MiddleR_lastIndexOfBy_m(GRGEN_ACTIONS.Rule_MiddleR.ConvertAsNeeded(array), (GRGEN_MODEL.IMiddle)value, startIndex);
                    default:
                        return -1;
                    }
                case "InfillR":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_InfillR_lastIndexOfBy_i(GRGEN_ACTIONS.Rule_InfillR.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value, startIndex);
                    default:
                        return -1;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    case "i":
                        return ArrayHelper.Array_WallR_front_lastIndexOfBy_i(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IInfill)value, startIndex);
                    case "w":
                        return ArrayHelper.Array_WallR_front_lastIndexOfBy_w(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_WallR_front_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_WallR_front.ConvertAsNeeded(array), (GRGEN_MODEL.Icontains)value, startIndex);
                    default:
                        return -1;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    case "w":
                        return ArrayHelper.Array_WallR_default_lastIndexOfBy_w(GRGEN_ACTIONS.Rule_WallR_default.ConvertAsNeeded(array), (GRGEN_MODEL.IWall)value, startIndex);
                    default:
                        return -1;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy_y(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "x":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy_x(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "z":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy_z(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_RightTransitive_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_RightTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iright)value, startIndex);
                    default:
                        return -1;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    case "y":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy_y(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "x":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy_x(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "z":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy_z(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.IDesignNode)value, startIndex);
                    case "_edge0":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy__edge0(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value, startIndex);
                    case "_edge1":
                        return ArrayHelper.Array_AboveTransitive_lastIndexOfBy__edge1(GRGEN_ACTIONS.Rule_AboveTransitive.ConvertAsNeeded(array), (GRGEN_MODEL.Iabove)value, startIndex);
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }

        public override int ArrayIndexOfOrderedBy(IList array, string member, object value)
        {
            if(array.Count == 0)
                return -1;
            string arrayType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array.GetType());
            string arrayValueType = GRGEN_LIBGR.TypesHelper.ExtractSrc(arrayType);
            if(!arrayValueType.StartsWith("match<"))
                return -1;
            if(array[0] == null)
                return -1;
            if(arrayValueType == "match<>")
                arrayValueType = GRGEN_LIBGR.TypesHelper.DotNetTypeToXgrsType(array[0].GetType());
            if(arrayValueType.StartsWith("match<class "))
            {
                switch(arrayValueType.Substring(12, arrayValueType.Length - 12 - 1))
                {
                default:
                    return -1;
                }
            }
            else
            {
                switch(arrayValueType.Substring(6, arrayValueType.Length - 6 - 1))
                {
                case "init":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "DesignR":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "MainPartR":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "MiddleR":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "InfillR":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "WallR_front":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "WallR_default":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "RightTransitive":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                case "AboveTransitive":
                    switch(member)
                    {
                    default:
                        return -1;
                    }
                default:
                    return -1;
                }
            }
        }
        public override void FailAssertion() { Debug.Assert(false); }
        public override string ModelMD5Hash { get { return "cd6f19a43cc6d3c0af2936c8cdb3716b"; } }
    }
}