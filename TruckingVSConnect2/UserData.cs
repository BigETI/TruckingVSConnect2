﻿using Ets2SdkClient;
using System.Runtime.Serialization;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Player data
    /// </summary>
    [DataContract]
    public class UserData
    {
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Running game
        /// </summary>
        [DataMember]
        private EGame runningGame;

        /// <summary>
        /// Position X
        /// </summary>
        [DataMember]
        private float posX;

        /// <summary>
        /// Position Y
        /// </summary>
        [DataMember]
        private float posY;

        /// <summary>
        /// Position Z
        /// </summary>
        [DataMember]
        private float posZ;

        /// <summary>
        /// Speed
        /// </summary>
        [DataMember]
        private float speed;

        /// <summary>
        /// Speed limit
        /// </summary>
        [DataMember]
        private float speedLimit;

        /// <summary>
        /// Manufacturer
        /// </summary>
        [DataMember]
        private string manufacturer;

        /// <summary>
        /// Truck
        /// </summary>
        [DataMember]
        private string truck;

        /// <summary>
        /// On job
        /// </summary>
        [DataMember]
        private bool onJob;

        /// <summary>
        /// Cargo
        /// </summary>
        [DataMember]
        private string cargo;

        /// <summary>
        /// Company source
        /// </summary>
        [DataMember]
        private string companySource;

        /// <summary>
        /// City source
        /// </summary>
        [DataMember]
        private string citySource;

        /// <summary>
        /// Company source
        /// </summary>
        [DataMember]
        private string companyDestination;

        /// <summary>
        /// City source
        /// </summary>
        [DataMember]
        private string cityDestination;

        /// <summary>
        /// Navigation distance left
        /// </summary>
        [DataMember]
        private float navigationDistanceLeft;

        /// <summary>
        /// Distance
        /// </summary>
        [DataMember]
        private float distance;

        /// <summary>
        /// Navigation time left
        /// </summary>
        [DataMember]
        private float navigationTimeLeft;

        /// <summary>
        /// Income
        /// </summary>
        [DataMember]
        private int income;

        /// <summary>
        /// Mass
        /// </summary>
        [DataMember]
        private float mass;

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
        /// Running game
        /// </summary>
        public EGame RunningGame
        {
            get
            {
                return runningGame;
            }
        }

        /// <summary>
        /// Position X
        /// </summary>
        public float PosX
        {
            get
            {
                return posX;
            }
        }

        /// <summary>
        /// Position Y
        /// </summary>
        public float PosY
        {
            get
            {
                return posY;
            }
        }

        /// <summary>
        /// Position Z
        /// </summary>
        public float PosZ
        {
            get
            {
                return posZ;
            }
        }

        /// <summary>
        /// Speed
        /// </summary>
        public float Speed
        {
            get
            {
                return speed;
            }
        }

        /// <summary>
        /// Speed limit
        /// </summary>
        public float SpeedLimit
        {
            get
            {
                return speedLimit;
            }
        }

        /// <summary>
        /// Manufacturer
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
        }

        /// <summary>
        /// Truck
        /// </summary>
        public string Truck
        {
            get
            {
                return truck;
            }
        }

        /// <summary>
        /// On job
        /// </summary>
        public bool OnJob
        {
            get
            {
                return onJob;
            }
        }

        /// <summary>
        /// Cargo
        /// </summary>
        public string Cargo
        {
            get
            {
                return cargo;
            }
        }

        /// <summary>
        /// Company source
        /// </summary>
        public string CompanySource
        {
            get
            {
                return companySource;
            }
        }

        /// <summary>
        /// City source
        /// </summary>
        public string CitySource
        {
            get
            {
                return citySource;
            }
        }

        /// <summary>
        /// Company source
        /// </summary>
        public string CompanyDestination
        {
            get
            {
                return companyDestination;
            }
        }

        /// <summary>
        /// City source
        /// </summary>
        public string CityDestination
        {
            get
            {
                return cityDestination;
            }
        }

        /// <summary>
        /// Navigation distance left
        /// </summary>
        public float NavigationDistanceLeft
        {
            get
            {
                return navigationDistanceLeft;
            }
        }

        /// <summary>
        /// Distance
        /// </summary>
        public float Distance
        {
            get
            {
                return distance;
            }
        }

        /// <summary>
        /// Navigation time left
        /// </summary>
        public float NavigationTimeLeft
        {
            get
            {
                return navigationTimeLeft;
            }
        }

        /// <summary>
        /// Income
        /// </summary>
        public int Income
        {
            get
            {
                return income;
            }
        }

        /// <summary>
        /// Mass
        /// </summary>
        public float Mass
        {
            get
            {
                return mass;
            }
        }

        public UserData()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="posX">Position X</param>
        /// <param name="posY">Position Y</param>
        public UserData(string name, Ets2Telemetry telemetryData, TruckingVSAPI api)
        {
            this.name = name;
            runningGame = Utils.RunningGame;
            posX = telemetryData.Physics.CoordinateX;
            posY = telemetryData.Physics.CoordinateY;
            posZ = telemetryData.Physics.CoordinateZ;
            speed = telemetryData.Physics.Speed;
            speedLimit = telemetryData.Job.SpeedLimit;
            manufacturer = telemetryData.Manufacturer;
            truck = telemetryData.Truck;
            onJob = telemetryData.Job.OnJob;
            cargo = telemetryData.Job.Cargo;
            companySource = telemetryData.Job.CompanySource;
            citySource = telemetryData.Job.CitySource;
            companyDestination = telemetryData.Job.CompanyDestination;
            cityDestination = telemetryData.Job.CityDestination;
            navigationDistanceLeft = telemetryData.Job.NavigationDistanceLeft;
            distance = api.Distance;
            navigationTimeLeft = telemetryData.Job.NavigationTimeLeft;
            income = telemetryData.Job.Income;
            mass = telemetryData.Job.Mass;
        }
    }
}
