// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Defines the response of a trigger subscription operation. </summary>
    public partial class TriggerSubscriptionOperationStatus
    {
        /// <summary> Initializes a new instance of TriggerSubscriptionOperationStatus. </summary>
        internal TriggerSubscriptionOperationStatus()
        {
        }

        /// <summary> Initializes a new instance of TriggerSubscriptionOperationStatus. </summary>
        /// <param name="triggerName"> Trigger name. </param>
        /// <param name="status"> Event Subscription Status. </param>
        internal TriggerSubscriptionOperationStatus(string triggerName, EventSubscriptionStatus? status)
        {
            TriggerName = triggerName;
            Status = status;
        }

        /// <summary> Trigger name. </summary>
        public string TriggerName { get; }
        /// <summary> Event Subscription Status. </summary>
        public EventSubscriptionStatus? Status { get; }
    }
}
