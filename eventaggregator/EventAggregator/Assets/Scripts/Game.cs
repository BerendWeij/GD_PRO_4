using UnityEngine;
using System.Collections;
using Event;

public class Game {

	private static EventAggregator _eventAggregator;

	public static EventAggregator eventAggregator {
		get {
			if(_eventAggregator == null)
			{
				_eventAggregator = new EventAggregator();
			}
			return _eventAggregator;
		}
	}

}
