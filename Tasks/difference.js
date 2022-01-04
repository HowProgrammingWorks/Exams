// Finde a difference of two dictionaries
'use strict';

const findDifference = function( object1,object2 ) {
    let obj1 = object1;
    let obj2 = object2;

    for (const key in obj2) {
        obj1[key] = obj2[key]
        delete obj1[key]
    }

    return obj1;
};

const result = findDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
