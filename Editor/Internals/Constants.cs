using UnityEngine;

namespace com.absence.editor.internals
{
    public static class Constants
    {
        public const int UNDERLINE_OFFSET = -12;
        public const int UNDERLINE_OFFSET_NONLAYOUT = 3;
        public static readonly Color UNDERLINE_COLOR = new Color(255f, 255f, 255f, 0.6f);

        public const int LINE_HEIGHT = 2;
        public const int LINE_OFFSET = 0;
        public const int LINE_MARGINS = 2;
        public static readonly Color LINE_COLOR = new Color(0f, 0f, 0f, 0.2f);

        public const int SEPERATOR_WIDTH = 1;
        public static readonly Color SEPERATOR_COLOR = new Color(255f, 255f, 255f, 0.2f);
    }
}