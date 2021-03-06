﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;

namespace RoutingWebSite
{
    // This controller contains actions mapped with a single controller-level route.
    [Route("Blog/{action=ShowPosts}/{postId?}")]
    public class BlogController
    {
        private readonly TestResponseGenerator _generator;

        public BlogController(TestResponseGenerator generator)
        {
            _generator = generator;
        }

        public IActionResult ShowPosts()
        {
            return _generator.Generate("/Blog", "/Blog/ShowPosts");
        }

        public IActionResult Edit(int postId)
        {
            return _generator.Generate("/Blog/Edit/" + postId);
        }
    }
}