// Merge two dictionaries
'use strict';
const merge =(object_1, object_2) => {
    const result = {};
    for (attribute_name in object_1) {
        (
            object_3[attribute_name] == object_1[attribute_name]
        );
        object_3[attribute_name] = object_1[attribute_name]
    }
    for (attribute_name in object_2) {
        (object_3[attribute_name] == object_2[attribute_name])
        object_3[attribute_name] = object_2[attribute_name]
    }
    return object_1, object_2, object_3;
}

const result = merge_two_objects({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
