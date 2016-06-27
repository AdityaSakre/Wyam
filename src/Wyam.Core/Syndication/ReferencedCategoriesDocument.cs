//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace Wyam.Core.Syndication
{
    [TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public class ReferencedCategoriesDocument : CategoriesDocument
    {
        Uri link;

        public ReferencedCategoriesDocument()
        {
        }

        public ReferencedCategoriesDocument(Uri link)
            : base()
        {
            if (link == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("link");
            }
            this.link = link;
        }

        public Uri Link
        {
            get { return this.link; }
            set { this.link = value; }
        }

        internal override bool IsInline
        {
            get { return false; }
        }
    }
}