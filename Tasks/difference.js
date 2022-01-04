// Finde a difference of two dictionaries
'use strict';

const findDifference = function( obj1,obj2 ) {
    for (attribute_name in obj1) {
        obj1[attribute_name] = obj1[attribute_name]
    }{}

    if (obj1 in obj2) return false

    for (attribute_name in obj2) {
        obj1[attribute_name] = obj2[attribute_name]
        delete obj1[attribute_name]
    }{}

    return obj1
};

const result = findDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
