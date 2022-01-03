// Finde an intersection of two dictionaries
'use strict';

const intersection = (object1, object2) => {
    const keys = Object.keys(object1); 
    const result = {}; 
    for (const key of keys) {
        if (object2[key]) {
            result[key] = object1[key]; 
        } 
    } 
    return result;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
