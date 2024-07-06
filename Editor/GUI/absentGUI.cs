using com.absence.editor.internals;
using UnityEditor;
using UnityEngine;

namespace com.absence.editor.gui
{
    /// <summary>
    /// Static class which contains some handy IMGUI functions.
    /// </summary>
    public static class absentGUI
    {
        /// <summary>
        /// Use to create a centered and underlined header.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="content">Header content.</param>
        public static void Header1(Rect rect, GUIContent content)
        {
            EditorGUI.LabelField(rect, content, absentEditorStyles.Header1Style);

            rect.y += absentEditorStyles.Header1Style.CalcHeight(content, EditorGUIUtility.currentViewWidth);
            DrawUnderline(rect);
        }
        /// <summary>
        /// Use to create a centered and underlined header.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="headerText">Header text.</param>
        public static void Header1(Rect rect, string headerText)
        {
            GUIContent temp = new GUIContent(headerText);
            Header1(rect, temp);
        }

        /// <summary>
        /// Use to create a centered header.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="content">Header content.</param>
        public static void Header2(Rect rect, GUIContent content)
        {
            EditorGUI.LabelField(rect, content, absentEditorStyles.Header2Style);
        }

        /// <summary>
        /// Use to create a centered header.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="headerText">Header text.</param>
        public static void Header2(Rect rect, string headerText)
        {
            GUIContent temp = new GUIContent(headerText);
            Header2(rect, temp);
        }

        /// <summary>
        /// Use to create a centered, small header.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="content">Header content.</param>
        public static void Header3(Rect rect, GUIContent content)
        {
            EditorGUI.LabelField(rect, content, absentEditorStyles.Header3Style);
        }
        /// <summary>
        /// Use to create a centered, small header.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="headerText">Header text.</param>
        public static void Header3(Rect rect, string headerText)
        {
            GUIContent temp = new GUIContent(headerText);
            Header3(rect, temp);
        }

        /// <summary>
        /// Use to draw a line with specific settings that set for underlining.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        public static void DrawUnderline(Rect rect)
        {
            DrawLine_Internal(rect, Constants.UNDERLINE_COLOR, Constants.LINE_HEIGHT, Constants.UNDERLINE_OFFSET_NONLAYOUT, 0);
        }

        /// <summary>
        /// Use to draw a line with a specific color.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        /// <param name="color">Color of the line.</param>
        public static void DrawLine(Rect rect, Color color)
        {
            DrawLine_Internal(rect, color, Constants.LINE_HEIGHT, Constants.LINE_OFFSET, Constants.LINE_MARGINS);
        }
        /// <summary>
        /// Use to draw a line.
        /// </summary>
        /// <param name="rect">Rect to use.</param>
        public static void DrawLine(Rect rect)
        {
            DrawLine(rect, Constants.LINE_COLOR);
        }

        internal static void DrawLine_Internal(Rect rect, Color color, int height, int offset, int verticalMargins)
        {
            rect.y += offset;

            Rect spaceRect = new Rect(rect);
            spaceRect.height = verticalMargins;

            Rect lineRect = new Rect(rect);
            lineRect.height = height;

            EditorGUI.DrawRect(spaceRect, new Color(0f, 0f, 0f, 0f));
            EditorGUI.DrawRect(lineRect, color);
            EditorGUI.DrawRect(spaceRect, new Color(0f, 0f, 0f, 0f));
        }
    }
}