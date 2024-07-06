using com.absence.editor.internals;
using UnityEditor;
using UnityEngine;

namespace com.absence.editor.gui
{
    /// <summary>
    /// Static class which contains some handy layout-based IMGUI functions.
    /// </summary>
    public static class absentGUILayout
    {
        /// <summary>
        /// Use to create a centered and underlined header.
        /// </summary>
        /// <param name="content">Header content.</param>
        public static void Header1(GUIContent content)
        {
            EditorGUILayout.LabelField(content, absentEditorStyles.Header1Style);

            DrawUnderline();
        }
        /// <summary>
        /// Use to create a centered and underlined header.
        /// </summary>
        /// <param name="headerText">Header text.</param>
        public static void Header1(string headerText)
        {
            GUIContent temp = new GUIContent(headerText);
            Header1(temp);
        }

        /// <summary>
        /// Use to create a centered header.
        /// </summary>
        /// <param name="content">Header content.</param>
        public static void Header2(GUIContent content)
        {
            EditorGUILayout.LabelField(content, absentEditorStyles.Header2Style);
        }
        /// <summary>
        /// Use to create a centered header.
        /// </summary>
        /// <param name="headerText">Header text.</param>
        public static void Header2(string headerText)
        {
            GUIContent temp = new GUIContent(headerText);
            Header2(temp);
        }

        /// <summary>
        /// Use to create a centered, small header.
        /// </summary>
        /// <param name="content">Header content.</param>
        public static void Header3(GUIContent content)
        {
            EditorGUILayout.LabelField(content, absentEditorStyles.Header3Style);
        }
        /// <summary>
        /// Use to create a centered, small header.
        /// </summary>
        /// <param name="headerText">Header text.</param>
        public static void Header3(string headerText)
        {
            GUIContent temp = new GUIContent(headerText);
            Header3(temp);
        }

        /// <summary>
        /// Use to draw an underline to the last thing drawn.
        /// </summary>
        public static void DrawUnderline()
        {
            DrawLine_Internal(Constants.UNDERLINE_COLOR, Constants.LINE_HEIGHT, Constants.UNDERLINE_OFFSET, 0);
        }

        /// <summary>
        /// Use to draw a line with a specific color.
        /// </summary>
        /// <param name="color">Color of the line.</param>
        public static void DrawLine(Color color)
        {
            DrawLine_Internal(color, Constants.LINE_HEIGHT, Constants.LINE_OFFSET, Constants.LINE_MARGINS);
        }
        /// <summary>
        /// Use to draw a line.
        /// </summary>
        public static void DrawLine()
        {
            DrawLine(Constants.LINE_COLOR);
        }

        /// <summary>
        /// Use to draw a vertical line with height of <see cref="EditorGUIUtility.singleLineHeight"/>.
        /// </summary>
        public static void DrawHorizontalSeperator()
        {
            DrawHorizontalSeperator_Internal(Constants.SEPERATOR_COLOR, Constants.SEPERATOR_WIDTH);
        }

        internal static void DrawHorizontalSeperator_Internal(Color color, int width)
        {
            Rect lastRect = EditorGUILayout.GetControlRect();
            lastRect.x = (lastRect.width - width) / 2;
            lastRect.height = EditorGUIUtility.singleLineHeight;
            lastRect.width = width;

            EditorGUI.DrawRect(lastRect, color);
        }
        internal static void DrawLine_Internal(Color color, int height, int offset, int verticalMargins)
        {
            Rect lastRect = EditorGUILayout.GetControlRect();
            absentGUI.DrawLine_Internal(lastRect, color, height, offset, verticalMargins);
        }
    }

}