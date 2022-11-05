using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GrGenWrapper.ObjectModel;
using GrGenWrapper.ObjectModel.GraphModels;
using GrGenWrapper.ObjectModel.RuleSets;

namespace GrGen_Wrapper_UnitTests
{
    [TestClass]
    public class SerializationUnitTest
    {
        [TestMethod]
        public void TestFileWrites()
        {
            string designModelName = "designModel";
            string schuppenModelName = "schuppenModel";
            string schuppenRuleSetName = "schuppenRules";
            GraphModel designGraphModel = new GraphModel(designModelName, new List<Snippet>());
            GraphModel schuppenGraphModel = new GraphModel(schuppenModelName, new List<Snippet>());
            RuleSet schuppenRuleSet = new RuleSet(schuppenRuleSetName, snippets: new List<Snippet>());

            CompileSet compileSet = new CompileSet(new List<GraphModel>() { designGraphModel, schuppenGraphModel }, schuppenRuleSet);
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Split('.').First());
            Directory.CreateDirectory(tempDirectory);
            compileSet.Write(tempDirectory);
            Assert.AreEqual(Directory.GetFiles(tempDirectory), new[]{ designModelName + ".gm", schuppenModelName + ".gm", schuppenRuleSetName +".grg" });
            Directory.Delete(tempDirectory, true);
        }

        [TestMethod] 
        public void TestFiles()
        {
            GraphModel designGraphModel = new GraphModel("design", new List<Snippet>()
                {
                    new Snippet(
@"class QuasiPlane {
    xyRotation:double;
    xzRotation:double;
    yzRotation:double;
}

abstract node class DesignNode {
    isAlignmentNode: boolean;
    filled: boolean;
}

edge class contains;
undirected edge class connected;
abstract edge class next;
abstract edge class locatedNext extends next;
edge class right extends locatedNext;
edge class infront extends locatedNext;
edge class above extends locatedNext;")
                });
            GraphModel schuppenGraphModel = new GraphModel("schuppen", new List<Snippet>()
                {
                    new Snippet(
@"enum Size {TALL,SMALL}
enum Overhang { BOTH, INSIDE, OUTSIDE }
enum Filling { BOX, WINDOW }

node class Design extends DesignNode;

node class Roof extends DesignNode;
node class MainPart extends DesignNode;
node class Base extends DesignNode;

node class RingBar extends DesignNode;
node class Middle extends DesignNode;

node class Post extends DesignNode;
node class Infill extends DesignNode;
node class Door extends DesignNode;

node class Wall extends DesignNode;
node class WallFrame extends DesignNode;

node class Module extends DesignNode;
node class FrameModule extends Module
{
    size: Size;
    overhang: Overhang;
    filling: Filling;
}
node class LModule extends Module;")
                });
            RuleSet schuppenRuleSet = new RuleSet("schuppen", snippets: new List<Snippet>()
                {
                    new Snippet(
"#using \"designGraph.gm \"" +
"#using \"schuppen.gm\"" +
@"
rule init {
    modify{
        d:Design;
        }
    }

    rule DesignR
    {
        d:Design;
    if{ d.filled == false; }
        modify
        {
            d -:contains->r:Roof;
            d -:contains->m:MainPart;
            d -:contains->b:Base;

            r -:connected - m -:connected - b;

            r -:above->m -:above->b;

            eval {
                b.isAlignmentNode = true;
                d.filled = true;
            }
        }
    }

    rule MainPartR
    {
        m:MainPart;
    if{ m.filled == false; }
        modify
        {
            m -:contains->r_u:RingBar;
            m -:contains->mi:Middle;
            m -:contains->r_d:RingBar;

            r_u -:connected - mi -:connected - r_d;

            r_d < -:above - mi < -:above - r_u;

            eval {
                r_d.isAlignmentNode = true;
                m.filled = true;
            }
        }
    }

    rule MiddleR
    {
        m:Middle;
    if{ m.filled == false; }
        modify
        {
            m -:contains->d:Door;

            m -:contains->i_f_r:Infill;
            m -:contains->i_f_l:Infill;
            m -:contains->i_l:Infill;
            m -:contains->i_r:Infill;
            m -:contains->i_b:Infill;

            m -:contains->p_f_r:Post;
            m -:contains->p_f_r_l:Post;
            m -:contains->p_f_l:Post;
            m -:contains->p_f_l_r:Post;
            m -:contains->p_b_r:Post;
            m -:contains->p_b_l:Post;

            p_f_l -:connected - p_f_l_r -:connected - d -:connected - p_f_r_l -:connected - p_f_r;
            p_f_l < -:right - i_l -:connected - p_b_l < -:right - i_b < -:right - p_b_r < -:right - i_r < -:right - p_f_r;

            p_f_l -:connected - i_l -:connected - p_b_l -:connected - i_b -:connected - p_b_r -:connected - i_r -:connected - p_f_r;
            p_f_l -:infront->i_l -:infront->p_b_l < -:right - i_b < -:right - p_b_r < -:infront - i_r < -:infront - p_f_r;

            p_f_l < -:right - i_b < -:right - p_f_r;

            eval {
                p_f_l.isAlignmentNode = true;
                m.filled = true;
            }
        }
    }

    rule InfillR
    {
        i:Infill;
    if{ i.filled == false; }
        modify
        {
        wf: WallFrame < -:contains - i -:contains->w:Wall;
            w -:connected - wf;
            w -:infront->wf;
            eval{
                i.filled = true;
            }
        }
    }

    rule WallR_front
    {
        i:Infill -:contains-> w:Wall;
    if{ w.filled == false; }
        negative { i < -:infront - .; }
        modify
        {
        fm_b: FrameModule < -:contains - w -:contains->fm_t:FrameModule;
        fm_t_b: FrameModule < -:contains - w -:contains->fm_b_t:FrameModule;

            fm_b -:connected - fm_b_t -:connected - fm_t_b -:connected - fm_t;
            fm_b < -:above - fm_b_t < -:above - fm_t_b < -:above - fm_t;

            eval{
                w.filled = true;

                fm_b.size = Size::SMALL;
                fm_b_t.size = Size::SMALL;
                fm_t.size = Size::SMALL;
                fm_t_b.size = Size::SMALL;

                fm_b.overhang = Overhang::OUTSIDE;
                fm_b_t.overhang = Overhang::OUTSIDE;
                fm_t.overhang = Overhang::OUTSIDE;
                fm_t_b.overhang = Overhang::OUTSIDE;

                fm_b.filling = Filling::BOX;
                fm_b_t.filling = Filling::WINDOW;
                fm_t.filling = Filling::BOX;
                fm_t_b.filling = Filling::WINDOW;

            }
        }
    }


    rule WallR_default
    {
        w:Wall;
    if{ w.filled == false; }
        modify
        {
        lm_b_r: LModule < -:contains - w -:contains->lm_b_l:LModule;
        lm_t_r: LModule < -:contains - w -:contains->lm_t_l:LModule;
        fm_b_r: FrameModule < -:contains - w -:contains->fm_b_l:FrameModule;
        fm_t_r: FrameModule < -:contains - w -:contains->fm_t_l:FrameModule;

            lm_b_l -:connected - lm_b_r -:connected - lm_t_r -:connected - lm_t_l -:connected - lm_b_l;
            lm_b_l < -:right - lm_b_r < -:above - lm_t_r -:right->lm_t_l -:above->lm_b_l;
            fm_b_l -:connected - fm_b_r -:connected - fm_t_r -:connected - fm_t_l -:connected - fm_b_l;
            fm_b_l < -:right - fm_b_r < -:above - fm_t_r -:right->fm_t_l -:above->fm_b_l;

            lm_b_l -:connected - fm_b_l;
            lm_b_l < -:right - fm_b_l -:above->lm_b_l;
            lm_b_r -:connected - fm_b_r;
            lm_b_r -:right->fm_b_r -:above->lm_b_r;

            lm_t_l -:connected - fm_t_r;
            lm_t_l -:right->fm_t_r < -:above - lm_t_l;
            lm_t_r -:connected - fm_t_r;
            lm_t_r -:right->fm_t_r < -:above - lm_t_r;

            eval {
                w.filled = true;
                fm_b_l.size = Size::TALL;
                fm_b_r.size = Size::TALL;
                fm_t_l.size = Size::TALL;
                fm_t_r.size = Size::TALL;

                fm_b_l.overhang = Overhang::BOTH;
                fm_b_r.overhang = Overhang::BOTH;
                fm_t_l.overhang = Overhang::BOTH;
                fm_t_r.overhang = Overhang::BOTH;

                fm_b_l.filling = Filling::BOX;
                fm_b_r.filling = Filling::BOX;
                fm_t_l.filling = Filling::BOX;
                fm_t_r.filling = Filling::BOX;

            }
        }
    }

    rule RightTransitive
    {
        x:DesignNode <-:right- y:DesignNode <-:right- z:DesignNode;
        negative
        {
            x < -:right - z;
        }
        modify
        {
            x < -:right - z;
        }
    }

    rule AboveTransitive
    {
        x:DesignNode <-:above- y:DesignNode <-:above- z:DesignNode;
        negative
        {
            x < -:above - z;
        }
        modify
        {
            x < -:above - z;
        }
    }
")
                });

            CompileSet compileSet = new CompileSet(new List<GraphModel>() { designGraphModel, schuppenGraphModel }, schuppenRuleSet);
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Split('.').First());
            Directory.CreateDirectory(tempDirectory);
            compileSet.Write(tempDirectory);
            Assert.Equals(Directory.GetFiles(tempDirectory), new[] { "design.gm", "schuppen.gm", "schuppen.grs" });
            Directory.Delete(tempDirectory, true);
        }
}
}
