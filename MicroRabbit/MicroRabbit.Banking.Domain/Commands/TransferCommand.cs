﻿using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
	public class TransferCommand : Command
	{
		public int From { get; protected set; }
		public int To { get; protected set; }
		public Decimal Amount { get; protected set; }
	}
}
