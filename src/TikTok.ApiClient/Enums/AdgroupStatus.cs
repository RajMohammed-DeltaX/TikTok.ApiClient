﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TikTok.ApiClient.Enums
{
    /// <summary>
    /// Ad Group Status Enum
    /// See Link - https://ads.tiktok.com/marketing_api/docs?id=1701890985340929
    /// </summary>
    public enum AdgroupStatus
    {
        /// <summary>
        /// Deleted
        /// </summary>
        ADGROUP_STATUS_DELETE,

        /// <summary>
        /// Campaign deleted
        /// </summary>
        ADGROUP_STATUS_CAMPAIGN_DELETE,

        /// <summary>
        /// Advertiser review failed
        /// </summary>
        ADGROUP_STATUS_ADVERTISER_AUDIT_DENY,

        /// <summary>
        /// Advertiser review in progress
        /// </summary>
        ADGROUP_STATUS_ADVERTISER_AUDIT,

        /// <summary>
        /// Advertiser contract has not taken effect
        /// </summary>
        ADVERTISER_CONTRACT_PENDING,

        /// <summary>
        /// Campaign over budget
        /// </summary>
        ADGROUP_STATUS_CAMPAIGN_EXCEED,

        /// <summary>
        /// Ad group over budget
        /// </summary>
        ADGROUP_STATUS_BUDGET_EXCEED,

        /// <summary>
        /// Insufficient account balance
        /// </summary>
        ADGROUP_STATUS_BALANCE_EXCEED,

        /// <summary>
        /// Ad group review failed
        /// </summary>
        ADGROUP_STATUS_AUDIT_DENY,

        /// <summary>
        /// Review of modifications in progress
        /// </summary>
        ADGROUP_STATUS_REAUDIT,

        /// <summary>
        /// New review created
        /// </summary>
        ADGROUP_STATUS_AUDIT,

        /// <summary>
        /// New ad group created
        /// </summary>
        ADGROUP_STATUS_CREATE,

        /// <summary>
        /// The scheduled delivery time has not started
        /// </summary>
        ADGROUP_STATUS_NOT_START,

        /// <summary>
        /// Completed
        /// </summary>
        ADGROUP_STATUS_TIME_DONE,

        /// <summary>
        /// Campaign suspended
        /// </summary>
        ADGROUP_STATUS_CAMPAIGN_DISABLE,

        /// <summary>
        /// Suspended
        /// </summary>
        ADGROUP_STATUS_DISABLE,

        /// <summary>
        /// Advertising in delivery
        /// </summary>
        ADGROUP_STATUS_DELIVERY_OK,

        /// <summary>
        /// Ad group in re-review progress
        /// </summary>
        ADGROUP_STATUS_SHADOW_ADGROUP_REAUDIT,

        /// <summary>
        /// "All statuses (including ""Deleted"")"
        /// </summary>
        ADGROUP_STATUS_ALL,

        /// <summary>
        /// "All statuses (excluding ""Deleted"")"
        /// </summary>
        ADGROUP_STATUS_NOT_DELETE,

        ADGROUP_STATUS_PRE_ONLINE,

        /// <summary>
        /// Deduction failed for the R&F ad group
        /// </summary>
        ADGROUP_STATUS_RF_DEDUCTION_FAILED,

        /// <summary>
        /// No valid creatives in the R&F ad group
        /// </summary>
        ADGROUP_STATUS_RF_NO_VALID_CREATIVE,

        /// <summary>
        /// The R&F ad group is closed
        /// </summary>
        ADGROUP_STATUS_RF_CLOSED_OTHERS,

        /// <summary>
        /// Not enough balance in the R&F ad group
        /// </summary>
        ADGROUP_STATUS_RF_SHORT_BALANCE,

        /// <summary>
        /// Budget / inventory has been booked for this R&F ad group
        /// </summary>
        ADGROUP_STATUS_RF_BOOKING,

        /// <summary>
        /// No creatives in this R&F ad group
        /// </summary>
        ADGROUP_STATUS_RF_NO_DELIVERY_CREATIVE,

        /// <summary>
        /// A schedule has been created for the R&F ad group
        /// </summary>
        ADGROUP_STATUS_RF_SCHEDULE,

        /// <summary>
        /// The R&F ad group is terminated
        /// </summary>
        ADGROUP_STATUS_RF_TERMINATE,

        /// <summary>
        /// The R&F ad is rejected (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_RF_AD_AUDIT_DENY,

        /// <summary>
        /// The advertiser account is invalid (can be used as filter)
        /// </summary>
        ADVERTISER_ACCOUNT_INVALID,

        /// <summary>
        /// The R&F ad group doesn't exist (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_RF_ADGROUP_INVALID,

        /// <summary>
        /// The R&F order is withdrawn (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_RF_WITHDRAW_ORDER,

        /// <summary>
        /// The R&F ad group is completed (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_RF_TIME_DONE,

        /// <summary>
        /// Advertiser account is punished (can be used as filter)
        /// </summary>
        ADVERTISER_ACCOUNT_PUNISH,

        /// <summary>
        /// Ad group is frozen (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_FROZEN,

        /// <summary>
        /// The associated pixel is unbound (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_PIXEL_UNBIND,

        /// <summary>
        /// Live is not yet started
        /// </summary>
        ADGROUP_STATUS_LIVE_OFFLINE,

        /// <summary>
        /// Ad group in partial review progress and not in delivery (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_PARTIAL_AUDIT_NO_DELIVERY,

        /// <summary>
        /// Ad group in partial review progress and in delivery (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_PARTIAL_AUDIT_DELIVERY_OK,

        /// <summary>
        /// Industry qualification is missing
        /// </summary>
        ADGROUP_STATUS_INDUSTRY_QUALIFICATION_MISSING,

        /// <summary>
        /// Industry qualification is expired
        /// </summary>
        ADGROUP_STATUS_INDUSTRY_QUALIFICATION_EXPIRED,

        /// <summary>
        /// Industry qualification is rejected (can be used as filter)
        /// </summary>
        ADGROUP_STATUS_INDUSTRY_QUALIFICATION_DENY,
    }
}
