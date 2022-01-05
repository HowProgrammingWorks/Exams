def diff(object_1,object_2):
    if object_1 == object_2:
        return False
    for attribute_name in object_2:
        object_1[attribute_name]=object_2[attribute_name]
        del object_1[attribute_name]
    return object_1
result = diff({'a':'uno', 'b':'due'},{'a':'uno', 'c':'tre'})
print(result)