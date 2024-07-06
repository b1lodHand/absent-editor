using com.absence.editor.helpers;
using com.absence.editor.internals;
using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace com.absence.editor.scripts
{
    [InitializeOnLoad]
    internal static class HierarchyIconDisplay
    {
        static bool m_hierarchyHasFocus = false;
        static EditorWindow m_hierarchyEditorWindow;

        static HierarchyIconDisplay()
        {
            EditorApplication.hierarchyWindowItemOnGUI += OnHierarchyWindowItemGUI;
            EditorApplication.update += OnEditorUpdate;
        }

        private static void OnEditorUpdate()
        {
            if (m_hierarchyEditorWindow == null)
                m_hierarchyEditorWindow = EditorWindow.GetWindow(System.Type.GetType("UnityEditor.SceneHierarchyWindow,UnityEditor"));

            m_hierarchyHasFocus = EditorWindow.focusedWindow != null && EditorWindow.focusedWindow == m_hierarchyEditorWindow;
        }

        private static void OnHierarchyWindowItemGUI(int instanceID, Rect selectionRect)
        {
            if (!PackageSettings.instance.PaintHierarchyScriptIcons) return;

            GameObject obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
            if (obj == null) return;

            Component[] components = obj.GetComponents<Component>();
            if (components == null || components.Length == 0) return;

            Component component = components.Length > 1 ? components[1] : components[0];

            Type type = component.GetType();

            GUIContent content = EditorGUIUtility.ObjectContent(component, type);
            content.text = null;
            content.tooltip = type.Name;

            if (content.image == null) return;

            bool isSelected = Selection.instanceIDs.Contains(instanceID);
            bool isHovering = selectionRect.Contains(Event.current.mousePosition);


            Color color = UnityEditorBackgroundColor.Get(isSelected, isHovering, m_hierarchyHasFocus);
            Rect backgroundRect = selectionRect;
            backgroundRect.width = 18.5f;
            EditorGUI.DrawRect(backgroundRect, color);

            EditorGUI.LabelField(selectionRect, content);
        }
    }
}