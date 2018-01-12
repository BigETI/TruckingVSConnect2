using System.Runtime.Serialization;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Trucking VS Connect² namespace
    /// </summary>
    [DataContract]
    public class PointOfInterestData
    {
        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        private string type;

        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// X
        /// </summary>
        [DataMember]
        private int x;

        /// <summary>
        /// Y
        /// </summary>
        [DataMember]
        private int y;

        /// <summary>
        /// Points of interests
        /// </summary>
        [DataMember(EmitDefaultValue = true, IsRequired = false, Name = "pois")]
        private PointOfInterestData[] pointOfInterests = new PointOfInterestData[0];

        /// <summary>
        /// Prefab model
        /// </summary>
        [DataMember(EmitDefaultValue = true, IsRequired = false, Name = "prefab_model")]
        private string prefabModel = "";

        /// <summary>
        /// Translated name
        /// </summary>
        private string translatedName;

        /// <summary>
        /// Type
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        public string TranslatedName
        {
            get
            {
                if (translatedName == null)
                {
                    translatedName = Translator.GetTranslation(name);
                }
                return translatedName;
            }
        }

        /// <summary>
        /// X
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
        }

        /// <summary>
        /// Y
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
        }

        /// <summary>
        /// Points of interests
        /// </summary>
        public PointOfInterestData[] PointOfInterests
        {
            get
            {
                return pointOfInterests;
            }
        }

        /// <summary>
        /// Prefab model
        /// </summary>
        public string PrefabModel
        {
            get
            {
                return prefabModel;
            }
        }
    }
}
