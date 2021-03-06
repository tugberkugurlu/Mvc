﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.AspNet.Mvc.FunctionalTests
{
    /// <summary>
    /// Limits MVC to use a single Assembly for controller discovery.
    /// </summary>
    /// <remarks>
    /// This is a generic type because it needs to instantiated by a service provider to replace
    /// a built-in MVC service.
    /// </remarks>
    public class TestAssemblyProvider<T> : IControllerAssemblyProvider
    {
	    public TestAssemblyProvider()
	    {
            CandidateAssemblies = new Assembly[] { typeof(T).GetTypeInfo().Assembly };
	    }

        public IEnumerable<Assembly> CandidateAssemblies { get; private set; }
    }
}