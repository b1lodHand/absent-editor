using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace com.absence.editor.scripts
{
    internal class FolderOpenHandler
    {
        [OnOpenAsset]
        public static bool OnOpenAsset(int instanceId)
        {
            Event e = Event.current;
            if (e == null || !e.control)
                return false;

            Object obj = EditorUtility.InstanceIDToObject(instanceId);
            string path = AssetDatabase.GetAssetPath(obj);
            if (AssetDatabase.IsValidFolder(path))
            {
                EditorUtility.RevealInFinder(path);
            }

            return true;
        }
    }
}