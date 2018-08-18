# Base Interfaces
### Why just not use System.Collections.Generic interfaces?
System.Collections.Generic interfaces contain a lot of stuff need to be implement, some for backward compatability, other for thread safety. Beacause of study purpose of this project, Extra features will be ommited in this lightweight interfaces. 

## `IEnumerable<T>`
**Summary:** Defines object, that represents a collection of items, which can be enumerated.
| Member | Type | Description |
|--------|------|-------------|
| System.Collections.Generic.`Enumerator<T>` **GetEnumerator()** | Method | *Returns* System.Collections.Generic.`Enumerator<T>` which can be used to access items (for instance, in ```foreach``` construction) |

## `ICollection<T>`
**Summary:** Defines a collection wich has a count.
| Member | Type | Description |
|--------|------|-------------|
| int **Count**  | readonly property | *Returns* Actual Number of items |

## `IReadonlyList<T>` : `IEnumerable<T>`, `ICollection<T>`
**Summary:** Defines a collection with read only acces.
| Member | Type | Description |
|--------|------|-------------|
| readonly indexer('[]') | operator | *Returns* item at specific position. If isdex is less than 0 or grater than Count - 1 the System.IndexOutOfRangeException will be thrown. |
| Int32 **IndexOf(T element)** | method | *Returns* Index of the specific element. If the index of given ement can not be found the System.ArgumentException will be thrown |
| bool **Contains(T element)** | method | Determines whether given element is presented in the collection at list one time.<br>*T element:* the given element.<br>*Returns* ```true``` if given element is presented in collection and ```false``` oterwice. |

## `IList<T>` : `IReadOnlyList<T>`
**Summary:** Defines a mutable collection of items.
| Member | Type | Description |
|--------|------|-------------|
| void **Insert(int position, T element)** | method | Inserts the element at the specific position.<br>*int position:* the posotion of element being inserted.<br>*T element:* the element being inserted.<br>If index is out of the collection's range (less than 0 of greater than count) the System.IndexOutOfRangeException will be thrown. If the count after element insertion will overflow Int32 type the System.OverflowException will be thrown. |
| bool **Remove(Int32 position)** | method | Removes the specific element from the collection. *position:* the position of element beeing removed.<br>*Returns* ```true``` if element was removed successfuly and ```false``` otherwice. |