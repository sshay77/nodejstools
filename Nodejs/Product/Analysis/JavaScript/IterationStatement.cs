﻿// IterationStatement.cs
//
// Copyright 2012 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Microsoft.NodejsTools.Parsing
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;

    [Serializable]
    internal abstract class IterationStatement : Statement
    {
        private Block m_body;

        public Block Body
        {
            get { return m_body; }
            set
            {
                m_body.ClearParent(this);
                m_body = value;
                m_body.AssignParent(this);
            }
        }

        protected IterationStatement(EncodedSpan span)
            : base(span)
        {
        }
    }
}
