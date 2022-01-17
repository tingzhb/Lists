using System;using System.Collections;
using System.Collections.Generic;

List<int> list = new List<int> {8, 7, 0, 6, 1, 0, 8, 3, 3, 2};
	
IEnumerable collection = list;
IEnumerator enumerator = collection.GetEnumerator();

while (enumerator.MoveNext()) {
	Console.WriteLine(enumerator.Current);
}

