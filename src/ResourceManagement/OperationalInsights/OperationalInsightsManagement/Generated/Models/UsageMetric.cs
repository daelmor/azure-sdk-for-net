// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// A metric describing the usage of a resource.
    /// </summary>
    public partial class UsageMetric
    {
        private double _currentValue;
        
        /// <summary>
        /// Optional. Gets or sets the current value of the metric.
        /// </summary>
        public double CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
        }
        
        private double _limit;
        
        /// <summary>
        /// Optional. Gets or sets the quota limit for the metric.
        /// </summary>
        public double Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }
        
        private MetricName _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the metric.
        /// </summary>
        public MetricName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private System.DateTime? _nextResetTime;
        
        /// <summary>
        /// Optional. Gets or sets the time that the metric's value will reset.
        /// </summary>
        public System.DateTime? NextResetTime
        {
            get { return this._nextResetTime; }
            set { this._nextResetTime = value; }
        }
        
        private string _quotaPeriod;
        
        /// <summary>
        /// Optional. Gets or sets the quota period that determines the length
        /// of time between value resets.
        /// </summary>
        public string QuotaPeriod
        {
            get { return this._quotaPeriod; }
            set { this._quotaPeriod = value; }
        }
        
        private string _unit;
        
        /// <summary>
        /// Optional. Gets or sets the units used for the metric.
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        public UsageMetric()
        {
        }
    }
}
