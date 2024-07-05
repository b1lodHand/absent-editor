using System;
using UnityEngine;

namespace com.absence.editor.gui
{
    [Serializable]
    public class absentGUIStyle
    {
        [SerializeField] private GUIStyle m_source = null;
        [SerializeField] private Func<GUIStyle> m_provider = null;

        public GUIStyle source
        {
            get
            {
                if (m_source == null) Fetch();
                return m_source;
            }

            private set
            {
                m_source = value;
            }
        }

        public absentGUIStyle(Func<GUIStyle> sourceProvider)
        {
            m_provider = sourceProvider;
        }
        public absentGUIStyle()
        {
            m_provider = null;
        }

        public void Fetch()
        {
            source = m_provider?.Invoke();
        }

        public static implicit operator GUIStyle(absentGUIStyle style)
        {
            if (style.source == null) style.Fetch();
            return style;
        }
    }
}