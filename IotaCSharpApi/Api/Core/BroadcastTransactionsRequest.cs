﻿using System.Collections.Generic;

namespace Iota.Lib.CSharp.Api.Core
{
    /// <summary>
    /// Broadcast a list of transactions to all neighbors. The input trytes for this call are provided by attachToTangle
    /// </summary>
    public class BroadcastTransactionsRequest : IotaRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastTransactionsRequest"/> class.
        /// </summary>
        /// <param name="trytes">The trytes.</param>
        public BroadcastTransactionsRequest(List<string> trytes)
            : base(Core.Command.BroadcastTransactions.GetCommandString())
        {
            Trytes = trytes;
        }

        /// <summary>
        /// Gets or sets the trytes representing the transactions
        /// </summary>
        /// <value>
        /// The trytes.
        /// </value>
        public List<string> Trytes { get; set; }

        public override string ToString()
        {
            return $"{nameof(Trytes)}: {string.Join(",", Trytes)}";
        }
    }
}