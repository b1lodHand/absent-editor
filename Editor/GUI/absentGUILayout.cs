using com.absence.editor.internals;
using UnityEditor;
using UnityEngine;

namespace com.absence.editor.gui
{
    public static class absentGUILayout
    {
        public static void Header1(GUIContent content)
        {
            EditorGUILayout.LabelField(content, absentEditorStyles.Header1Style);

            DrawUnderline();
        }
        public static void Header1(string headerText)
        {
            EditorGUILayout.LabelField(headerText, absentEditorStyles.Header1Style);

            DrawUnderline();
        }

        public static void Header2(GUIContent content)
        {
            EditorGUILayout.LabelField(content, absentEditorStyles.Header2Style);
        }
        public static void Header2(string headerText)
        {
            EditorGUILayout.LabelField(headerText, absentEditorStyles.Header2Style);
        }

        public static void Header3(GUIContent content)
        {
            EditorGUILayout.LabelField(content, absentEditorStyles.Header3Style);
        }
        public static void Header3(string headerText)
        {
            EditorGUILayout.LabelField(headerText, absentEditorStyles.Header3Style);
        }

        private static void DrawLine_Internal(Color color, int height, int offset, int verticalMargins)
        {
            Rect lastRect = EditorGUILayout.GetControlRect();
            absentGUI.DrawLine_Internal(lastRect, color, height, offset, verticalMargins);
        }

        public static void DrawUnderline()
        {
            DrawLine_Internal(Constants.UNDERLINE_COLOR, Constants.LINE_HEIGHT, Constants.UNDERLINE_OFFSET, 0);
        }
        public static void DrawLine(Color color)
        {
            DrawLine_Internal(color, Constants.LINE_HEIGHT, Constants.LINE_OFFSET, Constants.LINE_MARGINS);
        }
        public static void DrawLine()
        {
            DrawLine(Constants.LINE_COLOR);
        }

        private static void DrawHorizontalSeperator_Internal(Color color, int width)
        {
            Rect lastRect = EditorGUILayout.GetControlRect();
            lastRect.x = (lastRect.width - width) / 2;
            lastRect.height = EditorGUIUtility.singleLineHeight;
            lastRect.width = width;

            EditorGUI.DrawRect(lastRect, color);
        }

        public static void DrawHorizontalSeperator()
        {
            DrawHorizontalSeperator_Internal(Constants.SEPERATOR_COLOR, Constants.SEPERATOR_WIDTH);
        }
    }

}