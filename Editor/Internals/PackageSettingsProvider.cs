using UnityEditor;
using UnityEngine;

namespace com.absence.editor.internals
{
    internal class PackageSettingsProvider : SettingsProvider
    {
        public PackageSettingsProvider(string path, SettingsScope scope) : base(path, scope)
        {
        }

        public override void OnGUI(string searchContext)
        {
            base.OnGUI(searchContext);

            PackageSettings settings = PackageSettings.instance;
            bool fancyIcons = settings.PaintHierarchyScriptIcons;

            EditorGUILayout.Space(5);
            EditorGUI.indentLevel++;

            DrawFancyIconsToggle();

            EditorGUI.indentLevel--;

            return;

            void DrawFancyIconsToggle()
            {
                GUIContent content = new()
                {
                    text = "Paint Hierarchy Script Icons",
                    tooltip = "If true, script icons will get displayed instead of grey cubes in the hierarchy window."
                };

                bool fancyIconsNew = EditorGUILayout.Toggle(content, fancyIcons);
                if (fancyIcons != fancyIconsNew) settings.PaintHierarchyScriptIcons = fancyIconsNew;
            }
        }

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new PackageSettingsProvider("absencee_/absent-editor", SettingsScope.Project);
        }
    }
}
