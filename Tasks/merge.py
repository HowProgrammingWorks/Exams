def merge_two_objects(FirstObject, SecondObject):
    Merge = FirstObject | SecondObject
    return FirstObject, SecondObject, Merge
result = merge_two_objects({ 'a': 'uno', 'b': 'due' },{ 'c':' tre' })
print(result)