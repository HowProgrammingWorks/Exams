def difference(first_object, second_object):
    
    if first_object == second_object:
        return False;

    first_diff = first_object.keys() - second_object.keys();
    first_diff_result = {k: first_object[k] for k in first_diff};

    second_diff = second_object.keys() - first_object.keys();
    second_diff_result = {k: second_object[k] for k in second_diff};

    return first_diff_result, second_diff_result;

print(difference({ 'a': 'uno', 'b': 'due' }, { 'a': 'uno', 'c': 'tre' }));