// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The status of the role eligibility schedule request. </summary>
    public readonly partial struct RoleEligibilityScheduleRequestStatus : IEquatable<RoleEligibilityScheduleRequestStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleEligibilityScheduleRequestStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleEligibilityScheduleRequestStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string PendingEvaluationValue = "PendingEvaluation";
        private const string GrantedValue = "Granted";
        private const string DeniedValue = "Denied";
        private const string PendingProvisioningValue = "PendingProvisioning";
        private const string ProvisionedValue = "Provisioned";
        private const string PendingRevocationValue = "PendingRevocation";
        private const string RevokedValue = "Revoked";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string PendingApprovalProvisioningValue = "PendingApprovalProvisioning";
        private const string PendingApprovalValue = "PendingApproval";
        private const string FailedAsResourceIsLockedValue = "FailedAsResourceIsLocked";
        private const string PendingAdminDecisionValue = "PendingAdminDecision";
        private const string AdminApprovedValue = "AdminApproved";
        private const string AdminDeniedValue = "AdminDenied";
        private const string TimedOutValue = "TimedOut";
        private const string ProvisioningStartedValue = "ProvisioningStarted";
        private const string InvalidValue = "Invalid";
        private const string PendingScheduleCreationValue = "PendingScheduleCreation";
        private const string ScheduleCreatedValue = "ScheduleCreated";
        private const string PendingExternalProvisioningValue = "PendingExternalProvisioning";

        /// <summary> Accepted. </summary>
        public static RoleEligibilityScheduleRequestStatus Accepted { get; } = new RoleEligibilityScheduleRequestStatus(AcceptedValue);
        /// <summary> PendingEvaluation. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingEvaluation { get; } = new RoleEligibilityScheduleRequestStatus(PendingEvaluationValue);
        /// <summary> Granted. </summary>
        public static RoleEligibilityScheduleRequestStatus Granted { get; } = new RoleEligibilityScheduleRequestStatus(GrantedValue);
        /// <summary> Denied. </summary>
        public static RoleEligibilityScheduleRequestStatus Denied { get; } = new RoleEligibilityScheduleRequestStatus(DeniedValue);
        /// <summary> PendingProvisioning. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingProvisioning { get; } = new RoleEligibilityScheduleRequestStatus(PendingProvisioningValue);
        /// <summary> Provisioned. </summary>
        public static RoleEligibilityScheduleRequestStatus Provisioned { get; } = new RoleEligibilityScheduleRequestStatus(ProvisionedValue);
        /// <summary> PendingRevocation. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingRevocation { get; } = new RoleEligibilityScheduleRequestStatus(PendingRevocationValue);
        /// <summary> Revoked. </summary>
        public static RoleEligibilityScheduleRequestStatus Revoked { get; } = new RoleEligibilityScheduleRequestStatus(RevokedValue);
        /// <summary> Canceled. </summary>
        public static RoleEligibilityScheduleRequestStatus Canceled { get; } = new RoleEligibilityScheduleRequestStatus(CanceledValue);
        /// <summary> Failed. </summary>
        public static RoleEligibilityScheduleRequestStatus Failed { get; } = new RoleEligibilityScheduleRequestStatus(FailedValue);
        /// <summary> PendingApprovalProvisioning. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingApprovalProvisioning { get; } = new RoleEligibilityScheduleRequestStatus(PendingApprovalProvisioningValue);
        /// <summary> PendingApproval. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingApproval { get; } = new RoleEligibilityScheduleRequestStatus(PendingApprovalValue);
        /// <summary> FailedAsResourceIsLocked. </summary>
        public static RoleEligibilityScheduleRequestStatus FailedAsResourceIsLocked { get; } = new RoleEligibilityScheduleRequestStatus(FailedAsResourceIsLockedValue);
        /// <summary> PendingAdminDecision. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingAdminDecision { get; } = new RoleEligibilityScheduleRequestStatus(PendingAdminDecisionValue);
        /// <summary> AdminApproved. </summary>
        public static RoleEligibilityScheduleRequestStatus AdminApproved { get; } = new RoleEligibilityScheduleRequestStatus(AdminApprovedValue);
        /// <summary> AdminDenied. </summary>
        public static RoleEligibilityScheduleRequestStatus AdminDenied { get; } = new RoleEligibilityScheduleRequestStatus(AdminDeniedValue);
        /// <summary> TimedOut. </summary>
        public static RoleEligibilityScheduleRequestStatus TimedOut { get; } = new RoleEligibilityScheduleRequestStatus(TimedOutValue);
        /// <summary> ProvisioningStarted. </summary>
        public static RoleEligibilityScheduleRequestStatus ProvisioningStarted { get; } = new RoleEligibilityScheduleRequestStatus(ProvisioningStartedValue);
        /// <summary> Invalid. </summary>
        public static RoleEligibilityScheduleRequestStatus Invalid { get; } = new RoleEligibilityScheduleRequestStatus(InvalidValue);
        /// <summary> PendingScheduleCreation. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingScheduleCreation { get; } = new RoleEligibilityScheduleRequestStatus(PendingScheduleCreationValue);
        /// <summary> ScheduleCreated. </summary>
        public static RoleEligibilityScheduleRequestStatus ScheduleCreated { get; } = new RoleEligibilityScheduleRequestStatus(ScheduleCreatedValue);
        /// <summary> PendingExternalProvisioning. </summary>
        public static RoleEligibilityScheduleRequestStatus PendingExternalProvisioning { get; } = new RoleEligibilityScheduleRequestStatus(PendingExternalProvisioningValue);
        /// <summary> Determines if two <see cref="RoleEligibilityScheduleRequestStatus"/> values are the same. </summary>
        public static bool operator ==(RoleEligibilityScheduleRequestStatus left, RoleEligibilityScheduleRequestStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleEligibilityScheduleRequestStatus"/> values are not the same. </summary>
        public static bool operator !=(RoleEligibilityScheduleRequestStatus left, RoleEligibilityScheduleRequestStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleEligibilityScheduleRequestStatus"/>. </summary>
        public static implicit operator RoleEligibilityScheduleRequestStatus(string value) => new RoleEligibilityScheduleRequestStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleEligibilityScheduleRequestStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleEligibilityScheduleRequestStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
