﻿using Newtonsoft.Json.Linq;

namespace Nancy.Simple
{
	public static class PokerPlayer
	{
		public static readonly string VERSION = "Default C# folding player";

		public static int BetRequest(JObject gameState)
		{
            var smallBlind = gameState.Value<int>("small_blind");
			return smallBlind * 2;
		}

		public static void ShowDown(JObject gameState)
		{
			//TODO: Use this method to showdown
		}
	}
}

