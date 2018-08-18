# Array List. Implementation Notes
### Implementation Progress
- [ ] Indexer
- [ ] Insert
- [ ] Contains
- [ ] Remove
- [ ] Index Of
- [ ] Enumerator
- [ ] Count

## Insert(int postition, T item)

### Test Causes
- [ ] Should Insert When list is empty
- [ ] Should Insert at the start
- [ ] Should Insert at the end
- [ ] Should Insert at the middle
- [ ] Should not Insert with index less than 0
- [ ] Should not Insert with index greater than Count

### Pseudocode
```
def Insert(position, elsement)
    if position >= _capacity
        expandArray

    [//]: # (!!!TODO: I stopped here)

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
