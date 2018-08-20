# Array List. Implementation Notes

## General
Default initial size of inner array is 10. The state is represented by following:

|           |                               |
|-          |-                              |
|`_array`   |   array, acting as a strorage |
|`_count`   |   number of added items       |
|`_capacity`|   reserved space              |

### Implementation Progress
- [x] Indexer
- [x] Insert
- [x] Contains
- [x] Remove
- [x] Clear
- [x] Index Of
- [ ] Enumerator
- [x] Count

## IndeOf(T element)

### Test Cases

- [x] Should return index of element if countains
- [x] Should return index of first occurrence of element if duplications exists.
- [x] Should return -1 when element does not exists
- [x] Should return -1 when empty

### Notes

```
def IndexOf element
    let index = -1
    for i = 0, i < count, i++
        if array[i] == element
            index = i
            break
    return index;
```

## Clear

### Test Cases

- [x] Shold clear
- [x] Should not throw when empty

### Notes

```
def clear
    capacity = initialCapacity
    array = new [capacity]
    count = 0
```

## Remove(T element)

### Test Cases

- [x] Should not remove when out of range
- [x] Should not throw when array is empty
- [x] Should remove at the end
- [x] Should remove at the start
- [x] Should remove in the middle
- [x] Should remove when last element
- [x] Should shrink when capacity / count more than 2 
- [x] Should not shrink less than initial capacity 
- [x] Should not shrink when shrinking disabled 

### Notes

There are few special causes needs to be reviewed:
- Remove first lement
- Remove element at the end
- Remove lst element
- Remove not containing element
- Remove element when list is empty

Let's start with a simple scenatio and supose that we need to remove the element from the middle of the list. This cause will contain few steps:

1. Find the position of the element being removed
2. Removing the element from the list
3. Shift the list to fill the gap
4. Decrease capacity if need
5. Decrease count

Actual, removing is the simple array left shift until position of the element being emoved. So 2 and 3 meas the same.

```
before:
   remove
     |
     v
[1],[2],[3],[0]

step 1:
[1],[3],[3],[0]

step 2 final:
[1],[3],[0],[0]
```

When to shrink the array? 
It seem to be dificult question. This shrink behaviour takes additional time and should be performed when the memory is more prefered than the execution time. So the first option is to provide shrink functionality as the public method. The second option is to provide constructor setting which will be turn on of off shrink setting. I prefere to follow last approach, beacuse this way you just provide the setting once and ArrayList will do it every tyme doring the obejct life. 

```
def Remove element : bool
    let index = 0;
    while(_array[index] != element && index != _count)
        index++;
    if index == _count
        element not found!!!
        return false
        
    for i = index, i < _count i++
        _array[i] = _array[i + 1]

    count--;

    if shrinkEnabled and count != 0
        ShrinkArray

def ShrinkArray
    if capacity / count >= expandFactor 
    and capacity / expandFactor >= minCapacity
        capacity /= expandFactor
        var oldArray = array;
        array = new Array(capacity)
        for i = 0, i < count, i++
            array[i] = oldArray[i]
```

## Contains(T element)

### TestCauses

- [x] Should return true when contains
- [x] Should return false when not contains
- [x] Should return false when empty
- [x] Should return true when contains repeating element

### Notes

```
def Contains element
    let contains = false
    foreach item in _array
        if item == element
            contains = true
            break
    return contains
```

## Indexer(int index)

### Test Cases
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

### Test Cases
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
