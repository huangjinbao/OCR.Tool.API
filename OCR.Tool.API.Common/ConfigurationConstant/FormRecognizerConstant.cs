using System;
using System.Collections.Generic;
using System.Text;

namespace OCR.Tool.API.Common.ConfigurationConstant
{
    public class FormRecognizerConstant : BaseConstant
    {
        public static readonly string FormRecognizerVersion = Configuration["FormRecognizer:Version"];

        public static readonly string FormRecognizerSubscriptionKey = Configuration["FormRecognizer:SubscriptionKey"];

        public static readonly string FormRecognizerEndpoint = Configuration["FormRecognizer:FormRecognizerEndpoint"];
    }
}