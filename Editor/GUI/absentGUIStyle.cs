using System;
using UnityEngine;

namespace com.absence.editor.gui
{
    /// <summary>
    /// A simple wrapper class for <see cref="GUIStyle"/> with an implicit converter to <see cref="GUIStyle"/>.
    /// </summary>
    [Serializable]
    public class absentGUIStyle
    {
        [SerializeField] private GUIStyle m_source = null;
        [SerializeField] private Func<GUIStyle> m_provider = null;

        /// <summary>
        /// The GUIStyle wrapped by this class.
        /// </summary>
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

        /// <summary>
        /// Use to create a new instance with a provider.
        /// </summary>
        /// <param name="sourceProvider">Function to invoke when <see cref="Fetch"/> get called.</param>
        public absentGUIStyle(Func<GUIStyle> sourceProvider)
        {
            m_provider = sourceProvider;
        }

        /// <summary>
        /// Use to recreate the <see cref="source"/>.
        /// </summary>
        public void Fetch()
        {
            source = m_provider?.Invoke();
        }

        public static implicit operator GUIStyle(absentGUIStyle style)
        {
            return style.source;
        }
    }
}