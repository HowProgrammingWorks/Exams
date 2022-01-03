// Finde an intersection of two dictionaries
'use strict';

const intersection = (object1, object2) => {
    keys = Object.keys(object1); 
    for (const key of keys) {
        if (key !== '' && object2[key]) {
            object2[key] = object1[key]; {
            }
        } else {
            delete object1[key]; 
        } 
    } 
    return object1;
}

const result = intersection({ a: 'uno', b: 'due' }, { a: 'uno', c: 'tre' });
console.log(result);
