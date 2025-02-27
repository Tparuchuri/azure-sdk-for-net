// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The request body which contain contact detail metadata. </summary>
    public partial class NotificationContent
    {
        /// <summary> Initializes a new instance of NotificationContent. </summary>
        /// <param name="alertType"> The name of the supported alert type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alertType"/> is null. </exception>
        public NotificationContent(string alertType)
        {
            if (alertType == null)
            {
                throw new ArgumentNullException(nameof(alertType));
            }

            AlertType = alertType;
            EmailReceivers = new ChangeTrackingList<MonitorEmailReceiver>();
            SmsReceivers = new ChangeTrackingList<MonitorSmsReceiver>();
            WebhookReceivers = new ChangeTrackingList<MonitorWebhookReceiver>();
            ItsmReceivers = new ChangeTrackingList<MonitorItsmReceiver>();
            AzureAppPushReceivers = new ChangeTrackingList<MonitorAzureAppPushReceiver>();
            AutomationRunbookReceivers = new ChangeTrackingList<MonitorAutomationRunbookReceiver>();
            VoiceReceivers = new ChangeTrackingList<MonitorVoiceReceiver>();
            LogicAppReceivers = new ChangeTrackingList<MonitorLogicAppReceiver>();
            AzureFunctionReceivers = new ChangeTrackingList<MonitorAzureFunctionReceiver>();
            ArmRoleReceivers = new ChangeTrackingList<MonitorArmRoleReceiver>();
            EventHubReceivers = new ChangeTrackingList<MonitorEventHubReceiver>();
        }

        /// <summary> The name of the supported alert type. </summary>
        public string AlertType { get; }
        /// <summary> The list of email receivers that are part of this action group. </summary>
        public IList<MonitorEmailReceiver> EmailReceivers { get; }
        /// <summary> The list of SMS receivers that are part of this action group. </summary>
        public IList<MonitorSmsReceiver> SmsReceivers { get; }
        /// <summary> The list of webhook receivers that are part of this action group. </summary>
        public IList<MonitorWebhookReceiver> WebhookReceivers { get; }
        /// <summary> The list of ITSM receivers that are part of this action group. </summary>
        public IList<MonitorItsmReceiver> ItsmReceivers { get; }
        /// <summary> The list of AzureAppPush receivers that are part of this action group. </summary>
        public IList<MonitorAzureAppPushReceiver> AzureAppPushReceivers { get; }
        /// <summary> The list of AutomationRunbook receivers that are part of this action group. </summary>
        public IList<MonitorAutomationRunbookReceiver> AutomationRunbookReceivers { get; }
        /// <summary> The list of voice receivers that are part of this action group. </summary>
        public IList<MonitorVoiceReceiver> VoiceReceivers { get; }
        /// <summary> The list of logic app receivers that are part of this action group. </summary>
        public IList<MonitorLogicAppReceiver> LogicAppReceivers { get; }
        /// <summary> The list of azure function receivers that are part of this action group. </summary>
        public IList<MonitorAzureFunctionReceiver> AzureFunctionReceivers { get; }
        /// <summary> The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only built-in roles are supported. </summary>
        public IList<MonitorArmRoleReceiver> ArmRoleReceivers { get; }
        /// <summary> The list of event hub receivers that are part of this action group. </summary>
        public IList<MonitorEventHubReceiver> EventHubReceivers { get; }
    }
}
