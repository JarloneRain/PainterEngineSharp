using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Opject;


public delegate void OpjectUpdateHandler(Opject that, int idesc, uint elapsed);



public enum OpjectAlignEnum
{
    LeftBottom=1,MidBottom=2,RightBottom=3,
    LeftMid=4,MidMid=5,RightMid=6,
    LeftTop=7,MidTop=8,RightTop=9,
    Center=5
}

/// <summary>
/// Opject is PX_Object in PainterEngine
/// </summary>
/// 
public class Opject
{
    public required string Id { get; set; }

    public float X {  get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float Vx {  get; set; }
    public float Vy { get; set; }
    public float Vz { get; set; }
    public float Fx {  get; set; }
    public float Fy {  get; set; }
    public float Fz { get; set; }
    public float Ak {  get; set; }


    public float Width {  get; set; }
    public float Height { get; set; }
    public float Length {  get; set; }

    public OpjectAlignEnum AlignEnum { get; set; }

    public float Diameter {  get; set; }

    public bool OnFocus {  get; set; }
    public bool OnFocusNode {  get; set; }
    public bool OnLostFocusReleaseEvent { get; set; }
    public bool Enabled { get; set; }
    public bool Visible { get; set; }
    public bool ReceiveEvents { get; set; }
    public bool DelayDelete { get; set; }

    public int MapIndex {  get; set; }

    //public uint ImpactObjectType;
    //public uint ImpactTargetType;


    public Opject? Parent { get; set; } = null;
    public List<Opject> Children { get; set; } = [];
    public bool IsEnable { get; set; }
    public bool IsDelayDelete { get; set; }

    public event OpjectUpdateHandler OnUpdate = (_, _, _) => { };

    public void Update(uint elapsed)
    {
        if(!IsEnable) return;
        // update event

    }

    public Rectangle AbsoluteRectangle
    {
        get => new()
        {
            XY = InheritXY+new Point2D { X=X,Y=Y},
            Width = Width,
            Height = Height
        };
    }

    public Rectangle Rect
    {
        get
        {
            Rectangle r = AbsoluteRectangle;
            return AlignEnum switch
            {
                OpjectAlignEnum.LeftBottom => new Rectangle
                {
                    X = r.X,
                    Y = r.Y - r.Height,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.MidBottom => new Rectangle
                {
                    X = r.X - r.Width / 2,
                    Y = r.Y - r.Height,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.RightBottom => new Rectangle
                {
                    X = r.X - r.Width,
                    Y = r.Y - r.Height,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.LeftMid => new Rectangle
                {
                    X = r.X,
                    Y = r.Y - r.Height / 2,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.MidMid => new Rectangle
                {
                    X = r.X - r.Width / 2,
                    Y = r.Y - r.Height / 2,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.RightMid => new Rectangle
                {
                    X = r.X - r.Width,
                    Y = r.Y - r.Height / 2,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.LeftTop => new Rectangle
                {
                    X = r.X,
                    Y = r.Y,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.MidTop => new Rectangle
                {
                    X = r.X - r.Width / 2,
                    Y = r.Y,
                    Width = r.Width,
                    Height = r.Height,
                },
                OpjectAlignEnum.RightTop => new Rectangle
                {
                    X = r.X - r.Width,
                    Y = r.Y,
                    Width = r.Width,
                    Height = r.Height,
                },
                _ =>throw new ArgumentOutOfRangeException(nameof(AlignEnum), AlignEnum, "Invalid OpjectAlignEnum value.")
            };
        }
    }

    public Point2D InheritXY { get
        {
            Point2D res=new();
            var p = Parent;
            while(p != null) {
                res.X += p.X;
                res.Y += p.Y;
            }
            return res;
        } }

}

