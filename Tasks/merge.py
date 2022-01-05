def merge_two_objects(object_1,object_2):
    object_3=object_1|object_2
    return object_1,object_2,object_3
result=merge_two_objects({'a':'uno','b':'due'},{'c':'tre'})
print(result)