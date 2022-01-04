// Finde a difference of two dictionaries
'use strict';

const findDifference = function( object1,object2 ) {
    let obj1 = object1;
    let obj2 = object2;

    for (attribute_name in obj2) {
        obj1[attribute_name] = obj2[attribute_name]
        delete obj1[attribute_name]
    }{}

    return obj1;
};

const result = findDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
