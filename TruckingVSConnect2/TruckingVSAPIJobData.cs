using Ets2SdkClient;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Trucking VS API job data class
    /// </summary>
    public class TruckingVSAPIJobData
    {
        /// <summary>
        /// Telemetry data
        /// </summary>
        private Ets2Telemetry telemetryData;

        /// <summary>
        /// Job data type
        /// </summary>
        private ETruckingVSAPIJobDataType type;

        /// <summary>
        /// Telemetry data
        /// </summary>
        public Ets2Telemetry TelemetryData
        {
            get
            {
                return telemetryData;
            }
        }

        /// <summary>
        /// Job data type
        /// </summary>
        public ETruckingVSAPIJobDataType Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private TruckingVSAPIJobData()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public TruckingVSAPIJobData(Ets2Telemetry telemetryData, ETruckingVSAPIJobDataType type)
        {
            this.telemetryData = telemetryData;
            this.type = type;
        }
    }
}
