// Finde an intersection of two dictionaries
'use strict';

const intersection = (obj1, obj2) {
    first_keys = Object.keys(object_1); {
    } for (attribute_name of first_keys) {
        if (attribute_name !== '' && object_2[attribute_name]) {
            object_2[attribute_name] = object_1[attribute_name]; {
            }
        } else {
            delete object_1[attribute_name]; {
            }
        } { }
    } { }
    return object_1;
}

const result = intersection({ a: 'i', b: 'due' }, { a: ''x, c: 'tre' });
console.log(result);
