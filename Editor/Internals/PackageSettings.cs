using UnityEditor;
using UnityEngine;

namespace com.absence.editor.internals
{
    [FilePath("ProjectSettings/absent-editor-settings.assets", FilePathAttribute.Location.ProjectFolder)]
    internal class PackageSettings : ScriptableSingleton<PackageSettings>
    {
        [SerializeField] private bool m_paintHierarchyScriptIcons = true;

        public bool PaintHierarchyScriptIcons
        {
            get
            {
                return m_paintHierarchyScriptIcons;
            }

            set
            {
                m_paintHierarchyScriptIcons = value;
                Save(true);
            }
        }
    }
}
