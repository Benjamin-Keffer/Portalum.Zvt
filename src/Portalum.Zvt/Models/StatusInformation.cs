﻿using Portalum.Zvt.Responses;
using System;

namespace Portalum.Zvt.Models
{
    public class StatusInformation :
        IResponse,
        IResponseErrorMessage,
        IResponseErrorCode,
        IResponseAdditionalText,
        IResponseTerminalIdentifier,
        IResponseAmount,
        IResponseCardName,
        IResponseCardNumber,
        IResponseCardholderAuthentication,
        IResponseCardTechnology,
        IResponseTime,
        IResponseDate,
        IResponseCurrencyCode,
        IResponseReceiptNumber,
        IResponseTraceNumber,
        IResponseTraceNumberLongFormat,
        IResponseVuNumber,
        IResponseAidAuthorisationAttribute,
        IResponseApplicationId,
        IResponseExpiryDate,
        IResponseCardSequenceNumber,
        IResponseTurnoverRecordNumber,
        IResponseCardType,
        IResponseCardTechnologyType,
        IResponseCardSubtype,
        IResponseCardUid,
        IResponseATS,
        IResponseCardIdentificationItem,
        IResponseZvtCardTypeId,
        IResponseMaximumPreAuthorisationAmount
    {
        public string ErrorMessage { get; set; }
        public byte ErrorCode { get; set; }
        public int TerminalIdentifier { get; set; }
        public string AdditionalText { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public int CardSequenceNumber { get; set; }
        public string CardTechnology { get; set; }
        public string CardType { get; set; }
        public string CardholderAuthentication { get; set; }
        public decimal Amount { get; set; }
        public bool PrintoutNeeded { get; set; }
        public TimeSpan Time { get; set; }
        public int CurrencyCode { get; set; }
        public int ReceiptNumber { get; set; }
        public int TraceNumber { get; set; }
        public int TraceNumberLongFormat { get; set; }
        public string VuNumber { get; set; }
        public string AidAuthorisationAttribute { get; set; }
        public int ExpiryDateYear { get; set; }
        public int ExpiryDateMonth { get; set; }
        public int TurnoverRecordNumber { get; set; }
        public int DateMonth { get; set; }
        public int DateDay { get; set; }
        public string ApplicationId { get; set; }
        public string CardTechnologyType { get; set; }
        public int CardSubtype { get; set; }
        public string CardUid { get; set; }
        public byte[] ATS { get; set; }
        public byte[] CardIdentificationItem { get; set; }
        public int ZvtCardTypeId { get; set; }
        public int MaximumPreAuthorisationAmount { get; set; }
    }
}
