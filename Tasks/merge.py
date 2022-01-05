def merge_two_objects(first_object, second_object):
    
    merge = first_object | second_object;
    
    return first_object, second_object, merge;

print(merge_two_objects({ 'a': 'uno', 'b': 'due' }, { 'c':' tre' }));