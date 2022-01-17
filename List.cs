using System;
using System.Collections;
using System.Collections.Generic;


var num = new TurboList<int> {8, 7, 0, 6, 1, 0, 8, 3, 3, 2};
var enumerator = num.GetEnumerator();
class TurboList<T> : IEnumerable {
	private T[] elements;
	private int count;

	private int Count => elements.Length;

	private void Add(T item) {
		Array.Resize(ref elements, elements.Length + 1);
		elements[elements.Length] = item;
	}

	private T Get(int index) {
		return elements[index];
	}

	private void Clear() {
		Array.Clear();
	}

	private void RemoveAt(int index) {
		
	}

	bool Containts(T item) {
		return false;
	}

	int IndexOf(T item) {
		return 0;
	}

	void Remove(T item) {
		
	}

	void AddRange(IEnumerable<T> items) {
		
	}

	public IEnumerator GetEnumerator() {
		throw new NotImplementedException();
	}
}