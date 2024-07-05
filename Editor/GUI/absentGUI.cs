using com.absence.editor.internals;
using UnityEditor;
using UnityEngine;

namespace com.absence.editor.gui
{
    public static class absentGUI
    {
        public static void Header1(Rect rect, GUIContent content)
        {
            EditorGUI.LabelField(rect, content, absentEditorStyles.Header1Style);

            rect.y += absentEditorStyles.Header1Style.CalcHeight(content, EditorGUIUtility.currentViewWidth);
            DrawUnderline(rect);
        }
        public static void Header1(Rect rect, string headerText)
        {
            EditorGUI.LabelField(rect, headerText, absentEditorStyles.Header1Style);

            rect.y += absentEditorStyles.Header1Style.CalcHeight(new GUIContent(headerText), EditorGUIUtility.currentViewWidth);
            DrawUnderline(rect);
        }

        public static void Header2(Rect rect, GUIContent content)
        {
            EditorGUI.LabelField(rect, content, absentEditorStyles.Header2Style);
        }
        public static void Header2(Rect rect, string headerText)
        {
            EditorGUI.LabelField(rect, headerText, absentEditorStyles.Header2Style);
        }

        public static void Header3(Rect rect, GUIContent content)
        {
            EditorGUI.LabelField(rect, content, absentEditorStyles.Header3Style);
        }
        public static void Header3(Rect rect, string headerText)
        {
            EditorGUI.LabelField(rect, headerText, absentEditorStyles.Header3Style);
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

        public static void DrawUnderline(Rect rect)
        {
            DrawLine_Internal(rect, Constants.UNDERLINE_COLOR, Constants.LINE_HEIGHT, Constants.UNDERLINE_OFFSET_NONLAYOUT, 0);
        }
        public static void DrawLine(Rect rect, Color color)
        {
            DrawLine_Internal(rect, color, Constants.LINE_HEIGHT, Constants.LINE_OFFSET, Constants.LINE_MARGINS);
        }
        public static void DrawLine(Rect rect)
        {
            DrawLine(rect, Constants.LINE_COLOR);
        }
    }
}