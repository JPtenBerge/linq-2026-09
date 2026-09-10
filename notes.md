# Notes

## Collections

### Lijst classes

- `List<T>`
- `LinkedList<T>`
- `T[]`
- `Collection<T>`
- `Dictionary<k, V>`
- `SortedSet<T>`
- `Queue<T>`
- `Stack<T>`

### Datastructuren

- array - `List<T>`
  - `new int[32]`
  - fixed-length
- linked list
  - vooral handig bij veel items inserten/verwijderen
- hashmap/hashtable
- tree

[Grote O notatie / big O](https://stackoverflow.com/a/2307314):

- O(1)
- O(n)
- O(log n)
- O(n log n)
- O(n2)

### Belangrijke lijst-interfaces

- `IEnumerable<T>`
  - `GetEnumerator()` - `MoveNext()`
- `ICollection<T>` : `IEnumerable<T>`
  - `Count`
  - `Add()`
  - `Remove()`
  - `Clear()` - EF Core
- `IList<T>`
  - `Insert()`
  - `RemoveAt()`
  - indexer: `lijstje[4]`
  - `IndexOf()`

## Coole links

- [source.dot.net](https://source.dot.net)
- [NetPad](https://github.com/tareqimbasher/NetPad)

