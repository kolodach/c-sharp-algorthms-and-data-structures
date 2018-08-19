# Array List. Implementation Notes

### Notes
Default initial size of inner array is 10. The state is represented by following:

|           |                               |
|-          |-                              |
|`_array`   |   array, acting as a strorage |
|`_count`   |   number of added items       |
|`_capacity`|   reserved space              |

### Implementation Progress
- [x] Indexer
- [x] Insert
- [ ] Contains
- [ ] Remove
- [ ] Index Of
- [ ] Enumerator
- [ ] Count

## Indexer(int index)

### Test Causes
- [x] Should throw when out of range when empty
- [x] Should throw when out of range when not empty

### Pseudocode
```
def Get(int index)
    if index < 0 or index >= count
        out of range!
    return _array[index]
```

## Insert(int postition, T item)

### Notes
There are few special causes which cand be haldled separatly.
1. Array is empty
2. Insertion at the last place
3. Insertion at the fiest place

1 and 2 means at most the same behaviour, so thats causes can be combined. The third cause requires array shifting:
```
before shifting:

inset here
     |
     v 
[0],[1],[2],[_],...

step 1:
[0],[1],[2],[2],...

step 2:

redy for insestdion
     |
     v
[0],[1],[1],[2],...
```

By the way, 1 and 2 causes can be 1 reviewed as zero-shifting.

### Test Causes
- [x] Should Insert When list is empty
- [x] Should Insert at the start when not empty
- [x] Should Insert at the end
- [x] Should Insert at the middle
- [x] Should not Insert with index less than 0
- [x] Should not Insert with index greater than Count
- [x] Insert number of elements greater than capacity

### Pseudocode
```
def Insert(position, element)
    if position < 0 || position > count
        out of range!!!
    if _count + 1 > capacity
        expandArray
    for i = _count - 1, i => position, i--
        _array[i + 1] = _array[i]
    _array[position] = element
    count++

def ExpandArray
    if(capacity != MaxInt)
        _capacity = _capacity * 2 < MaxInt ? capacity * 2 : MaxInt
        let oldArray = _array
        _array = new Array(_capacity)
        for i = 0; i < oldArray.length; i++
            _array[i] = _oldArray[i]
```
