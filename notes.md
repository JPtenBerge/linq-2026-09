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

## Pre-LINQ

- `var` is gewoon fijn want `IEnumerable<CustomerEntity>`
- extension methods
  - LINQ doet alles extenden op `IEnumerable<T>`
- anonieme objecten/tuples om je query mee te customizen
- gedrag handmatig itereren en loopen en filteren


## LINQ

### Comprehension/query syntax

Wanneer? Voor mij:

- Leesbaarheid
- Zodra het complex wordt: groupby/handmatige joins

```cs
var expensiveProducts = from p
                        in products
                        where p.Price > 50
                        select p;
```

### Extension methods

```cs
products.Where(x => x.Price > 50)
```

Methoden:

- Select   map van A naar B
  ```js
  [1,2,3].map(x => x * 10)
  ```
- SelectMany  flatMap
- Where
- First/FirstOrDefault
- Single/SingleOrDefault
- Last/LastOrDefault
- Any
- All
- ToList/ToArray
- Aggregate
- GroupBy
- Join
- OrderBy
- Take
- Skip
- Count/Sum/Average

## Coole links

- [source.dot.net](https://source.dot.net)
- [NetPad](https://github.com/tareqimbasher/NetPad)

