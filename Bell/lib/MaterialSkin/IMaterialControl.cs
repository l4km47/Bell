﻿namespace RcisSchoolBell.lib.MaterialSkin
{
    internal interface IMaterialControl
    {
        int Depth { get; set; }
        MaterialSkinManager SkinManager { get; }
        MouseState MouseState { get; set; }

    }

    public enum MouseState
    {
        Hover,
        Down,
        Out
    }
}
