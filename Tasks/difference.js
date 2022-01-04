// Finde a difference of two dictionaries
'use strict';

const findDifference = function( object1,object2 ) {
    let obj1 = object1;
    let obj2 = object2;
    let res;

    if ( Object.keys(obj1) > Object.keys(obj2) ) {
        for (const key in obj2) {
            if ( obj1[key] === obj2[key] ) {
                delete obj1[key];
            }
        }
        res = obj1;
    } else {
        for (const key in obj1) {
            if ( obj2[key] === obj1[key] ) {
                delete obj2[key];
            }
        }
        res = obj2;
    }
    return res;
};

const result = findDifference({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
