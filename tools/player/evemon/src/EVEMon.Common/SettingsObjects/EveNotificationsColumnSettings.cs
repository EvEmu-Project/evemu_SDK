using System.Xml.Serialization;

namespace EVEMon.Common.SettingsObjects
{
    public sealed class EveNotificationsColumnSettings : IColumnSettings
    {
        public EveNotificationsColumnSettings()
        {
            Width = -1;
        }

        [XmlAttribute("column")]
        public EveNotificationsColumn Column
        {
            get;
            set;
        }

        [XmlAttribute("visible")]
        public bool Visible
        {
            get;
            set;
        }

        [XmlAttribute("width")]
        public int Width
        {
            get;
            set;
        }

        int IColumnSettings.Key
        {
            get { return (int)Column; }
        }

        /// <summary>
        /// ShallowClones this instance.
        /// </summary>
        /// <returns></returns>
        public EveNotificationsColumnSettings Clone()
        {
            return new EveNotificationsColumnSettings { Column = Column, Visible = Visible, Width = Width };
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Column.GetHeader();
        }
    }
}