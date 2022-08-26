using System.Dynamic;
using System.Numerics;
using Microsoft.VisualBasic;

namespace DDF.Core
{
    public class Project
    {
        public Project(string id, IEnumerable<Decision> decisions)
        {
            Id = id;
            Decisions = decisions;
        }

        public string Id { get; }
        public IEnumerable<Decision> Decisions { get; }
    }

    //public class ProjectDirector
    //{
    //    private DecisionBuilder decisionBuilder;
    //}

    //public interface DecisionBuilder
    //{
    //    Decision BuildDecision();
    //}

    public class Decision
    {
        public Decision(Design context, Design modification, IEnumerable<Decision> requiredDecisions, string name = "")
        {
            Context = context;
            Modification = modification;
            RequiredDecisions = requiredDecisions;
            Name = name;
        }

        public string Name { get; }
        public Design Context { get; }
        public Design Modification { get; }
        public IEnumerable<Decision> RequiredDecisions { get; }

    }


    public class Design
    {
        public Design(IEnumerable<Thing> things, IEnumerable<View> views, IEnumerable<Representation> representations)
        {
            Things = things;
            Views = views;
            Representations = representations;
        }

        public IEnumerable<Thing> Things { get; }
        public IEnumerable<View> Views { get; }
        public IEnumerable<Representation> Representations { get; }
    }
    public class Thing
    {
        public Thing(string type, Orientation? orientation = null, List<string>? concepts = null)
        {
            Type = type;
            Orientation = orientation ?? new Orientation();
            Concepts = concepts ?? new List<string>();

        }
        public string Type { get; }
        public Orientation? Orientation { get; }
        public List<string>? Concepts;
    }

    public class Orientation
    {
        public Orientation(float xRotation = 0, float yRotation = 0, float zRotation = 0)
        {
            this.xRotation = xRotation;
            this.yRotation = yRotation;
            this.zRotation = zRotation;
        }

        public float xRotation;
        public float yRotation;
        public float zRotation;


        /// <summary>
        /// Get a rotated plane from x,y,z rotations.
        /// </summary>
        /// <param name="xRot">Rotation around the x-axis in degree.</param>
        /// <param name="yRot">Rotation around the y-axis in degree.</param>
        /// <param name="zRot">Rotation around the z-axis in degree.</param>
        /// <returns>A plane with unit vectors</returns>
        static Plane GetPlane(float xRot, float yRot, float zRot) =>
            Plane.Transform(
                //Unit plane
                Plane.CreateFromVertices(
                    new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1)),
                //Rotation quaternion
                Quaternion.CreateFromYawPitchRoll(
                    DegToRad(xRot), DegToRad(yRot), DegToRad(zRot)));
        
        /// <summary>
        /// Convert degree angle to radiant angle
        /// </summary>
        /// <param name="a">angle in degree</param>
        /// <returns></returns>
        public static float DegToRad(float a) => (float)((Math.PI / 180) * a);
    }

    

    public abstract class View
    {
        protected View(IEnumerable<Relation> relations)
        {
            Relations = relations;
        }

        public static string[] Types { get; }
        public IEnumerable<Relation> Relations { get; }
    }

    public class PositionalView : View
    {
        public static string[] Types = { "right", "above", "behind", "xAligned", "yAligned", "zAligned" };

        public PositionalView(IEnumerable<Relation> relations) : base(relations)
        {
        }
    }

    public class MorphologicalView: View
    {
        public static string[] Types = { "touches","contains" };
        public MorphologicalView(IEnumerable<Relation> relations) : base(relations)
        {
        }
    }

    public class CompositionalView: View
    {
        public static string[] Types = { "partOf" };

        public CompositionalView(IEnumerable<Relation> relations) : base(relations)
        {
        }
    }

    public class Relation
    {
        public Relation(Thing someThing, string type, Thing anotherThing)
        {
            Type = type;
            SomeThing = someThing;
            AnotherThing = anotherThing;
        }

        public string Type { get; }
        public Thing SomeThing { get; }
        public Thing AnotherThing { get; }
    }

    public class Representation
    {
        public string Id { get; }
        public string Type { get; }
    }

    

}