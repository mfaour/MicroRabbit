﻿using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
	public class TransferCreatedEvent : Event
	{
		public int From { get; private set; }
		public int To {get;private set;}
	public Decimal Amount { get; private set; }

		public TransferCreatedEvent(int from, int to, Decimal amount)
		{
			From = from;
			To = to;
			Amount = amount;
		}
	}
}
