using UnityEditor;

namespace com.absence.editor.internals
{
    public class PackageSettingsProvider : SettingsProvider
    {
        public PackageSettingsProvider(string path, SettingsScope scope) : base(path, scope)
        {
        }

        public override void OnGUI(string searchContext)
        {
            base.OnGUI(searchContext);

            EditorGUILayout.Space(5);
            EditorGUI.indentLevel++;

            PackageSettings settings = PackageSettings.instance;

            bool fancyIcons = settings.PaintHierarchyScriptIcons;
            bool fancyIconsNew = EditorGUILayout.Toggle("Paint Hierarchy Script Icons", fancyIcons);
            if(fancyIcons != fancyIconsNew) settings.PaintHierarchyScriptIcons = fancyIconsNew;

            EditorGUI.indentLevel--;
        }

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new PackageSettingsProvider("absencee_/absent-editor", SettingsScope.Project);
        }
    }
}
