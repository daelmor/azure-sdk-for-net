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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.RemoteApp.Models;

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// Definition for result of ListBillingPlans operation.
    /// </summary>
    public partial class ListBillingPlansResult : AzureOperationResponse
    {
        private IList<BillingPlan> _planList;
        
        /// <summary>
        /// Optional. List of plan details returned by operation.
        /// </summary>
        public IList<BillingPlan> PlanList
        {
            get { return this._planList; }
            set { this._planList = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ListBillingPlansResult class.
        /// </summary>
        public ListBillingPlansResult()
        {
            this.PlanList = new LazyList<BillingPlan>();
        }
    }
}
