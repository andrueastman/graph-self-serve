// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace CustomGraph.Client.Models {
    public enum RiskDetail {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "adminGeneratedTemporaryPassword")]
        AdminGeneratedTemporaryPassword,
        [EnumMember(Value = "userPerformedSecuredPasswordChange")]
        UserPerformedSecuredPasswordChange,
        [EnumMember(Value = "userPerformedSecuredPasswordReset")]
        UserPerformedSecuredPasswordReset,
        [EnumMember(Value = "adminConfirmedSigninSafe")]
        AdminConfirmedSigninSafe,
        [EnumMember(Value = "aiConfirmedSigninSafe")]
        AiConfirmedSigninSafe,
        [EnumMember(Value = "userPassedMFADrivenByRiskBasedPolicy")]
        UserPassedMFADrivenByRiskBasedPolicy,
        [EnumMember(Value = "adminDismissedAllRiskForUser")]
        AdminDismissedAllRiskForUser,
        [EnumMember(Value = "adminConfirmedSigninCompromised")]
        AdminConfirmedSigninCompromised,
        [EnumMember(Value = "hidden")]
        Hidden,
        [EnumMember(Value = "adminConfirmedUserCompromised")]
        AdminConfirmedUserCompromised,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "m365DAdminDismissedDetection")]
        M365DAdminDismissedDetection,
        [EnumMember(Value = "adminConfirmedServicePrincipalCompromised")]
        AdminConfirmedServicePrincipalCompromised,
        [EnumMember(Value = "adminDismissedAllRiskForServicePrincipal")]
        AdminDismissedAllRiskForServicePrincipal,
    }
}
