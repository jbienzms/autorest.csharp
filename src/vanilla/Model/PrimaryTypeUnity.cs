// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using System;
using AutoRest.Core.Model;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.CSharp.Model
{
    public class PrimaryTypeUnity : PrimaryTypeCs
    {
        public PrimaryTypeUnity(KnownPrimaryType primaryType) : base(primaryType){}

        protected PrimaryTypeUnity() : base(){}

        public override string ImplementationName
        {
            get
            {
                switch (KnownPrimaryType)
                {
                    case KnownPrimaryType.Credentials:
                        return "Microsoft.Rest.Unity.ServiceClientCredentials";
                    default:
                        return base.ImplementationName;
                }
            }
        }
    }
}