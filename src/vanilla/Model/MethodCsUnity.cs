// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.Extensions;
using Newtonsoft.Json;

namespace AutoRest.CSharp.Model
{
    public class MethodCsUnity : MethodCs
    {
        public MethodCsUnity() { }
        
        /// <summary>
        /// Get the return type name for the underlying interface method
        /// </summary>
        public override string OperationResponseReturnTypeString
        {
            get
            {
                if (ReturnType.Body != null && ReturnType.Headers != null)
                {
                    return $"{ReturnType.Body.AsNullableType(HttpMethod != HttpMethod.Head && IsXNullableReturnType)},{ReturnType.Headers.AsNullableType(HttpMethod != HttpMethod.Head)}";
                }
                if (ReturnType.Body != null)
                {
                    return $"{ReturnType.Body.AsNullableType(HttpMethod != HttpMethod.Head && IsXNullableReturnType)}";
                }
                if (ReturnType.Headers != null)
                {
                    return $"{ReturnType.Headers.AsNullableType(HttpMethod != HttpMethod.Head)}";
                }

                return "";

            }
        }
    }
}
