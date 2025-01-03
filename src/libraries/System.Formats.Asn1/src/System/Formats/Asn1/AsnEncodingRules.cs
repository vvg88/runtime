// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Formats.Asn1
{
    /// <summary>
    ///   Specifies the encoding ruleset for an <see cref="AsnReader"/> or <see cref="AsnWriter"/>.
    /// </summary>
    // ITU-T-REC.X.680-201508 sec 4.
    public enum AsnEncodingRules
    {
        /// <summary>
        /// ITU-T X.690 Basic Encoding Rules.
        /// </summary>
        BER,

        /// <summary>
        /// ITU-T X.690 Canonical Encoding Rules.
        /// </summary>
        CER,

        /// <summary>
        /// ITU-T X.690 Distinguished Encoding Rules.
        /// </summary>
        DER,
    }
}
