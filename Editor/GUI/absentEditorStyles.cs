using UnityEditor;
using UnityEngine;

namespace com.absence.editor.gui
{
    /// <summary>
    /// Static class that holds all of the styles used by <see cref="absentGUI"/> and <see cref="absentGUILayout"/>. Some of the
    /// styles in this class may throw an error if you try to use them outside a GUI function.
    /// </summary>
    [InitializeOnLoad]
    public static class absentEditorStyles
    {
        static absentGUIStyle m_header1Style = new(SetupHeader1Style);
        static absentGUIStyle m_header2Style = new(SetupHeader2Style);
        static absentGUIStyle m_header3Style = new(SetupHeader3Style);

        public static GUIStyle Header1Style => m_header1Style.source;
        public static GUIStyle Header2Style => m_header2Style.source;
        public static GUIStyle Header3Style => m_header3Style.source;

        static absentEditorStyles()
        {
            m_header1Style = new(SetupHeader1Style);
            m_header2Style = new(SetupHeader2Style);
            m_header3Style = new(SetupHeader3Style);
        }

        #region Internals
        static GUIStyle SetupHeader1Style()
        {
            GUIStyle header1Style = new GUIStyle(EditorStyles.label);
            header1Style.fontSize = 18;
            header1Style.alignment = TextAnchor.MiddleCenter;
            header1Style.fontStyle = FontStyle.Bold;
            header1Style.margin.bottom = 10;
            header1Style.wordWrap = true;

            return header1Style;
        }
        static GUIStyle SetupHeader2Style()
        {
            GUIStyle header2Style = new GUIStyle(EditorStyles.label);
            header2Style.fontSize = 16;
            header2Style.alignment = TextAnchor.MiddleCenter;
            header2Style.fontStyle = FontStyle.Bold;
            header2Style.margin.bottom = 10;
            header2Style.wordWrap = true;

            return header2Style;
        }
        static GUIStyle SetupHeader3Style()
        {
            GUIStyle header3Style = new GUIStyle(EditorStyles.label);
            header3Style.fontSize = 14;
            header3Style.alignment = TextAnchor.MiddleCenter;
            header3Style.fontStyle = FontStyle.Bold;
            header3Style.margin.bottom = 10;
            header3Style.wordWrap = true;

            return header3Style;
        }
        #endregion
    }
}