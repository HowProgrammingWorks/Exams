// Merge two dictionaries
'use strict';
const merge =(object1, object2) => {
    const result = {}; 
    for (const key in object1) {
        result[key] = object1[key]; 
    }
    for (const key in object2) {
        result[key] = object2[key]; 
    }
    return result; 
}

const result = merge({ a: 'uno', b: 'due' }, { c: 'tre' });
console.log(result);
