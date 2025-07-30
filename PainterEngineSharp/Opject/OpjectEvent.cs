using PainterEngineSharp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Opject;

public enum OpjectEventEnum
{
    Any = 0,
    CursorMove = 1,
    CursorUp = 2,
    CursorRDown = 3,
    CursorDown = 4,
    CursorRUp = 5,
    CursorOver = 6,
    CursorOut = 7,
    CursorWheel = 8,
    CursorClick = 9,
    CursorDrag = 10,
    String = 11,
    Execute = 12,
    ValueChanged = 13,
    DragFile = 14,
    KeyDown = 15,
    KeyUp = 16,
    Impact = 17,
    Scale = 18,
    WindowResize = 19,
    OnFocus = 20,
    LostFocus = 21,
    Cancel = 22,
    Close = 23,
    CursorMUp = 24,
    CursorMDown = 25,
    RequestData = 26,
    Open = 27,
    Save = 28,
    Timeout = 29,
    Damage = 30,
    Reset = 31,
    Activating = 32,
    Update = 33,
}

static class OpjectEventEnumTools
{
    public static bool IsCursorEvent(this OpjectEventEnum e) => e switch
    {
        OpjectEventEnum.CursorMove or
        OpjectEventEnum.CursorUp or
        OpjectEventEnum.CursorRDown or
        OpjectEventEnum.CursorDown or
        OpjectEventEnum.CursorRUp or
        OpjectEventEnum.CursorOver or
        OpjectEventEnum.CursorOut or
        OpjectEventEnum.CursorWheel or
        OpjectEventEnum.CursorClick or
        OpjectEventEnum.CursorDrag => true,
        _ => false
    };
}

public struct OpjectEvent
{
    public OpjectEventEnum EventEnum { get; set; }

    [StructLayout(LayoutKind.Explicit)]
    public struct EventData
    {
        #region char[16]
        [StructLayout(LayoutKind.Explicit)]
        public struct ParamChar
        {
            [FieldOffset(0)] char paramChar0;
            [FieldOffset(1)] char paramChar1;
            [FieldOffset(2)] char paramChar2;
            [FieldOffset(3)] char paramChar3;
            [FieldOffset(4)] char paramChar4;
            [FieldOffset(5)] char paramChar5;
            [FieldOffset(6)] char paramChar6;
            [FieldOffset(7)] char paramChar7;
            [FieldOffset(8)] char paramChar8;
            [FieldOffset(9)] char paramChar9;
            [FieldOffset(10)] char paramChar10;
            [FieldOffset(11)] char paramChar11;
            [FieldOffset(12)] char paramChar12;
            [FieldOffset(13)] char paramChar13;
            [FieldOffset(14)] char paramChar14;
            [FieldOffset(15)] char paramChar15;

            public char this[int index]
            {
                readonly get => index switch
                {
                    0 => paramChar0,
                    1 => paramChar1,
                    2 => paramChar2,
                    3 => paramChar3,
                    4 => paramChar4,
                    5 => paramChar5,
                    6 => paramChar6,
                    7 => paramChar7,
                    8 => paramChar8,
                    9 => paramChar9,
                    10 => paramChar10,
                    11 => paramChar11,
                    12 => paramChar12,
                    13 => paramChar13,
                    14 => paramChar14,
                    15 => paramChar15,
                    _ => throw new ArgumentOutOfRangeException(nameof(index)),
                };
                set
                {
                    switch(index)
                    {
                        case 0: paramChar0 = value; break;
                        case 1: paramChar1 = value; break;
                        case 2: paramChar2 = value; break;
                        case 3: paramChar3 = value; break;
                        case 4: paramChar4 = value; break;
                        case 5: paramChar5 = value; break;
                        case 6: paramChar6 = value; break;
                        case 7: paramChar7 = value; break;
                        case 8: paramChar8 = value; break;
                        case 9: paramChar9 = value; break;
                        case 10: paramChar10 = value; break;
                        case 11: paramChar11 = value; break;
                        case 12: paramChar12 = value; break;
                        case 13: paramChar13 = value; break;
                        case 14: paramChar14 = value; break;
                        case 15: paramChar15 = value; break;
                        default: throw new ArgumentOutOfRangeException(nameof(index));
                    }
                }
            }
        }

        [FieldOffset(0)] public ParamChar Chars;
        #endregion

        #region bool[16]
        [StructLayout(LayoutKind.Explicit)]
        public struct ParamBool
        {
            [FieldOffset(0)] bool paramBool0;
            [FieldOffset(1)] bool paramBool1;
            [FieldOffset(2)] bool paramBool2;
            [FieldOffset(3)] bool paramBool3;
            [FieldOffset(4)] bool paramBool4;
            [FieldOffset(5)] bool paramBool5;
            [FieldOffset(6)] bool paramBool6;
            [FieldOffset(7)] bool paramBool7;
            [FieldOffset(8)] bool paramBool8;
            [FieldOffset(9)] bool paramBool9;
            [FieldOffset(10)] bool paramBool10;
            [FieldOffset(11)] bool paramBool11;
            [FieldOffset(12)] bool paramBool12;
            [FieldOffset(13)] bool paramBool13;
            [FieldOffset(14)] bool paramBool14;
            [FieldOffset(15)] bool paramBool15;

            public bool this[int index]
            {
                readonly get => index switch
                {
                    0 => paramBool0,
                    1 => paramBool1,
                    2 => paramBool2,
                    3 => paramBool3,
                    4 => paramBool4,
                    5 => paramBool5,
                    6 => paramBool6,
                    7 => paramBool7,
                    8 => paramBool8,
                    9 => paramBool9,
                    10 => paramBool10,
                    11 => paramBool11,
                    12 => paramBool12,
                    13 => paramBool13,
                    14 => paramBool14,
                    15 => paramBool15,
                    _ => throw new ArgumentOutOfRangeException(nameof(index)),
                };
                set
                {
                    switch(index)
                    {
                        case 0: paramBool0 = value; break;
                        case 1: paramBool1 = value; break;
                        case 2: paramBool2 = value; break;
                        case 3: paramBool3 = value; break;
                        case 4: paramBool4 = value; break;
                        case 5: paramBool5 = value; break;
                        case 6: paramBool6 = value; break;
                        case 7: paramBool7 = value; break;
                        case 8: paramBool8 = value; break;
                        case 9: paramBool9 = value; break;
                        case 10: paramBool10 = value; break;
                        case 11: paramBool11 = value; break;
                        case 12: paramBool12 = value; break;
                        case 13: paramBool13 = value; break;
                        case 14: paramBool14 = value; break;
                        case 15: paramBool15 = value; break;
                        default: throw new ArgumentOutOfRangeException(nameof(index));
                    }
                }
            }
        }

        [FieldOffset(0)] public ParamBool Bools;
        #endregion

        #region uint[4]
        [StructLayout(LayoutKind.Explicit)]
        public struct ParamUint
        {
            [FieldOffset(0)] uint paramUint0;
            [FieldOffset(4)] uint paramUint1;
            [FieldOffset(8)] uint paramUint2;
            [FieldOffset(12)] uint paramUint3;

            public uint this[int index]
            {
                readonly get => index switch
                {
                    0 => paramUint0,
                    1 => paramUint1,
                    2 => paramUint2,
                    3 => paramUint3,
                    _ => throw new ArgumentOutOfRangeException(nameof(index)),
                };
                set
                {
                    switch(index)
                    {
                        case 0: paramUint0 = value; break;
                        case 1: paramUint1 = value; break;
                        case 2: paramUint2 = value; break;
                        case 3: paramUint3 = value; break;
                        default: throw new ArgumentOutOfRangeException(nameof(index));
                    }
                }
            }
        }

        [FieldOffset(0)] public ParamUint Uints;
        #endregion

        #region int[4]
        [StructLayout(LayoutKind.Explicit)]
        public struct ParamInt
        {
            [FieldOffset(0)] int paramInt0;
            [FieldOffset(4)] int paramInt1;
            [FieldOffset(8)] int paramInt2;
            [FieldOffset(12)] int paramInt3;

            public int this[int index]
            {
                readonly get => index switch
                {
                    0 => paramInt0,
                    1 => paramInt1,
                    2 => paramInt2,
                    3 => paramInt3,
                    _ => throw new ArgumentOutOfRangeException(nameof(index)),
                };
                set
                {
                    switch(index)
                    {
                        case 0: paramInt0 = value; break;
                        case 1: paramInt1 = value; break;
                        case 2: paramInt2 = value; break;
                        case 3: paramInt3 = value; break;
                        default: throw new ArgumentOutOfRangeException(nameof(index));
                    }
                }
            }
        }

        [FieldOffset(0)] public ParamInt Ints;
        #endregion

        #region float[4]
        [StructLayout(LayoutKind.Explicit)]
        public struct ParamFloat
        {
            [FieldOffset(0)] float paramFloat0;
            [FieldOffset(4)] float paramFloat1;
            [FieldOffset(8)] float paramFloat2;
            [FieldOffset(12)] float paramFloat3;

            public float this[int index]
            {
                readonly get => index switch
                {
                    0 => paramFloat0,
                    1 => paramFloat1,
                    2 => paramFloat2,
                    3 => paramFloat3,
                    _ => throw new ArgumentOutOfRangeException(nameof(index)),
                };
                set
                {
                    switch(index)
                    {
                        case 0: paramFloat0 = value; break;
                        case 1: paramFloat1 = value; break;
                        case 2: paramFloat2 = value; break;
                        case 3: paramFloat3 = value; break;
                        default: throw new ArgumentOutOfRangeException(nameof(index));
                    }
                }
            }
        }

        [FieldOffset(0)] public ParamFloat Floats;
        #endregion

        [FieldOffset(16)] public object? Object;

        public void Reset()
        {
            for(int i = 0; i < 4; i++)
            {
                Uints[i] = 0;
            }
            Object = null;

        }
    }

    public EventData Data;

    public OpjectEvent(OpjectEventEnum eventEnum)
    {
        EventEnum = eventEnum;
        Data.Reset();
    }

    public OpjectEvent(OpjectEventEnum eventEnum, string content)
    {
        EventEnum = eventEnum;
        Data.Reset();
        Data.Object = content;
    }

    public OpjectEvent(OpjectEventEnum eventEnum, int index)
    {
        EventEnum = eventEnum;
        Data.Reset();
        Index = index;
    }

    public OpjectEvent CursorOffset(Point offset) => EventEnum.IsCursorEvent() ? this with
    {
        CursorX = CursorX + offset.X,
        CursorY = CursorY + offset.Y
    } : this;

    public OpjectEvent OpjectCursorOffset(Opject opject)
    {
        Rectangle region=//
    }

    public float CursorX { get => Data.Floats[0]; set => Data.Floats[0] = value; }
    public float CursorY { get => Data.Floats[1]; set => Data.Floats[1] = value; }

    public int Index { readonly get => Data.Ints[0]; set => Data.Ints[0] = value; }


}

